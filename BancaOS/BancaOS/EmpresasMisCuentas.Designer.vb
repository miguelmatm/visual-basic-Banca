<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresasMisCuentas
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
        Me.GbMisCuentas = New System.Windows.Forms.GroupBox()
        Me.lbsaldo2 = New System.Windows.Forms.Label()
        Me.lbbanco2 = New System.Windows.Forms.Label()
        Me.lbsaldo1 = New System.Windows.Forms.Label()
        Me.lbbanco1 = New System.Windows.Forms.Label()
        Me.LlbCC2 = New System.Windows.Forms.LinkLabel()
        Me.LlbCC1 = New System.Windows.Forms.LinkLabel()
        Me.GbMisCuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbMisCuentas
        '
        Me.GbMisCuentas.AutoSize = True
        Me.GbMisCuentas.Controls.Add(Me.lbsaldo2)
        Me.GbMisCuentas.Controls.Add(Me.lbbanco2)
        Me.GbMisCuentas.Controls.Add(Me.lbsaldo1)
        Me.GbMisCuentas.Controls.Add(Me.lbbanco1)
        Me.GbMisCuentas.Controls.Add(Me.LlbCC2)
        Me.GbMisCuentas.Controls.Add(Me.LlbCC1)
        Me.GbMisCuentas.Location = New System.Drawing.Point(201, 42)
        Me.GbMisCuentas.Name = "GbMisCuentas"
        Me.GbMisCuentas.Size = New System.Drawing.Size(550, 162)
        Me.GbMisCuentas.TabIndex = 3
        Me.GbMisCuentas.TabStop = False
        Me.GbMisCuentas.Text = "MIS CUENTAS"
        '
        'lbsaldo2
        '
        Me.lbsaldo2.AutoSize = True
        Me.lbsaldo2.Location = New System.Drawing.Point(459, 103)
        Me.lbsaldo2.Name = "lbsaldo2"
        Me.lbsaldo2.Size = New System.Drawing.Size(39, 13)
        Me.lbsaldo2.TabIndex = 5
        Me.lbsaldo2.Text = "Label4"
        '
        'lbbanco2
        '
        Me.lbbanco2.AutoSize = True
        Me.lbbanco2.Location = New System.Drawing.Point(252, 103)
        Me.lbbanco2.Name = "lbbanco2"
        Me.lbbanco2.Size = New System.Drawing.Size(39, 13)
        Me.lbbanco2.TabIndex = 4
        Me.lbbanco2.Text = "Label3"
        '
        'lbsaldo1
        '
        Me.lbsaldo1.AutoSize = True
        Me.lbsaldo1.Location = New System.Drawing.Point(459, 37)
        Me.lbsaldo1.Name = "lbsaldo1"
        Me.lbsaldo1.Size = New System.Drawing.Size(39, 13)
        Me.lbsaldo1.TabIndex = 3
        Me.lbsaldo1.Text = "Label2"
        '
        'lbbanco1
        '
        Me.lbbanco1.AutoSize = True
        Me.lbbanco1.Location = New System.Drawing.Point(252, 36)
        Me.lbbanco1.Name = "lbbanco1"
        Me.lbbanco1.Size = New System.Drawing.Size(39, 13)
        Me.lbbanco1.TabIndex = 2
        Me.lbbanco1.Text = "Label1"
        '
        'LlbCC2
        '
        Me.LlbCC2.AutoSize = True
        Me.LlbCC2.Location = New System.Drawing.Point(7, 103)
        Me.LlbCC2.Name = "LlbCC2"
        Me.LlbCC2.Size = New System.Drawing.Size(59, 13)
        Me.LlbCC2.TabIndex = 1
        Me.LlbCC2.TabStop = True
        Me.LlbCC2.Text = "LinkLabel2"
        '
        'LlbCC1
        '
        Me.LlbCC1.AutoSize = True
        Me.LlbCC1.Location = New System.Drawing.Point(7, 37)
        Me.LlbCC1.Name = "LlbCC1"
        Me.LlbCC1.Size = New System.Drawing.Size(59, 13)
        Me.LlbCC1.TabIndex = 0
        Me.LlbCC1.TabStop = True
        Me.LlbCC1.Text = "LinkLabel1"
        '
        'EmpresasMisCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 333)
        Me.Controls.Add(Me.GbMisCuentas)
        Me.Name = "EmpresasMisCuentas"
        Me.Text = "EmpresasMisCuentas"
        Me.Controls.SetChildIndex(Me.GbMisCuentas, 0)
        Me.GbMisCuentas.ResumeLayout(False)
        Me.GbMisCuentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbMisCuentas As GroupBox
    Friend WithEvents lbsaldo2 As Label
    Friend WithEvents lbbanco2 As Label
    Friend WithEvents lbsaldo1 As Label
    Friend WithEvents lbbanco1 As Label
    Friend WithEvents LlbCC2 As LinkLabel
    Friend WithEvents LlbCC1 As LinkLabel
End Class
