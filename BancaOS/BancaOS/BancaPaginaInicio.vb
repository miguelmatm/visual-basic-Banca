Public Class BancaPaginaInicio
    Private Sub BancaPaginaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x, y As Short
        x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' get x
        y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height ' get y
        Gbgestiones.Location = New Point((x / 2) - (LblCopyRight.Size.Width / 2) - 90, (y / 2) - 140) ' GroupBox Position
    End Sub

    Private Sub BtnGesEmpresa_Click(sender As Object, e As EventArgs) Handles BtnGesEmpresa.Click
        GestionarEmpresas.Show()
        Me.Close()
    End Sub

    Private Sub BtnGesCuentas_Click(sender As Object, e As EventArgs) Handles BtnGesCuentas.Click
        GestionarCuentas.Show()
        Me.Close()
    End Sub

    Private Sub BtnGestMov_Click(sender As Object, e As EventArgs) Handles BtnGestMov.Click
        BancaGestionMovimientos.Show()
        Me.Close()
    End Sub

    Private Sub BtnGestTrans_Click(sender As Object, e As EventArgs) Handles BtnGestTrans.Click
        Transferencias.Show()
        Me.Close()
    End Sub
End Class