Public Class FrmLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If user.Text = "izo" And psw.Text = "123" Then
            FrmMain.Show()
            Me.Close()

        Else
            MsgBox("Usuario o contraseña incorrecta")
            user.Text = ""
            psw.Text = ""
            user.Focus()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
