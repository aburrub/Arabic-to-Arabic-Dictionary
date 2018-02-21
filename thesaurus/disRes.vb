Public Class disRes
    Private _hasCircle As Boolean = False
    Private _word As String
    Private _meaning As String
    Private Sub disRes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = "Meanning for " + " (" + Me._word + ") : "
        If Me._hasCircle Then
            Me.Label3.Text = "Circle Found"
            Me.TextBox1.ForeColor = Color.Red
        Else
            Me.Label3.Text = "Circle not Found"
            Me.TextBox1.ForeColor = Color.Green
        End If
        Me.TextBox1.Text = Me._meaning
    End Sub

    Public Property WORD As String
        Set(ByVal value As String)
            Me._word = value
        End Set
        Get
            Return Me._word
        End Get
    End Property

    Public Property MEANING As String
        Set(ByVal value As String)
            Me._meaning = value
        End Set
        Get
            Return Me._meaning
        End Get
    End Property

    Public Property HAS_CIRCLE As Boolean
        Set(ByVal value As Boolean)
            Me._hasCircle = value
        End Set
        Get
            Return Me._hasCircle
        End Get
    End Property
End Class