Public Class GestionarCuentas
    Private Sub GestionarCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Code to center elements
        pnlGE.Location = New Point((Me.Width - pnlGE.Width) \ 2, (Me.Height - pnlGE.Height) \ 2)
        lblTittle.Location = New Point((pnlGE.Width - lblTittle.Width) \ 2, (lblTittle.Height))
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim aniadirCuentas As AddAccount = New AddAccount(Login.db)
        aniadirCuentas.Show()
        Me.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim reiniciarCuenta As ResestBalance = New ResestBalance(Login.db)
        reiniciarCuenta.Show()
        Me.Close()

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim freeCuent As FreeAccounts = New FreeAccounts(Login.db)
        freeCuent.Show()
        Me.Close()

    End Sub
End Class