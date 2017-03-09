<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transferencias
    Inherits EmpresaInicio

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbEmpresaOrigen = New System.Windows.Forms.Label()
        Me.lbCuentaOrigen = New System.Windows.Forms.Label()
        Me.lbCuentaDestino = New System.Windows.Forms.Label()
        Me.lbEmpresaDestino = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbPeriodica = New System.Windows.Forms.Label()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.lbRemitente = New System.Windows.Forms.Label()
        Me.lbConceptoExtendido = New System.Windows.Forms.Label()
        Me.lbDomiciliacionMasiva = New System.Windows.Forms.Label()
        Me.lbConcepto = New System.Windows.Forms.Label()
        Me.cbEmpresaOrigen = New System.Windows.Forms.ComboBox()
        Me.cbCuentaOrigen = New System.Windows.Forms.ComboBox()
        Me.cbCuentaDestino = New System.Windows.Forms.ComboBox()
        Me.cbEmpresaDestino = New System.Windows.Forms.ComboBox()
        Me.cbConcepto = New System.Windows.Forms.ComboBox()
        Me.cbPeriodica = New System.Windows.Forms.ComboBox()
        Me.tbRemitente = New System.Windows.Forms.TextBox()
        Me.tbConceptoExtendido = New System.Windows.Forms.TextBox()
        Me.chbDomiciliacionMasiva = New System.Windows.Forms.CheckBox()
        Me.btEnviar = New System.Windows.Forms.Button()
        Me.mtbFecha = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.btnretry = New System.Windows.Forms.Button()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbEmpresaOrigen
        '
        Me.lbEmpresaOrigen.AutoSize = True
        Me.lbEmpresaOrigen.Location = New System.Drawing.Point(36, 77)
        Me.lbEmpresaOrigen.Name = "lbEmpresaOrigen"
        Me.lbEmpresaOrigen.Size = New System.Drawing.Size(85, 13)
        Me.lbEmpresaOrigen.TabIndex = 0
        Me.lbEmpresaOrigen.Text = "Empresa Origen:"
        '
        'lbCuentaOrigen
        '
        Me.lbCuentaOrigen.AutoSize = True
        Me.lbCuentaOrigen.Location = New System.Drawing.Point(36, 111)
        Me.lbCuentaOrigen.Name = "lbCuentaOrigen"
        Me.lbCuentaOrigen.Size = New System.Drawing.Size(78, 13)
        Me.lbCuentaOrigen.TabIndex = 0
        Me.lbCuentaOrigen.Text = "Cuenta Origen:"
        '
        'lbCuentaDestino
        '
        Me.lbCuentaDestino.AutoSize = True
        Me.lbCuentaDestino.Location = New System.Drawing.Point(36, 178)
        Me.lbCuentaDestino.Name = "lbCuentaDestino"
        Me.lbCuentaDestino.Size = New System.Drawing.Size(83, 13)
        Me.lbCuentaDestino.TabIndex = 0
        Me.lbCuentaDestino.Text = "Cuenta Destino:"
        '
        'lbEmpresaDestino
        '
        Me.lbEmpresaDestino.AutoSize = True
        Me.lbEmpresaDestino.Location = New System.Drawing.Point(36, 148)
        Me.lbEmpresaDestino.Name = "lbEmpresaDestino"
        Me.lbEmpresaDestino.Size = New System.Drawing.Size(90, 13)
        Me.lbEmpresaDestino.TabIndex = 0
        Me.lbEmpresaDestino.Text = "Empresa Destino:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(314, 159)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(40, 13)
        Me.lbFecha.TabIndex = 0
        Me.lbFecha.Text = "Fecha:"
        '
        'lbPeriodica
        '
        Me.lbPeriodica.AutoSize = True
        Me.lbPeriodica.Location = New System.Drawing.Point(314, 133)
        Me.lbPeriodica.Name = "lbPeriodica"
        Me.lbPeriodica.Size = New System.Drawing.Size(51, 13)
        Me.lbPeriodica.TabIndex = 0
        Me.lbPeriodica.Text = "Periodica"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(314, 106)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbCantidad.TabIndex = 0
        Me.lbCantidad.Text = "Cantidad"
        '
        'lbRemitente
        '
        Me.lbRemitente.AutoSize = True
        Me.lbRemitente.Location = New System.Drawing.Point(314, 74)
        Me.lbRemitente.Name = "lbRemitente"
        Me.lbRemitente.Size = New System.Drawing.Size(58, 13)
        Me.lbRemitente.TabIndex = 0
        Me.lbRemitente.Text = "Remitente:"
        '
        'lbConceptoExtendido
        '
        Me.lbConceptoExtendido.AutoSize = True
        Me.lbConceptoExtendido.Location = New System.Drawing.Point(314, 220)
        Me.lbConceptoExtendido.Name = "lbConceptoExtendido"
        Me.lbConceptoExtendido.Size = New System.Drawing.Size(106, 13)
        Me.lbConceptoExtendido.TabIndex = 0
        Me.lbConceptoExtendido.Text = "Concepto Extendido:"
        '
        'lbDomiciliacionMasiva
        '
        Me.lbDomiciliacionMasiva.AutoSize = True
        Me.lbDomiciliacionMasiva.Location = New System.Drawing.Point(36, 219)
        Me.lbDomiciliacionMasiva.Name = "lbDomiciliacionMasiva"
        Me.lbDomiciliacionMasiva.Size = New System.Drawing.Size(109, 13)
        Me.lbDomiciliacionMasiva.TabIndex = 0
        Me.lbDomiciliacionMasiva.Text = "Domiciliacion Masiva:"
        '
        'lbConcepto
        '
        Me.lbConcepto.AutoSize = True
        Me.lbConcepto.Location = New System.Drawing.Point(314, 190)
        Me.lbConcepto.Name = "lbConcepto"
        Me.lbConcepto.Size = New System.Drawing.Size(56, 13)
        Me.lbConcepto.TabIndex = 0
        Me.lbConcepto.Text = "Concepto:"
        '
        'cbEmpresaOrigen
        '
        Me.cbEmpresaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresaOrigen.FormattingEnabled = True
        Me.cbEmpresaOrigen.Items.AddRange(New Object() {"Ninguna"})
        Me.cbEmpresaOrigen.Location = New System.Drawing.Point(156, 74)
        Me.cbEmpresaOrigen.MaxDropDownItems = 6
        Me.cbEmpresaOrigen.Name = "cbEmpresaOrigen"
        Me.cbEmpresaOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cbEmpresaOrigen.TabIndex = 1
        '
        'cbCuentaOrigen
        '
        Me.cbCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaOrigen.Enabled = False
        Me.cbCuentaOrigen.FormattingEnabled = True
        Me.cbCuentaOrigen.Location = New System.Drawing.Point(156, 108)
        Me.cbCuentaOrigen.MaxDropDownItems = 6
        Me.cbCuentaOrigen.Name = "cbCuentaOrigen"
        Me.cbCuentaOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cbCuentaOrigen.TabIndex = 2
        '
        'cbCuentaDestino
        '
        Me.cbCuentaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaDestino.Enabled = False
        Me.cbCuentaDestino.FormattingEnabled = True
        Me.cbCuentaDestino.Location = New System.Drawing.Point(156, 175)
        Me.cbCuentaDestino.MaxDropDownItems = 6
        Me.cbCuentaDestino.Name = "cbCuentaDestino"
        Me.cbCuentaDestino.Size = New System.Drawing.Size(121, 21)
        Me.cbCuentaDestino.TabIndex = 4
        '
        'cbEmpresaDestino
        '
        Me.cbEmpresaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresaDestino.FormattingEnabled = True
        Me.cbEmpresaDestino.Items.AddRange(New Object() {"Ninguna"})
        Me.cbEmpresaDestino.Location = New System.Drawing.Point(156, 142)
        Me.cbEmpresaDestino.MaxDropDownItems = 6
        Me.cbEmpresaDestino.Name = "cbEmpresaDestino"
        Me.cbEmpresaDestino.Size = New System.Drawing.Size(121, 21)
        Me.cbEmpresaDestino.TabIndex = 3
        '
        'cbConcepto
        '
        Me.cbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConcepto.FormattingEnabled = True
        Me.cbConcepto.Location = New System.Drawing.Point(434, 187)
        Me.cbConcepto.Name = "cbConcepto"
        Me.cbConcepto.Size = New System.Drawing.Size(121, 21)
        Me.cbConcepto.TabIndex = 9
        '
        'cbPeriodica
        '
        Me.cbPeriodica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodica.FormattingEnabled = True
        Me.cbPeriodica.Location = New System.Drawing.Point(434, 127)
        Me.cbPeriodica.MaxDropDownItems = 6
        Me.cbPeriodica.Name = "cbPeriodica"
        Me.cbPeriodica.Size = New System.Drawing.Size(121, 21)
        Me.cbPeriodica.TabIndex = 7
        '
        'tbRemitente
        '
        Me.tbRemitente.Location = New System.Drawing.Point(434, 71)
        Me.tbRemitente.Name = "tbRemitente"
        Me.tbRemitente.Size = New System.Drawing.Size(121, 20)
        Me.tbRemitente.TabIndex = 5
        '
        'tbConceptoExtendido
        '
        Me.tbConceptoExtendido.Location = New System.Drawing.Point(434, 217)
        Me.tbConceptoExtendido.Multiline = True
        Me.tbConceptoExtendido.Name = "tbConceptoExtendido"
        Me.tbConceptoExtendido.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbConceptoExtendido.Size = New System.Drawing.Size(121, 62)
        Me.tbConceptoExtendido.TabIndex = 11
        '
        'chbDomiciliacionMasiva
        '
        Me.chbDomiciliacionMasiva.AutoSize = True
        Me.chbDomiciliacionMasiva.Location = New System.Drawing.Point(156, 219)
        Me.chbDomiciliacionMasiva.Name = "chbDomiciliacionMasiva"
        Me.chbDomiciliacionMasiva.Size = New System.Drawing.Size(15, 14)
        Me.chbDomiciliacionMasiva.TabIndex = 10
        Me.chbDomiciliacionMasiva.UseVisualStyleBackColor = True
        '
        'btEnviar
        '
        Me.btEnviar.Location = New System.Drawing.Point(399, 313)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btEnviar.TabIndex = 12
        Me.btEnviar.Text = "Enviar"
        Me.btEnviar.UseVisualStyleBackColor = True
        '
        'mtbFecha
        '
        Me.mtbFecha.Location = New System.Drawing.Point(434, 156)
        Me.mtbFecha.Mask = "00-00-0000"
        Me.mtbFecha.Name = "mtbFecha"
        Me.mtbFecha.Size = New System.Drawing.Size(121, 20)
        Me.mtbFecha.TabIndex = 8
        Me.mtbFecha.ValidatingType = GetType(Date)
        '
        'mtbCantidad
        '
        Me.mtbCantidad.BeepOnError = True
        Me.mtbCantidad.Location = New System.Drawing.Point(434, 97)
        Me.mtbCantidad.Mask = "999999999999,99"
        Me.mtbCantidad.Name = "mtbCantidad"
        Me.mtbCantidad.Size = New System.Drawing.Size(121, 20)
        Me.mtbCantidad.TabIndex = 6
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.White
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.btnretry)
        Me.pnl.Controls.Add(Me.lblTittle)
        Me.pnl.Controls.Add(Me.lbEmpresaOrigen)
        Me.pnl.Controls.Add(Me.mtbCantidad)
        Me.pnl.Controls.Add(Me.lbCuentaOrigen)
        Me.pnl.Controls.Add(Me.mtbFecha)
        Me.pnl.Controls.Add(Me.lbEmpresaDestino)
        Me.pnl.Controls.Add(Me.btEnviar)
        Me.pnl.Controls.Add(Me.lbCuentaDestino)
        Me.pnl.Controls.Add(Me.chbDomiciliacionMasiva)
        Me.pnl.Controls.Add(Me.lbRemitente)
        Me.pnl.Controls.Add(Me.tbConceptoExtendido)
        Me.pnl.Controls.Add(Me.lbCantidad)
        Me.pnl.Controls.Add(Me.tbRemitente)
        Me.pnl.Controls.Add(Me.lbPeriodica)
        Me.pnl.Controls.Add(Me.cbConcepto)
        Me.pnl.Controls.Add(Me.lbFecha)
        Me.pnl.Controls.Add(Me.cbPeriodica)
        Me.pnl.Controls.Add(Me.lbConcepto)
        Me.pnl.Controls.Add(Me.cbCuentaDestino)
        Me.pnl.Controls.Add(Me.lbDomiciliacionMasiva)
        Me.pnl.Controls.Add(Me.cbEmpresaDestino)
        Me.pnl.Controls.Add(Me.lbConceptoExtendido)
        Me.pnl.Controls.Add(Me.cbCuentaOrigen)
        Me.pnl.Controls.Add(Me.cbEmpresaOrigen)
        Me.pnl.Location = New System.Drawing.Point(162, 92)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(592, 362)
        Me.pnl.TabIndex = 13
        '
        'btnretry
        '
        Me.btnretry.Location = New System.Drawing.Point(96, 313)
        Me.btnretry.Name = "btnretry"
        Me.btnretry.Size = New System.Drawing.Size(75, 23)
        Me.btnretry.TabIndex = 14
        Me.btnretry.Text = "Volver"
        Me.btnretry.UseVisualStyleBackColor = True
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(92, 0)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(156, 25)
        Me.lblTittle.TabIndex = 13
        Me.lblTittle.Text = "Transferencias"
        '
        'Transferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 633)
        Me.Controls.Add(Me.pnl)
        Me.Name = "Transferencias"
        Me.Text = "Transferencias"
        Me.Controls.SetChildIndex(Me.pnl, 0)
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbEmpresaOrigen As Label
    Friend WithEvents lbCuentaOrigen As Label
    Friend WithEvents lbCuentaDestino As Label
    Friend WithEvents lbEmpresaDestino As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents lbPeriodica As Label
    Friend WithEvents lbCantidad As Label
    Friend WithEvents lbRemitente As Label
    Friend WithEvents lbConceptoExtendido As Label
    Friend WithEvents lbDomiciliacionMasiva As Label
    Friend WithEvents lbConcepto As Label
    Friend WithEvents cbEmpresaOrigen As ComboBox
    Friend WithEvents cbCuentaOrigen As ComboBox
    Friend WithEvents cbCuentaDestino As ComboBox
    Friend WithEvents cbEmpresaDestino As ComboBox
    Friend WithEvents cbConcepto As ComboBox
    Friend WithEvents cbPeriodica As ComboBox
    Friend WithEvents tbRemitente As TextBox
    Friend WithEvents tbConceptoExtendido As TextBox
    Friend WithEvents chbDomiciliacionMasiva As CheckBox

    Friend WithEvents btEnviar As Button
    Friend WithEvents mtbFecha As MaskedTextBox
    Friend WithEvents mtbCantidad As MaskedTextBox
    Friend WithEvents pnl As Panel
    Friend WithEvents lblTittle As Label
    Friend WithEvents btnretry As Button
End Class
