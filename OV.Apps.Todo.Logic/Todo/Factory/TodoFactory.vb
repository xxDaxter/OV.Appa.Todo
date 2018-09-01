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
            Throw New NotImplementedException()
        End Sub

        Public Function GetAllTodos() As KeyValuePair(Of Integer, ITodoItem) Implements ITodoFactory.GetAllTodos
            Throw New NotImplementedException()
        End Function

        Public Function GetTodoById(id As Integer) As ITodoItem Implements ITodoFactory.GetTodoById
            Throw New NotImplementedException()
        End Function

        Public Function CreateNewTodo() As ITodoItem Implements ITodoFactory.CreateNewTodo
            Throw New NotImplementedException()
        End Function

        Public Function GetSelectedTodos(list As List(Of Integer)) As ITodoItem Implements ITodoFactory.GetSelectedTodos
            Throw New NotImplementedException()
        End Function
#End Region

#Region "private"

#End Region
#End Region

    End Class
End Namespace

