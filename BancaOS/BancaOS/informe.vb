Public Class informe
    Dim referencia As String = InformacionCuenta.DSReferencia

    Private Sub informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BancaonlineDataSet1.operaciones' table. You can move, or remove it, as needed.
        Me.OperacionesTableAdapter.Fill(Me.BancaonlineDataSet1.operaciones)
        Me.OperacionesTableAdapter.FillByReferencia(Me.BancaonlineDataSet1.operaciones, referencia)

        Dim rpt As New InformeCR()
        rpt.SetDataSource(BancaonlineDataSet1)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub OperacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OperacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancaonlineDataSet1)

    End Sub
End Class