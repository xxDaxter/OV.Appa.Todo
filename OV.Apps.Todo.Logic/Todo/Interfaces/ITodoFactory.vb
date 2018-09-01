Imports OV.Context.Interface

Namespace Todo
    Public Interface ITodoFactory

#Region "methods"
        Function GetAllTodos() As KeyValuePair(Of Integer, ITodoItem)
        Function GetTodoById(id As Integer) As ITodoItem
        Function GetSelectedTodos(list As List(Of Integer)) As ITodoItem
        Function CreateNewTodo() As ITodoItem
        Sub DeleteTodo(item As ITodoItem)
#End Region

    End Interface
End Namespace

