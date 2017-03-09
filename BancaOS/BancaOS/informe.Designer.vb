<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class informe
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
        Me.BancaonlineDataSet1 = New BancaOS.bancaonlineDataSet1()
        Me.OperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperacionesTableAdapter = New BancaOS.bancaonlineDataSet1TableAdapters.operacionesTableAdapter()
        Me.TableAdapterManager = New BancaOS.bancaonlineDataSet1TableAdapters.TableAdapterManager()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.BancaonlineDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BancaonlineDataSet1
        '
        Me.BancaonlineDataSet1.DataSetName = "bancaonlineDataSet1"
        Me.BancaonlineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperacionesBindingSource
        '
        Me.OperacionesBindingSource.DataMember = "operaciones"
        Me.OperacionesBindingSource.DataSource = Me.BancaonlineDataSet1
        '
        'OperacionesTableAdapter
        '
        Me.OperacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancosTableAdapter = Nothing
        Me.TableAdapterManager.cc_opTableAdapter = Nothing
        Me.TableAdapterManager.cuentasTableAdapter = Nothing
        Me.TableAdapterManager.empresasTableAdapter = Nothing
        Me.TableAdapterManager.operacionesTableAdapter = Me.OperacionesTableAdapter
        Me.TableAdapterManager.transfperiodTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BancaOS.bancaonlineDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(445, 350)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'informe
        '
        Me.ClientSize = New System.Drawing.Size(445, 350)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "informe"
        CType(Me.BancaonlineDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BancaonlineDataSet1 As bancaonlineDataSet1
    Friend WithEvents OperacionesBindingSource As BindingSource
    Friend WithEvents OperacionesTableAdapter As bancaonlineDataSet1TableAdapters.operacionesTableAdapter
    Friend WithEvents TableAdapterManager As bancaonlineDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
