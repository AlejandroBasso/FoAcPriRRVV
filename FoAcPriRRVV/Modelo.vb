Imports System.Data.OleDb

Public Class Modelo

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ChkBen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBen.CheckedChanged
        If Me.ChkBen.Checked Then
            Me.PnlBeneficiario.Visible = True
        Else
            Me.PnlBeneficiario.Visible = False
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Modelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim strConexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FoAcPriRRVV\FoAcPriRRVV.accdb")
        'Dim strSQL As String = "Select * from TablaMort"
        'Adaptador de la base de datos con la aplicación
        'Dim adaptador As New OleDb.OleDbDataAdapter(strSQL, strConexion)

        'Dim ds As New DataSet
        'adaptador.Fill(dt)
        'adaptador.Dispose()
        'For Index As Integer = 0 To 99
        'vTabla(Index, 1, 1) = dt.Rows(intFila)("Qx")
        'Next
        Me.PnlBeneficiario.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim xEdadMeses As Integer, xMesIni As Integer, xEdad As Integer, xSexo As Integer, xSalud As Integer, xDummy As Integer
        Dim xIsCsv As Boolean, IsAfiliado As Boolean
        Dim nReserva As Double, nPension As Double
        Dim nF1x As Double, nF1y As Double, nF2x As Double, nF3xy As Double, nF4x As Double
        Dim nRenMedAnu As Double, nTasImpRent As Double


        Call CargaTabla()

        ' (Revisar) Se hace negativo los meses
        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacAfi.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacAfi.Text))
        xEdad = Int(xEdadMeses / 12)
        xMesIni = Int(xEdadMeses - xEdad * 12)
        nAnoCal = Year(TxtFecCal.Text)

        If RbtHombre.Checked Then
            xSexo = 1
        Else
            xSexo = 2
        End If
        If RbtNormal.Checked Then
            xSalud = 0
        Else
            If RbtInvTot.Checked Then
                xSalud = 1
            Else
                xSalud = 2
            End If
        End If

        nF1x = 0
        nF1y = 0
        nF2x = 0
        nF3xy = 0
        nF4x = 0


        xIsCsv = ChkCsv.Checked
        IsAfiliado = Not ChkBen.Checked

        Call F1(True, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtPerGar.Text, xIsCsv)
        nF1x = xF1x
        nF2x = xF2x
        nF4x = xF4x

        xEdadMeses = (12 * (Year(Me.TxtFecCal.Text) - Year(Me.TxtFecNacBen.Text))) + (Month(Me.TxtFecCal.Text) - Month(Me.TxtFecNacBen.Text))
        xEdad = Int(xEdadMeses / 12)
        xMesIni = Int(xEdadMeses - xEdad * 12)

        If RbtHomBen.Checked Then
            xSexo = 1
        Else
            xSexo = 2
        End If

        If RbtNorBen.Checked Then
            xSalud = 0
        Else
            If RbtTotBen.Checked Then
                xSalud = 1
            Else
                xSalud = 2
            End If
        End If

        If ChkBen.Checked Then
            Call F3(False, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtPerGar.Text, xIsCsv)
            nF1y = xF1x
            nF3xy = xF3x
        End If



        Me.TxtTabla.Text = vNomTabla(xSexo, xSalud)
        Me.TxtF1x.Text = Format(nF1x, "##########0.0000")
        Me.TxtF1y.Text = Format(nF1y, "##########0.0000")
        Me.TxtF2x.Text = Format(nF2x, "##########0.0000")
        Me.TxtF215.Text = Format(nF2x * 15, "##########0.0000")
        Me.TxtF3xy.Text = Format(nF3xy, "##########0.0000")
        Me.TxtF4x.Text = Format(nF4x, "##########0.0000")

        If RbtReserva.Checked Then
            nPension = 0
            nReserva = (((nF1x + (nF1y * 0.6)) + nF4x - (nF3xy * 0.6)) * Me.TxtRenta.Text) + (nF2x * CUOTAMORT)
        Else
            nReserva = 0
            nRenMedAnu = Me.TxtRenAnu.Text / 100
            nTasImpRent = Me.TxtTasImp.Text / 100
            Call Acumulacion(Me.TxtFecJub.Text, Me.TxtFecIngSis.Text, nTasImpRent, nRenMedAnu, Me.TxtRenMed.Text, Me.TxtMesDes.Text, Me.TxtComCuo.Text, Me.TxtComSal.Text, Me.TxtComInt.Text)
            Me.TxtValCI.Text = Format(xTotAcuEsp, "###,##0.00")

            nPension = (xTotAcuEsp - (nF2x * CUOTAMORT)) / ((nF1x + (nF1y * 0.6)) + nF4x - (nF3xy * 0.6))
        End If

        Me.TxtReserva.Text = Format(nReserva, "###,##0.00")
        Me.TxtPension.Text = Format(nPension, "###,##0.00")


    End Sub

  

End Class