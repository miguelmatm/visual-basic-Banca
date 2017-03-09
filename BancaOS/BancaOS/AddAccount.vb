Public Class AddAccount


    Dim db As DataAccess
    Dim operationFree = True
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

    Private Sub AddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)
        ComboBox2.Items.Add("1")
        ComboBox2.Items.Add("2")
        ComboBox2.Items.Add("6")
        ComboBox2.Items.Add("16")
        ComboBox2.Items.Add("30")
        ComboBox2.SelectedIndex = 0
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

    Private Function balanceIsOk()

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
            quantityControl = quantityControl.Replace(".", "")
            quantityControl = CStr(quantityControl).Replace(",", ".")
            Return quantityControl
        Else
            Label8.Visible = True
        End If

        Return quantityControl
    End Function


    Private Sub resetErrors()
        Label3.Visible = False
        Label4.Visible = False

        Label8.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GestionarCuentas.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (operationFree) Then
            Dim inicNumbresBank = ""

            If (ComboBox1.SelectedIndex = -1) Then
                Label4.Visible = True
            Else
                resetErrors()
                Dim balance = balanceIsOk()
                If (Not balance = "") Then
                    Dim consult = "SELECT * FROM bancos WHERE nombre = '" + ComboBox1.SelectedItem.ToString + "'"
                    Dim resultSelect As DataSet = db.query(consult)
                    Dim found As Boolean = False

                    ' We control that it dows not jump error if the database is not connected
                    If (Not resultSelect.Tables.Count = 0) Then
                        ' We control that the result that it returns has at least 1 row
                        If (resultSelect.Tables(0).Rows.Count = 1) Then
                            For Each row As DataRow In resultSelect.Tables(0).Rows
                                inicNumbresBank = row("inicc")
                                found = True

                            Next
                        End If
                    End If

                    If (found) Then
                        generar_Aleatoriamente(CInt(ComboBox2.SelectedItem.ToString), inicNumbresBank, ComboBox1.SelectedItem.ToString, balance, TextBox2.Text)
                    End If
                End If
            End If
        End If
    End Sub




    Private Sub generar_Aleatoriamente(Numero As Long, inicBack As String, nameBank As String, balance As String, office As String)

        operationFree = False
        Dim arrayy As New List(Of Integer)
        Dim rnd As New Random()
        Dim allInserts As Integer = 0

        For i = 1 To Numero
            Dim aleatorio = rnd.Next(0, 1000)
            Dim existe = False

            For x = 1 To arrayy.Count
                If (arrayy(x - 1) = aleatorio) Then
                    existe = True
                End If
            Next

            If (Not existe) Then
                arrayy.Add(aleatorio)

                Dim format = String.Format("{0:000}", aleatorio)
                Dim insertAccount = "INSERT INTO cuentas(CC, Banco, Oficina, Saldo, Usado) VALUES ('" + inicBack + format + "', '" + nameBank + "', '" + office + "', " + CStr(balance) + ", 0)"
                If (db.cud(insertAccount) = 0) Then
                    i -= 1
                Else
                    allInserts += 1
                End If
            Else
                i -= 1
            End If

            If (arrayy.Count = 999) Then
                Dim texto = "No hay cuentas suficientes, Se ingresaron : " + CStr(allInserts)
                MessageBox.Show(texto, "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit For
            End If
        Next

        If (allInserts = Numero) Then
            MessageBox.Show("Se insertaron correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        operationFree = True
    End Sub

End Class