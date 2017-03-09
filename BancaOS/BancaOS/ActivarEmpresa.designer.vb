<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivarEmpresa
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
        Me.pnlAE = New System.Windows.Forms.Panel()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.lvNoactive = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.pnlAE.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAE
        '
        Me.pnlAE.BackColor = System.Drawing.Color.White
        Me.pnlAE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAE.Controls.Add(Me.btnRetry)
        Me.pnlAE.Controls.Add(Me.btnActivate)
        Me.pnlAE.Controls.Add(Me.lvNoactive)
        Me.pnlAE.Controls.Add(Me.lblTittle)
        Me.pnlAE.Location = New System.Drawing.Point(162, 189)
        Me.pnlAE.Name = "pnlAE"
        Me.pnlAE.Size = New System.Drawing.Size(865, 349)
        Me.pnlAE.TabIndex = 3
        '
        'btnRetry
        '
        Me.btnRetry.Location = New System.Drawing.Point(273, 304)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(75, 23)
        Me.btnRetry.TabIndex = 3
        Me.btnRetry.Text = "Volver"
        Me.btnRetry.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(482, 304)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(75, 23)
        Me.btnActivate.TabIndex = 2
        Me.btnActivate.Text = "Activar"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'lvNoactive
        '
        Me.lvNoactive.CheckBoxes = True
        Me.lvNoactive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvNoactive.FullRowSelect = True
        Me.lvNoactive.GridLines = True
        Me.lvNoactive.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvNoactive.Location = New System.Drawing.Point(206, 78)
        Me.lvNoactive.Name = "lvNoactive"
        Me.lvNoactive.Size = New System.Drawing.Size(451, 198)
        Me.lvNoactive.TabIndex = 1
        Me.lvNoactive.UseCompatibleStateImageBehavior = False
        Me.lvNoactive.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CIF"
        Me.ColumnHeader1.Width = 185
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 259
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTittle.Location = New System.Drawing.Point(327, 15)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(215, 25)
        Me.lblTittle.TabIndex = 0
        Me.lblTittle.Text = "Empresas no Activas"
        '
        'ActivarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.pnlAE)
        Me.Name = "ActivarEmpresa"
        Me.Text = "ActivarEmpresa"
        Me.Controls.SetChildIndex(Me.pnlAE, 0)
        Me.pnlAE.ResumeLayout(False)
        Me.pnlAE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAE As Panel
    Friend WithEvents lblTittle As Label
    Friend WithEvents lvNoactive As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnActivate As Button
    Friend WithEvents btnRetry As Button
End Class
