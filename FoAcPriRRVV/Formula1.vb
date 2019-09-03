Public Class Formula1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntSalir.Click
        Close()
    End Sub

    Private Sub Formula1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaTabla()
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim xEdadMeses As Integer, xMesIni As Integer, xEdad As Integer, xSexo As Integer, xSalud As Integer, xDummy As Integer
        Dim xIsCsv As Boolean, IsAfiliado As Boolean

        Call CargaTabla()

        ' (Revisar) Se hace negativo los meses
        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacAfi.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacAfi.Text))
        xEdad = Int(xEdadMeses / 12)
        xMesIni = Int(xEdadMeses - xEdad * 12)
        nAnoCal = Year(TxtFecCal.Text)

        xSexo = TxtSexo.Text
        xSalud = TxtSalud.Text
        xIsCsv = False
        IsAfiliado = True

        Call F1(True, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtRenGar.Text, xIsCsv)

        TxtEdad.Text = xEdad
        TxtEdadMeses.Text = xEdadMeses
        Me.TxtTabla.Text = vNomTabla(xSexo, xSalud)
        Me.TxtF1.Text = Format(xF1x, "###########.0000")



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xSalud As Integer, xSexo As Integer, xDif As Integer, xGar As Integer, xN As Integer
        Dim xEdadMeses As Integer, xEdad As Integer, xDummy As Integer
        Dim xF1 As Double, xSum As Double, xPitatoria As Double
        Dim xQy As Double, xAay As Double, xqy_k As Double, xpy_k As Double, xly As Double, xdy As Double
        Dim xtk As Integer
        Dim xPaso As Double

        xSexo = TxtSexo.Text
        xSalud = TxtSalud.Text

        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacAfi.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacAfi.Text))
        xEdad = Int(xEdadMeses / 12)

        xDif = TxtPerDif.Text
        xGar = TxtRenGar.Text
        xN = 110 - xEdad
        xPitatoria = 0
        xSum = 0

        ' xDummy = MessageBox.Show("Ver valor de Dif : " & xDif)

        xtk = (2019 - 2014) + 0
        xQy = vTablaLx(xSexo, xSalud, xEdad)
        xAay = vTablaAax(xSexo, xSalud, xEdad)
        xqy_k = xQy * (1 - xAay) ^ xtk
        xpy_k = 1 - xqy_k

        LabQy.Text = xQy
        LabAay.Text = xAay
        Labqy_k.Text = xqy_k
        Labpy_k.Text = xpy_k
        Lably.Text = xly
        Labdy.Text = xdy



        For i As Integer = xDif + xGar To xN
            xPitatoria = 1
            For k As Integer = 0 To i
                xPaso = vVTD(k)
                xPitatoria = xPitatoria * (1 / (1 + vVTD(k)))
            Next
            xSum = xSum + vTablaLx(xSexo, xSalud, xEdad + i) * xPitatoria
        Next

        xF1 = (1 / vTablaLx(xSexo, xSalud, xEdad)) * xSum

        TxtEdadMeses.Text = xEdadMeses
        TxtTabla.Text = vNomTabla(xSexo, xSalud)
        TxtEdad.Text = xEdad
        TxtF1.Text = xF1



    End Sub
End Class