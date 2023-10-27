Public Class ModalUSDValue

    Public Shared Property USDValue As Decimal
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click

        If Not IsNumeric(Price.Text) Then
            Price.Text = ""
            Price.Focus()
            MsgBox("Ingresa un valor válido")
        Else
            USDValue = Price.Text
            FrmConvert.Show()
            Me.Close()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmMain.Show()
    End Sub
End Class