# Pressure control via fan speed ramp

Cf. https://www.plctalk.net/qanda/showthread.php?t=125059

An enclosure has its internal pressure above ambient and controlled via a PID;
the PID CV (Controlled Variable; output) does not control fan speed directly,
it instead drives a speed ramp that changes the fan speed.  This is in effect
an ID controller; PID without the Proportional term acting directly on the fan
speed, but the ramp acts like the Integral (I; Reset) term of the PID equation.


    ================================================================
     Modeling pressure control of an enclosure via fan speed ramp (fan acceleration)
     Cf.  https://www.plctalk.net/qanda/showthread.php?t=125059
    
    
     PSIG:  PRESSURE MODEL
     =====================
    
       dPSIG/dt = (SCFin - SCFout) / Volume
    
     - PSIG is the pressure inside the enclosure
       - PSIG is also used in some places as a pressure unit
         - PSI-Gauge; pressure difference with respect to ambient
       - Context should make it clear which it is; sorry for any confusion
    
     - based on ideal gas law
       - PV = nRT
       - P = nRT/V
       - dP/dt = dn/dt RT/v
       - net flow accumulation, (SCFin-SCFout), is a proxy for dn/dt
       - P is absolute pressure = (Patm + PSIG)
         - Patm is constant
         - So dPSIG/dt is a proxy for dP/dt
     - Integrate numerically using Implict Euler to aid convergence
       - The code cheats and uses derivatives instead of partial differentials,
         but the results seem reasonable.
    
     SCFin:  FAN MODEL
     =================
     SCFin is modeled as from a fan running at some speed, with a
     pressure rise from ambient (0) to PSIG, the pressure inside the
     enclosure
    
        SCFin = SCFinmax(speed) arccos(PSIG / PSIGmax(speed) / (PI/2)
    
        speed = fan speed, 0-100%
        - Motor and airflow responses are modeled as instantaneous
    
        SCFinmax(speed) = [SCF/s max at 100% fan speed] * (speed / 100)
        - maximum flow at zero pressure rise acrosss the fan
    
        PSIGmax(speed) = [PSIGmax at 100% fan speed] * (speed / 100)
        - maximum pressure rise across the fan at zero flow
    
    
     SCFout:  ENCLOSURE LEAKAGE MODEL
     ================================
    
     SCFout = [SCF/s out at 1PSIG] SQRT(PSIG)
    
     - Leakage as a function of pressure
       - Responses to changes in pressure are modeled as instantaneous
     - Assumes turbulent flow:  that is probably wrong
       - Reynolds number will be small
         - D is low:  leakage implies small openings
         - Kinematic viscosity of air is high (15 times that of water)
         - Velocity of air will be low at low pressures
       - Laminar flow is more likely
         - Flow will be linear with pressure
    
    
     CONTROL
     =======
    
     PID control implemented in ladder logic for MicroLogix 1100
     - See accompanying .RSS and .pdf files
     - Rockwell Dependent formulation With parameters:  Kc; 1/Ti; Td.
       - Independent formulation equivalent parameters:  Kc; Kc/Ti; Kc*Td.
       - Calculation is incremental CV(t) = CV(t-deltat) + Kc * f(Error,PV,Ti,Td)
         - Bumpless; error is accepted as-is on mode switch from manual to automatic
     - Controller is Reverse-(Re-)Acting
       - dCV/dPV < 0
       - Controller output decreases With increasing Present Value
     - PSIG is the PID Present Value (PV; modeled value here; measured value in the field)
     - Setpoint is the PID setpoint
     - PID output (a.k.a. Controlled Variable; CV) is 0-100%
       - PID output drives fan speed ramp i.e. output drives fan acceleration
         - N.B. THE PID CONTROLLER DOES NOT KNOW THE ACTUAL FAN SPEED
                - The fan speed is modeled in this code, and kept in the range 0-100%
       - At 50% output, ramp is 0%/s
       - At 0% output, ramp is -10%/s
       - At 100% output, ramp is +10%/s
    
    
     IMPLEMENTATION
     ==============
    
     All persistent values are stored in AnalogValueDisplay (AVD) controls*
     - N.B. the number of digits chosen for display limits the accuracy of the results
     - PID parameters are downloaded to PLC using AdvancedHMI drivers*
       - Kc = F10:0
       - Ti = F10:1
       - Td = F10:2
       - SP = F10:5
       - PV = F10:6
       - CV = F10:9 (PID output; polled from PLC*)
       - dT = F10:3 (Loop update time; polled from PLC*)
     - Fan ramp and fan speed are also maintained in AVD controls
     - PLC Fre-Running clock is polled from PLC word N7:2
       - Status word S:4 is written to N7:2 periodically, either
         - Every second While PID Is In auto mode
           - At which time PID instruction also executes
         - OR
         - every 2s while PID is in manual mode.
       - Change of polled N7:2 value (AVD.ValueChanged) is trigger to run the model
     - Model parameters are on the left side of the window
       - Enclosure volume
       - Enclusure leakage
       - Fan curve characterization
       - Click any of these parameters to change them; they are written to F8:0,
         which is an unused location on the PLC
     
    
     * Cf.  https://advancedhmi.com/
    ================================================================
