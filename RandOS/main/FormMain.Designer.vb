<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.datee = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.time = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.POWERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHUTDOWNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTIVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULATORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTEPADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panelmenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datee
        '
        Me.datee.AutoSize = True
        Me.datee.BackColor = System.Drawing.Color.Transparent
        Me.datee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.datee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datee.ForeColor = System.Drawing.SystemColors.Control
        Me.datee.Location = New System.Drawing.Point(1025, 577)
        Me.datee.Name = "datee"
        Me.datee.Size = New System.Drawing.Size(36, 18)
        Me.datee.TabIndex = 0
        Me.datee.Text = "date"
        '
        'Timer1
        '
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.BackColor = System.Drawing.Color.Transparent
        Me.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.ForeColor = System.Drawing.SystemColors.Control
        Me.time.Location = New System.Drawing.Point(1031, 595)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(36, 18)
        Me.time.TabIndex = 1
        Me.time.Text = "time"
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.BackgroundImage = Global.RandOS.My.Resources.Resources.d3bd73477873ff05a127e686ee688f65_black_and_white_house_icon_by_vexels
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhome.ForeColor = System.Drawing.Color.Black
        Me.btnhome.Location = New System.Drawing.Point(-2, 578)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(43, 41)
        Me.btnhome.TabIndex = 2
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panelmenu.Controls.Add(Me.MenuStrip1)
        Me.Panelmenu.Location = New System.Drawing.Point(0, 486)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(140, 94)
        Me.Panelmenu.TabIndex = 3
        Me.Panelmenu.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.POWERToolStripMenuItem, Me.PRODUCTIVEToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(140, 82)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'POWERToolStripMenuItem
        '
        Me.POWERToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.POWERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGOUTToolStripMenuItem, Me.SHUTDOWNToolStripMenuItem})
        Me.POWERToolStripMenuItem.Name = "POWERToolStripMenuItem"
        Me.POWERToolStripMenuItem.Size = New System.Drawing.Size(133, 19)
        Me.POWERToolStripMenuItem.Text = "POWER"
        Me.POWERToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'SHUTDOWNToolStripMenuItem
        '
        Me.SHUTDOWNToolStripMenuItem.Name = "SHUTDOWNToolStripMenuItem"
        Me.SHUTDOWNToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SHUTDOWNToolStripMenuItem.Text = "SHUTDOWN"
        '
        'PRODUCTIVEToolStripMenuItem
        '
        Me.PRODUCTIVEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULATORToolStripMenuItem, Me.NOTEPADToolStripMenuItem, Me.PAINTToolStripMenuItem})
        Me.PRODUCTIVEToolStripMenuItem.Name = "PRODUCTIVEToolStripMenuItem"
        Me.PRODUCTIVEToolStripMenuItem.Size = New System.Drawing.Size(133, 19)
        Me.PRODUCTIVEToolStripMenuItem.Text = "PRODUCTIVE"
        '
        'CALCULATORToolStripMenuItem
        '
        Me.CALCULATORToolStripMenuItem.Name = "CALCULATORToolStripMenuItem"
        Me.CALCULATORToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CALCULATORToolStripMenuItem.Text = "CALCULATOR"
        '
        'NOTEPADToolStripMenuItem
        '
        Me.NOTEPADToolStripMenuItem.Name = "NOTEPADToolStripMenuItem"
        Me.NOTEPADToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NOTEPADToolStripMenuItem.Text = "NOTEPAD"
        '
        'PAINTToolStripMenuItem
        '
        Me.PAINTToolStripMenuItem.Name = "PAINTToolStripMenuItem"
        Me.PAINTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PAINTToolStripMenuItem.Text = "PAINT"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(133, 19)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1106, 618)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.datee)
        Me.Controls.Add(Me.Panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.Panelmenu.ResumeLayout(False)
        Me.Panelmenu.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datee As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents time As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnhome As Button
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents POWERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHUTDOWNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTIVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULATORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOTEPADToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
