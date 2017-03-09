<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarEmpresas
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
        Me.pnlGE = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.pnlGE.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGE
        '
        Me.pnlGE.BackColor = System.Drawing.Color.White
        Me.pnlGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGE.Controls.Add(Me.btnDel)
        Me.pnlGE.Controls.Add(Me.btnEdit)
        Me.pnlGE.Controls.Add(Me.btnadd)
        Me.pnlGE.Controls.Add(Me.btnActivate)
        Me.pnlGE.Controls.Add(Me.lblTittle)
        Me.pnlGE.Location = New System.Drawing.Point(455, 227)
        Me.pnlGE.Name = "pnlGE"
        Me.pnlGE.Size = New System.Drawing.Size(334, 282)
        Me.pnlGE.TabIndex = 3
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(98, 204)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(135, 23)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "Eliminar Empresa"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(98, 165)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(135, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Modificar Empresa"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(96, 125)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(137, 23)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Añadir Empresa"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(96, 86)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(137, 23)
        Me.btnActivate.TabIndex = 5
        Me.btnActivate.Text = "Activar Empresa"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(65, 33)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(207, 25)
        Me.lblTittle.TabIndex = 4
        Me.lblTittle.Text = "Gestionar Empresas"
        '
        'GestionarEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1050)
        Me.Controls.Add(Me.pnlGE)
        Me.Name = "GestionarEmpresas"
        Me.Text = "GestionarEmpresas"
        Me.Controls.SetChildIndex(Me.pnlGE, 0)
        Me.pnlGE.ResumeLayout(False)
        Me.pnlGE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlGE As Panel
    Friend WithEvents lblTittle As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnActivate As Button
End Class
