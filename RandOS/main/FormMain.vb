Imports RandOS.FormStartLogin
Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datee.Text = Date.Now.ToShortDateString
        time.Text = Date.Now.ToShortTimeString

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
        FormStartLogin.Show()
    End Sub

    Private Sub SHUTDOWNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHUTDOWNToolStripMenuItem.Click
        End
    End Sub

    Private Sub Btnhome_MouseHover(sender As Object, e As EventArgs) Handles btnhome.MouseHover
        Panelmenu.Visible = True
    End Sub

    Private Sub btnhome_MouseClick(sender As Object, e As MouseEventArgs) Handles btnhome.MouseClick
        Panelmenu.Visible = False
    End Sub
    '
    Private Sub FormMain_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Panelmenu.Visible = False
    End Sub

    Private Sub CALCULATORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULATORToolStripMenuItem.Click
        calculator.Show()
    End Sub

    Private Sub NOTEPADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOTEPADToolStripMenuItem.Click
        notepad.Show()
    End Sub

    Private Sub PAINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAINTToolStripMenuItem.Click
        painting.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub
End Class