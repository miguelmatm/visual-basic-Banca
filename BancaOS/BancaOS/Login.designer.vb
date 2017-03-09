<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits EmpresaInicio

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
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.lblRedirectRegister = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtbPwd = New System.Windows.Forms.TextBox()
        Me.txtbUser = New System.Windows.Forms.TextBox()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.EPUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlLogin.SuspendLayout()
        CType(Me.EPUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogin.Controls.Add(Me.lblRedirectRegister)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.txtbPwd)
        Me.pnlLogin.Controls.Add(Me.txtbUser)
        Me.pnlLogin.Controls.Add(Me.lblPwd)
        Me.pnlLogin.Controls.Add(Me.lblUser)
        Me.pnlLogin.Controls.Add(Me.lblTittle)
        Me.pnlLogin.Location = New System.Drawing.Point(68, 67)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(341, 307)
        Me.pnlLogin.TabIndex = 3
        '
        'lblRedirectRegister
        '
        Me.lblRedirectRegister.AutoSize = True
        Me.lblRedirectRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRedirectRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRedirectRegister.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblRedirectRegister.Location = New System.Drawing.Point(141, 247)
        Me.lblRedirectRegister.Name = "lblRedirectRegister"
        Me.lblRedirectRegister.Size = New System.Drawing.Size(61, 13)
        Me.lblRedirectRegister.TabIndex = 7
        Me.lblRedirectRegister.Text = "¡Registrate!"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(101, 174)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(157, 30)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Iniciar Sesión"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtbPwd
        '
        Me.txtbPwd.BackColor = System.Drawing.Color.White
        Me.txtbPwd.Location = New System.Drawing.Point(101, 133)
        Me.txtbPwd.MaxLength = 4
        Me.txtbPwd.Name = "txtbPwd"
        Me.txtbPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbPwd.Size = New System.Drawing.Size(157, 20)
        Me.txtbPwd.TabIndex = 4
        '
        'txtbUser
        '
        Me.txtbUser.BackColor = System.Drawing.Color.White
        Me.txtbUser.Location = New System.Drawing.Point(102, 83)
        Me.txtbUser.MaxLength = 9
        Me.txtbUser.Name = "txtbUser"
        Me.txtbUser.Size = New System.Drawing.Size(157, 20)
        Me.txtbUser.TabIndex = 3
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwd.ForeColor = System.Drawing.Color.Black
        Me.lblPwd.Location = New System.Drawing.Point(141, 117)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(71, 13)
        Me.lblPwd.TabIndex = 2
        Me.lblPwd.Text = "Contraseña"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(151, 67)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(50, 13)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Usuario"
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.BackColor = System.Drawing.Color.Transparent
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.ForeColor = System.Drawing.Color.Black
        Me.lblTittle.Location = New System.Drawing.Point(97, 12)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(162, 25)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "Inicio de sesión"
        '
        'EPUser
        '
        Me.EPUser.ContainerControl = Me
        '
        'EPPass
        '
        Me.EPPass.ContainerControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 415)
        Me.Controls.Add(Me.pnlLogin)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Controls.SetChildIndex(Me.pnlLogin, 0)
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.EPUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblTittle As Label
    Friend WithEvents txtbUser As TextBox
    Friend WithEvents lblPwd As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblRedirectRegister As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtbPwd As TextBox
    Friend WithEvents EPUser As ErrorProvider
    Friend WithEvents EPPass As ErrorProvider
End Class
