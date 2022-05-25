Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'check if the selected radiobutton is male
        If RadioButton1.Checked = True Then
            'display that the selected radio button is Male
            MsgBox("Your Gender is Male")

        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' The CheckBox control's Text property is changed each time the
        ' control is clicked, indicating a checked or unchecked state.
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Checked"
        Else
            CheckBox1.Text = "UnChecked"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ' The CheckBox control's Text property is changed each time the
        ' control is clicked, indicating a checked or unchecked state.
        If CheckBox2.Checked = True Then
            CheckBox2.Text = "Checked"
        Else
            CheckBox2.Text = "UnChecked"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ' The CheckBox control's Text property is changed each time the
        ' control is clicked, indicating a checked or unchecked state.
        If CheckBox3.Checked = True Then
            CheckBox3.Text = "Checked"
        Else
            CheckBox3.Text = "UnChecked"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'check if the selected radiobutton is female
        If RadioButton2.Checked = True Then
            'display that the selected radio button is FeMale
            MsgBox("Your Gender is Female")
        End If
    End Sub
End Class
