Public Class GestionarEmpresas
    Private Sub GestionarEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Code to center elements
        pnlGE.Location = New Point((Me.Width - pnlGE.Width) \ 2, (Me.Height - pnlGE.Height) \ 2)
        lblTittle.Location = New Point((pnlGE.Width - lblTittle.Width) \ 2, (lblTittle.Height))
    End Sub

    Private Sub pnlGE_Paint(sender As Object, e As PaintEventArgs) Handles pnlGE.Paint

    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        ActivarEmpresa.Show()
        Me.Hide()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ModificarEmpresas.Show()
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        AnadirEmpresa.Show()
        Me.Close()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim db As New DataAccess
        Dim query, msg, title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult

        msg = "¿Está seguro que desea borrar todas las empresas?"
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Borrar Empresas"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.
            Try
                query = "DELETE FROM empresas"
                db.cud(query)
                MessageBox.Show("Todas las empresas han sido borradas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("No se ha podido realizar la operacion", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
End Class