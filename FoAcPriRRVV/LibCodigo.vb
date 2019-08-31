Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Text

Module LibCodigo
    Public Const MAXVTD As Integer = 1333  ' 111 años * 12 Meses
    Public Const MAXTAB As Integer = 111   ' Largo Tabla de Mortalidad
    Public Const MAXMES As Integer = 11    ' De 0 a 11 Meses 
    Public Const LIMEDAD As Integer = 1094
    Public Const PATHAPP As String = "C:\FoAcPriRRVV\"
    Public Const ANOTABLA As Integer = 2014
    Public Const VALOR_LX As Integer = 1000000

    Public vTablaLx(MAXTAB, MAXTAB, MAXTAB)
    Public vTablaAax(MAXTAB, MAXTAB, MAXTAB)
    Public vVTD(1333)
    Public vVTD5(1333)
    Public vTabConm(MAXTAB, 6)
    Public vForTab(1094, 10) As Double
    Public vTabCal(1094, 12) As Double
    Public vTabCalAfi(1094) As Double
    Public vNomTabla(3, 3)

    Public file As System.IO.StreamWriter
    Public cData As String
    Public xF1x As Double, xF2x As Double, xF3x As Double
    Public nAnoCal As Integer



    ' =====================================================================================================
    Public Sub CargaTabla()

        Dim intFila As Integer = 0
        Dim Ix As Integer, Jx As Integer, Ex As Integer, xNomTab As String
        Dim xTasa As Double

        Dim strConexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FoAcPriRRVV\FoAcPriRRVV.accdb")
        Dim strSQL As String = "Select * from TablaMort Order By Periodo, IndexI, IndexJ, Edad"
        'Adaptador de la base de datos con la aplicación
        Dim dRecordSet As New OleDb.OleDbDataAdapter(strSQL, strConexion)
        Dim dt As New DataTable
        Dim ds As New DataSet

        dRecordSet.Fill(dt)
        dRecordSet.Dispose()

        Do While intFila < dt.Rows.Count
            Ix = dt.Rows(intFila)("IndexI")
            Jx = dt.Rows(intFila)("IndexJ")
            Ex = dt.Rows(intFila)("Edad")
            vTablaLx(Ix, Jx, Ex) = dt.Rows(intFila)("Qx")
            vTablaAax(Ix, Jx, Ex) = dt.Rows(intFila)("AAx")
            intFila = intFila + 1
        Loop

        'Dim file As System.IO.StreamWriter
        'Dim cData As String

        ' //// Carga VTD //////////////////////////
        strSQL = "Select * from TablaVTD"
        xTasa = 3 / 100
        vVTD(0) = 1
        vVTD5(0) = 1
        For i As Integer = 1 To MAXVTD
            If i = 1 Then
                vVTD(i) = 1 / (1 + ((1 + xTasa) ^ (1 / 12) - 1))
                vVTD5(i) = (1 / (1 + ((1 + xTasa) ^ (1 / 12) - 1))) ^ 0.5
            Else
                vVTD(i) = (1 / (1 + ((1 + xTasa) ^ (1 / 12) - 1))) * vVTD(i - 1)
                vVTD5(i) = (1 / (1 + ((1 + xTasa) ^ (1 / 12) - 1))) * vVTD5(i - 1)
            End If

        Next

        strSQL = "Select * from TablaNom Order By IndexI, IndexJ"
        dRecordSet = New OleDb.OleDbDataAdapter(strSQL, strConexion)
        dRecordSet.Fill(dt)
        dRecordSet.Dispose()
        intFila = 0

        Do While intFila < dt.Rows.Count
            Ix = dt.Rows(intFila)("IndexI")
            Jx = dt.Rows(intFila)("IndexJ")
            vNomTabla(Ix, Jx) = dt.Rows(intFila)("NombreTabla")
            intFila = intFila + 1
        Loop

        'file = My.Computer.FileSystem.OpenTextFileWriter(PATHAPP & "VTD_0_" & Format(Now(), "hms") & ".csv", True)
        'file.WriteLine("i;TT (1+Ij)^(-1);TT(1+Ij)^(-1+0,5)")

        'For i As Integer = 1 To MAXVTD
        'cData = i & ";" & vVTD(i) & ";" & vVTD5(i)
        'file.WriteLine(cData)
        'Next
        'file.Close()


    End Sub


    ' ====================================================================================================================================================
    Public Sub F1(ByVal IsAfiliado As Boolean, ByVal nEdadMeses As Integer, ByVal nMesIni As Integer, ByVal xSexo As Integer, ByVal xSalud As Integer, ByVal xDiferido As Integer, ByVal xGaratizado As Integer, ByVal IsImprime As Boolean)
        Dim xEdadA As Integer, xMesesA As Integer
        Dim Qx As Double, Lx As Double
        Dim tk As Integer
        Dim k As Integer
        Dim xLimEdad As Integer

        xF1x = 0
        xF2x = 0
        xF3x = 0

        'Try
        'Kill(PATHAPP & "*.csv")
        'Catch
        'MessageBox.Show("Archivos CSV están siendo utilizados.....")
        'End Try


        xLimEdad = 0
        Lx = 1000000

        xEdadA = Int(nEdadMeses / 12)
        xMesesA = nEdadMeses - xEdadA * 12
        tk = (nAnoCal - ANOTABLA) + 0

        ' Limpia Tabla
        Call LimpiaArrelgos(IsAfiliado)


        ' ===========================================================================
        ' =========     TABLA ANUAL DE PROBABILIDADES RECTIFICADA   =================
        ' ===========================================================================

        For i As Integer = xEdadA To MAXTAB
            vTabConm(i, 0) = i
            vTabConm(i, 1) = vTablaLx(xSexo, xSalud, i)  ' Qx
            vTabConm(i, 2) = vTablaAax(xSexo, xSalud, i) ' Axx 2
            vTabConm(i, 3) = vTabConm(i, 1) * (1 - vTabConm(i, 2)) ^ tk  ' Qxk 3
            vTabConm(i, 4) = 1 - vTabConm(i, 3)          ' px_k 4
            If i = xEdadA Then
                vTabConm(i, 5) = VALOR_LX
            Else
                vTabConm(i, 5) = vTabConm(i - 1, 5) * vTabConm(i - 1, 4) ' Lx 
            End If
            tk = tk + 1
        Next

        For i As Integer = xEdadA To MAXTAB
            If i < MAXTAB Then
                vTabConm(i, 6) = vTabConm(i, 5) - vTabConm(i + 1, 5) ' dx
            Else
                vTabConm(i, 6) = 1
            End If

        Next


        ' Columnas
        ' 0 = Indice 
        ' //////////////////////////////////////////////////////////////////////////////////////////////
        ' /////////////////     TABLA MENSUAL DE PROBABILIDADES RECTIFICADAS    ////////////////////////
        ' //////////////////////////////////////////////////////////////////////////////////////////////
        k = 0

        For i As Integer = xEdadA To MAXTAB
            Qx = vTabConm(i, 3) ' Qxk

            For j As Integer = nMesIni To MAXMES
                vForTab(k, 0) = k
                vForTab(k, 1) = Qx
                vForTab(k, 2) = ((Qx / 12) / (1 - j * Qx / 12)) 'qx_m
                vForTab(k, 3) = 1 - vForTab(k, 2)               'px_m
                If k = 0 Then
                    vForTab(k, 4) = VALOR_LX                     'lx
                Else
                    vForTab(k, 4) = vForTab(k - 1, 4) * vForTab(k - 1, 3) ' lx 4
                End If
                vForTab(k, 6) = vForTab(k, 4) / vForTab(0, 4)   'ipx 5
                vForTab(k, 7) = i
                vForTab(k, 8) = nEdadMeses + k
                vForTab(k, 9) = k
                k = k + 1
            Next
            nMesIni = 0
        Next

        xLimEdad = k

        For i As Integer = 0 To xLimEdad
            vForTab(i, 5) = vForTab(i, 4) - vForTab(i + 1, 4)  'dx
            vForTab(i, 7) = vForTab(i, 5) / vForTab(0, 4)      'iqx
        Next

        ' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        ' %%%%%%%%%%%%%%%%%%        TABLA DE GENERACIÓN CONMUTACIONAL       %%%%%%%%%%%%%%%%%%%%%%%%%%%%
        ' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        For i As Integer = 0 To xLimEdad
            vTabCal(i, 0) = i               ' 0 = Index
            vTabCal(i, 1) = vForTab(i, 4)   ' 1 = lx + i
            vTabCalAfi(i) = vForTab(i, 4)   ' lx+1
            vTabCal(i, 2) = vForTab(i, 5)   ' 2 = dx + i
            If i = 0 Then
                vTabCal(i, 3) = VALOR_LX     ' 3 =  TT(1+Ij)^(-1)
                vTabCal(i, 4) = VALOR_LX     ' 4 = lx+i * TT(1+Ij)^(-1)
            Else
                vTabCal(i, 3) = vVTD(i)     ' 3 =  TT(1+Ij)^(-1)
                vTabCal(i, 4) = vTabCal(i, 1) * vTabCal(i, 3) ' 4 = lx+i * TT(1+Ij)^(-1)
            End If
            vTabCal(i, 5) = vVTD5(i + 1)    ' 5 = TT(1+Ij)^(-1+0.5)
            vTabCal(i, 6) = vTabCal(i, 2) * vTabCal(i, 5) ' 6 = dx+i*TT(1+Ij)^(-1)
        Next


        For i As Integer = xLimEdad To 0 Step -1
            vTabCal(i, 7) = vTabCal(i, 4) + vTabCal(i + 1, 7)  ' 7 = Suma lx+i (VTD)
            vTabCal(i, 8) = vTabCal(i, 6) + vTabCal(i + 1, 8)  ' 8 = Suma dx+i (VTD)
        Next

        For i As Integer = 0 To xLimEdad
            vTabCal(i, 10) = vTabCal(i, 7) / vTabCal(0, 1)    ' 10 = F1x
            vTabCal(i, 11) = vTabCal(i, 8) / vTabCal(0, 1)    ' 11 = F2x
        Next
        xF1x = vTabCal(0 + xDiferido + xGaratizado, 10)
        xF2x = vTabCal(0 + xDiferido, 11)


        'If IsImprime Then
        'Call GeneraCSV_Afi(xSexo, xSalud, xEdadA, xLimEdad)
        'End If

    End Sub

    ' =========================================================================================================
    Public Sub F2(ByVal IsAfiliado As Boolean, ByVal nEdadMeses As Integer, ByVal nMesIni As Integer, ByVal xSexo As Integer, ByVal xSalud As Integer, ByVal xDiferido As Integer, ByVal xGaratizado As Integer, ByVal IsImprime As Boolean)
        Dim xEdadA As Integer, xMesesA As Integer
        Dim Qx As Double, Lx As Double, cF1 As Double, cF2 As Double, cF3 As Double
        Dim tk As Integer
        Dim k As Integer
        Dim xLimEdad As Integer

        xF1x = 0
        xF2x = 0
        xF3x = 0

        xLimEdad = 0
        Lx = 1000000
        xEdadA = Int(nEdadMeses / 12)
        xMesesA = nEdadMeses - xEdadA * 12
        tk = (nAnoCal - ANOTABLA) + 0
        'Erase vTabConm, vForTab, vTabCal
        ' Limpia Tabla
        Call LimpiaArrelgos(IsAfiliado)

        ' ===========================================================================
        ' =========     TABLA ANUAL DE PROBABILIDADES RECTIFICADA   =================
        ' ===========================================================================

        For i As Integer = xEdadA To MAXTAB
            vTabConm(i, 0) = i
            vTabConm(i, 1) = vTablaLx(xSexo, xSalud, i)  ' Qx1
            vTabConm(i, 2) = vTablaAax(xSexo, xSalud, i) ' Axx 2
            vTabConm(i, 3) = vTabConm(i, 1) * (1 - vTabConm(i, 2)) ^ tk  ' Qxk 3
            vTabConm(i, 4) = 1 - vTabConm(i, 3) ' px_k 4
            If i = xEdadA Then
                vTabConm(i, 5) = VALOR_LX
            Else
                vTabConm(i, 5) = vTabConm(i - 1, 5) * vTabConm(i - 1, 4) ' Lx 
            End If
            tk = tk + 1
        Next

        For i As Integer = xEdadA To MAXTAB ' 111
            If i < MAXTAB Then
                vTabConm(i, 6) = vTabConm(i, 5) - vTabConm(i + 1, 5) ' dx
            Else
                vTabConm(i, 6) = 1
            End If

        Next


        ' Columnas
        ' 0 = Indice 
        ' //////////////////////////////////////////////////////////////////////////////////////////////
        ' /////////////////     TABLA MENSUAL DE PROBABILIDADES RECTIFICADAS    ////////////////////////
        ' //////////////////////////////////////////////////////////////////////////////////////////////
        k = 0
        For i As Integer = xEdadA To MAXTAB
            Qx = vTabConm(i, 3) ' Qxk

            For j As Integer = nMesIni To MAXMES
                vForTab(k, 0) = j
                vForTab(k, 1) = Qx
                If i < MAXTAB Then
                    vForTab(k, 2) = ((Qx / 12) / (1 - j * Qx / 12)) 'qx_m
                    vForTab(k, 3) = 1 - vForTab(k, 2)               'px_m
                    If k = 0 Then
                        vForTab(k, 4) = VALOR_LX                     'ly
                    Else
                        vForTab(k, 4) = vForTab(k - 1, 4) * vForTab(k - 1, 3) '  4
                    End If
                    vForTab(k, 6) = vForTab(k, 4) / vForTab(0, 4)   'ipy 5
                Else
                    vForTab(k, 2) = 0
                    vForTab(k, 3) = 0
                    vForTab(k, 4) = 0
                    vForTab(k, 6) = 0
                End If

                vForTab(k, 7) = i
                vForTab(k, 8) = nEdadMeses + k
                vForTab(k, 9) = k
                k = k + 1
            Next
            nMesIni = 0
        Next

        cF1 = vForTab(k, 4)

        xLimEdad = k

        For i As Integer = 0 To xLimEdad
            If i <= MAXTAB Then
                vForTab(i, 5) = vForTab(i, 4) - vForTab(i + 1, 4)  'dy
                vForTab(i, 7) = vForTab(i, 5) / vForTab(0, 4)      'iqy
            Else
                vForTab(i, 5) = 0
                vForTab(i, 7) = 0
            End If
        Next

        ' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        ' %%%%%%%%%%%%%%%%%%        TABLA DE GENERACIÓN CONMUTACIONAL       %%%%%%%%%%%%%%%%%%%%%%%%%%%%
        ' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        ' Para Beneficiario
        For i As Integer = 0 To xLimEdad
            vTabCal(i, 0) = i               ' 0 = Index
            vTabCal(i, 1) = vForTab(i, 4)   ' 1 = ly+i
            vTabCal(i, 2) = vTabCalAfi(i)   ' 2 = dx+i
            If i = 0 Then
                vTabCal(i, 3) = 1    ' 3 = 
                vTabCal(i, 4) = VALOR_LX
            Else
                vTabCal(i, 3) = vVTD(i)     ' 3 = ∏(1+Ij)^(-1)
                vTabCal(i, 4) = vTabCal(i, 1) * vTabCal(i, 3) ' 4 = ly+i*∏(1+Ij)^(-1)
            End If
            vTabCal(i, 5) = vTabCal(i, 1) * vTabCal(i, 2)     'ly+i*lx+i
            vTabCal(i, 6) = vTabCal(i, 3) * vTabCal(i, 5)
        Next


        For i As Integer = xLimEdad To 0 Step -1
            vTabCal(i, 7) = vTabCal(i, 4) + vTabCal(i + 1, 7)
            vTabCal(i, 8) = vTabCal(i, 6) + vTabCal(i + 1, 8)
        Next

        For i As Integer = 0 To xLimEdad
            vTabCal(i, 10) = vTabCal(i, 7) / vTabCal(0, 1)
            vTabCal(i, 11) = vTabCal(i, 8) / (vTabCal(0, 1) * vTabCal(0, 2))
        Next

        xF1x = vTabCal(0 + xDiferido + xGaratizado, 10)
        xF2x = vTabCal(0 + xDiferido + xGaratizado, 10)
        xF3x = vTabCal(0 + xDiferido, 11)

        'If IsImprime Then
        Call GeneraCSV_Ben(xSexo, xSalud, xEdadA, xLimEdad)
        'End If




    End Sub

    ' ================================================================================================
    Public Sub GeneraCSV_Afi(ByVal ySexo As Integer, ByVal ySalud As Integer, ByVal yEdadA As Integer, ByVal yLimEdad As Integer)
        file = My.Computer.FileSystem.OpenTextFileWriter(PATHAPP & "vTabConmAfi_1_" & Format(Now(), "hms") & ".csv", True)
        file.WriteLine("Tabla;" & vNomTabla(ySexo, ySalud) & ";Sexo;" & ySexo & ";Salud;" & ySalud)
        file.WriteLine(" ")
        file.WriteLine("i; qx;Aax;qx+k;px+k;lx;dx ")
        For i As Integer = yEdadA To MAXTAB
            cData = ""
            For j As Integer = 0 To 6
                cData = cData & vTabConm(i, j) & ";"
            Next
            file.WriteLine(cData)
        Next
        file.Close()


        file = My.Computer.FileSystem.OpenTextFileWriter(PATHAPP & "vForTabAfi_2_" & Format(Now(), "hms") & ".csv", True)
        file.WriteLine("i; Tasa Anual Mort; Tasa Men de Mort; Tasa Men Sov;lx;dx;ipx;iqx;AñoBase;i")
        For i As Integer = 0 To yLimEdad
            cData = ""
            For j As Integer = 0 To 9
                cData = cData & vForTab(i, j) & ";"
            Next
            file.WriteLine(cData)
        Next
        file.Close()

        file = My.Computer.FileSystem.OpenTextFileWriter(PATHAPP & "vTabCalAfi_3_" & Format(Now(), "hms") & ".csv", True)
        file.WriteLine("i;lx+i;dx+i; TT(1+Ij)^(-1);lx+i*TT(1+Ij)^(-1);TT(1+Ij)^(-1+0.5);dx+i*TT(1+Ij)^(-1);Suma lx+i (VTD);Suma dx+i (VTD);Garantia;F1x;F2x;")
        For i As Integer = 0 To yLimEdad
            cData = ""
            For j As Integer = 0 To 11
                cData = cData & vTabCal(i, j) & ";"
            Next
            file.WriteLine(cData)
        Next
        file.Close()


    End Sub

    ' ==============================================================================================
    Public Sub LimpiaArrelgos(ByRef xIsAfiliado As Boolean)
        For i As Integer = 0 To MAXTAB
            For j As Integer = 0 To 6
                vTabConm(i, j) = 0
            Next
        Next
        For i As Integer = 0 To LIMEDAD
            For j As Integer = 0 To 12
                vTabCal(i, j) = 0
            Next
            For j As Integer = 0 To 10
                vForTab(i, j) = 0
            Next
        Next
        If xIsAfiliado Then
            For i As Integer = 0 To LIMEDAD
                vTabCalAfi(i) = 0
            Next
        End If

    End Sub

    Public Sub GeneraCSV_Ben(ByVal ySexo As Integer, ByVal ySalud As Integer, ByVal yEdadA As Integer, ByVal yLimEdad As Integer)
        file = My.Computer.FileSystem.OpenTextFileWriter(PATHAPP & "vTabConmBen_1_" & Format(Now(), "hms") & ".csv", True)
        file.WriteLine("Tabla;" & vNomTabla(ySexo, ySalud) & ";Sexo;" & ySexo & ";Salud;" & ySalud)
        file.WriteLine(" ")
        file.WriteLine("i; qx;Aax;qx+k;px+k;lx;dx ")
        For i As Integer = yEdadA To MAXTAB
            cData = ""
            For j As Integer = 0 To 6
                cData = cData & vTabConm(i, j) & ";"
            Next
            file.WriteLine(cData)
        Next
        file.Close()


        file = My.Computer.FileSystem.OpenTextFileWriter(PATHAPP & "vForTabBen_2_" & Format(Now(), "hms") & ".csv", True)
        file.WriteLine("i; Tasa Anual Mort; Tasa Men de Mort; Tasa Men Sov;lx;dx;ipx;iqx;AñoBase;i")
        For i As Integer = 0 To yLimEdad
            cData = ""
            For j As Integer = 0 To 8
                cData = cData & vForTab(i, j) & ";"
            Next
            file.WriteLine(cData)
        Next
        file.Close()

        file = My.Computer.FileSystem.OpenTextFileWriter(PATHAPP & "vTabCalBen_3_" & Format(Now(), "hms") & ".csv", True)
        file.WriteLine("i;lx+i;dx+i; TT(1+Ij)^(-1);lx+i*TT(1+Ij)^(-1);TT(1+Ij)^(-1+0.5);dx+i*TT(1+Ij)^(-1);Suma lx+i (VTD);Suma dx+i (VTD);Garantia;F1x;F2x;")
        For i As Integer = 0 To yLimEdad
            cData = ""
            For j As Integer = 0 To 11
                cData = cData & vTabCal(i, j) & ";"
            Next
            file.WriteLine(cData)
        Next
        file.Close()


    End Sub




    ' -------------------------------------------------------------------------------------------------
    Public Sub CalculoAfiliado(ByVal nEdadMeses As Integer, ByVal xSexo As Integer, ByVal xSalud As Integer, ByVal xDiferido As Integer, ByVal xGaratizado As Integer, ByVal IsImprime As Boolean)
        Dim xEdadA As Integer, xMesesA As Integer
        Dim Qx As Double, Lx As Double
        Dim tk As Integer
        Dim k As Integer
        Dim Dummy As Integer
        Dim xLimEdad As Integer
        Dim xLimTabla As Integer


        Try
            Kill(PATHAPP & "*.csv")
        Catch
            MessageBox.Show("Archivos CSV están siendo utilizados.....")
        End Try

        xLimEdad = 0


        Lx = 1000000
        xEdadA = Int(nEdadMeses / 12)
        xMesesA = nEdadMeses - xEdadA * 12
        tk = (2019 - 2014) + 0

        ' ===========================================================================
        ' ============================  Tabla 1 =====================================
        ' ===========================================================================
        For i As Integer = xEdadA To MAXTAB
            vTabConm(i, 0) = i
            vTabConm(i, 1) = vTablaLx(xSexo, xSalud, i)  ' Qx1
            vTabConm(i, 2) = vTablaAax(xSexo, xSalud, i) ' Axx 2
            vTabConm(i, 3) = vTabConm(i, 1) * (1 - vTabConm(i, 2)) ^ tk  ' Qxk 3
            vTabConm(i, 4) = 1 - vTabConm(i, 3) ' px_k 4
            If i = xEdadA Then
                vTabConm(i, 5) = Lx
            Else
                vTabConm(i, 5) = vTabConm(i - 1, 5) * vTabConm(i - 1, 4) ' Lx 
            End If
            tk = tk + 1
        Next

        For i As Integer = xEdadA To MAXTAB
            If i < 111 Then
                vTabConm(i, 6) = vTabConm(i, 5) - vTabConm(i + 1, 5) ' dx
            Else
                vTabConm(i, 6) = 1
            End If

        Next


        ' Columnas
        ' 0 = Indice 
        ' //////////////////////////////////////////////////////////////////////////////////////////////
        ' //////////////////////////////////////  Tabla 2 //////////////////////////////////////////////
        ' /////////////////////////////////////////////////////////////////////////////////////////////
        k = 0
        For i As Integer = xEdadA To MAXTAB
            Qx = vTabConm(i, 3) ' Qxk

            For j As Integer = 0 To 11
                vForTab(k, 0) = k
                vForTab(k, 1) = Qx
                vForTab(k, 2) = ((Qx / 12) / (1 - j * Qx / 12)) 'qx_m
                vForTab(k, 3) = 1 - vForTab(k, 2)               'px_m
                If xEdadA = i And j = 0 Then
                    vForTab(k, 4) = 1000000                     'lx
                Else
                    vForTab(k, 4) = vForTab(k - 1, 4) * vForTab(k - 1, 3) ' lx 4
                End If
                vForTab(k, 6) = vForTab(k, 4) / vForTab(0, 4)   'ipx 5
                vForTab(k, 7) = i
                vForTab(k, 8) = nEdadMeses + k
                k = k + 1
            Next
        Next

        xLimEdad = k - 1

        For i As Integer = 0 To xLimEdad
            vForTab(i, 5) = vForTab(i, 4) - vForTab(i + 1, 4)  'dx
            vForTab(i, 7) = vForTab(i, 5) / vForTab(0, 4)      'iqx
        Next


        ' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        ' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  Tabla 3 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        ' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        For i As Integer = 0 To xLimEdad
            vTabCal(i, 0) = i               ' 0 = Index
            vTabCal(i, 1) = vForTab(i, 4)   ' 1 = lx+i
            vTabCal(i, 2) = vForTab(i, 5)   ' 2 = dx+i
            If i = 0 Then
                vTabCal(i, 3) = 1000000        ' 3 = 
                vTabCal(i, 4) = 1000000
            Else
                vTabCal(i, 3) = vVTD(i)
                vTabCal(i, 4) = vTabCal(i, 1) * vTabCal(i, 3) ' 4 = 
            End If
            vTabCal(i, 5) = vVTD5(i + 1)
            vTabCal(i, 6) = vTabCal(i, 2) * vTabCal(i, 5)

        Next


        For i As Integer = xLimEdad To 0 Step -1
            vTabCal(i, 7) = vTabCal(i, 4) + vTabCal(i + 1, 7)
            vTabCal(i, 8) = vTabCal(i, 6) + vTabCal(i + 1, 8)
        Next

        For i As Integer = 0 To xLimEdad
            vTabCal(i, 10) = vTabCal(i, 7) / vTabCal(0, 1)
            vTabCal(i, 11) = vTabCal(i, 8) / vTabCal(0, 1)
        Next


        If IsImprime Then
            Call GeneraCSV_Afi(xSexo, xSalud, xEdadA, xLimEdad)

        End If

        xF1x = vTabCal(0 + xDiferido + xGaratizado, 10)
        xF2x = vTabCal(0 + xDiferido, 11)
        'xReserva = xF1x * Modelo.TxtRenta.Text + (xF2x * 15)

        'Modelo.TxtTabla.Text = vNomTabla(xSexo, xSalud)
        'Modelo.TxtF1x.Text = xF1x
        'Modelo.TxtF2x.Text = xF2x
        'Modelo.TxtReserva.Text = Format(xReserva, "###,##0.00")


    End Sub

End Module
