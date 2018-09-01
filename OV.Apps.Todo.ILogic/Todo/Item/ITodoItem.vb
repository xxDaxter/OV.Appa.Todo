Namespace Todo
    ''' <summary>
    ''' Dieses Interface stellt das TodoItem dar. Ist das Main Item des Programms.
    ''' </summary>
    Public Interface ITodoItem

#Region "properties"

        ''' <summary>
        ''' Die Id eines Todos.
        ''' </summary>
        ''' <returns>Integer</returns>
        Property id As Integer

        ''' <summary>
        ''' Der Name eines Todos.
        ''' </summary>
        ''' <returns>String</returns>
        Property name As String

        ''' <summary>
        ''' Die Überschrift des Todos.
        ''' </summary>
        ''' <returns>String</returns>
        Property headline As String

        ''' <summary>
        ''' Die Beschreibung eines Todos.
        ''' </summary>
        ''' <returns>String</returns>
        Property description As String

        ''' <summary>
        ''' Die Priorität des Todos, wird in 5 Stufen (0-4) angegeben. 0 hoch, 4 niedrig.
        ''' </summary>
        ''' <returns>TodoPriorityEnum</returns>
        Property priority As TodoPriorityEnum

        ''' <summary>
        ''' Datum, wann der Todo erstellt wurde.
        ''' </summary>
        ''' <returns>Date</returns>
        Property creationDate As Date

        ''' <summary>
        ''' Geplanter Bearbeitungsstart des Todos.
        ''' </summary>
        ''' <returns>Date</returns>
        Property startDate As Date

        ''' <summary>
        ''' Geplantes Bearbeitungsende des Todos.
        ''' </summary>
        ''' <returns>Date</returns>
        Property endDate As Date

        ''' <summary>
        ''' Eine Liste Von Anhängen.
        ''' </summary>
        ''' <returns>IAttachmentItem</returns>
        Property listOfAttachments As List(Of IAttachmentItem)

        '# Todo: kann noch nach belieben erweitert werden.
#End Region
    End Interface

End Namespace
