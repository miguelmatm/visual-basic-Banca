Imports MySql.Data.MySqlClient

Public Class EmpresasMisCuentas
    Dim ad As New DataAccess
    Dim DgvMisCuentas As New DataGridView
    Dim lbtextoprimario As New Label
    Public cuentaSeleccionada As String
    Dim DgvMisCuentasControl As Boolean = True
    Dim cifEmpresa = Login.dniUsuario

    Private Sub EmpresasMisCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x, y As Short
        x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' get x
        y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height ' get y
        GbMisCuentas.Location = New Point((x / 2) - (GbMisCuentas.Size.Width / 2), (y / 2) - 140) ' GroupBox Position


        Dim con As New MySqlConnection
        Dim consulta As String
        Dim dsconsulta As DataSet

        Try
            consulta = "SELECT CC, Banco, Saldo FROM cuentas WHERE CIF_emp = '" + cifEmpresa + "'"
            dsconsulta = ad.query(consulta)

            LlbCC1.Text = dsconsulta.Tables("Users").Rows(0).Item(0).ToString
            lbbanco1.Text = dsconsulta.Tables("Users").Rows(0).Item(1).ToString
            lbsaldo1.Text = dsconsulta.Tables("Users").Rows(0).Item(2).ToString & " €"
            LlbCC2.Text = dsconsulta.Tables("Users").Rows(1).Item(0).ToString
            lbbanco2.Text = dsconsulta.Tables("Users").Rows(1).Item(1).ToString
            lbsaldo2.Text = dsconsulta.Tables("Users").Rows(1).Item(2).ToString & " €"

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al transferir los datos")
        End Try
    End Sub

    Private Sub LlbCC1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbCC1.LinkClicked
        Dim con As New MySqlConnection
        Dim consulta As String
        Dim dsconsulta As DataSet
        Dim x, y As Short
        x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' get x
        y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height ' get y

        consulta = "SELECT p.referencias ,p.fecha, p.fecha_valor, p.cantidad, p.saldo FROM operaciones p, cc_op c WHERE c.cc = '" & LlbCC1.Text & "' AND c.cod_op = p.codigo"
        dsconsulta = ad.query(consulta)

        If dsconsulta.Tables(0).Rows.Count = 0 Then
            DgvMisCuentas.Visible = False
            lbtextoprimario.Show()
            lbtextoprimario.Text = "No hay registros en esta cuenta"
            Dim prueba = lbtextoprimario.Width
            lbtextoprimario.Location = New Point((x / 2) - (157 / 2), (y / 2) + 35) ' lbtextoprimario Position
            lbtextoprimario.AutoSize = True
            Me.Controls.Add(lbtextoprimario)
        Else
            lbtextoprimario.Hide()
            DgvMisCuentas.Visible = True
            DgvMisCuentas.AutoSize = True
            DgvMisCuentas.Size = New Size(550, 101)
            DgvMisCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DgvMisCuentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DgvMisCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DgvMisCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgvMisCuentas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
            DgvMisCuentas.BorderStyle = BorderStyle.None
            DgvMisCuentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
            DgvMisCuentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            DgvMisCuentas.RowHeadersVisible = False
            DgvMisCuentas.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
            DgvMisCuentas.AllowUserToAddRows = False
            DgvMisCuentas.BackgroundColor = Color.LightGray
            DgvMisCuentas.EditMode = DataGridViewEditMode.EditProgrammatically
            DgvMisCuentas.MaximumSize = New Size(550, 101)

            Dim columnHeaderStyle As New DataGridViewCellStyle
            columnHeaderStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            DgvMisCuentas.ColumnHeadersDefaultCellStyle = columnHeaderStyle

            DgvMisCuentas.DataSource = dsconsulta.Tables(0)
            DgvMisCuentas.Location = New Point((x / 2) - (DgvMisCuentas.Size.Width / 2), (y / 2) + 35) ' DataGridView Position


            If DgvMisCuentasControl = True Then
                AddHandler DgvMisCuentas.MouseClick, AddressOf dgvMisCuentas_MouseClick
                Me.Controls.Add(DgvMisCuentas)
                DgvMisCuentasControl = False
            End If
        End If
    End Sub

    Private Sub LlbCC2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbCC2.LinkClicked
        Dim con As New MySqlConnection
        Dim consulta As String
        Dim dsconsulta As DataSet
        Dim x, y As Short
        x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' get x
        y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height ' get y

        consulta = "SELECT p.referencias ,p.fecha, p.fecha_valor, p.cantidad, p.saldo FROM operaciones p, cc_op c WHERE c.cc = '" & LlbCC2.Text & "' AND c.cod_op = p.codigo"
        dsconsulta = ad.query(consulta)

        If dsconsulta.Tables(0).Rows.Count = 0 Then
            DgvMisCuentas.Visible = False
            lbtextoprimario.Show()
            lbtextoprimario.Text = "No hay registros en esta cuenta"
            lbtextoprimario.Location = New Point((x / 2) - (157 / 2), (y / 2) + 35) ' lbtextoprimario Position
            lbtextoprimario.AutoSize = True
            Me.Controls.Add(lbtextoprimario)
        Else
            lbtextoprimario.Hide()
            DgvMisCuentas.Visible = True
            DgvMisCuentas.AutoSize = True
            DgvMisCuentas.Size = New Size(550, 101)
            DgvMisCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DgvMisCuentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DgvMisCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DgvMisCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgvMisCuentas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
            DgvMisCuentas.BorderStyle = BorderStyle.None
            DgvMisCuentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
            DgvMisCuentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            DgvMisCuentas.RowHeadersVisible = False
            DgvMisCuentas.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
            DgvMisCuentas.AllowUserToAddRows = False
            DgvMisCuentas.BackgroundColor = Color.LightGray
            DgvMisCuentas.EditMode = DataGridViewEditMode.EditProgrammatically
            DgvMisCuentas.MaximumSize = New Size(550, 101)

            Dim columnHeaderStyle As New DataGridViewCellStyle
            columnHeaderStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            DgvMisCuentas.ColumnHeadersDefaultCellStyle = columnHeaderStyle

            DgvMisCuentas.DataSource = dsconsulta.Tables(0)
            DgvMisCuentas.Location = New Point((x / 2) - (DgvMisCuentas.Size.Width / 2), (y / 2) + 35) ' DataGridView Position

            If DgvMisCuentasControl = True Then
                AddHandler DgvMisCuentas.MouseClick, AddressOf dgvMisCuentas_MouseClick
                Me.Controls.Add(DgvMisCuentas)
                DgvMisCuentasControl = False
            End If
        End If
    End Sub

    Private Sub dgvMisCuentas_MouseClick(sender As Object, e As EventArgs)
        Try
            Dim codigo As String = CStr(DgvMisCuentas.CurrentRow.Cells(0).Value)

            cuentaSeleccionada = codigo
            InformacionCuenta.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        EmpresasPaginaInicio.Show()
        Me.Close()
    End Sub
End Class