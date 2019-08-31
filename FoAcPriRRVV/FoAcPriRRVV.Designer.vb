<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoAcPriRRVV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoAcPriRRVV))
        Me.BtnForm1 = New System.Windows.Forms.Button
        Me.BtnForm2 = New System.Windows.Forms.Button
        Me.BtnForm3 = New System.Windows.Forms.Button
        Me.BtnForm4 = New System.Windows.Forms.Button
        Me.BntSalir = New System.Windows.Forms.Button
        Me.BtnModelo = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnForm1
        '
        Me.BtnForm1.Location = New System.Drawing.Point(631, 31)
        Me.BtnForm1.Name = "BtnForm1"
        Me.BtnForm1.Size = New System.Drawing.Size(211, 53)
        Me.BtnForm1.TabIndex = 0
        Me.BtnForm1.Text = "Fórmula Uno"
        Me.BtnForm1.UseVisualStyleBackColor = True
        '
        'BtnForm2
        '
        Me.BtnForm2.Location = New System.Drawing.Point(631, 101)
        Me.BtnForm2.Name = "BtnForm2"
        Me.BtnForm2.Size = New System.Drawing.Size(211, 53)
        Me.BtnForm2.TabIndex = 1
        Me.BtnForm2.Text = "Fórmula Dos"
        Me.BtnForm2.UseVisualStyleBackColor = True
        '
        'BtnForm3
        '
        Me.BtnForm3.Location = New System.Drawing.Point(631, 185)
        Me.BtnForm3.Name = "BtnForm3"
        Me.BtnForm3.Size = New System.Drawing.Size(211, 53)
        Me.BtnForm3.TabIndex = 2
        Me.BtnForm3.Text = "Fórmula Tres"
        Me.BtnForm3.UseVisualStyleBackColor = True
        '
        'BtnForm4
        '
        Me.BtnForm4.Location = New System.Drawing.Point(631, 255)
        Me.BtnForm4.Name = "BtnForm4"
        Me.BtnForm4.Size = New System.Drawing.Size(211, 53)
        Me.BtnForm4.TabIndex = 3
        Me.BtnForm4.Text = "Fórmula Cuatro"
        Me.BtnForm4.UseVisualStyleBackColor = True
        '
        'BntSalir
        '
        Me.BntSalir.Location = New System.Drawing.Point(631, 469)
        Me.BntSalir.Name = "BntSalir"
        Me.BntSalir.Size = New System.Drawing.Size(211, 51)
        Me.BntSalir.TabIndex = 4
        Me.BntSalir.Text = "Salir"
        Me.BntSalir.UseVisualStyleBackColor = True
        '
        'BtnModelo
        '
        Me.BtnModelo.Location = New System.Drawing.Point(631, 327)
        Me.BtnModelo.Name = "BtnModelo"
        Me.BtnModelo.Size = New System.Drawing.Size(211, 53)
        Me.BtnModelo.TabIndex = 5
        Me.BtnModelo.Text = "Modelo"
        Me.BtnModelo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(882, 535)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FoAcPriRRVV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 547)
        Me.Controls.Add(Me.BtnModelo)
        Me.Controls.Add(Me.BtnForm4)
        Me.Controls.Add(Me.BtnForm3)
        Me.Controls.Add(Me.BtnForm2)
        Me.Controls.Add(Me.BtnForm1)
        Me.Controls.Add(Me.BntSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FoAcPriRRVV"
        Me.Text = "Fórmulación Actuarial Prtimas RRVV"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnForm1 As System.Windows.Forms.Button
    Friend WithEvents BtnForm2 As System.Windows.Forms.Button
    Friend WithEvents BtnForm3 As System.Windows.Forms.Button
    Friend WithEvents BtnForm4 As System.Windows.Forms.Button
    Friend WithEvents BntSalir As System.Windows.Forms.Button
    Friend WithEvents BtnModelo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
