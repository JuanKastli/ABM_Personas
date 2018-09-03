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
            MiPersona.Direccion = dr("Direccion")
            MiPersona.CodPostal = dr("CodPostal")
            MiPersona.IdProvincia = CInt(dr("IdProvincia"))
            MiPersona.TipoDocumento = CInt(dr("TipoDocumento"))
            MiPersona.NroDocumento = CInt(dr("NroDocumento"))

            Me.Add(MiPersona)

        Next
        Return Me
    End Function
    Public Sub insertarPersona(ByVal Mipersona As PersonasClass)

        Dim ObjBasedato As New BaseDeDatosClass

        ObjBasedato.objTabla = "Personas"

        Dim VSQL As New StringBuilder

        'VSQL.Append("(Id")
        VSQL.Append("(Nombre")
        VSQL.Append(",Direccion")
        VSQL.Append(",CodPostal")
        VSQL.Append(",IdProvincia")
        VSQL.Append(",TipoDocumento")
        VSQL.Append(",NroDocumento)")

        VSQL.Append(" VALUES ")

        'VSQL.Append("('" & Mipersona.Id.ToString & "'")
        VSQL.Append("( '" & Mipersona.Nombre & "'")
        VSQL.Append(", '" & Mipersona.Direccion & "'")
        VSQL.Append(", '" & Mipersona.CodPostal & "'")
        VSQL.Append(", '" & Mipersona.IdProvincia & "'")
        VSQL.Append(", '" & Mipersona.TipoDocumento & "'")
        VSQL.Append(", '" & Mipersona.NroDocumento & "')")

        Mipersona.Id = ObjBasedato.Insertar(VSQL.ToString)
        Me.Add(Mipersona)


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
        objBaseDatos.objTabla = "Personas"

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
        objBaseDatos.objTabla = "Personas"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("Id='" & MiPersona.Id.ToString & "'")
        vSQL.Append("TipoDocumento='" & MiPersona.TipoDocumento & "'")
        vSQL.Append(",NroDocumento='" & MiPersona.NroDocumento.ToString & "'")
        vSQL.Append(",Nombre='" & MiPersona.Nombre & "'")
        vSQL.Append(",Direccion='" & MiPersona.Direccion & "'")
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
