Namespace Todo
    Public Class TodoItem
        Inherits ADirty
        Implements ITodoItem

#Region "members and properties"

        Private _id As Integer
        Public Property id As Integer Implements ITodoItem.id
            Get
                Return _id
            End Get
            Set(value As Integer)
                If CheckIfIsDirty(_id, value) Then
                    _id = value
                End If
            End Set
        End Property

        Private _name As String
        Public Property name As String Implements ITodoItem.name
            Get
                Return _name
            End Get
            Set(value As String)
                If CheckIfIsDirty(_name, value) Then
                    _name = value
                End If
            End Set
        End Property

        Private _headline As String
        Public Property headline As String Implements ITodoItem.headline
            Get
                Return _headline
            End Get
            Set(value As String)
                If CheckIfIsDirty(_headline, value) Then
                    _headline = value
                End If
            End Set
        End Property

        Private _description As String
        Public Property description As String Implements ITodoItem.description
            Get
                Return _description
            End Get
            Set(value As String)
                If CheckIfIsDirty(_description, value) Then
                    _description = value
                End If
            End Set
        End Property

        Private _priority As TodoPriorityEnum
        Public Property priority As TodoPriorityEnum Implements ITodoItem.priority
            Get
                Return _priority
            End Get
            Set(value As TodoPriorityEnum)
                If CheckIfIsDirty(_priority, value) Then
                    _priority = value
                End If
            End Set
        End Property

        Private _creationDate As Date
        Public Property creationDate As Date Implements ITodoItem.creationDate
            Get
                Return _creationDate
            End Get
            Set(value As Date)
                If CheckIfIsDirty(_creationDate, value) Then
                    _creationDate = value
                End If
            End Set
        End Property

        Private _startDate As Date
        Public Property startDate As Date Implements ITodoItem.startDate
            Get
                Return _startDate
            End Get
            Set(value As Date)
                If CheckIfIsDirty(_startDate, value) Then
                    _startDate = value
                End If
            End Set
        End Property

        Private _endDate As Date
        Public Property endDate As Date Implements ITodoItem.endDate
            Get
                Return _endDate
            End Get
            Set(value As Date)
                If CheckIfIsDirty(_endDate, value) Then
                    _endDate = value
                End If
            End Set
        End Property

        Private _listOfAttachments As New List(Of IAttachmentItem)
        Public ReadOnly Property listOfAttachments As List(Of IAttachmentItem) Implements ITodoItem.listOfAttachments
            Get
                Return _listOfAttachments
            End Get
        End Property

        Public Property dbStatus As DbStatusEnum Implements ITodoItem.dbStatus
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As DbStatusEnum)
                Throw New NotImplementedException()
            End Set
        End Property
#End Region

#Region "constructor"
        Friend Sub New(id As Integer)

        End Sub
#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean ' Dient zur Erkennung redundanter Aufrufe.

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                End If

                ' TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalize() weiter unten überschreiben.
                ' TODO: große Felder auf Null setzen.
            End If
            disposedValue = True
        End Sub

        ' TODO: Finalize() nur überschreiben, wenn Dispose(disposing As Boolean) weiter oben Code zur Bereinigung nicht verwalteter Ressourcen enthält.
        'Protected Overrides Sub Finalize()
        '    ' Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(disposing As Boolean) weiter oben ein.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' Dieser Code wird von Visual Basic hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(disposing As Boolean) weiter oben ein.
            Dispose(True)
            ' TODO: Auskommentierung der folgenden Zeile aufheben, wenn Finalize() oben überschrieben wird.
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class
End Namespace

