Imports MySql.Data.MySqlClient

Public Class InformacionCuenta
    Public DSReferencia As String
    Public DSRemitente As String
    Public DSFecha As String
    Public DSFechaValor As String
    Public DSConcepto As String
    Public DSConceptoExt As String
    Public DSCantidad As String
    Public DSPeriodica As String
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub InformacionCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ad As New DataAccess
        Dim con As New MySqlConnection
        Dim consulta As String
        Dim dsconsulta As DataSet
        Dim idCuenta = EmpresasMisCuentas.cuentaSeleccionada

        If idCuenta = "" Then
            idCuenta = BancaGestionMovimientos.cuentaSeleccionada
        End If

        consulta = "SELECT * FROM operaciones WHERE referencias = '" & idCuenta & "'"
        dsconsulta = ad.query(consulta)

        LbFecha.Text = dsconsulta.Tables("Users").Rows(0).Item(4).ToString
        LbFechaValor.Text = dsconsulta.Tables("Users").Rows(0).Item(5).ToString
        LbRemitente.Text = dsconsulta.Tables("Users").Rows(0).Item(3).ToString
        LbReferencia.Text = dsconsulta.Tables("Users").Rows(0).Item(2).ToString
        LbPeriodica.Text = dsconsulta.Tables("Users").Rows(0).Item(10).ToString
        LbConcepto.Text = dsconsulta.Tables("Users").Rows(0).Item(6).ToString
        LbConceptoExt.Text = dsconsulta.Tables("Users").Rows(0).Item(7).ToString
        LbCantidad.Text = dsconsulta.Tables("Users").Rows(0).Item(8).ToString
    End Sub

    Private Sub btnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
        DSReferencia = LbReferencia.Text
        DSRemitente = LbRemitente.Text
        DSFecha = LbFecha.Text
        DSFechaValor = LbFechaValor.Text
        DSConcepto = LbConcepto.Text
        DSConceptoExt = LbConceptoExt.Text
        DSCantidad = LbCantidad.Text
        DSPeriodica = LbPeriodica.Text
        informe.Show()
    End Sub
End Class