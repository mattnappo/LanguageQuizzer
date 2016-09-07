Public Class quiz2
    Dim score As Integer = 0
    Public Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim s As String = Input.lb1.SelectedItem.ToString()
        Dim i As Integer = s.IndexOf(":")
        Dim f As String = s.Substring(i + 1, s.IndexOf(":", i + 1) - i - 1)
        Dim sx As String = Input.lb1.SelectedItem.ToString()
        Dim ix As Integer = sx.IndexOf(".")
        Dim xx As String = sx.Substring(ix + 1, s.IndexOf(".", ix + 1) - ix - 1)
        Label7.Text = xx
        Button2.Text = "New Word"
        Label1.Text = f
        TextBox1.Text = Nothing
    End Sub
    Private Sub quiz2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button2.Text = "Click to Start!"
        Input.lb1.SetSelected(Input.lb1.Items.Count - 1, True)
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Label7.Text Then
            MsgBox("Correct!", MsgBoxStyle.Information, "Answer")
            score = score + 1
            Label2.Text = score
            If Input.lb1.SelectedIndex > 0 Then
                Input.lb1.SelectedIndex = Input.lb1.SelectedIndex - 1
            ElseIf Input.lb1.SelectedIndex = 0 Then
                Dim ts As String = Label2.Text + " / " + Input.lb1.Items.Count.ToString
                MsgBox("You completed the quiz! Your score was " + ts + "!")
                score = 0
                Label2.Text = Nothing
                Me.Close()
            End If
        Else
            score = score - 1
            MsgBox("Incorrect!", MsgBoxStyle.Information, "Answer")
            Label2.Text = score
        End If
        TextBox1.Text = Nothing
    End Sub
End Class