Public Class EmpresasPaginaInicio
    Private Sub EmpresasPaginaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x, y As Short
        x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' get x
        y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height ' get y
        Gbgestiones.Location = New Point((x / 2) - (LblCopyRight.Size.Width / 2) - 90, (y / 2) - 140) ' GroupBox Position
    End Sub

    Private Sub BtnGesEmpresa_Click(sender As Object, e As EventArgs) Handles BtnGesEmpresa.Click
        GestionarEmpresas.Show()
        Me.Close()
    End Sub

    Private Sub BtnMiscuentas_Click(sender As Object, e As EventArgs) Handles BtnMiscuentas.Click
        Dim query As String
        Dim db As New DataAccess
        Dim ds As New DataSet

        query = "SELECT CC FROM cuentas WHERE CIF_emp = '" + Login.dniUsuario + "'"
        ds = db.query(query)

        If (ds.Tables(0).Rows.Count = 0) Then
            MessageBox.Show("No tienes cuentas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            EmpresasMisCuentas.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnTransferencia_Click(sender As Object, e As EventArgs) Handles BtnTransferencia.Click
        Dim db As New DataAccess
        Dim consult As String = "SELECT CC FROM cuentas where CIF_emp = '" + Login.dniUsuario + "' AND Usado = 1"
        Dim dataSet As DataSet = db.query(consult)

        ' We control that it dows not jump error if the database is not connected
        If (dataSet.Tables(0).Rows.Count = 0) Then
            MessageBox.Show("No tienes cuentas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' We control that the result that it returns has at least 1 row
            Dim transfer As TransferBusiness = New TransferBusiness(Login.dniUsuario, Login.db)
            transfer.Show()
            Me.Close()
        End If
    End Sub
End Class