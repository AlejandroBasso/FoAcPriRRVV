<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modelo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.LblFecNacAfi = New System.Windows.Forms.Label
        Me.TxtFecNacAfi = New System.Windows.Forms.MaskedTextBox
        Me.RbtHombre = New System.Windows.Forms.RadioButton
        Me.RbtMujer = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RbtInvPar = New System.Windows.Forms.RadioButton
        Me.RbtInvTot = New System.Windows.Forms.RadioButton
        Me.RbtNormal = New System.Windows.Forms.RadioButton
        Me.PnlBeneficiario = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RbtParBen = New System.Windows.Forms.RadioButton
        Me.RbtTotBen = New System.Windows.Forms.RadioButton
        Me.RbtNorBen = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RbtMujBen = New System.Windows.Forms.RadioButton
        Me.RbtHomBen = New System.Windows.Forms.RadioButton
        Me.TxtFecNacBen = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkBen = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtFecCal = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.RbtFijo = New System.Windows.Forms.RadioButton
        Me.RbtPrueba = New System.Windows.Forms.RadioButton
        Me.RbtSvs = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPerDif = New System.Windows.Forms.TextBox
        Me.TxtPerGar = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.RbtRenta = New System.Windows.Forms.RadioButton
        Me.RbtReserva = New System.Windows.Forms.RadioButton
        Me.BtnCalcular = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtRenta = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtReserva = New System.Windows.Forms.TextBox
        Me.ChkCsv = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtF2x = New System.Windows.Forms.TextBox
        Me.TxtF1x = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtTabla = New System.Windows.Forms.TextBox
        Me.TxtF215 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtF1Benx = New System.Windows.Forms.TextBox
        Me.TxtF1Benx60 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtF3B = New System.Windows.Forms.TextBox
        Me.TxtF3B60 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PnlBeneficiario.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(829, 437)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 36)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LblFecNacAfi
        '
        Me.LblFecNacAfi.AutoSize = True
        Me.LblFecNacAfi.Location = New System.Drawing.Point(38, 19)
        Me.LblFecNacAfi.Name = "LblFecNacAfi"
        Me.LblFecNacAfi.Size = New System.Drawing.Size(130, 13)
        Me.LblFecNacAfi.TabIndex = 1
        Me.LblFecNacAfi.Text = "Fecha Nacimiento Afiliado"
        '
        'TxtFecNacAfi
        '
        Me.TxtFecNacAfi.Location = New System.Drawing.Point(222, 15)
        Me.TxtFecNacAfi.Mask = "00/00/0000"
        Me.TxtFecNacAfi.Name = "TxtFecNacAfi"
        Me.TxtFecNacAfi.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecNacAfi.TabIndex = 1
        Me.TxtFecNacAfi.Text = "29011952"
        Me.TxtFecNacAfi.ValidatingType = GetType(Date)
        '
        'RbtHombre
        '
        Me.RbtHombre.AutoSize = True
        Me.RbtHombre.Checked = True
        Me.RbtHombre.Location = New System.Drawing.Point(6, 18)
        Me.RbtHombre.Name = "RbtHombre"
        Me.RbtHombre.Size = New System.Drawing.Size(62, 17)
        Me.RbtHombre.TabIndex = 4
        Me.RbtHombre.TabStop = True
        Me.RbtHombre.Text = "Hombre"
        Me.RbtHombre.UseVisualStyleBackColor = True
        '
        'RbtMujer
        '
        Me.RbtMujer.AutoSize = True
        Me.RbtMujer.Location = New System.Drawing.Point(105, 18)
        Me.RbtMujer.Name = "RbtMujer"
        Me.RbtMujer.Size = New System.Drawing.Size(51, 17)
        Me.RbtMujer.TabIndex = 5
        Me.RbtMujer.Text = "Mujer"
        Me.RbtMujer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtHombre)
        Me.GroupBox1.Controls.Add(Me.RbtMujer)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 41)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbtInvPar)
        Me.GroupBox3.Controls.Add(Me.RbtInvTot)
        Me.GroupBox3.Controls.Add(Me.RbtNormal)
        Me.GroupBox3.Location = New System.Drawing.Point(297, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 39)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'RbtInvPar
        '
        Me.RbtInvPar.AutoSize = True
        Me.RbtInvPar.Location = New System.Drawing.Point(196, 16)
        Me.RbtInvPar.Name = "RbtInvPar"
        Me.RbtInvPar.Size = New System.Drawing.Size(97, 17)
        Me.RbtInvPar.TabIndex = 2
        Me.RbtInvPar.Text = "Inválido Parcial"
        Me.RbtInvPar.UseVisualStyleBackColor = True
        '
        'RbtInvTot
        '
        Me.RbtInvTot.AutoSize = True
        Me.RbtInvTot.Checked = True
        Me.RbtInvTot.Location = New System.Drawing.Point(95, 16)
        Me.RbtInvTot.Name = "RbtInvTot"
        Me.RbtInvTot.Size = New System.Drawing.Size(89, 17)
        Me.RbtInvTot.TabIndex = 1
        Me.RbtInvTot.TabStop = True
        Me.RbtInvTot.Text = "Inválido Total"
        Me.RbtInvTot.UseVisualStyleBackColor = True
        '
        'RbtNormal
        '
        Me.RbtNormal.AutoSize = True
        Me.RbtNormal.Location = New System.Drawing.Point(11, 16)
        Me.RbtNormal.Name = "RbtNormal"
        Me.RbtNormal.Size = New System.Drawing.Size(58, 17)
        Me.RbtNormal.TabIndex = 0
        Me.RbtNormal.Text = "Normal"
        Me.RbtNormal.UseVisualStyleBackColor = True
        '
        'PnlBeneficiario
        '
        Me.PnlBeneficiario.Controls.Add(Me.GroupBox4)
        Me.PnlBeneficiario.Controls.Add(Me.GroupBox2)
        Me.PnlBeneficiario.Controls.Add(Me.TxtFecNacBen)
        Me.PnlBeneficiario.Controls.Add(Me.Label1)
        Me.PnlBeneficiario.Location = New System.Drawing.Point(30, 111)
        Me.PnlBeneficiario.Name = "PnlBeneficiario"
        Me.PnlBeneficiario.Size = New System.Drawing.Size(600, 108)
        Me.PnlBeneficiario.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbtParBen)
        Me.GroupBox4.Controls.Add(Me.RbtTotBen)
        Me.GroupBox4.Controls.Add(Me.RbtNorBen)
        Me.GroupBox4.Location = New System.Drawing.Point(267, 49)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(297, 39)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'RbtParBen
        '
        Me.RbtParBen.AutoSize = True
        Me.RbtParBen.Location = New System.Drawing.Point(196, 16)
        Me.RbtParBen.Name = "RbtParBen"
        Me.RbtParBen.Size = New System.Drawing.Size(97, 17)
        Me.RbtParBen.TabIndex = 2
        Me.RbtParBen.Text = "Inválido Parcial"
        Me.RbtParBen.UseVisualStyleBackColor = True
        '
        'RbtTotBen
        '
        Me.RbtTotBen.AutoSize = True
        Me.RbtTotBen.Checked = True
        Me.RbtTotBen.Location = New System.Drawing.Point(93, 16)
        Me.RbtTotBen.Name = "RbtTotBen"
        Me.RbtTotBen.Size = New System.Drawing.Size(89, 17)
        Me.RbtTotBen.TabIndex = 1
        Me.RbtTotBen.TabStop = True
        Me.RbtTotBen.Text = "Inválido Total"
        Me.RbtTotBen.UseVisualStyleBackColor = True
        '
        'RbtNorBen
        '
        Me.RbtNorBen.AutoSize = True
        Me.RbtNorBen.Location = New System.Drawing.Point(6, 16)
        Me.RbtNorBen.Name = "RbtNorBen"
        Me.RbtNorBen.Size = New System.Drawing.Size(58, 17)
        Me.RbtNorBen.TabIndex = 0
        Me.RbtNorBen.Text = "Normal"
        Me.RbtNorBen.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbtMujBen)
        Me.GroupBox2.Controls.Add(Me.RbtHomBen)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(15, 46)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 42)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'RbtMujBen
        '
        Me.RbtMujBen.AutoSize = True
        Me.RbtMujBen.Checked = True
        Me.RbtMujBen.Location = New System.Drawing.Point(105, 16)
        Me.RbtMujBen.Name = "RbtMujBen"
        Me.RbtMujBen.Size = New System.Drawing.Size(51, 17)
        Me.RbtMujBen.TabIndex = 1
        Me.RbtMujBen.TabStop = True
        Me.RbtMujBen.Text = "Mujer"
        Me.RbtMujBen.UseVisualStyleBackColor = True
        '
        'RbtHomBen
        '
        Me.RbtHomBen.AutoSize = True
        Me.RbtHomBen.Location = New System.Drawing.Point(11, 14)
        Me.RbtHomBen.Name = "RbtHomBen"
        Me.RbtHomBen.Size = New System.Drawing.Size(62, 17)
        Me.RbtHomBen.TabIndex = 0
        Me.RbtHomBen.Text = "Hombre"
        Me.RbtHomBen.UseVisualStyleBackColor = True
        '
        'TxtFecNacBen
        '
        Me.TxtFecNacBen.Location = New System.Drawing.Point(182, 22)
        Me.TxtFecNacBen.Mask = "00/00/0000"
        Me.TxtFecNacBen.Name = "TxtFecNacBen"
        Me.TxtFecNacBen.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecNacBen.TabIndex = 11
        Me.TxtFecNacBen.Text = "25111957"
        Me.TxtFecNacBen.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha Nacimiento Beneficiario"
        '
        'ChkBen
        '
        Me.ChkBen.AutoSize = True
        Me.ChkBen.Checked = True
        Me.ChkBen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBen.Location = New System.Drawing.Point(41, 88)
        Me.ChkBen.Name = "ChkBen"
        Me.ChkBen.Size = New System.Drawing.Size(112, 17)
        Me.ChkBen.TabIndex = 11
        Me.ChkBen.Text = "Existe Beneficiario"
        Me.ChkBen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha Cálculo"
        '
        'TxtFecCal
        '
        Me.TxtFecCal.Location = New System.Drawing.Point(202, 222)
        Me.TxtFecCal.Mask = "00/00/0000"
        Me.TxtFecCal.Name = "TxtFecCal"
        Me.TxtFecCal.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecCal.TabIndex = 14
        Me.TxtFecCal.Text = "01012019"
        Me.TxtFecCal.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Calculo con VDT"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RbtFijo)
        Me.GroupBox5.Controls.Add(Me.RbtPrueba)
        Me.GroupBox5.Controls.Add(Me.RbtSvs)
        Me.GroupBox5.Location = New System.Drawing.Point(202, 248)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(186, 36)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        '
        'RbtFijo
        '
        Me.RbtFijo.AllowDrop = True
        Me.RbtFijo.AutoSize = True
        Me.RbtFijo.Checked = True
        Me.RbtFijo.Location = New System.Drawing.Point(11, 16)
        Me.RbtFijo.Name = "RbtFijo"
        Me.RbtFijo.Size = New System.Drawing.Size(41, 17)
        Me.RbtFijo.TabIndex = 2
        Me.RbtFijo.TabStop = True
        Me.RbtFijo.Text = "Fijo"
        Me.RbtFijo.UseVisualStyleBackColor = True
        '
        'RbtPrueba
        '
        Me.RbtPrueba.AutoSize = True
        Me.RbtPrueba.Location = New System.Drawing.Point(63, 16)
        Me.RbtPrueba.Name = "RbtPrueba"
        Me.RbtPrueba.Size = New System.Drawing.Size(59, 17)
        Me.RbtPrueba.TabIndex = 1
        Me.RbtPrueba.Text = "Prueba"
        Me.RbtPrueba.UseVisualStyleBackColor = True
        '
        'RbtSvs
        '
        Me.RbtSvs.AutoSize = True
        Me.RbtSvs.Location = New System.Drawing.Point(11, 16)
        Me.RbtSvs.Name = "RbtSvs"
        Me.RbtSvs.Size = New System.Drawing.Size(46, 17)
        Me.RbtSvs.TabIndex = 0
        Me.RbtSvs.Text = "SVS"
        Me.RbtSvs.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Detalles de la Renta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Periodo Diferido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Periodo Garantizado"
        '
        'TxtPerDif
        '
        Me.TxtPerDif.Location = New System.Drawing.Point(212, 326)
        Me.TxtPerDif.MaxLength = 3
        Me.TxtPerDif.Name = "TxtPerDif"
        Me.TxtPerDif.Size = New System.Drawing.Size(61, 20)
        Me.TxtPerDif.TabIndex = 20
        Me.TxtPerDif.Text = "0"
        Me.TxtPerDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPerGar
        '
        Me.TxtPerGar.Location = New System.Drawing.Point(212, 353)
        Me.TxtPerGar.MaxLength = 3
        Me.TxtPerGar.Name = "TxtPerGar"
        Me.TxtPerGar.Size = New System.Drawing.Size(61, 20)
        Me.TxtPerGar.TabIndex = 21
        Me.TxtPerGar.Text = "0"
        Me.TxtPerGar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RbtRenta)
        Me.GroupBox6.Controls.Add(Me.RbtReserva)
        Me.GroupBox6.Location = New System.Drawing.Point(41, 379)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(205, 31)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        '
        'RbtRenta
        '
        Me.RbtRenta.AutoSize = True
        Me.RbtRenta.Location = New System.Drawing.Point(101, 9)
        Me.RbtRenta.Name = "RbtRenta"
        Me.RbtRenta.Size = New System.Drawing.Size(54, 17)
        Me.RbtRenta.TabIndex = 1
        Me.RbtRenta.Text = "Renta"
        Me.RbtRenta.UseVisualStyleBackColor = True
        '
        'RbtReserva
        '
        Me.RbtReserva.AutoSize = True
        Me.RbtReserva.Checked = True
        Me.RbtReserva.Location = New System.Drawing.Point(6, 9)
        Me.RbtReserva.Name = "RbtReserva"
        Me.RbtReserva.Size = New System.Drawing.Size(65, 17)
        Me.RbtReserva.TabIndex = 0
        Me.RbtReserva.TabStop = True
        Me.RbtReserva.Text = "Reserva"
        Me.RbtReserva.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(685, 437)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(127, 36)
        Me.BtnCalcular.TabIndex = 23
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(45, 430)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(166, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Valor Renta de referencia en UF="
        '
        'TxtRenta
        '
        Me.TxtRenta.Location = New System.Drawing.Point(222, 428)
        Me.TxtRenta.Name = "TxtRenta"
        Me.TxtRenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtRenta.TabIndex = 42
        Me.TxtRenta.Text = "10"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(417, 425)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 18)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Reserva"
        '
        'TxtReserva
        '
        Me.TxtReserva.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtReserva.Location = New System.Drawing.Point(507, 423)
        Me.TxtReserva.Name = "TxtReserva"
        Me.TxtReserva.Size = New System.Drawing.Size(129, 20)
        Me.TxtReserva.TabIndex = 44
        '
        'ChkCsv
        '
        Me.ChkCsv.AutoSize = True
        Me.ChkCsv.Checked = True
        Me.ChkCsv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCsv.Location = New System.Drawing.Point(297, 88)
        Me.ChkCsv.Name = "ChkCsv"
        Me.ChkCsv.Size = New System.Drawing.Size(129, 17)
        Me.ChkCsv.TabIndex = 45
        Me.ChkCsv.Text = "Genera Archivos CVS"
        Me.ChkCsv.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(417, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 18)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "F1x"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(417, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 18)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "F2x"
        '
        'TxtF2x
        '
        Me.TxtF2x.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtF2x.Location = New System.Drawing.Point(636, 292)
        Me.TxtF2x.Name = "TxtF2x"
        Me.TxtF2x.Size = New System.Drawing.Size(129, 20)
        Me.TxtF2x.TabIndex = 48
        '
        'TxtF1x
        '
        Me.TxtF1x.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtF1x.Location = New System.Drawing.Point(501, 264)
        Me.TxtF1x.Name = "TxtF1x"
        Me.TxtF1x.Size = New System.Drawing.Size(129, 20)
        Me.TxtF1x.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(417, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Tabla"
        '
        'TxtTabla
        '
        Me.TxtTabla.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtTabla.Location = New System.Drawing.Point(501, 236)
        Me.TxtTabla.Name = "TxtTabla"
        Me.TxtTabla.Size = New System.Drawing.Size(129, 20)
        Me.TxtTabla.TabIndex = 51
        '
        'TxtF215
        '
        Me.TxtF215.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtF215.Location = New System.Drawing.Point(501, 295)
        Me.TxtF215.Name = "TxtF215"
        Me.TxtF215.Size = New System.Drawing.Size(129, 20)
        Me.TxtF215.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(417, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "F1Ben"
        '
        'TxtF1Benx
        '
        Me.TxtF1Benx.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtF1Benx.Location = New System.Drawing.Point(636, 329)
        Me.TxtF1Benx.Name = "TxtF1Benx"
        Me.TxtF1Benx.Size = New System.Drawing.Size(129, 20)
        Me.TxtF1Benx.TabIndex = 54
        '
        'TxtF1Benx60
        '
        Me.TxtF1Benx60.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtF1Benx60.Location = New System.Drawing.Point(501, 329)
        Me.TxtF1Benx60.Name = "TxtF1Benx60"
        Me.TxtF1Benx60.Size = New System.Drawing.Size(129, 20)
        Me.TxtF1Benx60.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(418, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 18)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "F3Ben"
        '
        'TxtF3B
        '
        Me.TxtF3B.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtF3B.Location = New System.Drawing.Point(636, 356)
        Me.TxtF3B.Name = "TxtF3B"
        Me.TxtF3B.Size = New System.Drawing.Size(129, 20)
        Me.TxtF3B.TabIndex = 57
        '
        'TxtF3B60
        '
        Me.TxtF3B60.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TxtF3B60.Location = New System.Drawing.Point(501, 355)
        Me.TxtF3B60.Name = "TxtF3B60"
        Me.TxtF3B60.Size = New System.Drawing.Size(129, 20)
        Me.TxtF3B60.TabIndex = 58
        '
        'Modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 494)
        Me.Controls.Add(Me.TxtF3B60)
        Me.Controls.Add(Me.TxtF3B)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtF1Benx60)
        Me.Controls.Add(Me.TxtF1Benx)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtF215)
        Me.Controls.Add(Me.TxtTabla)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtF1x)
        Me.Controls.Add(Me.TxtF2x)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ChkCsv)
        Me.Controls.Add(Me.TxtReserva)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtRenta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.TxtPerGar)
        Me.Controls.Add(Me.TxtPerDif)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtFecCal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkBen)
        Me.Controls.Add(Me.PnlBeneficiario)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtFecNacAfi)
        Me.Controls.Add(Me.LblFecNacAfi)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "Modelo"
        Me.Text = "Modelo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PnlBeneficiario.ResumeLayout(False)
        Me.PnlBeneficiario.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LblFecNacAfi As System.Windows.Forms.Label
    Friend WithEvents TxtFecNacAfi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RbtHombre As System.Windows.Forms.RadioButton
    Friend WithEvents RbtMujer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtInvPar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtInvTot As System.Windows.Forms.RadioButton
    Friend WithEvents RbtNormal As System.Windows.Forms.RadioButton
    Friend WithEvents PnlBeneficiario As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtParBen As System.Windows.Forms.RadioButton
    Friend WithEvents RbtTotBen As System.Windows.Forms.RadioButton
    Friend WithEvents RbtNorBen As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtMujBen As System.Windows.Forms.RadioButton
    Friend WithEvents RbtHomBen As System.Windows.Forms.RadioButton
    Friend WithEvents TxtFecNacBen As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkBen As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtFecCal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtFijo As System.Windows.Forms.RadioButton
    Friend WithEvents RbtPrueba As System.Windows.Forms.RadioButton
    Friend WithEvents RbtSvs As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPerDif As System.Windows.Forms.TextBox
    Friend WithEvents TxtPerGar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtRenta As System.Windows.Forms.RadioButton
    Friend WithEvents RbtReserva As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtRenta As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtReserva As System.Windows.Forms.TextBox
    Friend WithEvents ChkCsv As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtF2x As System.Windows.Forms.TextBox
    Friend WithEvents TxtF1x As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTabla As System.Windows.Forms.TextBox
    Friend WithEvents TxtF215 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtF1Benx As System.Windows.Forms.TextBox
    Friend WithEvents TxtF1Benx60 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtF3B As System.Windows.Forms.TextBox
    Friend WithEvents TxtF3B60 As System.Windows.Forms.TextBox
End Class
