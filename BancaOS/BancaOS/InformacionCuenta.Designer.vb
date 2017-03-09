<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacionCuenta
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
        Me.LbTFecha = New System.Windows.Forms.Label()
        Me.LbTFechaValor = New System.Windows.Forms.Label()
        Me.LbTRemitente = New System.Windows.Forms.Label()
        Me.LbTReferencia = New System.Windows.Forms.Label()
        Me.LbTPeriodica = New System.Windows.Forms.Label()
        Me.LbTConcepto = New System.Windows.Forms.Label()
        Me.LbTConceptoExt = New System.Windows.Forms.Label()
        Me.LbTCantidad = New System.Windows.Forms.Label()
        Me.LbCantidad = New System.Windows.Forms.Label()
        Me.LbConceptoExt = New System.Windows.Forms.Label()
        Me.LbConcepto = New System.Windows.Forms.Label()
        Me.LbPeriodica = New System.Windows.Forms.Label()
        Me.LbReferencia = New System.Windows.Forms.Label()
        Me.LbRemitente = New System.Windows.Forms.Label()
        Me.LbFechaValor = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.btnInforme = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbTFecha
        '
        Me.LbTFecha.AutoSize = True
        Me.LbTFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTFecha.Location = New System.Drawing.Point(47, 65)
        Me.LbTFecha.Name = "LbTFecha"
        Me.LbTFecha.Size = New System.Drawing.Size(59, 18)
        Me.LbTFecha.TabIndex = 0
        Me.LbTFecha.Text = "Fecha:"
        '
        'LbTFechaValor
        '
        Me.LbTFechaValor.AutoSize = True
        Me.LbTFechaValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTFechaValor.Location = New System.Drawing.Point(47, 103)
        Me.LbTFechaValor.Name = "LbTFechaValor"
        Me.LbTFechaValor.Size = New System.Drawing.Size(103, 18)
        Me.LbTFechaValor.TabIndex = 1
        Me.LbTFechaValor.Text = "Fecha Valor:"
        '
        'LbTRemitente
        '
        Me.LbTRemitente.AutoSize = True
        Me.LbTRemitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTRemitente.Location = New System.Drawing.Point(47, 141)
        Me.LbTRemitente.Name = "LbTRemitente"
        Me.LbTRemitente.Size = New System.Drawing.Size(89, 18)
        Me.LbTRemitente.TabIndex = 2
        Me.LbTRemitente.Text = "Remitente:"
        '
        'LbTReferencia
        '
        Me.LbTReferencia.AutoSize = True
        Me.LbTReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTReferencia.Location = New System.Drawing.Point(47, 183)
        Me.LbTReferencia.Name = "LbTReferencia"
        Me.LbTReferencia.Size = New System.Drawing.Size(94, 18)
        Me.LbTReferencia.TabIndex = 3
        Me.LbTReferencia.Text = "Referencia:"
        '
        'LbTPeriodica
        '
        Me.LbTPeriodica.AutoSize = True
        Me.LbTPeriodica.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTPeriodica.Location = New System.Drawing.Point(320, 65)
        Me.LbTPeriodica.Name = "LbTPeriodica"
        Me.LbTPeriodica.Size = New System.Drawing.Size(84, 18)
        Me.LbTPeriodica.TabIndex = 4
        Me.LbTPeriodica.Text = "Periódica:"
        '
        'LbTConcepto
        '
        Me.LbTConcepto.AutoSize = True
        Me.LbTConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTConcepto.Location = New System.Drawing.Point(320, 103)
        Me.LbTConcepto.Name = "LbTConcepto"
        Me.LbTConcepto.Size = New System.Drawing.Size(86, 18)
        Me.LbTConcepto.TabIndex = 5
        Me.LbTConcepto.Text = "Concepto:"
        '
        'LbTConceptoExt
        '
        Me.LbTConceptoExt.AutoSize = True
        Me.LbTConceptoExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTConceptoExt.Location = New System.Drawing.Point(320, 141)
        Me.LbTConceptoExt.Name = "LbTConceptoExt"
        Me.LbTConceptoExt.Size = New System.Drawing.Size(165, 18)
        Me.LbTConceptoExt.TabIndex = 6
        Me.LbTConceptoExt.Text = "Concepto Extendido:"
        '
        'LbTCantidad
        '
        Me.LbTCantidad.AutoSize = True
        Me.LbTCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTCantidad.Location = New System.Drawing.Point(320, 183)
        Me.LbTCantidad.Name = "LbTCantidad"
        Me.LbTCantidad.Size = New System.Drawing.Size(79, 18)
        Me.LbTCantidad.TabIndex = 7
        Me.LbTCantidad.Text = "Cantidad:"
        '
        'LbCantidad
        '
        Me.LbCantidad.AutoSize = True
        Me.LbCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantidad.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbCantidad.Location = New System.Drawing.Point(484, 185)
        Me.LbCantidad.Name = "LbCantidad"
        Me.LbCantidad.Size = New System.Drawing.Size(74, 16)
        Me.LbCantidad.TabIndex = 15
        Me.LbCantidad.Text = "Cantidad:"
        '
        'LbConceptoExt
        '
        Me.LbConceptoExt.AutoSize = True
        Me.LbConceptoExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConceptoExt.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbConceptoExt.Location = New System.Drawing.Point(484, 143)
        Me.LbConceptoExt.Name = "LbConceptoExt"
        Me.LbConceptoExt.Size = New System.Drawing.Size(151, 16)
        Me.LbConceptoExt.TabIndex = 14
        Me.LbConceptoExt.Text = "Concepto Extendido:"
        '
        'LbConcepto
        '
        Me.LbConcepto.AutoSize = True
        Me.LbConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConcepto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbConcepto.Location = New System.Drawing.Point(484, 105)
        Me.LbConcepto.Name = "LbConcepto"
        Me.LbConcepto.Size = New System.Drawing.Size(78, 16)
        Me.LbConcepto.TabIndex = 13
        Me.LbConcepto.Text = "Concepto:"
        '
        'LbPeriodica
        '
        Me.LbPeriodica.AutoSize = True
        Me.LbPeriodica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPeriodica.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbPeriodica.Location = New System.Drawing.Point(484, 67)
        Me.LbPeriodica.Name = "LbPeriodica"
        Me.LbPeriodica.Size = New System.Drawing.Size(79, 16)
        Me.LbPeriodica.TabIndex = 12
        Me.LbPeriodica.Text = "Periódica:"
        '
        'LbReferencia
        '
        Me.LbReferencia.AutoSize = True
        Me.LbReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReferencia.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbReferencia.Location = New System.Drawing.Point(169, 185)
        Me.LbReferencia.Name = "LbReferencia"
        Me.LbReferencia.Size = New System.Drawing.Size(88, 16)
        Me.LbReferencia.TabIndex = 11
        Me.LbReferencia.Text = "Referencia:"
        '
        'LbRemitente
        '
        Me.LbRemitente.AutoSize = True
        Me.LbRemitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRemitente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbRemitente.Location = New System.Drawing.Point(169, 143)
        Me.LbRemitente.Name = "LbRemitente"
        Me.LbRemitente.Size = New System.Drawing.Size(82, 16)
        Me.LbRemitente.TabIndex = 10
        Me.LbRemitente.Text = "Remitente:"
        '
        'LbFechaValor
        '
        Me.LbFechaValor.AutoSize = True
        Me.LbFechaValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaValor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbFechaValor.Location = New System.Drawing.Point(169, 105)
        Me.LbFechaValor.Name = "LbFechaValor"
        Me.LbFechaValor.Size = New System.Drawing.Size(96, 16)
        Me.LbFechaValor.TabIndex = 9
        Me.LbFechaValor.Text = "Fecha Valor:"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbFecha.Location = New System.Drawing.Point(169, 67)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(55, 16)
        Me.LbFecha.TabIndex = 8
        Me.LbFecha.Text = "Fecha:"
        '
        'btnInforme
        '
        Me.btnInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInforme.Location = New System.Drawing.Point(440, 254)
        Me.btnInforme.Name = "btnInforme"
        Me.btnInforme.Size = New System.Drawing.Size(153, 30)
        Me.btnInforme.TabIndex = 25
        Me.btnInforme.Text = "Imprimir Informe"
        Me.btnInforme.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(172, 254)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(112, 30)
        Me.BtnVolver.TabIndex = 24
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'InformacionCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(753, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInforme)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LbCantidad)
        Me.Controls.Add(Me.LbConceptoExt)
        Me.Controls.Add(Me.LbConcepto)
        Me.Controls.Add(Me.LbPeriodica)
        Me.Controls.Add(Me.LbReferencia)
        Me.Controls.Add(Me.LbRemitente)
        Me.Controls.Add(Me.LbFechaValor)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.LbTCantidad)
        Me.Controls.Add(Me.LbTConceptoExt)
        Me.Controls.Add(Me.LbTConcepto)
        Me.Controls.Add(Me.LbTPeriodica)
        Me.Controls.Add(Me.LbTReferencia)
        Me.Controls.Add(Me.LbTRemitente)
        Me.Controls.Add(Me.LbTFechaValor)
        Me.Controls.Add(Me.LbTFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InformacionCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InformacionCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTFecha As Label
    Friend WithEvents LbTFechaValor As Label
    Friend WithEvents LbTRemitente As Label
    Friend WithEvents LbTReferencia As Label
    Friend WithEvents LbTPeriodica As Label
    Friend WithEvents LbTConcepto As Label
    Friend WithEvents LbTConceptoExt As Label
    Friend WithEvents LbTCantidad As Label
    Friend WithEvents LbCantidad As Label
    Friend WithEvents LbConceptoExt As Label
    Friend WithEvents LbConcepto As Label
    Friend WithEvents LbPeriodica As Label
    Friend WithEvents LbReferencia As Label
    Friend WithEvents LbRemitente As Label
    Friend WithEvents LbFechaValor As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents btnInforme As Button
    Friend WithEvents BtnVolver As Button
End Class
