Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Code to center elements
        pnlRegister.Location = New Point((Me.Width - pnlRegister.Width) \ 2, (Me.Height - pnlRegister.Height) \ 2)
        lblTittle.Location = New Point((pnlRegister.Width - lblTittle.Width) \ 2, (lblTittle.Height))
        lblAddress.Location = New Point((pnlRegister.Width - lblAddress.Width) \ 2, lblAddress.Location.Y)
        lblCif.Location = New Point((pnlRegister.Width - lblCif.Width) \ 2, lblCif.Location.Y)
        lblNombre.Location = New Point((pnlRegister.Width - lblNombre.Width) \ 2, lblNombre.Location.Y)
        txtbAddres.Location = New Point((pnlRegister.Width - txtbAddres.Width) \ 2, txtbAddres.Location.Y)
        txtbCIF.Location = New Point((pnlRegister.Width - txtbCIF.Width) \ 2, txtbCIF.Location.Y)
        txtbName.Location = New Point((pnlRegister.Width - txtbName.Width) \ 2, txtbName.Location.Y)
        btnRegister.Location = New Point((pnlRegister.Width - btnRegister.Width) \ 2, btnRegister.Location.Y)

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim db As New DataAccess
        Dim ds As New DataSet
        Dim query As String
        Dim m As New Util()

        If txtbCIF.Text = "" Or txtbAddres.Text = "" Or txtbName.Text = "" Then
            MessageBox.Show("Debes rellenar todos los campos", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clean()
        Else
            If m.CheckCIF(txtbCIF.Text) Then
                Try
                    query = "Select * from empresas where CIF = '" + txtbCIF.Text + "'"
                    ds = db.query(query)
                    If ds.Tables(0).Rows.Count = 1 Then
                        MessageBox.Show("El usuario ya existe", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        query = "INSERT INTO `empresas`(`CIF`, `pw`, `nombre`, `domicilio`, `activa`) VALUES ('" & txtbCIF.Text & "','" & m.generatepwd(txtbCIF.Text) & "','" & txtbName.Text & "','" & txtbAddres.Text & "', 0)"
                        Dim result = db.cud(query)

                        If (result = 1) Then
                            MessageBox.Show("Usuario registrado correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Login.Show()
                            Me.Hide()
                            clean()
                        Else
                            MessageBox.Show("Error al registrar el usuario", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If

                    End If
                Catch ex As Exception
                    MsgBox("Error al insertar los datos")
                    MessageBox.Show("Error al insertar los datos", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Comprueba si el CIF es correcto", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub clean()
        txtbAddres.Text = ""
        txtbCIF.Text = ""
        txtbName.Text = ""
    End Sub
End Class