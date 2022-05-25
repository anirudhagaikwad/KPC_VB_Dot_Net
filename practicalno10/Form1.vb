Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("sem 1")
        ComboBox1.Items.Add("sem 2")
        ComboBox1.Items.Add("sem 3")
        ComboBox1.Items.Add("sem 4")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("chemistry")
            ListBox1.Items.Add("Physics")
            ListBox1.Items.Add("Biology")
            ListBox1.Items.Add("Maths")
            ListBox1.Items.Add("English")
        End If
        If ComboBox1.SelectedIndex = 1 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("WPD")
            ListBox1.Items.Add("CPHM")
            ListBox1.Items.Add("PIC")
            ListBox1.Items.Add("EEC")
        End If
        If ComboBox1.SelectedIndex = 2 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("CGR")
            ListBox1.Items.Add("DBMS")
            ListBox1.Items.Add("OOPS")
            ListBox1.Items.Add("DSU")
        End If
        If ComboBox1.SelectedIndex = 3 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("GAD")
            ListBox1.Items.Add("DCC")
            ListBox1.Items.Add("Biology")
            ListBox1.Items.Add("JPR")
            ListBox1.Items.Add("SEM")
        End If



    End Sub
End Class
