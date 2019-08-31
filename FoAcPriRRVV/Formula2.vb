Public Class Formula2

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim xEdadMeses As Integer, xMesIni As Integer, xEdad As Integer, xSexo As Integer, xSalud As Integer, xDummy As Integer
        Dim xIsCsv As Boolean, IsAfiliado As Boolean
        Dim nF1y As Double, nF2x As Double, nF2xy As Double, nF1x As Double, nF2B As Double


        Call CargaTabla()

        xIsCsv = False
        IsAfiliado = True
        nF1y = 0
        nF1x = 0
        nF2x = 0
        nF2xy = 0
        nAnoCal = Year(TxtFecCal.Text)

        ' F1y
        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacBen.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacAfi.Text))
        xEdad = Int(xEdadMeses / 12)
        xMesIni = Int(xEdadMeses - xEdad * 12)
        xSexo = TxtSexCon.Text
        xSalud = TxtSalCon.Text

        Call F1(False, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtRenGar.Text, xIsCsv)
        nF1y = xF1x
        nF2B = xF2x


        ' F1x
        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacAfi.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacAfi.Text))
        xEdad = Int(xEdadMeses / 12)
        xMesIni = Int(xEdadMeses - xEdad * 12)
        xSexo = TxtSexo.Text
        xSalud = TxtSalud.Text

        Call F1(True, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtRenGar.Text, xIsCsv)
        nF1x = xF1x

        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacBen.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacBen.Text))
        xEdad = Int(xEdadMeses / 12)
        xMesIni = Int(xEdadMeses - xEdad * 12)
        xSexo = TxtSexCon.Text
        xSalud = TxtSalCon.Text

        ' F1x F2y
        Call F2(False, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtRenGar.Text, xIsCsv)
        nF2xy = xF2x


        TxtEdad.Text = xEdad
        TxtEdadMeses.Text = xEdadMeses
        Me.TxtTabla.Text = vNomTabla(xSexo, xSalud)
        Me.TxtF1y.Text = nF1y
        Me.TxtF2xy.Text = nF2xy
        Me.Txt60F1xF2xy.Text = 0.6 * (nF1y - nF2xy)



    End Sub

    Private Sub BntSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntSalir.Click
        Close()
    End Sub
End Class