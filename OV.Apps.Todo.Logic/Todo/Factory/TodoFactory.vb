Imports OV.Context.Interface

Namespace Todo
    Public Class TodoFactory
        Implements ITodoFactory

#Region "members"
        Private _context As IContext
#End Region

#Region "constructor"
        Friend Sub New(context As IContext)
            _context = context
        End Sub
#End Region

#Region "methods"
#Region "public"
        Public Sub DeleteTodo(item As ITodoItem) Implements ITodoFactory.DeleteTodo
            '# Todo: Abstrakte Klasse Fehlt noch dbStatus
        End Sub

        Public Function GetAllTodos() As List(Of ITodoItem) Implements ITodoFactory.GetAllTodos
            Dim listOfItems As New List(Of ITodoItem)
            '# Todo: Lader der Items

            Return listOfItems
        End Function

        Public Function GetTodoById(id As Integer) As ITodoItem Implements ITodoFactory.GetTodoById
            Dim item As ITodoItem = New TodoItem(id)
            '# Todo: Lader des Items

            Return item
        End Function

        Public Function CreateNewTodo() As ITodoItem Implements ITodoFactory.CreateNewTodo
            Dim item As ITodoItem = New TodoItem(0)

            Return item
        End Function

        Public Function GetSelectedTodos(list As List(Of Integer)) As List(Of ITodoItem) Implements ITodoFactory.GetSelectedTodos
            Dim listOfItems As New List(Of ITodoItem)
            '# Todo: Lader der Items

            Return listOfItems
        End Function
#End Region

#Region "private"

#End Region
#End Region

    End Class
End Namespace

