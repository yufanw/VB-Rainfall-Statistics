<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfallStatistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRainfallStatistics))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMost = New System.Windows.Forms.Label()
        Me.picRain = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        CType(Me.picRain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(574, 131)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(372, 51)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Rainfall Statistics"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.Location = New System.Drawing.Point(661, 203)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(198, 37)
        Me.lblYears.TabIndex = 1
        Me.lblYears.Text = "2000 - 2017"
        '
        'cboYears
        '
        Me.cboYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(637, 265)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(247, 45)
        Me.cboYears.TabIndex = 2
        Me.cboYears.Text = "Select Year"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRainfall.Location = New System.Drawing.Point(207, 396)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(612, 37)
        Me.lblRainfall.TabIndex = 3
        Me.lblRainfall.Text = "The total rainfall in Year XXXX is XX.X."
        Me.lblRainfall.Visible = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(332, 452)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(362, 66)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Statistics"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(217, 537)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(593, 37)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.Text = "The average rainfall was XX.X inches."
        Me.lblAverage.Visible = False
        '
        'lblMost
        '
        Me.lblMost.AutoSize = True
        Me.lblMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMost.Location = New System.Drawing.Point(135, 606)
        Me.lblMost.Name = "lblMost"
        Me.lblMost.Size = New System.Drawing.Size(768, 37)
        Me.lblMost.TabIndex = 6
        Me.lblMost.Text = "Year 2006 had the most rain between 2000-2017."
        Me.lblMost.Visible = False
        '
        'picRain
        '
        Me.picRain.Image = CType(resources.GetObject("picRain.Image"), System.Drawing.Image)
        Me.picRain.Location = New System.Drawing.Point(12, 55)
        Me.picRain.Name = "picRain"
        Me.picRain.Size = New System.Drawing.Size(527, 338)
        Me.picRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRain.TabIndex = 7
        Me.picRain.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1027, 40)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(70, 653)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(887, 37)
        Me.lblSecond.TabIndex = 9
        Me.lblSecond.Text = "Year 2006 had the second most rain between 2000-2017."
        Me.lblSecond.Visible = False
        '
        'lblThird
        '
        Me.lblThird.AutoSize = True
        Me.lblThird.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThird.Location = New System.Drawing.Point(90, 701)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(846, 37)
        Me.lblThird.TabIndex = 10
        Me.lblThird.Text = "Year 2006 had the third most rain between 2000-2017."
        Me.lblThird.Visible = False
        '
        'frmRainfallStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1027, 779)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.picRain)
        Me.Controls.Add(Me.lblMost)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.cboYears)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRainfallStatistics"
        Me.Text = "WANG Rainfall Statistics"
        CType(Me.picRain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents lblRainfall As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblMost As Label
    Friend WithEvents picRain As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblThird As Label
End Class
