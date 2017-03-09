Public Class Login
    Dim m As New Util()
    Public db As New DataAccess
    Public dniUsuario

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Code to center elements
        pnlLogin.Location = New Point((Me.Width - pnlLogin.Width) \ 2, (Me.Height - pnlLogin.Height) \ 2)
        lblTittle.Location = New Point((pnlLogin.Width - lblTittle.Width) \ 2, (lblTittle.Height))
        lblUser.Location = New Point((pnlLogin.Width - lblUser.Width) \ 2, lblUser.Location.Y)
        lblPwd.Location = New Point((pnlLogin.Width - lblPwd.Width) \ 2, lblPwd.Location.Y)
        txtbPwd.Location = New Point((pnlLogin.Width - txtbPwd.Width) \ 2, txtbPwd.Location.Y)
        txtbUser.Location = New Point((pnlLogin.Width - txtbUser.Width) \ 2, txtbUser.Location.Y)
        btnLogin.Location = New Point((pnlLogin.Width - btnLogin.Width) \ 2, btnLogin.Location.Y)
        lblRedirectRegister.Location = New Point((pnlLogin.Width - lblRedirectRegister.Width) \ 2, lblRedirectRegister.Location.Y)

        m.Comprobar()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblRedirectRegister.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim ds As New DataSet
        Dim query As String
        Dim cifCheck = False, pwdCheck = False

        'Check that the Textbox for the user is not empty
        If txtbUser.Text <> "" Then
            If m.CheckCIF(txtbUser.Text) Then
                cifCheck = True
            End If
        Else
            EPUser.SetError(txtbUser, "Introduzca un usuario")
        End If

        'Check that the Textbox for the password is not empty
        If txtbPwd.Text <> "" Then
            pwdCheck = True
        Else
            EPPass.SetError(txtbPwd, "Introduzca una contraseña")
        End If

        query = "Select * from empresas where CIF = '" & txtbUser.Text & "' and pw = '" & txtbPwd.Text & "'"

        dniUsuario = txtbUser.Text

        'You start session depending on the user you are
        If cifCheck And pwdCheck Then
            If txtbUser.Text = "A11111111" And txtbPwd.Text = "1111" Then
                BancaPaginaInicio.Show()
                Me.Hide()
                clean()
            Else
                Try
                    ds = db.query(query)
                    If ds.Tables(0).Rows.Count >= 1 Then
                        EmpresasPaginaInicio.Show()
                        Me.Hide()
                        clean()
                    Else
                        MessageBox.Show("Error al iniciar sesión. Por favor compruebe sus datos.", "Login incorrecto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        clean()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al conectar", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        Else
            MessageBox.Show("Debes rellenar correctamente todos los campos", "Login incorrecto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub clean()
        txtbUser.Text = ""
        txtbPwd.Text = ""
    End Sub
End Class