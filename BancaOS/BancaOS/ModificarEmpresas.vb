Public Class ModificarEmpresas
    Dim Errorcuenta As Boolean = False

    Private Sub ModificarEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Code to center elements
        pnlModify.Location = New Point((Me.Width - pnlModify.Width) \ 2, (Me.Height - pnlModify.Height) \ 2)
        lblTittle.Location = New Point((pnlModify.Width - lblTittle.Width) \ 2, (lblTittle.Height))

        UpdateComp()
    End Sub

    Private Sub UpdateComp()
        Dim db As New DataAccess
        Dim ds As New DataSet
        Dim query As String

        'Mostramos empresas
        query = "SELECT CIF, nombre FROM empresas"

        ds = db.query(query)

        cmbComparny.DataSource = ds.Tables(0)
        cmbComparny.DisplayMember = "nombre"
        cmbComparny.ValueMember = "CIF"
        cmbComparny.SelectedIndex = -1
    End Sub


    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim db As New DataAccess
        Dim ds, dscheck As New DataSet
        Dim query, checkcc, queryupdateacount1, queryupdateacount2, queryaddacount1, queryaddacount2, querydlt As String
        Dim m As New Util()

        If txtbName.Text = "" Or txtbHome.Text = "" Or checkAccountIsValid() = False Then
            If Errorcuenta = True Then
                MessageBox.Show("Error en la cuenta", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Compruebe que ha rellenado los campos correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Errorcuenta = False
        Else

            query = "UPDATE empresas SET nombre='" & txtbName.Text & "', domicilio='" & txtbHome.Text & "',`activa`= " & m.CheckCB(ckActivate) & " WHERE CIF = '" & txtbcif.Text & "'"
            db.cud(query)

            checkcc = "SELECT CC FROM cuentas WHERE CIF_emp = '" & cmbComparny.SelectedValue.ToString() & "'"

            dscheck = db.query(checkcc)

            If dscheck.Tables(0).Rows.Count = 0 Then
                If txtbAcount1.Tag = 1 And txtbAcount2.Tag = 1 Then
                    Try
                        queryaddacount1 = "UPDATE cuentas SET CIF_emp='" & txtbcif.Text & "', Usado = 1 WHERE CC = '" & txtbAcount1.Text & "'"
                        queryaddacount2 = "UPDATE cuentas SET CIF_emp='" & txtbcif.Text & "', Usado = 1 WHERE CC = '" & txtbAcount2.Text & "'"

                        db.cud(queryaddacount1)
                        db.cud(queryaddacount2)

                        MessageBox.Show("Cuentas Añadidas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clean()
                        UpdateComp()
                    Catch ex As Exception
                        MessageBox.Show("No se han podido añadir las cuentas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                End If
            Else
                Try

                    queryupdateacount1 = "UPDATE cuentas SET CIF_emp='" & txtbcif.Text & "', Usado = 1 WHERE CC = '" & txtbAcount1.Text & "'"
                    queryupdateacount2 = "UPDATE cuentas SET CIF_emp='" & txtbcif.Text & "', Usado = 1 WHERE CC = '" & txtbAcount2.Text & "'"

                    db.cud(queryupdateacount1)
                    db.cud(queryupdateacount2)

                    querydlt = "UPDATE cuentas SET CIF_EMP = NULL, Usado = 0 WHERE CIF_EMP = '" & txtbcif.Text & "' AND (CC <> '" & txtbAcount1.Text & "' AND CC <> '" & txtbAcount2.Text & "')"
                    db.cud(querydlt)

                    MessageBox.Show("Cuentas actualizadas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clean()
                    UpdateComp()
                Catch ex As Exception
                    MessageBox.Show("Error al actualizar cuentas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Function checkAccountIsValid()
        Dim db As New DataAccess
        Dim ds, ds2 As New DataSet
        Dim dscompany, dsaccounts As New DataSet
        Dim query, query2 As String
        Dim tienecif1, tienecif2, esnumerico, res As Boolean

        If IsNumeric(txtbAcount1.Text) And IsNumeric(txtbAcount2.Text) Then

            Try
                esnumerico = True

                query = "Select CIF_EMP from cuentas WHERE CC = '" & txtbAcount1.Text & "'"
                query2 = "Select CIF_EMP from cuentas WHERE CC = '" & txtbAcount2.Text & "'"

                ds = db.query(query)
                ds2 = db.query(query2)

                If (ds.Tables(0).Rows(0).Item(0).ToString = "" Or ds.Tables(0).Rows(0).Item(0).ToString = txtbcif.Text) Then
                    tienecif1 = True
                Else
                    tienecif1 = False
                End If

                If (ds2.Tables(0).Rows(0).Item(0).ToString = "" Or ds2.Tables(0).Rows(0).Item(0).ToString = txtbcif.Text) Then
                    tienecif2 = True
                Else
                    tienecif2 = False
                End If

            Catch ex As Exception
                Errorcuenta = True
            End Try
        Else
            tienecif1 = False
            tienecif2 = False
            esnumerico = False
        End If

        If tienecif1 And tienecif2 And esnumerico Then
            res = True
        Else
            res = False
        End If

        Return res
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GestionarEmpresas.Show()
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim db As New DataAccess
        Dim dscompany, dsaccounts As New DataSet
        Dim queryCompany, queryaccount As String


        If (cmbComparny.SelectedIndex = -1) Then
            'Nothing
        Else
            Try
                queryCompany = "Select * from empresas where CIF = '" & cmbComparny.SelectedValue.ToString() & "'"
                queryaccount = "SELECT CC FROM cuentas WHERE CIF_emp = '" & cmbComparny.SelectedValue.ToString() & "'"

                dscompany = db.query(queryCompany)
                dsaccounts = db.query(queryaccount)

                If dsaccounts.Tables(0).Rows.Count = 0 Then
                    txtbAcount1.Text = "Aún no tiene cuenta"
                    txtbAcount2.Text = "Aún no tiene cuenta"

                Else
                    txtbAcount1.Text = dsaccounts.Tables(0).Rows(0).Item(0).ToString
                    txtbAcount2.Text = dsaccounts.Tables(0).Rows(1).Item(0).ToString
                    txtbAcount1.Tag = 1
                    txtbAcount2.Tag = 1

                End If

                txtbcif.Text = dscompany.Tables(0).Rows(0).Item(0).ToString
                txtbHome.Text = dscompany.Tables(0).Rows(0).Item(3).ToString
                txtbName.Text = dscompany.Tables(0).Rows(0).Item(2).ToString



                ckActivate.Checked = False
                If dscompany.Tables(0).Rows(0).Item(4).ToString = 1 Then
                    ckActivate.Checked = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar las empresas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub btnclean_Click(sender As Object, e As EventArgs) Handles btnclean.Click
        clean()
    End Sub

    Private Sub clean()
        cmbComparny.SelectedIndex = -1

        txtbcif.Text = ""
        txtbHome.Text = ""
        txtbName.Text = ""
        txtbAcount1.Text = ""
        txtbAcount2.Text = ""

        ckActivate.Checked = False
    End Sub

    Private Sub txtbAcount1_TextChanged(sender As Object, e As EventArgs) Handles txtbAcount1.TextChanged
        txtbAcount1.Tag = 1
    End Sub

    Private Sub txtbAcount2_TextChanged(sender As Object, e As EventArgs) Handles txtbAcount2.TextChanged
        txtbAcount2.Tag = 1
    End Sub
End Class