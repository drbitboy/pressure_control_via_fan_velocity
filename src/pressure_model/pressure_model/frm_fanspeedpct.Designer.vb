<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_fanspeedpct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tr_fanspeedpct = New AdvancedHMIControls.BasicTrendChart()
        Me.SuspendLayout()
        '
        'tr_fanspeedpct
        '
        Me.tr_fanspeedpct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tr_fanspeedpct.BackColor = System.Drawing.Color.Black
        Me.tr_fanspeedpct.Location = New System.Drawing.Point(0, 0)
        Me.tr_fanspeedpct.MaxPoints = 1024
        Me.tr_fanspeedpct.Name = "tr_fanspeedpct"
        Me.tr_fanspeedpct.PLCAddressValue = ""
        Me.tr_fanspeedpct.PLCAddressVisible = ""
        Me.tr_fanspeedpct.Size = New System.Drawing.Size(732, 360)
        Me.tr_fanspeedpct.TabIndex = 0
        Me.tr_fanspeedpct.Value = ""
        Me.tr_fanspeedpct.YMaximum = 100
        Me.tr_fanspeedpct.YMinimum = 0
        '
        'frm_fanspeedpct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.tr_fanspeedpct)
        Me.Name = "frm_fanspeedpct"
        Me.Text = "Fan speed, %"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tr_fanspeedpct As AdvancedHMIControls.BasicTrendChart
End Class
