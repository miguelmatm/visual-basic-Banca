<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtbAddres = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtbName = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtbCIF = New System.Windows.Forms.TextBox()
        Me.lblCif = New System.Windows.Forms.Label()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.pnlRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRegister
        '
        Me.pnlRegister.BackColor = System.Drawing.Color.White
        Me.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.txtbAddres)
        Me.pnlRegister.Controls.Add(Me.lblAddress)
        Me.pnlRegister.Controls.Add(Me.txtbName)
        Me.pnlRegister.Controls.Add(Me.lblNombre)
        Me.pnlRegister.Controls.Add(Me.txtbCIF)
        Me.pnlRegister.Controls.Add(Me.lblCif)
        Me.pnlRegister.Controls.Add(Me.lblTittle)
        Me.pnlRegister.Location = New System.Drawing.Point(77, 48)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(303, 309)
        Me.pnlRegister.TabIndex = 3
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(97, 232)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(100, 23)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "Registrar"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtbAddres
        '
        Me.txtbAddres.BackColor = System.Drawing.Color.White
        Me.txtbAddres.Location = New System.Drawing.Point(97, 193)
        Me.txtbAddres.MaxLength = 150
        Me.txtbAddres.Name = "txtbAddres"
        Me.txtbAddres.Size = New System.Drawing.Size(100, 20)
        Me.txtbAddres.TabIndex = 6
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(122, 177)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 13)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Domicilio"
        '
        'txtbName
        '
        Me.txtbName.BackColor = System.Drawing.Color.White
        Me.txtbName.Location = New System.Drawing.Point(97, 144)
        Me.txtbName.MaxLength = 100
        Me.txtbName.Name = "txtbName"
        Me.txtbName.Size = New System.Drawing.Size(100, 20)
        Me.txtbName.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(122, 128)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'txtbCIF
        '
        Me.txtbCIF.BackColor = System.Drawing.Color.White
        Me.txtbCIF.Location = New System.Drawing.Point(97, 96)
        Me.txtbCIF.MaxLength = 9
        Me.txtbCIF.Name = "txtbCIF"
        Me.txtbCIF.Size = New System.Drawing.Size(100, 20)
        Me.txtbCIF.TabIndex = 2
        '
        'lblCif
        '
        Me.lblCif.AutoSize = True
        Me.lblCif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCif.Location = New System.Drawing.Point(134, 80)
        Me.lblCif.Name = "lblCif"
        Me.lblCif.Size = New System.Drawing.Size(26, 13)
        Me.lblCif.TabIndex = 1
        Me.lblCif.Text = "CIF"
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTittle.Location = New System.Drawing.Point(107, 10)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(91, 25)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "Registro"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 528)
        Me.Controls.Add(Me.pnlRegister)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.Controls.SetChildIndex(Me.pnlRegister, 0)
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRegister As Panel
    Friend WithEvents lblTittle As Label
    Friend WithEvents txtbAddres As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtbName As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtbCIF As TextBox
    Friend WithEvents lblCif As Label
    Friend WithEvents btnRegister As Button
End Class
