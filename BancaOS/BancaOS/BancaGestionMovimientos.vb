Public Class BancaGestionMovimientos

    Dim ad As New DataAccess
    Public cuentaSeleccionada As String

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.Location = New Point((Me.Width - Panel1.Width) / 2, (200))
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel2.Location = New Point((Me.Width - Panel2.Width) / 2, (400))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Location = New Point((Panel2.Width - DataGridView1.Width) / 2, (Panel2.Height - DataGridView1.Height) / 2)
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        BancaPaginaInicio.Show()
        Me.Hide()
    End Sub

    Private Sub BancaGestionMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String
        Dim dsConsulta As DataSet

        consulta = "select nombre from empresas"
        dsConsulta = ad.query(consulta)

        For Each row As DataRow In dsConsulta.Tables(0).Rows
            Dim nombre As String = row("nombre")
            ComboBox1.Items.Add(nombre)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        Dim empresa = ComboBox1.SelectedItem.ToString()
        Dim DsConsulta As DataSet
        Dim consulta = "select cc from cuentas where cif_emp = (select cif from empresas where nombre = '" + empresa + "')"
        DsConsulta = ad.query(consulta)

        For Each row As DataRow In DsConsulta.Tables(0).Rows
            Dim cc As String = row("cc")
            ComboBox2.Items.Add(cc)
        Next
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim dsDatos As DataSet

        If Not (ComboBox1.SelectedItem Is Nothing Or ComboBox2.SelectedItem Is Nothing) Then
            Dim consulta = "SELECT referencias ,fecha, fecha_valor, cantidad, saldo from operaciones where codigo IN (select cod_op from cc_op where cc='" + ComboBox2.SelectedItem.ToString + "')"
            dsDatos = ad.query(consulta)

            If dsDatos.Tables(0).Rows.Count() = 0 Then
                MessageBox.Show("No hay datos de esta cuenta", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DataGridView1.DataSource = ""
            Else
                DataGridView1.AutoSize = True
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
                DataGridView1.BorderStyle = BorderStyle.None
                DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
                DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
                DataGridView1.RowHeadersVisible = False
                DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
                DataGridView1.AllowUserToAddRows = False
                DataGridView1.BackgroundColor = Color.LightGray
                DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
                DataGridView1.MaximumSize = New Size(940, 135)
                DataGridView1.DataSource = dsDatos.Tables(0)

                AddHandler DataGridView1.MouseClick, AddressOf dgvMisCuentas_MouseClick

                Panel2.Show()
            End If
        Else
            DataGridView1.DataSource = ""
        End If
    End Sub

    Private Sub dgvMisCuentas_MouseClick(sender As Object, e As EventArgs)
        Try
            Dim codigo As String = CStr(DataGridView1.CurrentRow.Cells(0).Value)

            cuentaSeleccionada = codigo
            InformacionCuenta.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub


End Class