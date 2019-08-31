<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formula1
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
        Me.BntSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtEdad = New System.Windows.Forms.TextBox
        Me.TxtPerDif = New System.Windows.Forms.TextBox
        Me.TxtRenGar = New System.Windows.Forms.TextBox
        Me.BtnCalcular = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtSexo = New System.Windows.Forms.TextBox
        Me.TxtSalud = New System.Windows.Forms.TextBox
        Me.TxtFecNacAfi = New System.Windows.Forms.MaskedTextBox
        Me.LblFecNacAfi = New System.Windows.Forms.Label
        Me.TxtFecCal = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtTabla = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtF1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtEdadMeses = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LabQy = New System.Windows.Forms.Label
        Me.LabAay = New System.Windows.Forms.Label
        Me.Labqy_k = New System.Windows.Forms.Label
        Me.Labpy_k = New System.Windows.Forms.Label
        Me.Lably = New System.Windows.Forms.Label
        Me.Labdy = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtF2 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtF215 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BntSalir
        '
        Me.BntSalir.Location = New System.Drawing.Point(755, 344)
        Me.BntSalir.Name = "BntSalir"
        Me.BntSalir.Size = New System.Drawing.Size(121, 29)
        Me.BntSalir.TabIndex = 0
        Me.BntSalir.Text = "Salir"
        Me.BntSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Período diferido de la renta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Período  garantizado"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(300, 238)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdad.TabIndex = 5
        Me.TxtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPerDif
        '
        Me.TxtPerDif.Location = New System.Drawing.Point(300, 134)
        Me.TxtPerDif.Name = "TxtPerDif"
        Me.TxtPerDif.Size = New System.Drawing.Size(63, 20)
        Me.TxtPerDif.TabIndex = 7
        Me.TxtPerDif.Text = "0"
        Me.TxtPerDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtRenGar
        '
        Me.TxtRenGar.Location = New System.Drawing.Point(300, 160)
        Me.TxtRenGar.Name = "TxtRenGar"
        Me.TxtRenGar.Size = New System.Drawing.Size(63, 20)
        Me.TxtRenGar.TabIndex = 8
        Me.TxtRenGar.Text = "0"
        Me.TxtRenGar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(611, 344)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(121, 29)
        Me.BtnCalcular.TabIndex = 9
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sexo (1=Masculino, 2= Famenino)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Salud (0=Normal, 1= Inválido)"
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(300, 81)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(63, 20)
        Me.TxtSexo.TabIndex = 12
        Me.TxtSexo.Text = "1"
        Me.TxtSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSalud
        '
        Me.TxtSalud.Location = New System.Drawing.Point(300, 108)
        Me.TxtSalud.Name = "TxtSalud"
        Me.TxtSalud.Size = New System.Drawing.Size(63, 20)
        Me.TxtSalud.TabIndex = 13
        Me.TxtSalud.Text = "1"
        Me.TxtSalud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFecNacAfi
        '
        Me.TxtFecNacAfi.Location = New System.Drawing.Point(300, 27)
        Me.TxtFecNacAfi.Mask = "00/00/0000"
        Me.TxtFecNacAfi.Name = "TxtFecNacAfi"
        Me.TxtFecNacAfi.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecNacAfi.TabIndex = 15
        Me.TxtFecNacAfi.Text = "29011952"
        Me.TxtFecNacAfi.ValidatingType = GetType(Date)
        '
        'LblFecNacAfi
        '
        Me.LblFecNacAfi.AutoSize = True
        Me.LblFecNacAfi.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecNacAfi.Location = New System.Drawing.Point(9, 28)
        Me.LblFecNacAfi.Name = "LblFecNacAfi"
        Me.LblFecNacAfi.Size = New System.Drawing.Size(170, 18)
        Me.LblFecNacAfi.TabIndex = 14
        Me.LblFecNacAfi.Text = "Fecha Nacimiento Afiliado"
        '
        'TxtFecCal
        '
        Me.TxtFecCal.Location = New System.Drawing.Point(300, 53)
        Me.TxtFecCal.Mask = "00/00/0000"
        Me.TxtFecCal.Name = "TxtFecCal"
        Me.TxtFecCal.Size = New System.Drawing.Size(71, 20)
        Me.TxtFecCal.TabIndex = 17
        Me.TxtFecCal.Text = "01012019"
        Me.TxtFecCal.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Fecha Cálculo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Tabla"
        '
        'TxtTabla
        '
        Me.TxtTabla.Location = New System.Drawing.Point(300, 289)
        Me.TxtTabla.Name = "TxtTabla"
        Me.TxtTabla.Size = New System.Drawing.Size(100, 20)
        Me.TxtTabla.TabIndex = 19
        Me.TxtTabla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fórmula 1"
        '
        'TxtF1
        '
        Me.TxtF1.Location = New System.Drawing.Point(300, 315)
        Me.TxtF1.Name = "TxtF1"
        Me.TxtF1.Size = New System.Drawing.Size(100, 20)
        Me.TxtF1.TabIndex = 21
        Me.TxtF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Edad Meses"
        '
        'TxtEdadMeses
        '
        Me.TxtEdadMeses.Location = New System.Drawing.Point(300, 264)
        Me.TxtEdadMeses.Name = "TxtEdadMeses"
        Me.TxtEdadMeses.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdadMeses.TabIndex = 23
        Me.TxtEdadMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(477, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Qy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(477, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Aay"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(477, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "qy+k"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(477, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "py+k"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(477, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "ly"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(477, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "dy"
        '
        'LabQy
        '
        Me.LabQy.AutoSize = True
        Me.LabQy.Location = New System.Drawing.Point(557, 9)
        Me.LabQy.Name = "LabQy"
        Me.LabQy.Size = New System.Drawing.Size(20, 13)
        Me.LabQy.TabIndex = 30
        Me.LabQy.Text = "Qy"
        '
        'LabAay
        '
        Me.LabAay.AutoSize = True
        Me.LabAay.Location = New System.Drawing.Point(557, 31)
        Me.LabAay.Name = "LabAay"
        Me.LabAay.Size = New System.Drawing.Size(25, 13)
        Me.LabAay.TabIndex = 31
        Me.LabAay.Text = "Aay"
        '
        'Labqy_k
        '
        Me.Labqy_k.AutoSize = True
        Me.Labqy_k.Location = New System.Drawing.Point(557, 57)
        Me.Labqy_k.Name = "Labqy_k"
        Me.Labqy_k.Size = New System.Drawing.Size(30, 13)
        Me.Labqy_k.TabIndex = 32
        Me.Labqy_k.Text = "qy+k"
        '
        'Labpy_k
        '
        Me.Labpy_k.AutoSize = True
        Me.Labpy_k.Location = New System.Drawing.Point(557, 84)
        Me.Labpy_k.Name = "Labpy_k"
        Me.Labpy_k.Size = New System.Drawing.Size(30, 13)
        Me.Labpy_k.TabIndex = 33
        Me.Labpy_k.Text = "py+k"
        '
        'Lably
        '
        Me.Lably.AutoSize = True
        Me.Lably.Location = New System.Drawing.Point(557, 111)
        Me.Lably.Name = "Lably"
        Me.Lably.Size = New System.Drawing.Size(14, 13)
        Me.Lably.TabIndex = 34
        Me.Lably.Text = "ly"
        '
        'Labdy
        '
        Me.Labdy.AutoSize = True
        Me.Labdy.Location = New System.Drawing.Point(557, 136)
        Me.Labdy.Name = "Labdy"
        Me.Labdy.Size = New System.Drawing.Size(18, 13)
        Me.Labdy.TabIndex = 35
        Me.Labdy.Text = "dy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Fórmula 2"
        '
        'TxtF2
        '
        Me.TxtF2.Location = New System.Drawing.Point(300, 341)
        Me.TxtF2.Name = "TxtF2"
        Me.TxtF2.Size = New System.Drawing.Size(100, 20)
        Me.TxtF2.TabIndex = 38
        Me.TxtF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(412, 344)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 18)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "x 15"
        '
        'TxtF215
        '
        Me.TxtF215.Location = New System.Drawing.Point(450, 344)
        Me.TxtF215.Name = "TxtF215"
        Me.TxtF215.Size = New System.Drawing.Size(100, 20)
        Me.TxtF215.TabIndex = 80
        Me.TxtF215.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Formula1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 411)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtF215)
        Me.Controls.Add(Me.TxtF2)
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
        Me.Controls.Add(Me.TxtF1)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "Formula1"
        Me.Text = "Fórmula 1. Renta Simple"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BntSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtEdad As System.Windows.Forms.TextBox
    Friend WithEvents TxtPerDif As System.Windows.Forms.TextBox
    Friend WithEvents TxtRenGar As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSexo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSalud As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecNacAfi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblFecNacAfi As System.Windows.Forms.Label
    Friend WithEvents TxtFecCal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTabla As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtF1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtEdadMeses As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabQy As System.Windows.Forms.Label
    Friend WithEvents LabAay As System.Windows.Forms.Label
    Friend WithEvents Labqy_k As System.Windows.Forms.Label
    Friend WithEvents Labpy_k As System.Windows.Forms.Label
    Friend WithEvents Lably As System.Windows.Forms.Label
    Friend WithEvents Labdy As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtF2 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtF215 As System.Windows.Forms.TextBox
End Class
