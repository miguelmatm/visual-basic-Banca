Public Class AnadirEmpresa
    Private Sub pnladd_Paint(sender As Object, e As PaintEventArgs) Handles pnlAdd.Paint

    End Sub

    Private Sub AñadirEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Code to center elements
        pnlAdd.Location = New Point((Me.Width - pnlAdd.Width) \ 2, (Me.Height - pnlAdd.Height) \ 2)
        lblTittle.Location = New Point((pnlAdd.Width - lblTittle.Width) \ 2, (lblTittle.Height))

        AccountCMB()

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim db As New DataAccess
        Dim ds As New DataSet
        Dim queryAccount1, queryAccount2, queryCompany As String
        Dim m As New Util()



        If txtbcif.Text = "" Or txtbname.Text = "" Or txtbhome.Text = "" Then
            MessageBox.Show("Debes rellenar los campos", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If m.CheckCIF(txtbcif.Text) Then
                If m.CheckIsSameAccounts(cmbaccount1.Text, cmbaccount2.Text) Then
                    queryCompany = "INSERT INTO empresas (`CIF`, `pw`, `nombre`, `domicilio`, `activa`) VALUES ('" & txtbcif.Text & "', '" & m.generatepwd(txtbcif.Text) & "' ,'" & txtbname.Text & "','" & txtbhome.Text & "', " & m.CheckCB(ckbActivate) & ")"
                    queryAccount1 = "UPDATE cuentas SET CIF_emp='" & txtbcif.Text & "', Usado = 1 WHERE CC = '" & cmbaccount1.Text & "'"
                    queryAccount2 = "UPDATE cuentas SET CIF_emp='" & txtbcif.Text & "', Usado = 1 WHERE CC = '" & cmbaccount2.Text & "'"

                    Try
                        db.cud(queryCompany)
                        db.cud(queryAccount1)
                        db.cud(queryAccount2)


                        limpiar()
                        AccountCMB()
                    Catch ex As Exception
                        MessageBox.Show("No se ha podido añadir la empresa", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                Else
                    MessageBox.Show("Debes seleccionar dos cuentas diferentes", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("El CIF es incorrecto", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        GestionarEmpresas.Show()
        Me.Close()
    End Sub

    Private Sub limpiar()
        txtbcif.Text = ""
        txtbname.Text = ""
        txtbhome.Text = ""
        ckbActivate.Checked = False
    End Sub

    Private Sub btnclean_Click(sender As Object, e As EventArgs) Handles btnclean.Click
        limpiar()
    End Sub

    Private Sub AccountCMB()
        Dim db As New DataAccess
        Dim ds, ds2 As New DataSet
        Dim query, query2 As String


        'Mostramos las cuentas que no tienen empresas
        query = "Select CC FROM cuentas WHERE CIF_emp Is NULL"
        query2 = "Select CC FROM cuentas WHERE CIF_emp Is NULL"

        ds = db.query(query)
        ds2 = db.query(query)

        cmbaccount1.DataSource = ds.Tables(0)
        cmbaccount1.DisplayMember = "CC"

        cmbaccount2.DataSource = ds2.Tables(0)
        cmbaccount2.DisplayMember = "CC"
    End Sub

End Class
