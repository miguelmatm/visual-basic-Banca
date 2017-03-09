Public Class TransferBusiness

    Dim db As DataAccess
    Dim cifCompany As String
    Dim loadReady As Boolean = True
    Dim resultInserts As Integer = 0

    Dim ccAccountOrigin As String
    Dim util As Util = New Util


    'We give a constructor to the class to be able to pass the parameters of the logged user and the db
    Sub New(cifCompany As String, dataBase As DataAccess)

        ' This call is required by the designer.
        InitializeComponent()
        Me.cifCompany = cifCompany
        db = dataBase

    End Sub

    'This is the method load'
    Private Sub TransferBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        db = New DataAccess()
        addComponents()

        If (fillComboBoxOrigen()) Then
            fillComboBoxCompanyDestination()
        End If
    End Sub

    'We add all componets in the Window of application
    Private Sub addComponents()

        Panel1.Size = New System.Drawing.Size(480, 483)
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)


        'Ini We add background of image in the form'
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferBusiness))
        Dim backgroindImage As PictureBox = New System.Windows.Forms.PictureBox()
        CType(backgroindImage, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()


        Panel1.Controls.Add(backgroindImage)
        Me.Controls.Add(Panel1)
        'Finish We add all the components of the form'
    End Sub

    Private Function fillComboBoxOrigen()

        Dim found = False
        Dim consult As String = "SELECT * FROM cuentas where CIF_emp = '" + cifCompany + "' AND Usado = 1"
        Dim dataSet As DataSet = db.query(consult)

        ' We control that it dows not jump error if the database is not connected
        If (Not dataSet.Tables.Count = 0) Then
            ' We control that the result that it returns has at least 1 row
            If (Not dataSet.Tables(0).Rows.Count = 0) Then

                found = True

                ccAccountOrigin = dataSet.Tables(0).Rows(0).Item("CC")
                For Each row As DataRow In dataSet.Tables(0).Rows
                    Dim account As String = row("banco") + " : " + row("CC")

                    ComboBox1.Items.Add(account)
                Next
                ComboBox1.SelectedIndex = 0

                Dim parts = Split(ComboBox1.SelectedItem.ToString(), " : ")
                ccAccountOrigin = parts(1)
            End If
        End If

        Return found
    End Function

    'We consult the database and fill in the combobox
    Private Sub fillComboBoxCompanyDestination()
        Dim consult As String = "SELECT * FROM empresas where activa = 1"
        Dim dataSet As DataSet = db.query(consult)


        If (Not dataSet.Tables.Count = 0) Then
            For Each row As DataRow In dataSet.Tables(0).Rows
                Dim account As String = row("nombre")
                Dim consultCc As String = "SELECT COUNT(*) as total FROM cuentas where CIF_emp = '" + row("CIF") + "' AND Usado = 1"
                Dim dataSett As DataSet = db.query(consultCc)
                Dim allAccountsAso = dataSett.Tables(0).Rows(0).Item("total")

                If (Not allAccountsAso < 1) Then
                    If (row("CIF") = cifCompany And allAccountsAso > 1) Then
                        ComboBox2.Items.Add(account)
                    ElseIf (Not row("CIF") = cifCompany) Then
                        ComboBox2.Items.Add(account)
                    End If



                End If

            Next
        End If
    End Sub

    'We consult the database and fill in the combobox
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()

        Dim selected As String = ComboBox2.SelectedItem.ToString()
        Dim consult As String = "SELECT * FROM bancaonline.cuentas WHERE CIF_emp = (SELECT CIF FROM `empresas` WHERE `nombre` = '" + selected + "')"

        Dim dataSet As DataSet = db.query(consult)

        ' We control that it dows not jump error if the database is not connected
        If (Not dataSet.Tables.Count = 0) Then
            ' We control that the result that it returns has at least 1 row
            If (Not dataSet.Tables.Count = 0) Then

                For Each row As DataRow In dataSet.Tables(0).Rows
                    Dim account As String = row("banco") + " : " + row("CC")


                    If (Not row("CC") = ccAccountOrigin) Then
                        ComboBox3.Items.Add(account)
                    End If



                Next
            End If
        End If
    End Sub


    'this method we see is all ok'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (loadReady) Then
            resetErrors()

            Dim allReady As Boolean = True
            Dim accountOrigin As String = ComboBox1.SelectedItem.ToString()
            Dim companyDestination As String = ""
            Dim accountDestination As String = ""
            Dim quantity As String = TextBox1.Text
            Dim quantityControl As String = "0"
            Dim type As String = ""
            Dim senderr As String = TextBox2.Text
            Dim concept As String = TextBox3.Text
            Dim conceptExtend As String = TextBox4.Text

            'here control insert consult sql 
            senderr = senderr.Replace(";", "")
            concept = concept.Replace(";", "")
            conceptExtend = conceptExtend.Replace(";", "")


            If (ComboBox2.SelectedIndex = -1) Then
                Label10.Visible = True
                allReady = False
            Else
                companyDestination = ComboBox2.SelectedItem.ToString()
            End If

            If (ComboBox3.SelectedIndex = -1) Then
                Label9.Visible = True
                allReady = False
            Else
                accountDestination = ComboBox3.SelectedItem.ToString()
            End If


            If (Not IsNumeric(quantity)) Then
                allReady = False
                Label8.Visible = True
            Else
                quantityControl = util.controlDec(quantity)

                If (Not quantityControl = 0) Then
                    If (quantityControl > 0) Then
                        type = "Cargo"
                    Else
                        type = "Abono"

                    End If
                Else
                    allReady = False
                    Label8.Visible = True
                End If


            End If

            If (allReady) Then
                'we send all the data collected for the structuring of the program'
                saveTransaction(accountOrigin, accountDestination, quantityControl, senderr, concept, conceptExtend, type)
            End If

        End If

    End Sub

    'In this method we will prepare all the necessary elements to later save them
    Private Sub saveTransaction(accountOriginParam As String, accountDestinationParam As String, quantity As String, sender As String, concept As String, conceptExtend As String, type As String)

        Dim accountOriginSplit = Split(accountOriginParam, " : ")
        Dim accountOrigin As String = accountOriginSplit(1)

        Dim consultOrigin As String = "SELECT * FROM cuentas where CC = '" + accountOrigin + "'"
        Dim dataSetCuentaOrigen As DataSet = db.query(consultOrigin)


        Dim accountDestinationSplit = Split(accountDestinationParam, " : ")
        Dim accountDestination As String = accountDestinationSplit(1)

        Dim consultDestination As String = "SELECT * FROM cuentas where CC = '" + accountDestination + "'"
        Dim dataSetAccountDestination As DataSet = db.query(consultDestination)


        Dim balanceAccountOrigin As Double = 0
        Dim balanceAccountDestination As Double = 0

        Dim calculationBalanceIsOk As Boolean = True




        ' We control that it dows not jump error if the database is not connected
        If (Not dataSetCuentaOrigen.Tables.Count = 0) Then
            ' We control that the result that it returns has at least 1 row
            If (dataSetCuentaOrigen.Tables(0).Rows.Count = 1) Then
                For Each row As DataRow In dataSetCuentaOrigen.Tables(0).Rows
                    'Here we transform the "." in "," to be able to convert it into double
                    balanceAccountOrigin = Format(CDbl(CStr(row("Saldo")).Replace(".", ",")) - CDbl(quantity), "#,##0.00")
                Next
            Else
                calculationBalanceIsOk = False
            End If
        Else
            calculationBalanceIsOk = False
        End If


        ' controlamos que no salte error si la base de datos no esta conectada
        If (Not dataSetAccountDestination.Tables.Count = 0) Then
            ' controlamos que el resultado que de devuelve tenga unicamente 1 fila
            If (dataSetAccountDestination.Tables(0).Rows.Count = 1) Then
                For Each row As DataRow In dataSetAccountDestination.Tables(0).Rows
                    'Here we transform the "." in "," to be able to convert it into double
                    balanceAccountDestination = Format(CDbl(CStr(row("Saldo")).Replace(".", ",")) + CDbl(quantity), "#,##0.00")

                Next
            Else
                calculationBalanceIsOk = False
            End If
        Else
            calculationBalanceIsOk = False
        End If

        Dim balanceAccountDestinationFinal = CStr(balanceAccountDestination).Replace(",", ".")
        Dim balanceAccountOriginFinal = CStr(balanceAccountOrigin).Replace(",", ".")

        Dim cantidadOpuesta = Format(-CDbl(quantity), "#,##0.00")
        quantity = Format(CDbl(quantity), "#,##0.00")

        quantity = quantity.Replace(".", "")
        cantidadOpuesta = cantidadOpuesta.Replace(".", "")

        Dim cantidadOpuestaFinal = CStr(cantidadOpuesta).Replace(",", ".")
        Dim quantityFinal = CStr(quantity).Replace(",", ".")

        If (calculationBalanceIsOk) Then
            carryOut(accountOrigin, accountDestination, quantityFinal, cantidadOpuestaFinal, sender, concept, conceptExtend, type, balanceAccountOriginFinal, balanceAccountDestinationFinal)
        End If
    End Sub

    'Here we save all . in the DB
    Private Sub carryOut(cuentaOrigen, cuentaDestino, cantidad, cantidadOpuesta, remitente, concepto, conceptoExtendido, type, saldoCuentaOrigen, saldoCuentaDestino)
        ' Here save all or dont save'

        Dim datee = DateTime.Now
        Dim today = CStr(datee.Day) + "-" + CStr(datee.Month) + "-" + CStr(datee.Year)
        Dim yearPart = CStr(datee.Year).Substring(CStr(datee.Year).Length() - 2, 2)
        Dim lastThreeNumOrigin = cuentaOrigen.Substring(cuentaOrigen.Length - 3, 3)
        Dim lastThreeNumDestination = cuentaDestino.Substring(cuentaDestino.Length - 3, 3)
        Dim referen = ""
        Dim referenType = ""
        Dim secondType = "Abono"

        If (type = "Abono") Then
            referenType = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "C"
            referen = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "A"
            secondType = "Cargo"
        Else
            referenType = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "A"
            referen = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "C"

        End If

        Dim updateUno As String =
        "UPDATE cuentas SET Saldo=" + CStr(saldoCuentaDestino) + " WHERE CC = '" + cuentaDestino + "';" +
        "UPDATE cuentas SET Saldo=" + CStr(saldoCuentaOrigen) + " WHERE CC = '" + cuentaOrigen + "';" +
        "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('" + type + "', '" + referen + "', '" + remitente + "', '" + today + "', '" + today + "', '" + concepto + "', '" + conceptoExtendido + "', " + cantidadOpuesta + ", " + CStr(saldoCuentaOrigen) + ", " + CStr(0) + ");"




        Dim updateDos As String = "INSERT INTO cc_op(cod_op, cc, tipo, saldo) VALUES (PALABRACLAVE, '" + cuentaOrigen + "', '" + type + "', " + CStr(saldoCuentaOrigen) + ");" +
                                  "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('" + secondType + "', '" + referenType + "', '" + remitente + "', '" + today + "', '" + today + "', '" + concepto + "', '" + conceptoExtendido + "', " + cantidad + ", " + CStr(saldoCuentaDestino) + ", " + CStr(0) + ");"

        Dim updateTres As String = "INSERT INTO cc_op(cod_op, cc, tipo, saldo) VALUES (PALABRACLAVE, '" + cuentaDestino + "', '" + secondType + "', " + CStr(saldoCuentaDestino) + ");"

        resultInserts = db.cudTransferencia(updateUno, updateDos, updateTres)

        loadReady = False
        Timer1.Enabled = True

    End Sub


    'Reset all labels of the errors info'
    Private Sub resetErrors()

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        ProgressBar1.Visible = True
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0

            loadReady = True
            msInfo()
        End If
    End Sub

    'clear all form 
    Private Sub msInfo()
        If (resultInserts = 6) Then
            MessageBox.Show("Transferencia realizada correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()

            fillComboBoxCompanyDestination()


        Else
            MessageBox.Show("Error al guardar", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        resultInserts = 0
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        EmpresasPaginaInicio.Show()
        Me.Close()
    End Sub


    'Clicked Cancelar and return index Company'
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        EmpresasPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim parts = Split(ComboBox1.SelectedItem.ToString(), " : ")
        ccAccountOrigin = parts(1)
        ComboBox3.Items.Clear()
    End Sub
End Class