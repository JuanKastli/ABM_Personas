<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonasForm
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
        Me.Nombre = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.Label
        Me.CodPostal = New System.Windows.Forms.Label
        Me.Provincia = New System.Windows.Forms.Label
        Me.TipoDocumento = New System.Windows.Forms.Label
        Me.NroDocumento = New System.Windows.Forms.Label
        Me.TextBoxNYA = New System.Windows.Forms.TextBox
        Me.Direc = New System.Windows.Forms.TextBox
        Me.CodigoPostal = New System.Windows.Forms.TextBox
        Me.TextBoxNUMD = New System.Windows.Forms.TextBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.id = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(66, 79)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(94, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre Y Apellido"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Location = New System.Drawing.Point(66, 111)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(52, 13)
        Me.Direccion.TabIndex = 1
        Me.Direccion.Text = "Direccion"
        '
        'CodPostal
        '
        Me.CodPostal.AutoSize = True
        Me.CodPostal.Location = New System.Drawing.Point(66, 149)
        Me.CodPostal.Name = "CodPostal"
        Me.CodPostal.Size = New System.Drawing.Size(72, 13)
        Me.CodPostal.TabIndex = 2
        Me.CodPostal.Text = "Codigo Postal"
        '
        'Provincia
        '
        Me.Provincia.AutoSize = True
        Me.Provincia.Location = New System.Drawing.Point(66, 188)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(51, 13)
        Me.Provincia.TabIndex = 3
        Me.Provincia.Text = "Provincia"
        '
        'TipoDocumento
        '
        Me.TipoDocumento.AutoSize = True
        Me.TipoDocumento.Location = New System.Drawing.Point(66, 220)
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.Size = New System.Drawing.Size(101, 13)
        Me.TipoDocumento.TabIndex = 4
        Me.TipoDocumento.Text = "Tipo de Documento"
        '
        'NroDocumento
        '
        Me.NroDocumento.AutoSize = True
        Me.NroDocumento.Location = New System.Drawing.Point(66, 262)
        Me.NroDocumento.Name = "NroDocumento"
        Me.NroDocumento.Size = New System.Drawing.Size(117, 13)
        Me.NroDocumento.TabIndex = 5
        Me.NroDocumento.Text = "Numero de Documento"
        '
        'TextBoxNYA
        '
        Me.TextBoxNYA.Location = New System.Drawing.Point(246, 72)
        Me.TextBoxNYA.Multiline = True
        Me.TextBoxNYA.Name = "TextBoxNYA"
        Me.TextBoxNYA.Size = New System.Drawing.Size(165, 20)
        Me.TextBoxNYA.TabIndex = 6
        '
        'Direc
        '
        Me.Direc.Location = New System.Drawing.Point(246, 108)
        Me.Direc.Name = "Direc"
        Me.Direc.Size = New System.Drawing.Size(165, 20)
        Me.Direc.TabIndex = 7
        '
        'CodigoPostal
        '
        Me.CodigoPostal.Location = New System.Drawing.Point(246, 146)
        Me.CodigoPostal.Name = "CodigoPostal"
        Me.CodigoPostal.Size = New System.Drawing.Size(165, 20)
        Me.CodigoPostal.TabIndex = 8
        '
        'TextBoxNUMD
        '
        Me.TextBoxNUMD.Location = New System.Drawing.Point(246, 262)
        Me.TextBoxNUMD.Name = "TextBoxNUMD"
        Me.TextBoxNUMD.Size = New System.Drawing.Size(165, 20)
        Me.TextBoxNUMD.TabIndex = 11
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(107, 316)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(117, 23)
        Me.Aceptar.TabIndex = 12
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(322, 316)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(112, 23)
        Me.Cancelar.TabIndex = 13
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(246, 220)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(246, 180)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(66, 42)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(16, 13)
        Me.id.TabIndex = 16
        Me.id.Text = "Id"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(246, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 20)
        Me.TextBox1.TabIndex = 17
        '
        'PersonasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 365)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.TextBoxNUMD)
        Me.Controls.Add(Me.CodigoPostal)
        Me.Controls.Add(Me.Direc)
        Me.Controls.Add(Me.TextBoxNYA)
        Me.Controls.Add(Me.NroDocumento)
        Me.Controls.Add(Me.TipoDocumento)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.CodPostal)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "PersonasForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.Label
    Friend WithEvents CodPostal As System.Windows.Forms.Label
    Friend WithEvents Provincia As System.Windows.Forms.Label
    Friend WithEvents TipoDocumento As System.Windows.Forms.Label
    Friend WithEvents NroDocumento As System.Windows.Forms.Label
    Friend WithEvents TextBoxNYA As System.Windows.Forms.TextBox
    Friend WithEvents Direc As System.Windows.Forms.TextBox
    Friend WithEvents CodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNUMD As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
