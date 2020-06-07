<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_logabserr
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Form overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tr_logabserr = New AdvancedHMIControls.BasicTrendChart()
        Me.SuspendLayout()
        '
        'tr_logabserr
        '
        Me.tr_logabserr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tr_logabserr.BackColor = System.Drawing.Color.Black
        Me.tr_logabserr.ComComponent = Nothing
        Me.tr_logabserr.Location = New System.Drawing.Point(0, 0)
        Me.tr_logabserr.MaxPoints = 1024
        Me.tr_logabserr.Name = "tr_logabserr"
        Me.tr_logabserr.PLCAddressValue = ""
        Me.tr_logabserr.PLCAddressVisible = ""
        Me.tr_logabserr.Size = New System.Drawing.Size(732, 360)
        Me.tr_logabserr.TabIndex = 3
        Me.tr_logabserr.Value = ""
        Me.tr_logabserr.YMaximum = 100
        Me.tr_logabserr.YMinimum = -700
        '
        'frm_logabserr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.tr_logabserr)
        Me.Name = "frm_logabserr"
        Me.Tag = "2"
        Me.Text = "100 x Log10(||Error||)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tr_logabserr As AdvancedHMIControls.BasicTrendChart
End Class
