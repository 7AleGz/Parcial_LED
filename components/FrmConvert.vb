Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmConvert
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmMain.Show()
    End Sub

    Dim USDValue As String = ModalUSDValue.USDValue
    Dim cantidadCompraUSD As Double
    Dim cantidadCompraARS As Double

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        If Double.TryParse(USDCant.Text, cantidadCompraUSD) Then
            Dim dateNow As DateTime = DateTime.Now
            Dim formatDate As String = dateNow.ToString("dd/MM/yyyy")
            Dim formatHour As String = dateNow.ToString("HH:mm:ss")
            Dim resultado As Double = USDValue * cantidadCompraUSD
            Dim arsPrice As Double = Math.Round(resultado, 2)
            ARSCant.Text = arsPrice.ToString()
            My.Computer.FileSystem.WriteAllText("..\..\data\history.txt",
            formatDate & " " & formatHour & " ARS $" & resultado & vbCrLf, True)
        ElseIf Double.TryParse(ARSCant.Text, cantidadCompraARS) Then
            Dim dateNow As DateTime = DateTime.Now
            Dim formatDate As String = dateNow.ToString("dd/MM/yyyy")
            Dim formatHour As String = dateNow.ToString("HH:mm:ss")
            Dim resultado As Double = cantidadCompraARS / USDValue
            Dim usdPrice As Double = Math.Round(resultado, 2)
            USDCant.Text = usdPrice.ToString()
            My.Computer.FileSystem.WriteAllText("..\..\data\history.txt",
            formatDate & " " & formatHour & " USD $" & resultado & vbCrLf, True)
        Else
            MessageBox.Show("Por favor, ingresa una cantidad válida para comprar.")
            USDCant.Text = ""
            ARSCant.Text = ""
            USDCant.Focus()
        End If
    End Sub

    Private Sub FormConvert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelValue.Text = "$" + ModalUSDValue.USDValue.ToString()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ARSCant.Text = ""
        USDCant.Text = ""
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        MsgBox(My.Computer.FileSystem.ReadAllText("..\..\data\history.txt"))
    End Sub

    'Private Sub USDCant_TextChanged(sender As Object, e As EventArgs) Handles USDCant.TextChanged
    'ARSCant.ReadOnly = True
    'End Sub

End Class
