Public Class Formula4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub BntSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntSalir.Click
        Close()
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
        Me.TxtF4.Text = Format(xF4x, "###########.0000")

    End Sub
End Class