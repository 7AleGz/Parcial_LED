Public Class FrmCalculation

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If Not IsNumeric(LongSize.Text) OrElse Not IsNumeric(WideSize.Text) Then
            MsgBox("Ingresa un valor válido")
            LongSize.Text = ""
            WideSize.Text = ""
            LongSize.Focus()
        Else
            Result.Text = CDec(LongSize.Text) * CDec(WideSize.Text)
        End If
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmMain.Show()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        LongSize.Text = ""
        WideSize.Text = ""
        Result.Text = ""
        LongSize.Focus()
    End Sub
End Class