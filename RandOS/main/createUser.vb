Imports System.Data.OleDb
Public Class createUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUser.Text = "" Or tbPass.Text = "" Or tbPassComf.Text = "" Then
            MessageBox.Show("Thensomething empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call koneksi()
            Dim a, b As String

            a = tbUser.Text
            b = tbPass.Text

            sql = "insert into [user] (username, pass)values('" & a & "', '" & b & "')"

            If tbPass.Text = tbPassComf.Text Then
                cmd = New OleDb.OleDbCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("password is not same!, chack again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub CbPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbPass.CheckedChanged
        If cbPass.Checked Then
            tbPass.UseSystemPasswordChar = True
        Else
            tbPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Cbpass2_CheckedChanged(sender As Object, e As EventArgs) Handles cbpass2.CheckedChanged
        If cbPass.Checked Then
            tbPass.UseSystemPasswordChar = True
        Else
            tbPass.UseSystemPasswordChar = False
        End If
    End Sub
End Class