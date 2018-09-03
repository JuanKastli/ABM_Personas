Public Class PersonasGrid

    Private Sub PersonasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click


        PersonasForm.operacion = "Agregar"

        PersonasForm.Text = "Alta de persona"

        PersonasForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If lst.Count = 0 Then Exit Sub
        PersonasForm.operacion = "Eliminar"
        PersonasForm.Text = "Eliminar datos de Persona"

        PersonasForm.indice = DataGridView1.CurrentRow.Index

        llenarform()

        PersonasForm.Show()
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If lst.Count = 0 Then Exit Sub
        PersonasForm.operacion = "Modificar"
        PersonasForm.Text = "Modifica datos Persona"
        PersonasForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        PersonasForm.Show()
    End Sub
    Private Sub llenarform()

        PersonasForm.TextBox1.Text = DataGridView1.CurrentRow.Cells("Id").Value.ToString
        PersonasForm.CodigoPostal.Text = DataGridView1.CurrentRow.Cells("CodPostal").Value.ToString
        PersonasForm.Direc.Text = DataGridView1.CurrentRow.Cells("Direccion").Value.ToString
        PersonasForm.TextBoxNUMD.Text = DataGridView1.CurrentRow.Cells("NroDocumento").Value.ToString
        PersonasForm.ComboBox1.Text = DataGridView1.CurrentRow.Cells("TipoDocumento").Value.ToString
        PersonasForm.TextBoxNYA.Text = DataGridView1.CurrentRow.Cells("Nombre").Value.ToString
        PersonasForm.ComboBox2.Text = DataGridView1.CurrentRow.Cells("nombreProvincia").Value.ToString


    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub
End Class