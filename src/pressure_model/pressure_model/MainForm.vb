Imports MfgControl.AdvancedHMI.Controls
Imports Microsoft.Win32

Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub
    Private Function VDbl(O As Object) As Double
        Return CDbl(O.Value)
    End Function
    Private Sub chk_debug_CheckedChanged(sender As Object, e As EventArgs)
        Dim showthem As Boolean
        showthem = chk_debug.Checked
        lbl_debug_free_running_clock.Visible = showthem
        avd_debug_free_running_clock.Visible = showthem
        lbl_debug_delta_psig.Visible = showthem
        avd_debug_delta_psig.Visible = showthem
    End Sub

    ''================================================================
    '' Modeling pressure control of an enclosure via fan speed ramp (fan acceleration)
    '' Cf.  https://www.plctalk.net/qanda/showthread.php?t=125059
    ''
    ''
    '' PSIG:  PRESSURE MODEL
    '' =====================
    ''
    ''   dPSIG/dt = (SCFin - SCFout) / Volume
    ''
    '' - PSIG is the pressure inside the enclosure
    ''   - PSIG is also used in some places as a pressure unit
    ''     - PSI-Gauge; pressure difference with respect to ambient
    ''   - Context should make it clear which it is; sorry for any confusion
    ''
    '' - based on ideal gas law
    ''   - PV = nRT
    ''   - P = nRT/V
    ''   - dP/dt = dn/dt RT/v
    ''   - net flow accumulation, (SCFin-SCFout), is a proxy for dn/dt
    ''   - P is absolute pressure = (Patm + PSIG)
    ''     - Patm is constant
    ''     - So dPSIG/dt is a proxy for dP/dt
    '' - Integrate numerically using Implict Euler to aid convergence
    ''   - The code cheats and uses derivatives instead of partial differentials,
    ''     but the results seem reasonable.
    ''
    '' SCFin:  FAN MODEL
    '' =================
    '' SCFin is modeled as from a fan running at some speed, with a
    '' pressure rise from ambient (0) to PSIG, the pressure inside the
    '' enclosure
    ''
    ''    SCFin = SCFinmax(speed) arccos(PSIG / PSIGmax(speed) / (PI/2)
    ''
    ''    speed = fan speed, 0-100%
    ''    - Motor and airflow responses are modeled as instantaneous
    ''
    ''    SCFinmax(speed) = [SCF/s max at 100% fan speed] * (speed / 100)
    ''    - maximum flow at zero pressure rise acrosss the fan
    ''
    ''    PSIGmax(speed) = [PSIGmax at 100% fan speed] * (speed / 100)
    ''    - maximum pressure rise across the fan at zero flow
    ''
    ''
    '' SCFout:  ENCLOSURE LEAKAGE MODEL
    '' ================================
    ''
    '' SCFout = [SCF/s out at 1PSIG] SQRT(PSIG)
    ''
    '' - Leakage as a function of pressure
    ''   - Responses to changes in pressure are modeled as instantaneous
    '' - Assumes turbulent flow:  that is probably wrong
    ''   - Reynolds number will be small
    ''     - D is low:  leakage implies small openings
    ''     - Kinematic viscosity of air is high (15 times that of water)
    ''     - Velocity of air will be low at low pressures
    ''   - Laminar flow is more likely
    ''     - Flow will be linear with pressure
    ''
    ''
    '' CONTROL
    '' =======
    ''
    '' PID control implemented in ladder logic for MicroLogix 1100
    '' - See accompanying .RSS and .pdf files
    '' - Rockwell Dependent formulation With parameters:  Kc; 1/Ti; Td.
    ''   - Independent formulation equivalent parameters:  Kc; Kc/Ti; Kc*Td.
    ''   - Calculation is incremental CV(t) = CV(t-deltat) + Kc * f(Error,PV,Ti,Td)
    ''     - Bumpless; error is accepted as-is on mode switch from manual to automatic
    '' - Controller is Reverse-(Re-)Acting
    ''   - dCV/dPV < 0
    ''   - Controller output decreases With increasing Present Value
    '' - PSIG is the PID Present Value (PV; modeled value here; measured value in the field)
    '' - Setpoint is the PID setpoint
    '' - PID output (a.k.a. Controlled Variable; CV) is 0-100%
    ''   - PID output drives fan speed ramp i.e. output drives fan acceleration
    ''     - N.B. THE PID CONTROLLER DOES NOT KNOW THE ACTUAL FAN SPEED
    ''            - The fan speed is modeled in this code, and kept in the range 0-100%
    ''   - At 50% output, ramp is 0%/s
    ''   - At 0% output, ramp is -10%/s
    ''   - At 100% output, ramp is +10%/s
    ''
    ''
    '' IMPLEMENTATION
    '' ==============
    ''
    '' All persistent values are stored in AnalogValueDisplay (AVD) controls*
    '' - N.B. the number of digits chosen for display limits the accuracy of the results
    '' - PID parameters are downloaded to PLC using AdvancedHMI drivers*
    ''   - Kc = F10:0
    ''   - Ti = F10:1
    ''   - Td = F10:2
    ''   - SP = F10:5
    ''   - PV = F10:6
    ''   - CV = F10:9 (PID output; polled from PLC*)
    ''   - dT = F10:3 (Loop update time; polled from PLC*)
    '' - Fan ramp and fan speed are also maintained in AVD controls
    '' - PLC Fre-Running clock is polled from PLC word N7:2
    ''   - Status word S:4 is written to N7:2 periodically, either
    ''     - Every second While PID Is In auto mode
    ''       - At which time PID instruction also executes
    ''     - OR
    ''     - every 2s while PID is in manual mode.
    ''   - Change of polled N7:2 value (AVD.ValueChanged) is trigger to run the model
    '' - Model parameters are on the left side of the window
    ''   - Enclosure volume
    ''   - Enclusure leakage
    ''   - Fan curve characterization
    ''   - Click any of these parameters to change them; they are written to F8:0,
    ''     which is an unused location on the PLC
    '' 
    ''
    '' * Cf.  https://advancedhmi.com/
    ''================================================================

    Private Sub avd_debug_free_running_clock_ValueChanged(sender As Object, e As EventArgs) Handles avd_debug_free_running_clock.ValueChanged
        '' Analog Value Display will change at time either of each PLC PID execution
        '' if PID is in auto mode, or at 2s intervals otherwise
        '' - Run integration with updated inputs
        '' 
        '' Ramp = -10/0/+10 %/s at 0/50/100% PID output
        Dim fan_ramp_pctps As Double
        fan_ramp_pctps = (VDbl(avd_pid_output) - 50.0) * 0.2
        avd_fan_ramp.Value = fan_ramp_pctps

        '' Adjust fan speed; limit to range 0-100%
        Dim fan_speed_pct As Double
        fan_speed_pct = VDbl(avd_fan_speed) + (fan_ramp_pctps * VDbl(avd_pid_update_rate))
        If fan_speed_pct > 100.0 Then
            fan_speed_pct = 100
        ElseIf fan_speed_pct < 0.0 Then
            fan_speed_pct = 0.0
        End If
        avd_fan_speed.Value = fan_speed_pct   '' Update AVD

        '' Model pressure change
        Dim delta_psig As Double
        delta_psig = delta_psig_model()
        avd_debug_delta_psig.Value = delta_psig
        Dim new_psig As Double
        new_psig = VDbl(avd_pid_pv) + delta_psig
        If new_psig < 0.0 Then
            new_psig = 0.0
        End If
        avd_pid_pv.Value = new_psig  '' Update AVD

        '' Update PV in PLC
        EthernetIPforSLCMicroCom1.Write(avd_pid_pv.PLCAddressKeypad, new_psig)
    End Sub

    Private Function dpdt_model(psig_input As Double, speed_input_pct As Double) As Double

        '' Model [dPSIG/dt = (SCFin - SCFout) / Volume] as a function
        '' enclosure pressure (psig_input) and fan speed (speed_input_pct)

        '' Model parameters
        Dim psig_max As Double  ' PSIG at 100% fan speed and zero flow
        Dim scfs_max As Double  ' SCF/s at 100% fan speed and 1PSIG
        Dim leak_rate As Double ' SCF/s at 1PSIG
        Dim volume As Double
        Dim delta_t As Double

        '' Calculate maximum possible pressure that can be achieved by current fan speed
        If speed_input_pct > 0.0 Then
            psig_max = VDbl(avd_psig_max) * speed_input_pct * 0.01
        Else
            psig_max = 0.0
        End If

        '' Get other model parameters
        scfs_max = VDbl(avd_scfs_max)
        leak_rate = VDbl(avd_leak_coeff)
        volume = VDbl(avd_volume)
        delta_t = VDbl(avd_pid_update_rate)

        '' Calculate flow rate arccosine factor
        Dim arccos As Double
        If psig_input >= 0.0 And psig_max > psig_input Then
            arccos = Math.Acos(psig_input / psig_max)
        ElseIf psig_input > 0 Then
            arccos = 0.0
        Else
            arccos = 1.0
        End If

        '' Calculate fan-driving inlet flow rate
        Dim scfs_in As Double
        If speed_input_pct < 0.0 Then
            scfs_in = 0.0
        ElseIf speed_input_pct > 100.0 Then
            scfs_in = 2.0 * arccos / Math.PI
        Else
            scfs_in = 2.0 * speed_input_pct * 0.01 * arccos / Math.PI
        End If

        '' Calculate leakage flow rate
        Dim scfs_out As Double
        If psig_input > 0.0 Then
            scfs_out = leak_rate * Math.Sqrt(psig_input)
        Else
            scfs_out = 0.0
        End If

        '' Calculate and return dPSIG/dt using those flow rates and the enclosure volume
        Dim dpdt As Double
        dpdt = (scfs_in - scfs_out) / volume

        Return dpdt
    End Function

    Private Function delta_psig_model() As Double

        '' Model parameters
        Dim psig_input As Double
        Dim speed_input As Double
        Dim update_rate As Double
        Dim psig_max As Double
        psig_input = VDbl(avd_pid_pv)
        speed_input = VDbl(avd_fan_speed)
        update_rate = VDbl(avd_pid_update_rate)
        psig_max = VDbl(avd_psig_max) * speed_input * 0.01

        '' dPSIG/dT at nominal conditions, and at conditions predicted by Explicit Euler
        Dim dpdt_0 As Double
        Dim ramp_rate As Double
        Dim dpdt_1 As Double
        dpdt_0 = dpdt_model(psig_input, speed_input)
        ramp_rate = VDbl(avd_fan_ramp)
        dpdt_1 = dpdt_model(psig_input + (dpdt_0 * update_rate), speed_input + (ramp_rate * update_rate))

        '' Update display
        If chk_debug.Checked Then
            avd_debug_dpdt_0.Value = dpdt_0
            avd_debug_dpdt_1.Value = dpdt_1

            Dim dbl_error As Double
            dbl_error = VDbl(avd_pid_setpoint) - VDbl(avd_pid_pv)
            avd_debug_error.Value = dbl_error
            frm_logabserr.addpoint(dbl_error)
            frm_fanspeedpct.addpoint(VDbl(avd_fan_speed))
        End If

        '' Get Implicit Euler parameter
        Dim ie As Double
        ie = VDbl(avd_implicit_euler)
        If ie < 0.0 Then
            ie = 0.0
        ElseIf ie > 1.0 Then
            ie = 1.0
        End If

        '' Make Implicit Euler calculation; clamp result
        Dim delta_psig
        delta_psig = update_rate * ((dpdt_0 * (1.0 - ie)) + (ie * dpdt_1))
        If delta_psig < (-psig_input) Then
            delta_psig = -psig_input
        ElseIf delta_psig > 0 And psig_max >= psig_input And (delta_psig + psig_input) > psig_max Then
            delta_psig = psig_max - psig_input
        End If

        Return delta_psig
    End Function
    Private Sub debug_toggle(c As Control)
        '' Toggle visibility of a control
        c.Location = New Point(c.Location.X(), -c.Location.Y())
    End Sub
    Private Sub chk_debug_CheckedChanged_1(sender As Object, e As EventArgs) Handles chk_debug.CheckedChanged
        '' When chk_debug checkbox changes value, toggle visibility of debug labels and AVDs
        debug_toggle(lbl_debug_free_running_clock)
        debug_toggle(avd_debug_free_running_clock)
        debug_toggle(lbl_debug_dpdt_0)
        debug_toggle(avd_debug_dpdt_0)
        debug_toggle(lbl_debug_dpdt_1)
        debug_toggle(avd_debug_dpdt_1)
        debug_toggle(lbl_debug_delta_psig)
        debug_toggle(avd_debug_delta_psig)
        debug_toggle(lbl_debug_error)
        debug_toggle(avd_debug_error)
    End Sub

    Private Sub lbl_debug_error_Click(sender As Object, e As EventArgs) Handles lbl_debug_error.Click
        frm_logabserr.Visible = Not frm_logabserr.Visible
    End Sub
    Private Sub lbl_fan_speed_Click(sender As Object, e As EventArgs) Handles lbl_fan_speed.Click
        frm_fanspeedpct.Visible = Not frm_fanspeedpct.Visible
    End Sub
End Class
