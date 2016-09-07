Imports System
Imports System.IO
Imports System.Text
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Public Class Input
    Dim w As IO.StreamWriter
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim t As String = TextBox1.Text
        Dim tt As String = textbox2.text
        Dim ttt As String = "." + t + ".:" + tt + ":"
        lb1.Items.Add(ttt)
        lb1.SelectedIndex = lb1.SelectedIndex + 1
        ListBox1.Items.Add(t + ":" + tt)
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Dim i As Integer
        'w = New IO.StreamWriter("C:\b\" & TextBox2.Text & ".txt")
        'For i = 0 To lb1.Items.Count - 1
        'w.WriteLine(lb1.Items.Item(i))
        'Next
        'w.Close()
        choose.Show()
    End Sub

    Private Sub Input_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class