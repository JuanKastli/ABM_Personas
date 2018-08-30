Public Class PersonasForm
    Dim operacion_ As String

    Dim MiPersona As New PersonasClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte
    Public Property indice() As String
        Get
            Return indice_
        End Get
        Set(ByVal value As String)

            indice_ = value
        End Set
    End Property
    Private Sub PersonasForm_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ComboBox2.DataSource = MiPersona.provincias
        ComboBox1.DataSource = MiPersona.documentos

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

    End Sub
   
   

    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        
        'MiPersona.Id = CInt(TextBox1.Text)
        MiPersona.Nombre = TextBoxNYA.Text
        MiPersona.Dirección = Dirección.Text
        MiPersona.CodPostal = CInt(CodigoPostal.Text)
        MiPersona.IdProvincia = ComboBox1.SelectedIndex
        MiPersona.TipoDocumento = ComboBox2.SelectedIndex
        MiPersona.NroDocumento = TextBoxNUMD.Text


        Select Case operacion_

            Case "Agregar"

                lst.InsertarPersona(MiPersona)

            Case "Modificar"

                lst.ActualizarPersona(MiPersona)
                PersonasGrid.DataGridView1.Refresh()

            Case "Eliminar"
                lst.EliminarPersona(MiPersona)

        End Select


        Me.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

   
    
End Class
