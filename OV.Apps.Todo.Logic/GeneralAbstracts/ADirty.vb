Public MustInherit Class ADirty

#Region "members and properties"

    Protected _isDirty As Boolean
    Public ReadOnly Property IsDirty() As Boolean
        Get
            Return _isDirty
        End Get
    End Property

#End Region

#Region "methods"

    Protected Function CheckIfIsDirty(original As Object, newValue As Object) As Boolean
        If original Is Nothing Then

            Return False
        End If

        If Not original.Equals(newValue) Then
            SetIsDirty(True)
            Return True
        End If

        Return False
    End Function

    Private Sub SetIsDirty(value As Boolean)
        If _isDirty = False AndAlso value = True Then
            _isDirty = True
        End If
    End Sub
#End Region
End Class
