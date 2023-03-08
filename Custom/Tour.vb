Public Class Tour
    Private _Datefi As Date

    Property datefi As Date
        Get
            Return Me._Datefi
        End Get
        Set(value As Date)
            Me._Datefi = value
        End Set
    End Property

    Sub New(datefi As Date)
        Me.datefi = datefi
    End Sub

    'Public Overrides Function ToString() As String
    '    If Me.datefi <> Nothing Then
    '        Return Me.Montant & "  (" & Me.datefi & ")"
    '    End If
    '    Return MyBase.ToString
    'End Function
End Class
