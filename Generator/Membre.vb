<Serializable> _
Public Class Membre
    Private _Nom As String
    Private _Date As Date

    Property Nom As String
        Get
            Return Me._Nom
        End Get
        Set(value As String)
            Me._Nom = value
        End Set
    End Property

    Property datetir As Date
        Get
            Return Me._Date
        End Get
        Set(value As Date)
            Me._Date = value
        End Set
    End Property

    Sub New(nom As String)
        Me.Nom = nom
    End Sub

    Sub New(nom As String, datetir As Date)
        Me.datetir = datetir
        Me.Nom = nom
    End Sub

    Public Overrides Function ToString() As String
        If Me.datetir <> Nothing Then
            Return Me.Nom & "  (" & Me.datetir & ")"
        End If
        Return MyBase.ToString
    End Function
End Class
