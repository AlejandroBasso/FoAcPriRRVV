Public Class Formula2

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim xEdadMeses As Integer, xMesIni As Integer, xEdad As Integer, xSexo As Integer, xSalud As Integer
        Dim xIsCsv As Boolean, IsAfiliado As Boolean

        Call CargaTabla()

        xIsCsv = False
        IsAfiliado = True
        nAnoCal = Year(TxtFecCal.Text)

        ' F2x
        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacAfi.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacAfi.Text))
        xEdad = Int(xEdadMeses / 12)
        xMesIni = Int(xEdadMeses - xEdad * 12)
        xSexo = TxtSexo.Text
        xSalud = TxtSalud.Text

        Call F1(True, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtRenGar.Text, xIsCsv)
        TxtEdad.Text = xEdad
        TxtEdadMeses.Text = xEdadMeses
        Me.TxtTabla.Text = vNomTabla(xSexo, xSalud)
        Me.TxtF2x.Text = xF2x




    End Sub

    Private Sub BntSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntSalir.Click
        Close()
    End Sub
End Class