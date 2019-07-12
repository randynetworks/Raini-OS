Imports System.Data.OleDb
Public Class FormStartLogin

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUser.Text = "" Or tbPass.Text = "" Then
            MessageBox.Show("something empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call koneksi()
            cmd = New OleDbCommand("SELECT * FROM [user] WHERE username='" & tbUser.Text & "' and pass='" & tbPass.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Me.Hide()
                FormMain.Show()
            Else
                MessageBox.Show("username or password wrong!, check again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUser.Text = ""
        tbPass.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbPass.CheckedChanged
        If cbPass.Checked Then
            tbPass.UseSystemPasswordChar = True
        Else
            tbPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub LinkNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNew.LinkClicked
        createUser.Show()
    End Sub
End Class
