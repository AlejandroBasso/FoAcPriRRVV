
Public Class FoAcPriRRVV
    Public vTabla(100, 100, 100)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForm1.Click
        Formula1.Show()
    End Sub

    Private Sub BntSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BntSalir.Click
        Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModelo.Click
        Modelo.Show()
    End Sub


    Private Sub BtnForm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForm2.Click
        Formula2.Show()
    End Sub

    Private Sub BtnForm3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForm3.Click
        Formula3.Show()
    End Sub

    Private Sub BtnForm4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForm4.Click
        Formula4.Show()
    End Sub
End Class
