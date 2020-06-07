<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.lbl_volume = New System.Windows.Forms.Label()
        Me.lbl_leak_coeff = New System.Windows.Forms.Label()
        Me.lbl_scfs_max = New System.Windows.Forms.Label()
        Me.lbl_psig_max = New System.Windows.Forms.Label()
        Me.lbl_model_params = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.avd_psig_max = New AdvancedHMIControls.AnalogValueDisplay()
        Me.EthernetIPforSLCMicroCom1 = New AdvancedHMIDrivers.EthernetIPforSLCMicroCom(Me.components)
        Me.avd_scfs_max = New AdvancedHMIControls.AnalogValueDisplay()
        Me.avd_leak_coeff = New AdvancedHMIControls.AnalogValueDisplay()
        Me.avd_volume = New AdvancedHMIControls.AnalogValueDisplay()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_pid = New System.Windows.Forms.Label()
        Me.lbl_pid_setpoint = New System.Windows.Forms.Label()
        Me.avd_pid_setpoint = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_pid_pv = New System.Windows.Forms.Label()
        Me.avd_pid_pv = New AdvancedHMIControls.AnalogValueDisplay()
        Me.avd_pid_output = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_pid_output = New System.Windows.Forms.Label()
        Me.avd_fan_speed = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_fan_speed = New System.Windows.Forms.Label()
        Me.avd_fan_ramp = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_fan_ramp = New System.Windows.Forms.Label()
        Me.lbl_pid_update_rate = New System.Windows.Forms.Label()
        Me.avd_pid_update_rate = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_pid_gain = New System.Windows.Forms.Label()
        Me.avd_pid_gain = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_pid_reset = New System.Windows.Forms.Label()
        Me.avd_pid_reset = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_pid_rate = New System.Windows.Forms.Label()
        Me.avd_pid_rate = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_implicit_euler = New System.Windows.Forms.Label()
        Me.avd_implicit_euler = New AdvancedHMIControls.AnalogValueDisplay()
        Me.chk_pid_auto = New AdvancedHMIControls.CheckBox()
        Me.chk_pid_reverse = New AdvancedHMIControls.CheckBox()
        Me.avd_debug_free_running_clock = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_debug_free_running_clock = New System.Windows.Forms.Label()
        Me.lbl_debug_delta_psig = New System.Windows.Forms.Label()
        Me.avd_debug_delta_psig = New AdvancedHMIControls.AnalogValueDisplay()
        Me.chk_debug = New System.Windows.Forms.CheckBox()
        Me.lbl_debug_dpdt_0 = New System.Windows.Forms.Label()
        Me.lbl_debug_dpdt_1 = New System.Windows.Forms.Label()
        Me.avd_debug_dpdt_0 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.avd_debug_dpdt_1 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.avd_debug_error = New AdvancedHMIControls.AnalogValueDisplay()
        Me.lbl_debug_error = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforSLCMicroCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_volume
        '
        Me.lbl_volume.AutoSize = True
        Me.lbl_volume.ForeColor = System.Drawing.Color.White
        Me.lbl_volume.Location = New System.Drawing.Point(157, 57)
        Me.lbl_volume.Name = "lbl_volume"
        Me.lbl_volume.Size = New System.Drawing.Size(101, 18)
        Me.lbl_volume.TabIndex = 11
        Me.lbl_volume.Text = "Volume, SCF"
        '
        'lbl_leak_coeff
        '
        Me.lbl_leak_coeff.AutoSize = True
        Me.lbl_leak_coeff.ForeColor = System.Drawing.Color.White
        Me.lbl_leak_coeff.Location = New System.Drawing.Point(110, 91)
        Me.lbl_leak_coeff.Name = "lbl_leak_coeff"
        Me.lbl_leak_coeff.Size = New System.Drawing.Size(148, 18)
        Me.lbl_leak_coeff.TabIndex = 13
        Me.lbl_leak_coeff.Text = "SCF/s out @ 1PSIG"
        '
        'lbl_scfs_max
        '
        Me.lbl_scfs_max.AutoSize = True
        Me.lbl_scfs_max.ForeColor = System.Drawing.Color.White
        Me.lbl_scfs_max.Location = New System.Drawing.Point(37, 125)
        Me.lbl_scfs_max.Name = "lbl_scfs_max"
        Me.lbl_scfs_max.Size = New System.Drawing.Size(221, 18)
        Me.lbl_scfs_max.TabIndex = 15
        Me.lbl_scfs_max.Text = "SCF/s max at 100% fan speed"
        '
        'lbl_psig_max
        '
        Me.lbl_psig_max.AutoSize = True
        Me.lbl_psig_max.ForeColor = System.Drawing.Color.White
        Me.lbl_psig_max.Location = New System.Drawing.Point(45, 159)
        Me.lbl_psig_max.Name = "lbl_psig_max"
        Me.lbl_psig_max.Size = New System.Drawing.Size(213, 18)
        Me.lbl_psig_max.TabIndex = 17
        Me.lbl_psig_max.Text = "PSIG max at 100% fan speed"
        '
        'lbl_model_params
        '
        Me.lbl_model_params.AutoSize = True
        Me.lbl_model_params.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_model_params.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_model_params.ForeColor = System.Drawing.Color.White
        Me.lbl_model_params.Location = New System.Drawing.Point(30, 19)
        Me.lbl_model_params.Name = "lbl_model_params"
        Me.lbl_model_params.Size = New System.Drawing.Size(173, 25)
        Me.lbl_model_params.TabIndex = 18
        Me.lbl_model_params.Text = "Model Parameters"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(371, 368)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'avd_psig_max
        '
        Me.avd_psig_max.AutoSize = True
        Me.avd_psig_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_psig_max.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_psig_max.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_psig_max.ForeColor = System.Drawing.Color.White
        Me.avd_psig_max.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_psig_max.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_psig_max.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_psig_max.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_psig_max.KeypadMaxValue = 0R
        Me.avd_psig_max.KeypadMinValue = 0R
        Me.avd_psig_max.KeypadPasscode = Nothing
        Me.avd_psig_max.KeypadScaleFactor = 1.0R
        Me.avd_psig_max.KeypadText = Nothing
        Me.avd_psig_max.KeypadWidth = 300
        Me.avd_psig_max.Location = New System.Drawing.Point(264, 159)
        Me.avd_psig_max.Name = "avd_psig_max"
        Me.avd_psig_max.NumericFormat = "F3"
        Me.avd_psig_max.PLCAddressKeypad = "F8:0"
        Me.avd_psig_max.PLCAddressValue = Nothing
        Me.avd_psig_max.PLCAddressValueLimitLower = Nothing
        Me.avd_psig_max.PLCAddressValueLimitUpper = Nothing
        Me.avd_psig_max.PLCAddressVisible = Nothing
        Me.avd_psig_max.ShowValue = True
        Me.avd_psig_max.Size = New System.Drawing.Size(73, 29)
        Me.avd_psig_max.TabIndex = 16
        Me.avd_psig_max.Text = "1.000"
        Me.avd_psig_max.Value = "1"
        Me.avd_psig_max.ValueLimitLower = -999999.0R
        Me.avd_psig_max.ValueLimitUpper = 999999.0R
        Me.avd_psig_max.ValuePrefix = Nothing
        Me.avd_psig_max.ValueSuffix = Nothing
        Me.avd_psig_max.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'EthernetIPforSLCMicroCom1
        '
        Me.EthernetIPforSLCMicroCom1.CIPConnectionSize = 508
        Me.EthernetIPforSLCMicroCom1.DisableSubscriptions = False
        Me.EthernetIPforSLCMicroCom1.IniFileName = ""
        Me.EthernetIPforSLCMicroCom1.IniFileSection = Nothing
        Me.EthernetIPforSLCMicroCom1.IPAddress = "192.168.1.112"
        Me.EthernetIPforSLCMicroCom1.IsPLC5 = False
        Me.EthernetIPforSLCMicroCom1.MaxPCCCPacketSize = 236
        Me.EthernetIPforSLCMicroCom1.PollRateOverride = 500
        Me.EthernetIPforSLCMicroCom1.Port = 44818
        Me.EthernetIPforSLCMicroCom1.RoutePath = Nothing
        Me.EthernetIPforSLCMicroCom1.Timeout = 5000
        '
        'avd_scfs_max
        '
        Me.avd_scfs_max.AutoSize = True
        Me.avd_scfs_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_scfs_max.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_scfs_max.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_scfs_max.ForeColor = System.Drawing.Color.White
        Me.avd_scfs_max.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_scfs_max.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_scfs_max.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_scfs_max.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_scfs_max.KeypadMaxValue = 0R
        Me.avd_scfs_max.KeypadMinValue = 0R
        Me.avd_scfs_max.KeypadPasscode = Nothing
        Me.avd_scfs_max.KeypadScaleFactor = 1.0R
        Me.avd_scfs_max.KeypadText = Nothing
        Me.avd_scfs_max.KeypadWidth = 300
        Me.avd_scfs_max.Location = New System.Drawing.Point(264, 125)
        Me.avd_scfs_max.Name = "avd_scfs_max"
        Me.avd_scfs_max.NumericFormat = "F3"
        Me.avd_scfs_max.PLCAddressKeypad = "F8:0"
        Me.avd_scfs_max.PLCAddressValue = Nothing
        Me.avd_scfs_max.PLCAddressValueLimitLower = Nothing
        Me.avd_scfs_max.PLCAddressValueLimitUpper = Nothing
        Me.avd_scfs_max.PLCAddressVisible = Nothing
        Me.avd_scfs_max.ShowValue = True
        Me.avd_scfs_max.Size = New System.Drawing.Size(73, 29)
        Me.avd_scfs_max.TabIndex = 14
        Me.avd_scfs_max.Text = "1.000"
        Me.avd_scfs_max.Value = "1"
        Me.avd_scfs_max.ValueLimitLower = -999999.0R
        Me.avd_scfs_max.ValueLimitUpper = 999999.0R
        Me.avd_scfs_max.ValuePrefix = Nothing
        Me.avd_scfs_max.ValueSuffix = Nothing
        Me.avd_scfs_max.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'avd_leak_coeff
        '
        Me.avd_leak_coeff.AutoSize = True
        Me.avd_leak_coeff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_leak_coeff.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_leak_coeff.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_leak_coeff.ForeColor = System.Drawing.Color.White
        Me.avd_leak_coeff.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_leak_coeff.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_leak_coeff.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_leak_coeff.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_leak_coeff.KeypadMaxValue = 0R
        Me.avd_leak_coeff.KeypadMinValue = 0R
        Me.avd_leak_coeff.KeypadPasscode = Nothing
        Me.avd_leak_coeff.KeypadScaleFactor = 1.0R
        Me.avd_leak_coeff.KeypadText = Nothing
        Me.avd_leak_coeff.KeypadWidth = 300
        Me.avd_leak_coeff.Location = New System.Drawing.Point(264, 91)
        Me.avd_leak_coeff.Name = "avd_leak_coeff"
        Me.avd_leak_coeff.NumericFormat = "F3"
        Me.avd_leak_coeff.PLCAddressKeypad = "F8:0"
        Me.avd_leak_coeff.PLCAddressValue = Nothing
        Me.avd_leak_coeff.PLCAddressValueLimitLower = Nothing
        Me.avd_leak_coeff.PLCAddressValueLimitUpper = Nothing
        Me.avd_leak_coeff.PLCAddressVisible = Nothing
        Me.avd_leak_coeff.ShowValue = True
        Me.avd_leak_coeff.Size = New System.Drawing.Size(73, 29)
        Me.avd_leak_coeff.TabIndex = 12
        Me.avd_leak_coeff.Text = "0.100"
        Me.avd_leak_coeff.Value = ".1"
        Me.avd_leak_coeff.ValueLimitLower = -999999.0R
        Me.avd_leak_coeff.ValueLimitUpper = 999999.0R
        Me.avd_leak_coeff.ValuePrefix = Nothing
        Me.avd_leak_coeff.ValueSuffix = Nothing
        Me.avd_leak_coeff.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'avd_volume
        '
        Me.avd_volume.AutoSize = True
        Me.avd_volume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_volume.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_volume.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_volume.ForeColor = System.Drawing.Color.White
        Me.avd_volume.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_volume.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_volume.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_volume.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_volume.KeypadMaxValue = 0R
        Me.avd_volume.KeypadMinValue = 0R
        Me.avd_volume.KeypadPasscode = Nothing
        Me.avd_volume.KeypadScaleFactor = 1.0R
        Me.avd_volume.KeypadText = Nothing
        Me.avd_volume.KeypadWidth = 300
        Me.avd_volume.Location = New System.Drawing.Point(264, 57)
        Me.avd_volume.Name = "avd_volume"
        Me.avd_volume.NumericFormat = "F3"
        Me.avd_volume.PLCAddressKeypad = "F8:0"
        Me.avd_volume.PLCAddressValue = Nothing
        Me.avd_volume.PLCAddressValueLimitLower = Nothing
        Me.avd_volume.PLCAddressValueLimitUpper = Nothing
        Me.avd_volume.PLCAddressVisible = Nothing
        Me.avd_volume.ShowValue = True
        Me.avd_volume.Size = New System.Drawing.Size(86, 29)
        Me.avd_volume.TabIndex = 10
        Me.avd_volume.Text = "10.000"
        Me.avd_volume.Value = "10"
        Me.avd_volume.ValueLimitLower = -999999.0R
        Me.avd_volume.ValueLimitUpper = 999999.0R
        Me.avd_volume.ValuePrefix = Nothing
        Me.avd_volume.ValueSuffix = Nothing
        Me.avd_volume.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(395, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(329, 368)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'lbl_pid
        '
        Me.lbl_pid.AutoSize = True
        Me.lbl_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_pid.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pid.ForeColor = System.Drawing.Color.White
        Me.lbl_pid.Location = New System.Drawing.Point(419, 19)
        Me.lbl_pid.Name = "lbl_pid"
        Me.lbl_pid.Size = New System.Drawing.Size(42, 25)
        Me.lbl_pid.TabIndex = 21
        Me.lbl_pid.Text = "PID"
        '
        'lbl_pid_setpoint
        '
        Me.lbl_pid_setpoint.AutoSize = True
        Me.lbl_pid_setpoint.ForeColor = System.Drawing.Color.White
        Me.lbl_pid_setpoint.Location = New System.Drawing.Point(452, 159)
        Me.lbl_pid_setpoint.Name = "lbl_pid_setpoint"
        Me.lbl_pid_setpoint.Size = New System.Drawing.Size(111, 18)
        Me.lbl_pid_setpoint.TabIndex = 23
        Me.lbl_pid_setpoint.Text = "Setpoint, PSIG"
        '
        'avd_pid_setpoint
        '
        Me.avd_pid_setpoint.AutoSize = True
        Me.avd_pid_setpoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_pid_setpoint.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_pid_setpoint.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_pid_setpoint.ForeColor = System.Drawing.Color.White
        Me.avd_pid_setpoint.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_pid_setpoint.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_pid_setpoint.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_pid_setpoint.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_pid_setpoint.KeypadMaxValue = 0R
        Me.avd_pid_setpoint.KeypadMinValue = 0R
        Me.avd_pid_setpoint.KeypadPasscode = Nothing
        Me.avd_pid_setpoint.KeypadScaleFactor = 1.0R
        Me.avd_pid_setpoint.KeypadText = Nothing
        Me.avd_pid_setpoint.KeypadWidth = 300
        Me.avd_pid_setpoint.Location = New System.Drawing.Point(572, 159)
        Me.avd_pid_setpoint.Name = "avd_pid_setpoint"
        Me.avd_pid_setpoint.NumericFormat = "F6"
        Me.avd_pid_setpoint.PLCAddressKeypad = "F10:5"
        Me.avd_pid_setpoint.PLCAddressValue = CType(resources.GetObject("avd_pid_setpoint.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.avd_pid_setpoint.PLCAddressValueLimitLower = Nothing
        Me.avd_pid_setpoint.PLCAddressValueLimitUpper = Nothing
        Me.avd_pid_setpoint.PLCAddressVisible = Nothing
        Me.avd_pid_setpoint.ShowValue = True
        Me.avd_pid_setpoint.Size = New System.Drawing.Size(112, 29)
        Me.avd_pid_setpoint.TabIndex = 22
        Me.avd_pid_setpoint.Text = "0.000000"
        Me.avd_pid_setpoint.Value = "0"
        Me.avd_pid_setpoint.ValueLimitLower = -999999.0R
        Me.avd_pid_setpoint.ValueLimitUpper = 999999.0R
        Me.avd_pid_setpoint.ValuePrefix = Nothing
        Me.avd_pid_setpoint.ValueSuffix = Nothing
        Me.avd_pid_setpoint.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_pid_pv
        '
        Me.lbl_pid_pv.AutoSize = True
        Me.lbl_pid_pv.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbl_pid_pv.Location = New System.Drawing.Point(416, 194)
        Me.lbl_pid_pv.Name = "lbl_pid_pv"
        Me.lbl_pid_pv.Size = New System.Drawing.Size(150, 18)
        Me.lbl_pid_pv.TabIndex = 24
        Me.lbl_pid_pv.Text = "Present Value, PSIG"
        '
        'avd_pid_pv
        '
        Me.avd_pid_pv.AutoSize = True
        Me.avd_pid_pv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_pid_pv.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_pid_pv.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_pid_pv.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.avd_pid_pv.ForeColorInLimits = System.Drawing.Color.CornflowerBlue
        Me.avd_pid_pv.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_pid_pv.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_pid_pv.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_pid_pv.KeypadMaxValue = 0R
        Me.avd_pid_pv.KeypadMinValue = 0R
        Me.avd_pid_pv.KeypadPasscode = Nothing
        Me.avd_pid_pv.KeypadScaleFactor = 1.0R
        Me.avd_pid_pv.KeypadText = Nothing
        Me.avd_pid_pv.KeypadWidth = 300
        Me.avd_pid_pv.Location = New System.Drawing.Point(572, 194)
        Me.avd_pid_pv.Name = "avd_pid_pv"
        Me.avd_pid_pv.NumericFormat = "F6"
        Me.avd_pid_pv.PLCAddressKeypad = "F10:6"
        Me.avd_pid_pv.PLCAddressValue = Nothing
        Me.avd_pid_pv.PLCAddressValueLimitLower = Nothing
        Me.avd_pid_pv.PLCAddressValueLimitUpper = Nothing
        Me.avd_pid_pv.PLCAddressVisible = Nothing
        Me.avd_pid_pv.ShowValue = True
        Me.avd_pid_pv.Size = New System.Drawing.Size(112, 29)
        Me.avd_pid_pv.TabIndex = 25
        Me.avd_pid_pv.Text = "0.000000"
        Me.avd_pid_pv.Value = "0"
        Me.avd_pid_pv.ValueLimitLower = -999999.0R
        Me.avd_pid_pv.ValueLimitUpper = 999999.0R
        Me.avd_pid_pv.ValuePrefix = Nothing
        Me.avd_pid_pv.ValueSuffix = Nothing
        Me.avd_pid_pv.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'avd_pid_output
        '
        Me.avd_pid_output.AutoSize = True
        Me.avd_pid_output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_pid_output.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_pid_output.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_pid_output.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.avd_pid_output.ForeColorInLimits = System.Drawing.Color.CornflowerBlue
        Me.avd_pid_output.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_pid_output.ForeColorUnderLimit = System.Drawing.Color.Red
        Me.avd_pid_output.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_pid_output.KeypadMaxValue = 0R
        Me.avd_pid_output.KeypadMinValue = 0R
        Me.avd_pid_output.KeypadPasscode = Nothing
        Me.avd_pid_output.KeypadScaleFactor = 1.0R
        Me.avd_pid_output.KeypadText = Nothing
        Me.avd_pid_output.KeypadWidth = 300
        Me.avd_pid_output.Location = New System.Drawing.Point(572, 228)
        Me.avd_pid_output.Name = "avd_pid_output"
        Me.avd_pid_output.NumericFormat = "F5"
        Me.avd_pid_output.PLCAddressKeypad = "F10:9"
        Me.avd_pid_output.PLCAddressValue = CType(resources.GetObject("avd_pid_output.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.avd_pid_output.PLCAddressValueLimitLower = Nothing
        Me.avd_pid_output.PLCAddressValueLimitUpper = Nothing
        Me.avd_pid_output.PLCAddressVisible = Nothing
        Me.avd_pid_output.ShowValue = True
        Me.avd_pid_output.Size = New System.Drawing.Size(112, 29)
        Me.avd_pid_output.TabIndex = 27
        Me.avd_pid_output.Text = "50.00000"
        Me.avd_pid_output.Value = "50"
        Me.avd_pid_output.ValueLimitLower = 0.001R
        Me.avd_pid_output.ValueLimitUpper = 99.999R
        Me.avd_pid_output.ValuePrefix = Nothing
        Me.avd_pid_output.ValueSuffix = Nothing
        Me.avd_pid_output.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_pid_output
        '
        Me.lbl_pid_output.AutoSize = True
        Me.lbl_pid_output.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbl_pid_output.Location = New System.Drawing.Point(491, 228)
        Me.lbl_pid_output.Name = "lbl_pid_output"
        Me.lbl_pid_output.Size = New System.Drawing.Size(75, 18)
        Me.lbl_pid_output.TabIndex = 26
        Me.lbl_pid_output.Text = "Output, %"
        '
        'avd_fan_speed
        '
        Me.avd_fan_speed.AutoSize = True
        Me.avd_fan_speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_fan_speed.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_fan_speed.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_fan_speed.ForeColor = System.Drawing.Color.Red
        Me.avd_fan_speed.ForeColorInLimits = System.Drawing.Color.CornflowerBlue
        Me.avd_fan_speed.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_fan_speed.ForeColorUnderLimit = System.Drawing.Color.Red
        Me.avd_fan_speed.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_fan_speed.KeypadMaxValue = 0R
        Me.avd_fan_speed.KeypadMinValue = 0R
        Me.avd_fan_speed.KeypadPasscode = Nothing
        Me.avd_fan_speed.KeypadScaleFactor = 1.0R
        Me.avd_fan_speed.KeypadText = Nothing
        Me.avd_fan_speed.KeypadWidth = 300
        Me.avd_fan_speed.Location = New System.Drawing.Point(572, 296)
        Me.avd_fan_speed.Name = "avd_fan_speed"
        Me.avd_fan_speed.NumericFormat = "f6"
        Me.avd_fan_speed.PLCAddressKeypad = "F8:0"
        Me.avd_fan_speed.PLCAddressValue = Nothing
        Me.avd_fan_speed.PLCAddressValueLimitLower = Nothing
        Me.avd_fan_speed.PLCAddressValueLimitUpper = Nothing
        Me.avd_fan_speed.PLCAddressVisible = Nothing
        Me.avd_fan_speed.ShowValue = True
        Me.avd_fan_speed.Size = New System.Drawing.Size(112, 29)
        Me.avd_fan_speed.TabIndex = 29
        Me.avd_fan_speed.Text = "0.000000"
        Me.avd_fan_speed.Value = "0"
        Me.avd_fan_speed.ValueLimitLower = 0.0005R
        Me.avd_fan_speed.ValueLimitUpper = 99.9995R
        Me.avd_fan_speed.ValuePrefix = Nothing
        Me.avd_fan_speed.ValueSuffix = Nothing
        Me.avd_fan_speed.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_fan_speed
        '
        Me.lbl_fan_speed.AutoSize = True
        Me.lbl_fan_speed.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbl_fan_speed.Location = New System.Drawing.Point(455, 296)
        Me.lbl_fan_speed.Name = "lbl_fan_speed"
        Me.lbl_fan_speed.Size = New System.Drawing.Size(108, 18)
        Me.lbl_fan_speed.TabIndex = 28
        Me.lbl_fan_speed.Text = "Fan Speed, %"
        '
        'avd_fan_ramp
        '
        Me.avd_fan_ramp.AutoSize = True
        Me.avd_fan_ramp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_fan_ramp.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_fan_ramp.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_fan_ramp.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.avd_fan_ramp.ForeColorInLimits = System.Drawing.Color.CornflowerBlue
        Me.avd_fan_ramp.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_fan_ramp.ForeColorUnderLimit = System.Drawing.Color.Red
        Me.avd_fan_ramp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_fan_ramp.KeypadMaxValue = 0R
        Me.avd_fan_ramp.KeypadMinValue = 0R
        Me.avd_fan_ramp.KeypadPasscode = Nothing
        Me.avd_fan_ramp.KeypadScaleFactor = 1.0R
        Me.avd_fan_ramp.KeypadText = Nothing
        Me.avd_fan_ramp.KeypadWidth = 300
        Me.avd_fan_ramp.Location = New System.Drawing.Point(572, 262)
        Me.avd_fan_ramp.Name = "avd_fan_ramp"
        Me.avd_fan_ramp.NumericFormat = "F6"
        Me.avd_fan_ramp.PLCAddressKeypad = ""
        Me.avd_fan_ramp.PLCAddressValue = Nothing
        Me.avd_fan_ramp.PLCAddressValueLimitLower = Nothing
        Me.avd_fan_ramp.PLCAddressValueLimitUpper = Nothing
        Me.avd_fan_ramp.PLCAddressVisible = Nothing
        Me.avd_fan_ramp.ShowValue = True
        Me.avd_fan_ramp.Size = New System.Drawing.Size(112, 29)
        Me.avd_fan_ramp.TabIndex = 31
        Me.avd_fan_ramp.Text = "0.000000"
        Me.avd_fan_ramp.Value = "0"
        Me.avd_fan_ramp.ValueLimitLower = -99999.0R
        Me.avd_fan_ramp.ValueLimitUpper = 99999.0R
        Me.avd_fan_ramp.ValuePrefix = Nothing
        Me.avd_fan_ramp.ValueSuffix = Nothing
        Me.avd_fan_ramp.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_fan_ramp
        '
        Me.lbl_fan_ramp.AutoSize = True
        Me.lbl_fan_ramp.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbl_fan_ramp.Location = New System.Drawing.Point(452, 262)
        Me.lbl_fan_ramp.Name = "lbl_fan_ramp"
        Me.lbl_fan_ramp.Size = New System.Drawing.Size(115, 18)
        Me.lbl_fan_ramp.TabIndex = 30
        Me.lbl_fan_ramp.Text = "Fan Ramp, %/s"
        '
        'lbl_pid_update_rate
        '
        Me.lbl_pid_update_rate.AutoSize = True
        Me.lbl_pid_update_rate.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbl_pid_update_rate.Location = New System.Drawing.Point(451, 330)
        Me.lbl_pid_update_rate.Name = "lbl_pid_update_rate"
        Me.lbl_pid_update_rate.Size = New System.Drawing.Size(112, 18)
        Me.lbl_pid_update_rate.TabIndex = 34
        Me.lbl_pid_update_rate.Text = "Update Rate, s"
        '
        'avd_pid_update_rate
        '
        Me.avd_pid_update_rate.AutoSize = True
        Me.avd_pid_update_rate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_pid_update_rate.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_pid_update_rate.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_pid_update_rate.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.avd_pid_update_rate.ForeColorInLimits = System.Drawing.Color.CornflowerBlue
        Me.avd_pid_update_rate.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_pid_update_rate.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_pid_update_rate.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_pid_update_rate.KeypadMaxValue = 0R
        Me.avd_pid_update_rate.KeypadMinValue = 0R
        Me.avd_pid_update_rate.KeypadPasscode = Nothing
        Me.avd_pid_update_rate.KeypadScaleFactor = 1.0R
        Me.avd_pid_update_rate.KeypadText = Nothing
        Me.avd_pid_update_rate.KeypadWidth = 300
        Me.avd_pid_update_rate.Location = New System.Drawing.Point(572, 330)
        Me.avd_pid_update_rate.Name = "avd_pid_update_rate"
        Me.avd_pid_update_rate.NumericFormat = "F4"
        Me.avd_pid_update_rate.PLCAddressKeypad = ""
        Me.avd_pid_update_rate.PLCAddressValue = CType(resources.GetObject("avd_pid_update_rate.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.avd_pid_update_rate.PLCAddressValueLimitLower = Nothing
        Me.avd_pid_update_rate.PLCAddressValueLimitUpper = Nothing
        Me.avd_pid_update_rate.PLCAddressVisible = Nothing
        Me.avd_pid_update_rate.ShowValue = True
        Me.avd_pid_update_rate.Size = New System.Drawing.Size(86, 29)
        Me.avd_pid_update_rate.TabIndex = 33
        Me.avd_pid_update_rate.Text = "1.0000"
        Me.avd_pid_update_rate.Value = "1"
        Me.avd_pid_update_rate.ValueLimitLower = -999999.0R
        Me.avd_pid_update_rate.ValueLimitUpper = 999999.0R
        Me.avd_pid_update_rate.ValuePrefix = Nothing
        Me.avd_pid_update_rate.ValueSuffix = Nothing
        Me.avd_pid_update_rate.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_pid_gain
        '
        Me.lbl_pid_gain.AutoSize = True
        Me.lbl_pid_gain.ForeColor = System.Drawing.Color.White
        Me.lbl_pid_gain.Location = New System.Drawing.Point(491, 57)
        Me.lbl_pid_gain.Name = "lbl_pid_gain"
        Me.lbl_pid_gain.Size = New System.Drawing.Size(68, 18)
        Me.lbl_pid_gain.TabIndex = 36
        Me.lbl_pid_gain.Text = "Gain, Kc"
        '
        'avd_pid_gain
        '
        Me.avd_pid_gain.AutoSize = True
        Me.avd_pid_gain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_pid_gain.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_pid_gain.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_pid_gain.ForeColor = System.Drawing.Color.White
        Me.avd_pid_gain.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_pid_gain.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_pid_gain.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_pid_gain.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_pid_gain.KeypadMaxValue = 0R
        Me.avd_pid_gain.KeypadMinValue = 0R
        Me.avd_pid_gain.KeypadPasscode = Nothing
        Me.avd_pid_gain.KeypadScaleFactor = 1.0R
        Me.avd_pid_gain.KeypadText = Nothing
        Me.avd_pid_gain.KeypadWidth = 300
        Me.avd_pid_gain.Location = New System.Drawing.Point(572, 57)
        Me.avd_pid_gain.Name = "avd_pid_gain"
        Me.avd_pid_gain.NumericFormat = "F3"
        Me.avd_pid_gain.PLCAddressKeypad = "F10:0"
        Me.avd_pid_gain.PLCAddressValue = CType(resources.GetObject("avd_pid_gain.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.avd_pid_gain.PLCAddressValueLimitLower = Nothing
        Me.avd_pid_gain.PLCAddressValueLimitUpper = Nothing
        Me.avd_pid_gain.PLCAddressVisible = Nothing
        Me.avd_pid_gain.ShowValue = True
        Me.avd_pid_gain.Size = New System.Drawing.Size(73, 29)
        Me.avd_pid_gain.TabIndex = 35
        Me.avd_pid_gain.Text = "0.000"
        Me.avd_pid_gain.Value = "0"
        Me.avd_pid_gain.ValueLimitLower = -999999.0R
        Me.avd_pid_gain.ValueLimitUpper = 999999.0R
        Me.avd_pid_gain.ValuePrefix = Nothing
        Me.avd_pid_gain.ValueSuffix = Nothing
        Me.avd_pid_gain.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_pid_reset
        '
        Me.lbl_pid_reset.AutoSize = True
        Me.lbl_pid_reset.ForeColor = System.Drawing.Color.White
        Me.lbl_pid_reset.Location = New System.Drawing.Point(436, 91)
        Me.lbl_pid_reset.Name = "lbl_pid_reset"
        Me.lbl_pid_reset.Size = New System.Drawing.Size(131, 18)
        Me.lbl_pid_reset.TabIndex = 38
        Me.lbl_pid_reset.Text = "Reset, Ti, minutes"
        '
        'avd_pid_reset
        '
        Me.avd_pid_reset.AutoSize = True
        Me.avd_pid_reset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_pid_reset.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_pid_reset.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_pid_reset.ForeColor = System.Drawing.Color.White
        Me.avd_pid_reset.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_pid_reset.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_pid_reset.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_pid_reset.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_pid_reset.KeypadMaxValue = 0R
        Me.avd_pid_reset.KeypadMinValue = 0R
        Me.avd_pid_reset.KeypadPasscode = Nothing
        Me.avd_pid_reset.KeypadScaleFactor = 1.0R
        Me.avd_pid_reset.KeypadText = Nothing
        Me.avd_pid_reset.KeypadWidth = 300
        Me.avd_pid_reset.Location = New System.Drawing.Point(572, 91)
        Me.avd_pid_reset.Name = "avd_pid_reset"
        Me.avd_pid_reset.NumericFormat = "F3"
        Me.avd_pid_reset.PLCAddressKeypad = "F10:1"
        Me.avd_pid_reset.PLCAddressValue = CType(resources.GetObject("avd_pid_reset.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.avd_pid_reset.PLCAddressValueLimitLower = Nothing
        Me.avd_pid_reset.PLCAddressValueLimitUpper = Nothing
        Me.avd_pid_reset.PLCAddressVisible = Nothing
        Me.avd_pid_reset.ShowValue = True
        Me.avd_pid_reset.Size = New System.Drawing.Size(73, 29)
        Me.avd_pid_reset.TabIndex = 37
        Me.avd_pid_reset.Text = "0.000"
        Me.avd_pid_reset.Value = "0"
        Me.avd_pid_reset.ValueLimitLower = -999999.0R
        Me.avd_pid_reset.ValueLimitUpper = 999999.0R
        Me.avd_pid_reset.ValuePrefix = Nothing
        Me.avd_pid_reset.ValueSuffix = Nothing
        Me.avd_pid_reset.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_pid_rate
        '
        Me.lbl_pid_rate.AutoSize = True
        Me.lbl_pid_rate.ForeColor = System.Drawing.Color.White
        Me.lbl_pid_rate.Location = New System.Drawing.Point(435, 125)
        Me.lbl_pid_rate.Name = "lbl_pid_rate"
        Me.lbl_pid_rate.Size = New System.Drawing.Size(129, 18)
        Me.lbl_pid_rate.TabIndex = 40
        Me.lbl_pid_rate.Text = "Rate, Td, minutes"
        '
        'avd_pid_rate
        '
        Me.avd_pid_rate.AutoSize = True
        Me.avd_pid_rate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_pid_rate.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_pid_rate.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_pid_rate.ForeColor = System.Drawing.Color.White
        Me.avd_pid_rate.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_pid_rate.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_pid_rate.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.avd_pid_rate.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_pid_rate.KeypadMaxValue = 0R
        Me.avd_pid_rate.KeypadMinValue = 0R
        Me.avd_pid_rate.KeypadPasscode = Nothing
        Me.avd_pid_rate.KeypadScaleFactor = 1.0R
        Me.avd_pid_rate.KeypadText = Nothing
        Me.avd_pid_rate.KeypadWidth = 300
        Me.avd_pid_rate.Location = New System.Drawing.Point(572, 125)
        Me.avd_pid_rate.Name = "avd_pid_rate"
        Me.avd_pid_rate.NumericFormat = "F3"
        Me.avd_pid_rate.PLCAddressKeypad = "F10:2"
        Me.avd_pid_rate.PLCAddressValue = CType(resources.GetObject("avd_pid_rate.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.avd_pid_rate.PLCAddressValueLimitLower = Nothing
        Me.avd_pid_rate.PLCAddressValueLimitUpper = Nothing
        Me.avd_pid_rate.PLCAddressVisible = Nothing
        Me.avd_pid_rate.ShowValue = True
        Me.avd_pid_rate.Size = New System.Drawing.Size(73, 29)
        Me.avd_pid_rate.TabIndex = 39
        Me.avd_pid_rate.Text = "0.000"
        Me.avd_pid_rate.Value = "0"
        Me.avd_pid_rate.ValueLimitLower = -999999.0R
        Me.avd_pid_rate.ValueLimitUpper = 999999.0R
        Me.avd_pid_rate.ValuePrefix = Nothing
        Me.avd_pid_rate.ValueSuffix = Nothing
        Me.avd_pid_rate.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_implicit_euler
        '
        Me.lbl_implicit_euler.AutoSize = True
        Me.lbl_implicit_euler.ForeColor = System.Drawing.Color.White
        Me.lbl_implicit_euler.Location = New System.Drawing.Point(56, 195)
        Me.lbl_implicit_euler.Name = "lbl_implicit_euler"
        Me.lbl_implicit_euler.Size = New System.Drawing.Size(202, 18)
        Me.lbl_implicit_euler.TabIndex = 41
        Me.lbl_implicit_euler.Text = "Implicit Euler parameter, 0-1"
        '
        'avd_implicit_euler
        '
        Me.avd_implicit_euler.AutoSize = True
        Me.avd_implicit_euler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.avd_implicit_euler.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_implicit_euler.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avd_implicit_euler.ForeColor = System.Drawing.Color.White
        Me.avd_implicit_euler.ForeColorInLimits = System.Drawing.Color.White
        Me.avd_implicit_euler.ForeColorOverLimit = System.Drawing.Color.Red
        Me.avd_implicit_euler.ForeColorUnderLimit = System.Drawing.Color.Red
        Me.avd_implicit_euler.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_implicit_euler.KeypadMaxValue = 0R
        Me.avd_implicit_euler.KeypadMinValue = 0R
        Me.avd_implicit_euler.KeypadPasscode = Nothing
        Me.avd_implicit_euler.KeypadScaleFactor = 1.0R
        Me.avd_implicit_euler.KeypadText = Nothing
        Me.avd_implicit_euler.KeypadWidth = 300
        Me.avd_implicit_euler.Location = New System.Drawing.Point(264, 195)
        Me.avd_implicit_euler.Name = "avd_implicit_euler"
        Me.avd_implicit_euler.NumericFormat = "F3"
        Me.avd_implicit_euler.PLCAddressKeypad = "F8:0"
        Me.avd_implicit_euler.PLCAddressValue = Nothing
        Me.avd_implicit_euler.PLCAddressValueLimitLower = Nothing
        Me.avd_implicit_euler.PLCAddressValueLimitUpper = Nothing
        Me.avd_implicit_euler.PLCAddressVisible = Nothing
        Me.avd_implicit_euler.ShowValue = True
        Me.avd_implicit_euler.Size = New System.Drawing.Size(73, 29)
        Me.avd_implicit_euler.TabIndex = 42
        Me.avd_implicit_euler.Text = "0.500"
        Me.avd_implicit_euler.Value = "0.5"
        Me.avd_implicit_euler.ValueLimitLower = 0R
        Me.avd_implicit_euler.ValueLimitUpper = 1.0R
        Me.avd_implicit_euler.ValuePrefix = Nothing
        Me.avd_implicit_euler.ValueSuffix = Nothing
        Me.avd_implicit_euler.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'chk_pid_auto
        '
        Me.chk_pid_auto.AutoSize = True
        Me.chk_pid_auto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_pid_auto.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.chk_pid_auto.ForeColor = System.Drawing.Color.White
        Me.chk_pid_auto.Location = New System.Drawing.Point(494, 22)
        Me.chk_pid_auto.Name = "chk_pid_auto"
        Me.chk_pid_auto.PLCAddressCheckChanged = "B3:0/0"
        Me.chk_pid_auto.PLCAddressChecked = "B3:0/0"
        Me.chk_pid_auto.PLCAddressText = ""
        Me.chk_pid_auto.PLCAddressVisible = ""
        Me.chk_pid_auto.Size = New System.Drawing.Size(59, 22)
        Me.chk_pid_auto.TabIndex = 43
        Me.chk_pid_auto.Text = "Auto"
        Me.chk_pid_auto.UseVisualStyleBackColor = True
        '
        'chk_pid_reverse
        '
        Me.chk_pid_reverse.AutoSize = True
        Me.chk_pid_reverse.BackColor = System.Drawing.Color.Black
        Me.chk_pid_reverse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_pid_reverse.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.chk_pid_reverse.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chk_pid_reverse.ForeColor = System.Drawing.Color.White
        Me.chk_pid_reverse.Location = New System.Drawing.Point(572, 22)
        Me.chk_pid_reverse.Name = "chk_pid_reverse"
        Me.chk_pid_reverse.PLCAddressCheckChanged = "B3:0/2"
        Me.chk_pid_reverse.PLCAddressChecked = "B3:0/2"
        Me.chk_pid_reverse.PLCAddressText = ""
        Me.chk_pid_reverse.PLCAddressVisible = ""
        Me.chk_pid_reverse.Size = New System.Drawing.Size(85, 22)
        Me.chk_pid_reverse.TabIndex = 44
        Me.chk_pid_reverse.Text = "Reverse"
        Me.chk_pid_reverse.UseVisualStyleBackColor = False
        '
        'avd_debug_free_running_clock
        '
        Me.avd_debug_free_running_clock.AutoSize = True
        Me.avd_debug_free_running_clock.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_debug_free_running_clock.ForeColor = System.Drawing.Color.Gray
        Me.avd_debug_free_running_clock.ForeColorInLimits = System.Drawing.Color.Gray
        Me.avd_debug_free_running_clock.ForeColorOverLimit = System.Drawing.Color.Gray
        Me.avd_debug_free_running_clock.ForeColorUnderLimit = System.Drawing.Color.Gray
        Me.avd_debug_free_running_clock.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_debug_free_running_clock.KeypadMaxValue = 0R
        Me.avd_debug_free_running_clock.KeypadMinValue = 0R
        Me.avd_debug_free_running_clock.KeypadPasscode = Nothing
        Me.avd_debug_free_running_clock.KeypadScaleFactor = 1.0R
        Me.avd_debug_free_running_clock.KeypadText = Nothing
        Me.avd_debug_free_running_clock.KeypadWidth = 300
        Me.avd_debug_free_running_clock.Location = New System.Drawing.Point(261, -254)
        Me.avd_debug_free_running_clock.Name = "avd_debug_free_running_clock"
        Me.avd_debug_free_running_clock.NumericFormat = Nothing
        Me.avd_debug_free_running_clock.PLCAddressKeypad = ""
        Me.avd_debug_free_running_clock.PLCAddressValue = CType(resources.GetObject("avd_debug_free_running_clock.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.avd_debug_free_running_clock.PLCAddressValueLimitLower = Nothing
        Me.avd_debug_free_running_clock.PLCAddressValueLimitUpper = Nothing
        Me.avd_debug_free_running_clock.PLCAddressVisible = Nothing
        Me.avd_debug_free_running_clock.ShowValue = True
        Me.avd_debug_free_running_clock.Size = New System.Drawing.Size(44, 18)
        Me.avd_debug_free_running_clock.TabIndex = 45
        Me.avd_debug_free_running_clock.Text = "0000"
        Me.avd_debug_free_running_clock.Value = "0000"
        Me.avd_debug_free_running_clock.ValueLimitLower = -999999.0R
        Me.avd_debug_free_running_clock.ValueLimitUpper = 999999.0R
        Me.avd_debug_free_running_clock.ValuePrefix = Nothing
        Me.avd_debug_free_running_clock.ValueSuffix = Nothing
        Me.avd_debug_free_running_clock.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_debug_free_running_clock
        '
        Me.lbl_debug_free_running_clock.AutoSize = True
        Me.lbl_debug_free_running_clock.ForeColor = System.Drawing.Color.Gray
        Me.lbl_debug_free_running_clock.Location = New System.Drawing.Point(112, -254)
        Me.lbl_debug_free_running_clock.Name = "lbl_debug_free_running_clock"
        Me.lbl_debug_free_running_clock.Size = New System.Drawing.Size(146, 18)
        Me.lbl_debug_free_running_clock.TabIndex = 47
        Me.lbl_debug_free_running_clock.Text = "Free-Running Clock"
        '
        'lbl_debug_delta_psig
        '
        Me.lbl_debug_delta_psig.AutoSize = True
        Me.lbl_debug_delta_psig.ForeColor = System.Drawing.Color.Gray
        Me.lbl_debug_delta_psig.Location = New System.Drawing.Point(172, -275)
        Me.lbl_debug_delta_psig.Name = "lbl_debug_delta_psig"
        Me.lbl_debug_delta_psig.Size = New System.Drawing.Size(86, 18)
        Me.lbl_debug_delta_psig.TabIndex = 48
        Me.lbl_debug_delta_psig.Text = "Delta PSIG"
        '
        'avd_debug_delta_psig
        '
        Me.avd_debug_delta_psig.AutoSize = True
        Me.avd_debug_delta_psig.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_debug_delta_psig.ForeColor = System.Drawing.Color.Gray
        Me.avd_debug_delta_psig.ForeColorInLimits = System.Drawing.Color.Gray
        Me.avd_debug_delta_psig.ForeColorOverLimit = System.Drawing.Color.Gray
        Me.avd_debug_delta_psig.ForeColorUnderLimit = System.Drawing.Color.Gray
        Me.avd_debug_delta_psig.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_debug_delta_psig.KeypadMaxValue = 0R
        Me.avd_debug_delta_psig.KeypadMinValue = 0R
        Me.avd_debug_delta_psig.KeypadPasscode = Nothing
        Me.avd_debug_delta_psig.KeypadScaleFactor = 1.0R
        Me.avd_debug_delta_psig.KeypadText = Nothing
        Me.avd_debug_delta_psig.KeypadWidth = 300
        Me.avd_debug_delta_psig.Location = New System.Drawing.Point(261, -275)
        Me.avd_debug_delta_psig.Name = "avd_debug_delta_psig"
        Me.avd_debug_delta_psig.NumericFormat = "E5"
        Me.avd_debug_delta_psig.PLCAddressKeypad = ""
        Me.avd_debug_delta_psig.PLCAddressValue = Nothing
        Me.avd_debug_delta_psig.PLCAddressValueLimitLower = Nothing
        Me.avd_debug_delta_psig.PLCAddressValueLimitUpper = Nothing
        Me.avd_debug_delta_psig.PLCAddressVisible = Nothing
        Me.avd_debug_delta_psig.ShowValue = True
        Me.avd_debug_delta_psig.Size = New System.Drawing.Size(113, 18)
        Me.avd_debug_delta_psig.TabIndex = 49
        Me.avd_debug_delta_psig.Text = "9.99900E+003"
        Me.avd_debug_delta_psig.Value = "9999"
        Me.avd_debug_delta_psig.ValueLimitLower = -999999.0R
        Me.avd_debug_delta_psig.ValueLimitUpper = 999999.0R
        Me.avd_debug_delta_psig.ValuePrefix = Nothing
        Me.avd_debug_delta_psig.ValueSuffix = Nothing
        Me.avd_debug_delta_psig.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'chk_debug
        '
        Me.chk_debug.AutoSize = True
        Me.chk_debug.BackColor = System.Drawing.Color.Black
        Me.chk_debug.ForeColor = System.Drawing.Color.Gray
        Me.chk_debug.Location = New System.Drawing.Point(204, 229)
        Me.chk_debug.Name = "chk_debug"
        Me.chk_debug.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_debug.Size = New System.Drawing.Size(74, 22)
        Me.chk_debug.TabIndex = 50
        Me.chk_debug.Text = "Debug"
        Me.chk_debug.UseVisualStyleBackColor = False
        '
        'lbl_debug_dpdt_0
        '
        Me.lbl_debug_dpdt_0.AutoSize = True
        Me.lbl_debug_dpdt_0.ForeColor = System.Drawing.Color.Gray
        Me.lbl_debug_dpdt_0.Location = New System.Drawing.Point(145, -298)
        Me.lbl_debug_dpdt_0.Name = "lbl_debug_dpdt_0"
        Me.lbl_debug_dpdt_0.Size = New System.Drawing.Size(113, 18)
        Me.lbl_debug_dpdt_0.TabIndex = 51
        Me.lbl_debug_dpdt_0.Text = "dp/dt 0, PSIG/s"
        '
        'lbl_debug_dpdt_1
        '
        Me.lbl_debug_dpdt_1.AutoSize = True
        Me.lbl_debug_dpdt_1.ForeColor = System.Drawing.Color.Gray
        Me.lbl_debug_dpdt_1.Location = New System.Drawing.Point(145, -321)
        Me.lbl_debug_dpdt_1.Name = "lbl_debug_dpdt_1"
        Me.lbl_debug_dpdt_1.Size = New System.Drawing.Size(113, 18)
        Me.lbl_debug_dpdt_1.TabIndex = 52
        Me.lbl_debug_dpdt_1.Text = "dp/dt 1, PSIG/s"
        '
        'avd_debug_dpdt_0
        '
        Me.avd_debug_dpdt_0.AutoSize = True
        Me.avd_debug_dpdt_0.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_debug_dpdt_0.ForeColor = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_0.ForeColorInLimits = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_0.ForeColorOverLimit = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_0.ForeColorUnderLimit = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_0.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_debug_dpdt_0.KeypadMaxValue = 0R
        Me.avd_debug_dpdt_0.KeypadMinValue = 0R
        Me.avd_debug_dpdt_0.KeypadPasscode = Nothing
        Me.avd_debug_dpdt_0.KeypadScaleFactor = 1.0R
        Me.avd_debug_dpdt_0.KeypadText = Nothing
        Me.avd_debug_dpdt_0.KeypadWidth = 300
        Me.avd_debug_dpdt_0.Location = New System.Drawing.Point(261, -298)
        Me.avd_debug_dpdt_0.Name = "avd_debug_dpdt_0"
        Me.avd_debug_dpdt_0.NumericFormat = "E5"
        Me.avd_debug_dpdt_0.PLCAddressKeypad = ""
        Me.avd_debug_dpdt_0.PLCAddressValue = Nothing
        Me.avd_debug_dpdt_0.PLCAddressValueLimitLower = Nothing
        Me.avd_debug_dpdt_0.PLCAddressValueLimitUpper = Nothing
        Me.avd_debug_dpdt_0.PLCAddressVisible = Nothing
        Me.avd_debug_dpdt_0.ShowValue = True
        Me.avd_debug_dpdt_0.Size = New System.Drawing.Size(113, 18)
        Me.avd_debug_dpdt_0.TabIndex = 53
        Me.avd_debug_dpdt_0.Text = "9.99900E+003"
        Me.avd_debug_dpdt_0.Value = "9999"
        Me.avd_debug_dpdt_0.ValueLimitLower = -999999.0R
        Me.avd_debug_dpdt_0.ValueLimitUpper = 999999.0R
        Me.avd_debug_dpdt_0.ValuePrefix = Nothing
        Me.avd_debug_dpdt_0.ValueSuffix = Nothing
        Me.avd_debug_dpdt_0.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'avd_debug_dpdt_1
        '
        Me.avd_debug_dpdt_1.AutoSize = True
        Me.avd_debug_dpdt_1.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_debug_dpdt_1.ForeColor = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_1.ForeColorInLimits = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_1.ForeColorOverLimit = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_1.ForeColorUnderLimit = System.Drawing.Color.Gray
        Me.avd_debug_dpdt_1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_debug_dpdt_1.KeypadMaxValue = 0R
        Me.avd_debug_dpdt_1.KeypadMinValue = 0R
        Me.avd_debug_dpdt_1.KeypadPasscode = Nothing
        Me.avd_debug_dpdt_1.KeypadScaleFactor = 1.0R
        Me.avd_debug_dpdt_1.KeypadText = Nothing
        Me.avd_debug_dpdt_1.KeypadWidth = 300
        Me.avd_debug_dpdt_1.Location = New System.Drawing.Point(261, -321)
        Me.avd_debug_dpdt_1.Name = "avd_debug_dpdt_1"
        Me.avd_debug_dpdt_1.NumericFormat = "E5"
        Me.avd_debug_dpdt_1.PLCAddressKeypad = ""
        Me.avd_debug_dpdt_1.PLCAddressValue = Nothing
        Me.avd_debug_dpdt_1.PLCAddressValueLimitLower = Nothing
        Me.avd_debug_dpdt_1.PLCAddressValueLimitUpper = Nothing
        Me.avd_debug_dpdt_1.PLCAddressVisible = Nothing
        Me.avd_debug_dpdt_1.ShowValue = True
        Me.avd_debug_dpdt_1.Size = New System.Drawing.Size(113, 18)
        Me.avd_debug_dpdt_1.TabIndex = 54
        Me.avd_debug_dpdt_1.Text = "9.99900E+003"
        Me.avd_debug_dpdt_1.Value = "9999"
        Me.avd_debug_dpdt_1.ValueLimitLower = -999999.0R
        Me.avd_debug_dpdt_1.ValueLimitUpper = 999999.0R
        Me.avd_debug_dpdt_1.ValuePrefix = Nothing
        Me.avd_debug_dpdt_1.ValueSuffix = Nothing
        Me.avd_debug_dpdt_1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'avd_debug_error
        '
        Me.avd_debug_error.AutoSize = True
        Me.avd_debug_error.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.avd_debug_error.ForeColor = System.Drawing.Color.Gray
        Me.avd_debug_error.ForeColorInLimits = System.Drawing.Color.Gray
        Me.avd_debug_error.ForeColorOverLimit = System.Drawing.Color.Gray
        Me.avd_debug_error.ForeColorUnderLimit = System.Drawing.Color.Gray
        Me.avd_debug_error.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.avd_debug_error.KeypadMaxValue = 0R
        Me.avd_debug_error.KeypadMinValue = 0R
        Me.avd_debug_error.KeypadPasscode = Nothing
        Me.avd_debug_error.KeypadScaleFactor = 1.0R
        Me.avd_debug_error.KeypadText = Nothing
        Me.avd_debug_error.KeypadWidth = 300
        Me.avd_debug_error.Location = New System.Drawing.Point(261, -343)
        Me.avd_debug_error.Name = "avd_debug_error"
        Me.avd_debug_error.NumericFormat = "E5"
        Me.avd_debug_error.PLCAddressKeypad = ""
        Me.avd_debug_error.PLCAddressValue = Nothing
        Me.avd_debug_error.PLCAddressValueLimitLower = Nothing
        Me.avd_debug_error.PLCAddressValueLimitUpper = Nothing
        Me.avd_debug_error.PLCAddressVisible = Nothing
        Me.avd_debug_error.ShowValue = True
        Me.avd_debug_error.Size = New System.Drawing.Size(113, 18)
        Me.avd_debug_error.TabIndex = 56
        Me.avd_debug_error.Text = "9.99900E+003"
        Me.avd_debug_error.Value = "9999"
        Me.avd_debug_error.ValueLimitLower = -999999.0R
        Me.avd_debug_error.ValueLimitUpper = 999999.0R
        Me.avd_debug_error.ValuePrefix = Nothing
        Me.avd_debug_error.ValueSuffix = Nothing
        Me.avd_debug_error.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'lbl_debug_error
        '
        Me.lbl_debug_error.AutoSize = True
        Me.lbl_debug_error.ForeColor = System.Drawing.Color.Gray
        Me.lbl_debug_error.Location = New System.Drawing.Point(171, -341)
        Me.lbl_debug_error.Name = "lbl_debug_error"
        Me.lbl_debug_error.Size = New System.Drawing.Size(87, 18)
        Me.lbl_debug_error.TabIndex = 55
        Me.lbl_debug_error.Text = "Error, PSIG"
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(736, 389)
        Me.Controls.Add(Me.avd_debug_error)
        Me.Controls.Add(Me.lbl_debug_error)
        Me.Controls.Add(Me.avd_debug_dpdt_1)
        Me.Controls.Add(Me.avd_debug_dpdt_0)
        Me.Controls.Add(Me.lbl_debug_dpdt_1)
        Me.Controls.Add(Me.lbl_debug_dpdt_0)
        Me.Controls.Add(Me.chk_debug)
        Me.Controls.Add(Me.avd_debug_delta_psig)
        Me.Controls.Add(Me.lbl_debug_delta_psig)
        Me.Controls.Add(Me.lbl_debug_free_running_clock)
        Me.Controls.Add(Me.avd_debug_free_running_clock)
        Me.Controls.Add(Me.chk_pid_reverse)
        Me.Controls.Add(Me.chk_pid_auto)
        Me.Controls.Add(Me.avd_implicit_euler)
        Me.Controls.Add(Me.lbl_implicit_euler)
        Me.Controls.Add(Me.lbl_pid_rate)
        Me.Controls.Add(Me.avd_pid_rate)
        Me.Controls.Add(Me.lbl_pid_reset)
        Me.Controls.Add(Me.avd_pid_reset)
        Me.Controls.Add(Me.lbl_pid_gain)
        Me.Controls.Add(Me.avd_pid_gain)
        Me.Controls.Add(Me.lbl_pid_update_rate)
        Me.Controls.Add(Me.avd_pid_update_rate)
        Me.Controls.Add(Me.avd_fan_ramp)
        Me.Controls.Add(Me.lbl_fan_ramp)
        Me.Controls.Add(Me.avd_fan_speed)
        Me.Controls.Add(Me.lbl_fan_speed)
        Me.Controls.Add(Me.avd_pid_output)
        Me.Controls.Add(Me.lbl_pid_output)
        Me.Controls.Add(Me.avd_pid_pv)
        Me.Controls.Add(Me.lbl_pid_pv)
        Me.Controls.Add(Me.lbl_pid_setpoint)
        Me.Controls.Add(Me.avd_pid_setpoint)
        Me.Controls.Add(Me.lbl_pid)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_model_params)
        Me.Controls.Add(Me.lbl_psig_max)
        Me.Controls.Add(Me.avd_psig_max)
        Me.Controls.Add(Me.lbl_scfs_max)
        Me.Controls.Add(Me.avd_scfs_max)
        Me.Controls.Add(Me.lbl_leak_coeff)
        Me.Controls.Add(Me.avd_leak_coeff)
        Me.Controls.Add(Me.lbl_volume)
        Me.Controls.Add(Me.avd_volume)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforSLCMicroCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents EthernetIPforSLCMicroCom1 As AdvancedHMIDrivers.EthernetIPforSLCMicroCom
    Friend WithEvents avd_volume As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_volume As Label
    Friend WithEvents lbl_leak_coeff As Label
    Friend WithEvents avd_leak_coeff As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_scfs_max As Label
    Friend WithEvents avd_scfs_max As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_psig_max As Label
    Friend WithEvents avd_psig_max As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_model_params As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_pid As Label
    Friend WithEvents lbl_pid_setpoint As Label
    Friend WithEvents avd_pid_setpoint As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_pid_pv As Label
    Friend WithEvents avd_pid_pv As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents avd_pid_output As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_pid_output As Label
    Friend WithEvents avd_fan_speed As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_fan_speed As Label
    Friend WithEvents avd_fan_ramp As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_fan_ramp As Label
    Friend WithEvents lbl_pid_update_rate As Label
    Friend WithEvents avd_pid_update_rate As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_pid_gain As Label
    Friend WithEvents avd_pid_gain As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_pid_reset As Label
    Friend WithEvents avd_pid_reset As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_pid_rate As Label
    Friend WithEvents avd_pid_rate As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_implicit_euler As Label
    Friend WithEvents avd_implicit_euler As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents chk_pid_auto As AdvancedHMIControls.CheckBox
    Friend WithEvents chk_pid_reverse As AdvancedHMIControls.CheckBox
    Friend WithEvents avd_debug_free_running_clock As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_debug_free_running_clock As Label
    Friend WithEvents lbl_debug_delta_psig As Label
    Friend WithEvents avd_debug_delta_psig As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents chk_debug As CheckBox
    Friend WithEvents lbl_debug_dpdt_0 As Label
    Friend WithEvents lbl_debug_dpdt_1 As Label
    Friend WithEvents avd_debug_dpdt_0 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents avd_debug_dpdt_1 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents avd_debug_error As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents lbl_debug_error As Label
End Class
