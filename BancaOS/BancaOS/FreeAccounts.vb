Public Class FreeAccounts

    Dim db As DataAccess
    Dim util As Util = New Util


    'We give a constructor to the class to be able to pass the parameters  the db
    Sub New(dataBase As DataAccess)

        ' This call is required by the designer.
        InitializeComponent()
        db = dataBase

    End Sub


    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub


    Private Sub FreeAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)

        addElementsComboBox()
    End Sub


    Private Sub addElementsComboBox()
        Dim found = False
        Dim consult As String = "SELECT * FROM bancos"
        Dim dataSet As DataSet = db.query(consult)

        ' We control that it dows not jump error if the database is not connected
        If (Not dataSet.Tables.Count = 0) Then
            ' We control that the result that it returns has at least 1 row
            If (Not dataSet.Tables(0).Rows.Count = 0) Then
                Label3.Visible = False
                found = True

                For Each row As DataRow In dataSet.Tables(0).Rows
                    Dim account As String = row("nombre")
                    ComboBox1.Items.Add(account)
                Next
            End If
        End If

        If (Not found) Then
            Label3.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "¿Está seguro que desea liberar las cuentas?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        title = "Liberar Cuentas"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.
            If (ComboBox1.SelectedIndex = -1) Then
                Label4.Visible = True
            Else
                resetErrors()
                balanceIsOk()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GestionarCuentas.Show()
        Me.Close()
    End Sub

    Private Sub balanceIsOk()

        Dim quantity = TextBox1.Text
        Dim quantityControl = ""
        Dim allReady As Boolean = False

        If (IsNumeric(quantity)) Then
            If (Not quantity = "0") Then
                quantityControl = util.controlDec(quantity)

                If (Not quantityControl = "0") Then
                    allReady = True
                End If
            Else
                quantityControl = 0
                allReady = True
            End If
        End If

        If (allReady) Then
            quantityControl = Format(CDbl(quantityControl), "#,##0.00")
            quantityControl = CStr(quantityControl).Replace(",", ".")
            freeAllAccounts(quantityControl)
        Else
            Label8.Visible = True
        End If
    End Sub

    Private Sub freeAllAccounts(quantityControl)
        Dim nameBank = ComboBox1.SelectedItem.ToString()

        Dim stringDeletes As String = ""
        Dim consultAllCC = "SELECT * FROM cuentas where Banco = '" + nameBank + "'"
        Dim dataSetAllAccounts As DataSet = db.query(consultAllCC)

        ' We control that it dows not jump error if the database is not connected
        If (Not dataSetAllAccounts.Tables.Count = 0) Then
            ' We control that the result that it returns has at least 1 row
            If (Not dataSetAllAccounts.Tables(0).Rows.Count = 0) Then
                For Each row As DataRow In dataSetAllAccounts.Tables(0).Rows
                    Dim cc As String = row("CC")
                    Dim consultCod_op = "SELECT * FROM cc_op where CC = '" + cc + "'"
                    Dim dataSetAllCCOP As DataSet = db.query(consultCod_op)

                    If (Not dataSetAllCCOP.Tables.Count = 0) Then
                        If (Not dataSetAllAccounts.Tables(0).Rows.Count = 0) Then
                            For Each rowTwo As DataRow In dataSetAllCCOP.Tables(0).Rows
                                Dim codOp As String = rowTwo("cod_op")
                                stringDeletes += "DELETE FROM operaciones WHERE codigo = " + codOp + ";"
                            Next
                        End If
                    End If

                    stringDeletes += "DELETE FROM transfperiod WHERE cc1 = '" + cc + "' or cc2 = '" + cc + "';"
                Next
            End If
        End If


        Dim consult As String = "START TRANSACTION;" +
                                "UPDATE cuentas SET Saldo = " + CStr(quantityControl) + ", CIF_emp='', Usado = 0 WHERE Banco = '" + nameBank + "';" + stringDeletes +
                                "COMMIT;"


        Dim dataSet = db.cud(consult)

        If (dataSet = 0) Then
            MessageBox.Show("No se pudieron liberar las cuentas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Cuentas Liberadas", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub resetErrors()
        Label3.Visible = False
        Label4.Visible = False
        Label8.Visible = False
    End Sub
End Class