Public Class Form1
    Private depth As Integer = 10
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CheckBox1.Checked = False
        Me.TextBox1.Text = ""
        Me.depth_TextBox.Text = 10
    End Sub

    ' to get odd numbers if(num mod 2 = 1)
    Private Sub printArray(ByRef arr As List(Of String), ByVal hasCircle As Boolean, ByVal word As String)
        If arr.Count = 0 Then
            MsgBox("no meanning words found")
        Else
            Dim result As String = ""
            '  For i As Integer = 0 To arr.Count - 1
            For i As Integer = 0 To arr.Count - 1     ' Step 2
                result = result + "word[" + (i + 1).ToString + "] : " + arr(i) + Environment.NewLine
            Next
            disRes.HAS_CIRCLE = hasCircle
            disRes.WORD = word
            disRes.MEANING = result
            disRes.ShowDialog()
        End If

    End Sub
    Private Function checkIfCircleExist(ByRef gf As Term, ByRef stObj As Stack, ByVal max As Integer, ByVal retVal As Boolean) As Boolean
        If max >= 0 Then
            If Not stObj.Contains(gf.VALUE) And gf.VISITED Then
                retVal = True
            End If
            gf.VISITED = True
            stObj.Push(gf.VALUE)
            For Each st As Term In gf.LINKS
                checkIfCircleExist(st, stObj, max - 1, retVal)
            Next
            stObj.Pop()
        End If
        Return retVal
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim gf As New wordGraph(Me.TextBox1.Text, Me.CheckBox1.Checked)

            gf.buildTree(Me.depth)
            Dim s As List(Of String) = gf.FindCircleGraph()

            printlist(s)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub printlist(ByRef s As List(Of String))
        Dim r As String = ""
        For Each i As String In s
            r = r + i + ", " + Environment.NewLine
        Next
        MsgBox(r)
    End Sub

    Private Sub depth_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles depth_Button.Click
        Try
            Me.depth = Integer.Parse(Me.depth_TextBox.Text)
        Catch ex As Exception
            Me.depth = 10
        End Try

    End Sub

    Private Sub check_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Button.Click
        Me.TextBox1.Text = ""
        Dim adp As New thesaurusDataSetTableAdapters.testTableAdapter()
        Dim dt As DataTable = adp.GetDataAllArabicWords
        Dim word As String
        Dim count As Integer = Integer.Parse(adp.GetWordsCount().ToString)
        Dim subCount As Integer = 0
        For Each row As DataRow In dt.Rows
            word = (row.ItemArray(2).ToString)
            Dim gf As New wordGraph(word, False)
            gf.buildTree(Me.depth)            
            Try
                Dim s As List(Of String) = gf.FindCircleGraph()
                subCount = If(s.Count >= 1, subCount + 1, subCount)
            Catch ex As Exception

            End Try
        Next
        Me.TextBox1.Text = "Number of Circles (" + subCount.ToString + ") of (" + count.ToString + ") words"
    End Sub
End Class
