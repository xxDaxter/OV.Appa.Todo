Imports OV.Context.Interface

Namespace Todo
    Public Interface ITodoFactory

#Region "methods"
        Function GetTodoFactory(context As IContext) As ITodoFactory
        Function GetAllTodos() As KeyValuePair(Of Integer, ITodoItem)
        Function GetTodoById(id As Integer) As ITodoItem
        Function CreateNewTodo() As ITodoItem
        Sub DeleteTodo(item As ITodoItem)
#End Region
    End Interface
End Namespace

