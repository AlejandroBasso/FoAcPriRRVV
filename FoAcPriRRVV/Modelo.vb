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
        Dim nReserva As Double, nF1A As Double, nF2A As Double, nF1B As Double, nF3B As Double

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

        nF1B = 0
        nF3B = 0
        nF1A = 0
        nF2A = 0


        xIsCsv = ChkCsv.Checked
        IsAfiliado = Not ChkBen.Checked

        Call F1(True, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtPerGar.Text, xIsCsv)
        nF1A = xF1x
        nF2A = xF2x



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
            Call F2(False, xEdadMeses, xMesIni, xSexo, xSalud, Me.TxtPerDif.Text, Me.TxtPerGar.Text, xIsCsv)
            nF1B = xF1x
            nF3B = xF3x
        End If



        Me.TxtTabla.Text = vNomTabla(xSexo, xSalud)
        Me.TxtF1x.Text = Format(nF1A, "###########.0000")
        Me.TxtF2x.Text = Format(nF2A, "###########.0000")
        Me.TxtF215.Text = Format(nF2A * 15, "###########.0000")
        Me.TxtF1Benx.Text = Format(nF1B, "###########.0000")
        Me.TxtF1Benx60.Text = Format(nF1B * 0.6, "###########.0000")
        Me.TxtF3B.Text = Format(nF3B, "###########.0000")
        Me.TxtF3B60.Text = Format(nF3B * 0.6, "###########.0000")

        nReserva = ((nF1A + (nF1B * 0.6) - (nF3B * 0.6)) * Me.TxtRenta.Text) + (nF2A * 15)
        Me.TxtReserva.Text = Format(nReserva, "###,##0.00")



    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class