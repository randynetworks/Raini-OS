Public Class calculator
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDot.Click, btnKali.Click, btnBagi.Click, btnTambah.Click, btnKurang.Click, btnResult.Click, btnClear.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "btn0" Then
            txtBox.Text = txtBox.Text + "0"
        End If

        If button.Name = "btn1" Then
            txtBox.Text = txtBox.Text + "1"
        End If

        If button.Name = "btn2" Then
            txtBox.Text = txtBox.Text + "2"
        End If

        If button.Name = "btn3" Then
            txtBox.Text = txtBox.Text + "3"
        End If

        If button.Name = "btn4" Then
            txtBox.Text = txtBox.Text + "4"
        End If

        If button.Name = "btn5" Then
            txtBox.Text = txtBox.Text + "5"
        End If

        If button.Name = "btn6" Then
            txtBox.Text = txtBox.Text + "6"
        End If

        If button.Name = "btn7" Then
            txtBox.Text = txtBox.Text + "7"
        End If

        If button.Name = "btn8" Then
            txtBox.Text = txtBox.Text + "8"
        End If

        If button.Name = "btn9" Then
            txtBox.Text = txtBox.Text + "9"
        End If

        If button.Name = "btnDot" Then
            txtBox.Text = txtBox.Text + "."
        End If

        If button.Name = "btnKali" Then
            txtBox.Text = txtBox.Text + "*"
        End If

        If button.Name = "btnBagi" Then
            txtBox.Text = txtBox.Text + "/"
        End If

        If button.Name = "btnKurang" Then
            txtBox.Text = txtBox.Text + "-"
        End If

        If button.Name = "btnTambah" Then
            txtBox.Text = txtBox.Text + "+"
        End If

        If button.Name = "btnClear" Then
            txtBox.Text = " "
        End If

        If button.Name = "btnResult" Then
            Dim equation As String = txtBox.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            txtBox.Text = result
        End If

    End Sub
End Class