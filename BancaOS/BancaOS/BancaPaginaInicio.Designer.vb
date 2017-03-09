<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancaPaginaInicio
    Inherits BancaOS.EmpresaInicio

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
        Me.Gbgestiones = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGesCuentas = New System.Windows.Forms.Button()
        Me.BtnGesEmpresa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnGestTrans = New System.Windows.Forms.Button()
        Me.BtnGestMov = New System.Windows.Forms.Button()
        Me.Gbgestiones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbgestiones
        '
        Me.Gbgestiones.AutoSize = True
        Me.Gbgestiones.Controls.Add(Me.GroupBox2)
        Me.Gbgestiones.Controls.Add(Me.GroupBox1)
        Me.Gbgestiones.Location = New System.Drawing.Point(181, 27)
        Me.Gbgestiones.Name = "Gbgestiones"
        Me.Gbgestiones.Size = New System.Drawing.Size(538, 202)
        Me.Gbgestiones.TabIndex = 4
        Me.Gbgestiones.TabStop = False
        Me.Gbgestiones.Text = "GESTIONES"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.BtnGesCuentas)
        Me.GroupBox2.Controls.Add(Me.BtnGesEmpresa)
        Me.GroupBox2.Location = New System.Drawing.Point(280, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 163)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Administración de la Banca"
        '
        'BtnGesCuentas
        '
        Me.BtnGesCuentas.AutoSize = True
        Me.BtnGesCuentas.Location = New System.Drawing.Point(9, 94)
        Me.BtnGesCuentas.Name = "BtnGesCuentas"
        Me.BtnGesCuentas.Size = New System.Drawing.Size(222, 50)
        Me.BtnGesCuentas.TabIndex = 2
        Me.BtnGesCuentas.Text = "Gestionar Cuentas"
        Me.BtnGesCuentas.UseVisualStyleBackColor = True
        '
        'BtnGesEmpresa
        '
        Me.BtnGesEmpresa.AutoSize = True
        Me.BtnGesEmpresa.Location = New System.Drawing.Point(9, 30)
        Me.BtnGesEmpresa.Name = "BtnGesEmpresa"
        Me.BtnGesEmpresa.Size = New System.Drawing.Size(222, 50)
        Me.BtnGesEmpresa.TabIndex = 1
        Me.BtnGesEmpresa.Text = "Gestionar Empresas"
        Me.BtnGesEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.BtnGestTrans)
        Me.GroupBox1.Controls.Add(Me.BtnGestMov)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de Cuentas"
        '
        'BtnGestTrans
        '
        Me.BtnGestTrans.AutoSize = True
        Me.BtnGestTrans.Location = New System.Drawing.Point(9, 94)
        Me.BtnGestTrans.Name = "BtnGestTrans"
        Me.BtnGestTrans.Size = New System.Drawing.Size(222, 50)
        Me.BtnGestTrans.TabIndex = 1
        Me.BtnGestTrans.Text = "Gestionar Transferencia"
        Me.BtnGestTrans.UseVisualStyleBackColor = True
        '
        'BtnGestMov
        '
        Me.BtnGestMov.AutoSize = True
        Me.BtnGestMov.Location = New System.Drawing.Point(8, 30)
        Me.BtnGestMov.Name = "BtnGestMov"
        Me.BtnGestMov.Size = New System.Drawing.Size(222, 50)
        Me.BtnGestMov.TabIndex = 0
        Me.BtnGestMov.Text = "Gestionar Movimiento"
        Me.BtnGestMov.UseVisualStyleBackColor = True
        '
        'BancaPaginaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 333)
        Me.Controls.Add(Me.Gbgestiones)
        Me.Name = "BancaPaginaInicio"
        Me.Text = "BancaPaginaInicio"
        Me.Controls.SetChildIndex(Me.Gbgestiones, 0)
        Me.Gbgestiones.ResumeLayout(False)
        Me.Gbgestiones.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gbgestiones As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnGesCuentas As Button
    Friend WithEvents BtnGesEmpresa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGestTrans As Button
    Friend WithEvents BtnGestMov As Button
End Class
