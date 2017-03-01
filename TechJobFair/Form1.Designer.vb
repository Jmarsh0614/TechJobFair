<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechJobFair
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblJobFairDtls = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVwJobFairDtls = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(54, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(209, 35)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Tech Job Fair"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(71, 71)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(174, 18)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "All Students are Welcome"
        '
        'lblJobFairDtls
        '
        Me.lblJobFairDtls.AutoSize = True
        Me.lblJobFairDtls.Location = New System.Drawing.Point(99, 151)
        Me.lblJobFairDtls.Name = "lblJobFairDtls"
        Me.lblJobFairDtls.Size = New System.Drawing.Size(119, 65)
        Me.lblJobFairDtls.TabIndex = 2
        Me.lblJobFairDtls.Text = "May 2, 2015" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Located in Lochlan Hall" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room 101"
        Me.lblJobFairDtls.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TechJobFair.My.Resources.Resources.Fair
        Me.PictureBox1.Location = New System.Drawing.Point(260, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 317)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnVwJobFairDtls
        '
        Me.btnVwJobFairDtls.AutoSize = True
        Me.btnVwJobFairDtls.BackColor = System.Drawing.Color.Honeydew
        Me.btnVwJobFairDtls.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwJobFairDtls.Location = New System.Drawing.Point(84, 109)
        Me.btnVwJobFairDtls.Name = "btnVwJobFairDtls"
        Me.btnVwJobFairDtls.Size = New System.Drawing.Size(149, 28)
        Me.btnVwJobFairDtls.TabIndex = 4
        Me.btnVwJobFairDtls.Text = "View Job Fair Details"
        Me.btnVwJobFairDtls.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(84, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmTechJobFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(601, 417)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVwJobFairDtls)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblJobFairDtls)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmTechJobFair"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblJobFairDtls As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVwJobFairDtls As Button
    Friend WithEvents btnExit As Button
End Class
