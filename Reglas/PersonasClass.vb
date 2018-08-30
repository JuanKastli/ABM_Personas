Public Class PersonasClass
    Dim documentos_() As String = {"DNI", "LE", "LC", "CI", "PAS"}

    Dim provincias_() As String = _
 {"Ciudad Autónoma de Buenos Aires", _
       "Buenos Aires", _
       "Catamarca", _
       "Córdoba", _
       "Corrientes", _
       "Entre Ríos", _
       "Jujuy", _
       "Mendoza", _
       "La Rioja", _
       "Salta", _
       "San Juan", _
       "San Luis", _
       "Santa Fe", _
       "Santiago del Estero", _
       "Tucumán", _
       "Chaco", _
       "Chubut", _
       "Formosa", _
       "Misiones", _
       "Neuquén", _
       "La Pampa", _
       "Río Negro", _
       "Santa Cruz", _
       "Tierra del Fuego"}

    Dim Id_, IdProvincia_, TipoDocumento_, CodPostal_, NroDocumento_ As Integer
    Dim Nombre_, Dirección_ As String
    Public Property Id() As Integer
        Get
            Return Id_

        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Public Property CodPostal() As Integer
        Get
            Return CodPostal_


        End Get
        Set(ByVal value As Integer)
            CodPostal_ = value
        End Set
    End Property
    Public Property Dirección() As String
        Get
            Return Dirección_

        End Get
        Set(ByVal value As String)
            Dirección_ = value
        End Set
    End Property
    Public Property NroDocumento() As Integer
        Get
            Return NroDocumento_

        End Get
        Set(ByVal value As Integer)
            NroDocumento_ = value
        End Set
    End Property
    Public Property TipoDocumento() As Integer
        Get
            Return TipoDocumento_

        End Get
        Set(ByVal value As Integer)
            TipoDocumento_ = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return Nombre_


        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property
    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_

        End Get
        Set(ByVal value As Integer)
            IdProvincia_ = value
        End Set
    End Property
    Public ReadOnly Property documentos() As Array
        Get
            Return documentos_
        End Get
    End Property
    Public ReadOnly Property nombreDocumentos() As String
        Get
            If TipoDocumento_ <= 0 Then
                'Return ""
            End If
            Return documentos(CInt(tipoDocumento))
        End Get
    End Property

    Public ReadOnly Property provincias() As Array
        Get
            Return provincias_
        End Get
    End Property
    Public ReadOnly Property nombreProvincia() As String
        Get
            If TipoDocumento_ <= 0 Then
                'Return ""
            End If

            Return provincias(CInt(IdProvincia_))
        End Get
    End Property

End Class
