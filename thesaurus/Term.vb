Public Class Term
    Private engFlag As Boolean
    Private _value As String ' here we save the term
    Public _links As List(Of Term) ' we store term adj
    Private _visited As Boolean = False
    Public Sub New(ByVal value As String, ByVal engFlag As Boolean)
        Me.engFlag = engFlag
        Me._links = New List(Of Term)
        Me._value = value
    End Sub

    Public Sub addAdjacent(ByRef term As Term)
        Me._links.Add(term)
    End Sub

    Public Sub removeLink(ByRef key As String)
        For Each link As Term In Me._links
            If key = link.VALUE Then
                link = Nothing
                Exit For
            End If

        Next
    End Sub
    Public Function checkAjacentNodeIfExist(ByRef term As Term) As Boolean
        For Each t As Term In Me.LINKS
            If term Is t Then
                Return True
            End If
        Next
        Return False
    End Function
    Public ReadOnly Property ENGLISH_FLAG() As Boolean
        Get
            Return Me.engFlag
        End Get
    End Property

    Public Property VALUE() As String
        Get
            Return Me._value
        End Get
        Set(ByVal value As String)
            Me._value = value
        End Set
    End Property

    Public Property VISITED() As Boolean
        Get
            Return Me._visited
        End Get
        Set(ByVal value As Boolean)
            Me._visited = value
        End Set
    End Property

    Public ReadOnly Property LINKS() As List(Of Term)
        Get
            Return Me._links
        End Get
    End Property

    Public Function getNumberOfLinks() As Integer
        Try
            Return Me._links.Count
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
