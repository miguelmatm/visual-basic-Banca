<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEmpresas
    Inherits EmpresaInicio

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
        Me.pnlModify = New System.Windows.Forms.Panel()
        Me.btnclean = New System.Windows.Forms.Button()
        Me.txtbAcount2 = New System.Windows.Forms.TextBox()
        Me.txtbAcount1 = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.cmbComparny = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ckActivate = New System.Windows.Forms.CheckBox()
        Me.txtbHome = New System.Windows.Forms.TextBox()
        Me.txtbName = New System.Windows.Forms.TextBox()
        Me.txtbcif = New System.Windows.Forms.TextBox()
        Me.lblAccount2 = New System.Windows.Forms.Label()
        Me.lblAccount1 = New System.Windows.Forms.Label()
        Me.lblActivate = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCif = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.pnlModify.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlModify
        '
        Me.pnlModify.BackColor = System.Drawing.Color.White
        Me.pnlModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlModify.Controls.Add(Me.btnclean)
        Me.pnlModify.Controls.Add(Me.txtbAcount2)
        Me.pnlModify.Controls.Add(Me.txtbAcount1)
        Me.pnlModify.Controls.Add(Me.btnLoad)
        Me.pnlModify.Controls.Add(Me.cmbComparny)
        Me.pnlModify.Controls.Add(Me.btnBack)
        Me.pnlModify.Controls.Add(Me.btnSave)
        Me.pnlModify.Controls.Add(Me.ckActivate)
        Me.pnlModify.Controls.Add(Me.txtbHome)
        Me.pnlModify.Controls.Add(Me.txtbName)
        Me.pnlModify.Controls.Add(Me.txtbcif)
        Me.pnlModify.Controls.Add(Me.lblAccount2)
        Me.pnlModify.Controls.Add(Me.lblAccount1)
        Me.pnlModify.Controls.Add(Me.lblActivate)
        Me.pnlModify.Controls.Add(Me.lblHome)
        Me.pnlModify.Controls.Add(Me.lblName)
        Me.pnlModify.Controls.Add(Me.lblCif)
        Me.pnlModify.Controls.Add(Me.lblCompany)
        Me.pnlModify.Controls.Add(Me.lblTittle)
        Me.pnlModify.Location = New System.Drawing.Point(419, 188)
        Me.pnlModify.Name = "pnlModify"
        Me.pnlModify.Size = New System.Drawing.Size(464, 404)
        Me.pnlModify.TabIndex = 3
        '
        'btnclean
        '
        Me.btnclean.Location = New System.Drawing.Point(319, 346)
        Me.btnclean.Name = "btnclean"
        Me.btnclean.Size = New System.Drawing.Size(75, 23)
        Me.btnclean.TabIndex = 21
        Me.btnclean.Text = "Limpiar"
        Me.btnclean.UseVisualStyleBackColor = True
        '
        'txtbAcount2
        '
        Me.txtbAcount2.Location = New System.Drawing.Point(172, 271)
        Me.txtbAcount2.MaxLength = 23
        Me.txtbAcount2.Name = "txtbAcount2"
        Me.txtbAcount2.Size = New System.Drawing.Size(222, 20)
        Me.txtbAcount2.TabIndex = 20
        '
        'txtbAcount1
        '
        Me.txtbAcount1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtbAcount1.Location = New System.Drawing.Point(172, 236)
        Me.txtbAcount1.MaxLength = 23
        Me.txtbAcount1.Name = "txtbAcount1"
        Me.txtbAcount1.Size = New System.Drawing.Size(222, 20)
        Me.txtbAcount1.TabIndex = 19
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(313, 74)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(81, 23)
        Me.btnLoad.TabIndex = 18
        Me.btnLoad.Text = "Cargar Datos"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'cmbComparny
        '
        Me.cmbComparny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComparny.FormattingEnabled = True
        Me.cmbComparny.Location = New System.Drawing.Point(172, 74)
        Me.cmbComparny.Name = "cmbComparny"
        Me.cmbComparny.Size = New System.Drawing.Size(121, 21)
        Me.cmbComparny.TabIndex = 17
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(88, 346)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Volver"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(207, 346)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ckActivate
        '
        Me.ckActivate.AutoSize = True
        Me.ckActivate.Location = New System.Drawing.Point(172, 209)
        Me.ckActivate.Name = "ckActivate"
        Me.ckActivate.Size = New System.Drawing.Size(15, 14)
        Me.ckActivate.TabIndex = 12
        Me.ckActivate.UseVisualStyleBackColor = True
        '
        'txtbHome
        '
        Me.txtbHome.Location = New System.Drawing.Point(172, 174)
        Me.txtbHome.MaxLength = 150
        Me.txtbHome.Name = "txtbHome"
        Me.txtbHome.Size = New System.Drawing.Size(100, 20)
        Me.txtbHome.TabIndex = 11
        '
        'txtbName
        '
        Me.txtbName.Location = New System.Drawing.Point(172, 141)
        Me.txtbName.MaxLength = 100
        Me.txtbName.Name = "txtbName"
        Me.txtbName.Size = New System.Drawing.Size(100, 20)
        Me.txtbName.TabIndex = 10
        '
        'txtbcif
        '
        Me.txtbcif.Enabled = False
        Me.txtbcif.Location = New System.Drawing.Point(172, 109)
        Me.txtbcif.MaxLength = 9
        Me.txtbcif.Name = "txtbcif"
        Me.txtbcif.Size = New System.Drawing.Size(100, 20)
        Me.txtbcif.TabIndex = 9
        '
        'lblAccount2
        '
        Me.lblAccount2.AutoSize = True
        Me.lblAccount2.Location = New System.Drawing.Point(84, 278)
        Me.lblAccount2.Name = "lblAccount2"
        Me.lblAccount2.Size = New System.Drawing.Size(63, 13)
        Me.lblAccount2.TabIndex = 7
        Me.lblAccount2.Text = "Cuenta nº2:"
        '
        'lblAccount1
        '
        Me.lblAccount1.AutoSize = True
        Me.lblAccount1.Location = New System.Drawing.Point(84, 239)
        Me.lblAccount1.Name = "lblAccount1"
        Me.lblAccount1.Size = New System.Drawing.Size(63, 13)
        Me.lblAccount1.TabIndex = 6
        Me.lblAccount1.Text = "Cuenta nº1:"
        '
        'lblActivate
        '
        Me.lblActivate.AutoSize = True
        Me.lblActivate.Location = New System.Drawing.Point(85, 209)
        Me.lblActivate.Name = "lblActivate"
        Me.lblActivate.Size = New System.Drawing.Size(40, 13)
        Me.lblActivate.TabIndex = 5
        Me.lblActivate.Text = "Activa:"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Location = New System.Drawing.Point(85, 174)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(52, 13)
        Me.lblHome.TabIndex = 4
        Me.lblHome.Text = "Domicilio:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(84, 141)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Nombre:"
        '
        'lblCif
        '
        Me.lblCif.AutoSize = True
        Me.lblCif.Location = New System.Drawing.Point(85, 109)
        Me.lblCif.Name = "lblCif"
        Me.lblCif.Size = New System.Drawing.Size(26, 13)
        Me.lblCif.TabIndex = 2
        Me.lblCif.Text = "CIF:"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(85, 74)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(51, 13)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "Empresa:"
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTittle.Location = New System.Drawing.Point(188, 18)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(202, 25)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "Modificar Empresas"
        '
        'ModificarEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.pnlModify)
        Me.Name = "ModificarEmpresas"
        Me.Text = "ModificarEmpresas"
        Me.Controls.SetChildIndex(Me.pnlModify, 0)
        Me.pnlModify.ResumeLayout(False)
        Me.pnlModify.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlModify As Panel
    Friend WithEvents lblTittle As Label
    Friend WithEvents lblAccount2 As Label
    Friend WithEvents lblAccount1 As Label
    Friend WithEvents lblActivate As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCif As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ckActivate As CheckBox
    Friend WithEvents txtbHome As TextBox
    Friend WithEvents txtbName As TextBox
    Friend WithEvents txtbcif As TextBox
    Friend WithEvents cmbComparny As ComboBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtbAcount2 As TextBox
    Friend WithEvents txtbAcount1 As TextBox
    Friend WithEvents btnclean As Button
End Class
