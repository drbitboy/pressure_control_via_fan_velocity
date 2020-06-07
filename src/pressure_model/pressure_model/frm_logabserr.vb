Public Class frm_logabserr
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

    Public Sub addpoint(newval As Double)
        Dim ax As Double
        ax = Math.Abs(newval)
        If Me.Visible Then
            Dim ix As Integer
            If ax > 10 Then
                ix = 100
            ElseIf ax < 0.000000101 Then
                ix = -700
            Else
                ix = Math.Round(100 * Math.Log10(ax))
            End If
            tr_logabserr.Points.Add(ix)
        End If

    End Sub
End Class