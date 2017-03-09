Public Class ActivarEmpresa
    Private Sub ActivarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Code to center elements
        pnlAE.Location = New Point((Me.Width - pnlAE.Width) \ 2, (Me.Height - pnlAE.Height) \ 2)
        lblTittle.Location = New Point((pnlAE.Width - lblTittle.Width) \ 2, (lblTittle.Height))
        lvNoactive.Location = New Point((pnlAE.Width - lvNoactive.Width) \ 2, lvNoactive.Location.Y)

        RellenarNoActivas()
    End Sub

    Private Sub RellenarNoActivas()
        Dim db As New DataAccess
        Dim ds As New DataSet
        Dim query As String

        query = "Select CIF, nombre from empresas where activa = 0"
        ds = db.query(query)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            With lvNoactive
                .Items.Add(ds.Tables(0).Rows(i).Item(0))
                With .Items(.Items.Count - 1).SubItems
                    .Add(ds.Tables(0).Rows(i).Item(1))
                End With
            End With
        Next
    End Sub

    Private Sub activar()
        Dim query As String
        Dim db As New DataAccess

        For Each item As ListViewItem In lvNoactive.Items
            If item.Checked Then
                query = "UPDATE empresas SET activa=1 WHERE CIF = '" & item.Text & "'"

                Try
                    db.cud(query)
                    lvNoactive.Items.Remove(item)
                Catch ex As Exception
                    MessageBox.Show("Error al activar la/s empresa/s", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Next
        MessageBox.Show("Activación realizada correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        activar()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        GestionarEmpresas.Show()
        Me.Close()
    End Sub
End Class