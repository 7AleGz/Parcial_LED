Public Class FrmMain
    Private Sub BtnCalculo_Click(sender As Object, e As EventArgs) Handles BtnM2.Click
        FrmCalculation.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCasa_Click(sender As Object, e As EventArgs) Handles BtnExchange.Click
        ModalUSDValue.Show()
        Me.Hide()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class