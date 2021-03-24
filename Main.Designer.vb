<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.randGen = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.txtWeapon = New System.Windows.Forms.TextBox()
        Me.txtField = New System.Windows.Forms.TextBox()
        Me.txtAmmo = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pnlMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'randGen
        '
        Me.randGen.Enabled = True
        Me.randGen.Interval = 15
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btn1)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(200, 468)
        Me.pnlMenu.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Roboto Cn", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.Location = New System.Drawing.Point(0, 80)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(200, 37)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Cold War"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(200, 80)
        Me.pnlLogo.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.btnStart)
        Me.pnlMain.Controls.Add(Me.txtAmmo)
        Me.pnlMain.Controls.Add(Me.txtField)
        Me.pnlMain.Controls.Add(Me.txtWeapon)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(200, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(584, 468)
        Me.pnlMain.TabIndex = 1
        '
        'txtWeapon
        '
        Me.txtWeapon.Location = New System.Drawing.Point(6, 3)
        Me.txtWeapon.Name = "txtWeapon"
        Me.txtWeapon.Size = New System.Drawing.Size(100, 20)
        Me.txtWeapon.TabIndex = 2
        '
        'txtField
        '
        Me.txtField.Location = New System.Drawing.Point(112, 3)
        Me.txtField.Name = "txtField"
        Me.txtField.Size = New System.Drawing.Size(100, 20)
        Me.txtField.TabIndex = 3
        '
        'txtAmmo
        '
        Me.txtAmmo.Location = New System.Drawing.Point(218, 3)
        Me.txtAmmo.Name = "txtAmmo"
        Me.txtAmmo.Size = New System.Drawing.Size(100, 20)
        Me.txtAmmo.TabIndex = 4
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(6, 29)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Button1"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 468)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "Main"
        Me.Text = "COD Zombies Challenger"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents randGen As Timer
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents btn1 As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents txtAmmo As TextBox
    Friend WithEvents txtField As TextBox
    Friend WithEvents txtWeapon As TextBox
End Class
