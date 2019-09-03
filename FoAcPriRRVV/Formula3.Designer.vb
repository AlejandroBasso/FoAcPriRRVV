<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formula3
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
        Me.TxtF3xy = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtSalCon = New System.Windows.Forms.TextBox
        Me.TxtSexCon = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtFecNacBen = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Labdy = New System.Windows.Forms.Label
        Me.Lably = New System.Windows.Forms.Label
        Me.Labpy_k = New System.Windows.Forms.Label
        Me.Labqy_k = New System.Windows.Forms.Label
        Me.LabAay = New System.Windows.Forms.Label
        Me.LabQy = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtEdadMeses = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtTabla = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtFecCal = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtFecNacAfi = New System.Windows.Forms.MaskedTextBox
        Me.LblFecNacAfi = New System.Windows.Forms.Label
        Me.TxtSalud = New System.Windows.Forms.TextBox
        Me.TxtSexo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnCalcular = New System.Windows.Forms.Button
        Me.TxtRenGar = New System.Windows.Forms.TextBox
        Me.TxtPerDif = New System.Windows.Forms.TextBox
        Me.TxtEdad = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BntSalir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtF3xy
        '
        Me.TxtF3xy.BackColor = System.Drawing.Color.Azure
        Me.TxtF3xy.Location = New System.Drawing.Point(401, 398)
        Me.TxtF3xy.Name = "TxtF3xy"
        Me.TxtF3xy.Size = New System.Drawing.Size(132, 20)
        Me.TxtF3xy.TabIndex = 125
        Me.TxtF3xy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 391)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 18)
        Me.Label20.TabIndex = 124
        Me.Label20.Text = "Formula 3"
        '
        'TxtSalCon
        '
        Me.TxtSalCon.Location = New System.Drawing.Point(401, 160)
        Me.TxtSalCon.Name = "TxtSalCon"
        Me.TxtSalCon.Size = New System.Drawing.Size(52, 20)
        Me.TxtSalCon.TabIndex = 121
        Me.TxtSalCon.Text = "1"
        Me.TxtSalCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSexCon
        '
        Me.TxtSexCon.Location = New System.Drawing.Point(401, 134)
        Me.TxtSexCon.Name = "TxtSexCon"
        Me.TxtSexCon.Size = New System.Drawing.Size(52, 20)
        Me.TxtSexCon.TabIndex = 120
        Me.TxtSexCon.Text = "2"
        Me.TxtSexCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(189, 18)
        Me.Label18.TabIndex = 119
        Me.Label18.Text = "Salud (0=Normal, 1= Inválido)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(215, 18)
        Me.Label17.TabIndex = 118
        Me.Label17.Text = "Sexo (1=Masculino, 2= Famenino)"
        '
        'TxtFecNacBen
        '
        Me.TxtFecNacBen.Location = New System.Drawing.Point(401, 108)
        Me.TxtFecNacBen.Mask = "00/00/0000"
        Me.TxtFecNacBen.Name = "TxtFecNacBen"
        Me.TxtFecNacBen.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecNacBen.TabIndex = 117
        Me.TxtFecNacBen.Text = "25111957"
        Me.TxtFecNacBen.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 18)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Fecha Nacimiento Conyuge"
        '
        'Labdy
        '
        Me.Labdy.AutoSize = True
        Me.Labdy.Location = New System.Drawing.Point(658, 153)
        Me.Labdy.Name = "Labdy"
        Me.Labdy.Size = New System.Drawing.Size(18, 13)
        Me.Labdy.TabIndex = 115
        Me.Labdy.Text = "dy"
        '
        'Lably
        '
        Me.Lably.AutoSize = True
        Me.Lably.Location = New System.Drawing.Point(658, 128)
        Me.Lably.Name = "Lably"
        Me.Lably.Size = New System.Drawing.Size(14, 13)
        Me.Lably.TabIndex = 114
        Me.Lably.Text = "ly"
        '
        'Labpy_k
        '
        Me.Labpy_k.AutoSize = True
        Me.Labpy_k.Location = New System.Drawing.Point(658, 101)
        Me.Labpy_k.Name = "Labpy_k"
        Me.Labpy_k.Size = New System.Drawing.Size(30, 13)
        Me.Labpy_k.TabIndex = 113
        Me.Labpy_k.Text = "py+k"
        '
        'Labqy_k
        '
        Me.Labqy_k.AutoSize = True
        Me.Labqy_k.Location = New System.Drawing.Point(658, 74)
        Me.Labqy_k.Name = "Labqy_k"
        Me.Labqy_k.Size = New System.Drawing.Size(30, 13)
        Me.Labqy_k.TabIndex = 112
        Me.Labqy_k.Text = "qy+k"
        '
        'LabAay
        '
        Me.LabAay.AutoSize = True
        Me.LabAay.Location = New System.Drawing.Point(658, 48)
        Me.LabAay.Name = "LabAay"
        Me.LabAay.Size = New System.Drawing.Size(25, 13)
        Me.LabAay.TabIndex = 111
        Me.LabAay.Text = "Aay"
        '
        'LabQy
        '
        Me.LabQy.AutoSize = True
        Me.LabQy.Location = New System.Drawing.Point(658, 26)
        Me.LabQy.Name = "LabQy"
        Me.LabQy.Size = New System.Drawing.Size(20, 13)
        Me.LabQy.TabIndex = 110
        Me.LabQy.Text = "Qy"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(578, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 13)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "dy"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(578, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 13)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "ly"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(578, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "py+k"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(578, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "qy+k"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(578, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Aay"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(578, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Qy"
        '
        'TxtEdadMeses
        '
        Me.TxtEdadMeses.Location = New System.Drawing.Point(401, 321)
        Me.TxtEdadMeses.Name = "TxtEdadMeses"
        Me.TxtEdadMeses.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdadMeses.TabIndex = 103
        Me.TxtEdadMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 318)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Edad Meses"
        '
        'TxtTabla
        '
        Me.TxtTabla.Location = New System.Drawing.Point(401, 346)
        Me.TxtTabla.Name = "TxtTabla"
        Me.TxtTabla.Size = New System.Drawing.Size(100, 20)
        Me.TxtTabla.TabIndex = 99
        Me.TxtTabla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 18)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Tabla"
        '
        'TxtFecCal
        '
        Me.TxtFecCal.Location = New System.Drawing.Point(401, 204)
        Me.TxtFecCal.Mask = "00/00/0000"
        Me.TxtFecCal.Name = "TxtFecCal"
        Me.TxtFecCal.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecCal.TabIndex = 97
        Me.TxtFecCal.Text = "01012019"
        Me.TxtFecCal.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Fecha Cálculo"
        '
        'TxtFecNacAfi
        '
        Me.TxtFecNacAfi.Location = New System.Drawing.Point(401, 20)
        Me.TxtFecNacAfi.Mask = "00/00/0000"
        Me.TxtFecNacAfi.Name = "TxtFecNacAfi"
        Me.TxtFecNacAfi.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecNacAfi.TabIndex = 95
        Me.TxtFecNacAfi.Text = "29011952"
        Me.TxtFecNacAfi.ValidatingType = GetType(Date)
        '
        'LblFecNacAfi
        '
        Me.LblFecNacAfi.AutoSize = True
        Me.LblFecNacAfi.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecNacAfi.Location = New System.Drawing.Point(13, 21)
        Me.LblFecNacAfi.Name = "LblFecNacAfi"
        Me.LblFecNacAfi.Size = New System.Drawing.Size(170, 18)
        Me.LblFecNacAfi.TabIndex = 94
        Me.LblFecNacAfi.Text = "Fecha Nacimiento Afiliado"
        '
        'TxtSalud
        '
        Me.TxtSalud.Location = New System.Drawing.Point(401, 70)
        Me.TxtSalud.Name = "TxtSalud"
        Me.TxtSalud.Size = New System.Drawing.Size(52, 20)
        Me.TxtSalud.TabIndex = 93
        Me.TxtSalud.Text = "1"
        Me.TxtSalud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(401, 46)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(52, 20)
        Me.TxtSexo.TabIndex = 92
        Me.TxtSexo.Text = "1"
        Me.TxtSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 18)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Salud (0=Normal, 1= Inválido)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 18)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Sexo (1=Masculino, 2= Famenino)"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(604, 447)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(121, 29)
        Me.BtnCalcular.TabIndex = 89
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'TxtRenGar
        '
        Me.TxtRenGar.Location = New System.Drawing.Point(401, 256)
        Me.TxtRenGar.Name = "TxtRenGar"
        Me.TxtRenGar.Size = New System.Drawing.Size(71, 20)
        Me.TxtRenGar.TabIndex = 88
        Me.TxtRenGar.Text = "0"
        Me.TxtRenGar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPerDif
        '
        Me.TxtPerDif.Location = New System.Drawing.Point(401, 230)
        Me.TxtPerDif.Name = "TxtPerDif"
        Me.TxtPerDif.Size = New System.Drawing.Size(71, 20)
        Me.TxtPerDif.TabIndex = 87
        Me.TxtPerDif.Text = "0"
        Me.TxtPerDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(401, 295)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdad.TabIndex = 86
        Me.TxtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 18)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Período en que se ha otorgado una renta garantizada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 18)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Período diferido de la renta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Edad"
        '
        'BntSalir
        '
        Me.BntSalir.Location = New System.Drawing.Point(731, 448)
        Me.BntSalir.Name = "BntSalir"
        Me.BntSalir.Size = New System.Drawing.Size(121, 29)
        Me.BntSalir.TabIndex = 82
        Me.BntSalir.Text = "Salir"
        Me.BntSalir.UseVisualStyleBackColor = True
        '
        'Formula3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 489)
        Me.Controls.Add(Me.TxtF3xy)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtSalCon)
        Me.Controls.Add(Me.TxtSexCon)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtFecNacBen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Labdy)
        Me.Controls.Add(Me.Lably)
        Me.Controls.Add(Me.Labpy_k)
        Me.Controls.Add(Me.Labqy_k)
        Me.Controls.Add(Me.LabAay)
        Me.Controls.Add(Me.LabQy)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtEdadMeses)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTabla)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtFecCal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtFecNacAfi)
        Me.Controls.Add(Me.LblFecNacAfi)
        Me.Controls.Add(Me.TxtSalud)
        Me.Controls.Add(Me.TxtSexo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtRenGar)
        Me.Controls.Add(Me.TxtPerDif)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BntSalir)
        Me.Name = "Formula3"
        Me.Text = "Formula3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtF3xy As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtSalCon As System.Windows.Forms.TextBox
    Friend WithEvents TxtSexCon As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtFecNacBen As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Labdy As System.Windows.Forms.Label
    Friend WithEvents Lably As System.Windows.Forms.Label
    Friend WithEvents Labpy_k As System.Windows.Forms.Label
    Friend WithEvents Labqy_k As System.Windows.Forms.Label
    Friend WithEvents LabAay As System.Windows.Forms.Label
    Friend WithEvents LabQy As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtEdadMeses As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTabla As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtFecCal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtFecNacAfi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblFecNacAfi As System.Windows.Forms.Label
    Friend WithEvents TxtSalud As System.Windows.Forms.TextBox
    Friend WithEvents TxtSexo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents TxtRenGar As System.Windows.Forms.TextBox
    Friend WithEvents TxtPerDif As System.Windows.Forms.TextBox
    Friend WithEvents TxtEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BntSalir As System.Windows.Forms.Button
End Class
