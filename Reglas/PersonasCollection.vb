Imports System.ComponentModel
Imports System.Text

Public Class PersonasCollection

    Inherits BindingList(Of PersonasClass)

    Public Sub New()
        Me.TraerPersonas()

    End Sub
    Public Function TraerPersonas() As PersonasCollection

        Dim objBaseDatos As New BaseDeDatosClass
        Dim MiDataTable As New DataTable
        Dim MiPersona As PersonasClass

        objBaseDatos.objTabla = "Personas"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows

            MiPersona = New PersonasClass

            MiPersona.id = CInt(dr("Id"))
            MiPersona.Nombre = dr("Nombre")
            MiPersona.Dirección = dr("Dirección")
            MiPersona.CodPostal = dr("CodPostal")
            MiPersona.IdProvincia = CInt(dr("IdProvincia"))
            MiPersona.TipoDocumento = CInt(dr("TipoDocumento"))
            MiPersona.NroDocumento = CInt(dr("NroDocumento"))

            Me.Add(MiPersona)

        Next
        Return Me
    End Function
    Public Sub InsertarPersona(ByVal MiPersona As PersonasClass)

        Dim objBaseDatos As New BaseDeDatosClass
        objBaseDatos.objTabla = "Personas"
        Dim vsql As New StringBuilder
        'vsql.Append("(Id)")
        vsql.Append(",Nombre")
        vsql.Append(",Dirección")
        vsql.Append(",CodPostal")
        vsql.Append(",IdProvincia")
        vsql.Append(",TipoDocumento")
        vsql.Append(",NroDocumento)")

        vsql.Append("VALUES")

        'vsql.Append("('" & MiPersona.id & "'")
        vsql.Append("," & MiPersona.Nombre & "'")
        vsql.Append("," & MiPersona.Dirección & "'")
        vsql.Append("," & MiPersona.CodPostal & "'")
        vsql.Append("," & MiPersona.IdProvincia & "'")
        vsql.Append("," & MiPersona.TipoDocumento & "'")
        vsql.Append("," & MiPersona.NroDocumento & "'")

        MiPersona.id = objBaseDatos.Insertar(vsql.ToString)

        Me.Add(MiPersona)

    End Sub
    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each carrera In Me
            If prop.GetValue(carrera).Equals(key) Then
                Return Me.IndexOf(carrera)
            End If
        Next

        Return -1
    End Function


    Public Sub EliminarPersona(ByVal MiPersona As PersonasClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDeDatosClass
        objBaseDatos.objTabla = "personas"

        'Ejecuta el método base eliminar.
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiPersona.Id)

        If resultado Then

            'Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiPersona)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiPersona.Id))
        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarPersona(ByVal MiPersona As PersonasClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDeDatosClass
        objBaseDatos.objTabla = "personas"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Id='" & MiPersona.Id.ToString & "'")
        vSQL.Append(",TipoDocumento='" & MiPersona.tipoDocumento & "'")
        vSQL.Append(",NumeroDocumento='" & MiPersona.NroDocumento.ToString & "'")
        vSQL.Append(",Nombre='" & MiPersona.Nombre & "'")
        vSQL.Append(",Direccion='" & MiPersona.Dirección & "'")
        vSQL.Append(",IdProvincia='" & MiPersona.IdProvincia.ToString & "'")
        vSQL.Append(",CodPostal='" & MiPersona.CodPostal.ToString & "'")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiPersona.Id)

        If resultado Then
            'El código a continuación sirve para localizar el ítem en la lista
            'en este caso un persona.
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiPersona)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiPersona.Id)) = MiPersona
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If

    End Sub

    
End Class
