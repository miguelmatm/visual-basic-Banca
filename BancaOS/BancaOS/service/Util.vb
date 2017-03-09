Public Class Util
    Dim db As New DataAccess
    Dim resultInserts = 0

    'We verify that the CIF is composed of one character and nine digits.
    Public Function CheckCIF(CIF As String)
        Dim result As Boolean = False
        Dim letter = CIF.Substring(0, 1)
        Dim numbers = CIF.Substring(1, CIF.Length - 1)

        If CIF.Length = 9 And IsNumeric(numbers) And CheckLetter(letter) Then
            result = True
        End If

        Return result
    End Function

    'A CIF is composed of a certain letter, by this method we can check if the letter is correct
    Private Function CheckLetter(letter As String)
        Dim result As Boolean = False
        Dim letters = "ABCDEFGHJNPQRSUVW"

        For i As Integer = 0 To letters.Length - 1
            If letters.Substring(i, 1).Equals(letter.ToUpper) Then
                result = True
            End If
        Next

        Return result
    End Function

    'With this function we generate the password. The CIF is taken and the last 4 digits of this
    Public Function generatepwd(CIF As String)

        Dim pwd = CIF.Substring(CIF.Length - 4, 4) '(We start from the length of the cif, length)

        Return pwd
    End Function

    Public Function CheckCB(ckbActivate As CheckBox)
        Dim Activa = 0

        If ckbActivate.Checked Then
            Activa = 1
        End If

        Return Activa
    End Function

    Public Function CheckIsSameAccounts(account1 As String, account2 As String)
        Dim res As Boolean = True

        If account1 = account2 Then
            res = False
        End If

        Return res
    End Function

    Sub New()
    End Sub

    Public Function controlDec(quantity As String)
        Dim dot = quantity.Split(".")
        Dim coma = quantity.Split(",")
        Dim result As String = "0"
        Dim plusCount = 0

        If (dot.Length() = 2) Then
            If (coma.Length() = 1) Then

                plusCount = 0
                Dim firstCaracter = dot(0).Substring(0, 1)



                If (dot(0).Length() <= (4 + plusCount)) Then

                    result = quantity.Replace(".", ",")

                End If
            End If

        ElseIf (dot.Length() = 1) Then

            If (coma.Length() = 2) Then

                plusCount = 0
                Dim firstCaracter = coma(0).Substring(0, 1)

                If (firstCaracter = "-" Or firstCaracter = "+") Then
                    plusCount = 1
                End If

                If (coma(0).Length() <= (4 + plusCount)) Then

                    result = quantity.Replace(".", ",")

                End If

            ElseIf (coma.Length = 1) Then


                Dim firstCaracter = quantity.Substring(0, 1)

                If (firstCaracter = "-" Or firstCaracter = "+") Then
                    plusCount = 1
                End If

                If (quantity.Length() <= (4 + plusCount)) Then
                    result = quantity
                End If
            End If
        End If

        Return result

    End Function


    Public Sub Comprobar()
        Dim DsConsulta As DataSet
        Dim actualizacion As String
        Dim actualizar

        Dim consulta = "SELECT STR_TO_DATE(proximafecha, '%d-%m-%Y'), dias, cod, cc1, cc2, cantidad from transfperiod where STR_TO_DATE(proximafecha, '%d-%m-%Y') <= curdate()"
        DsConsulta = db.query(consulta)

        For Each row As DataRow In DsConsulta.Tables(0).Rows
            Dim pro_fe = row("STR_TO_DATE(proximafecha, '%d-%m-%Y')")

            Dim dias = row("dias")
            Dim sig_fe = pro_fe.AddDays(dias)

            Dim prox_fec As String
            prox_fec = CStr(sig_fe)
            prox_fec = prox_fec.Substring(0, 10)
            prox_fec = prox_fec.Replace("/", "-")

            Dim cod = CInt(row("cod"))

            actualizacion = CStr("UPDATE transfperiod SET proximafecha = '" & prox_fec & "' where cod=" & cod)
            actualizar = db.cud(actualizacion)


            saveTransaction(row("cc1"), row("cc2"), row("cantidad"), "", "Transferencia Periodica", "", "Cargo")

        Next
    End Sub


    'In this method we will prepare all the necessary elements to later save them
    Private Sub saveTransaction(accountOriginParam As String, accountDestinationParam As String, quantity As String, sender As String, concept As String, conceptExtend As String, type As String)


        Dim accountOrigin As String = accountOriginParam

        Dim accountDestination As String = accountDestinationParam

        Dim consultDestination As String = "SELECT * FROM cuentas where CC = '" + accountDestination + "'"
        Dim dataSetAccountDestination As DataSet = db.query(consultDestination)
        Dim balanceAccountOriginFinal = ""


        Dim balanceAccountOrigin As Double = 0
        Dim balanceAccountDestination As Double = 0

        Dim calculationBalanceIsOk As Boolean = True

        If (Not accountOrigin = "A11111111") Then
            Dim consultOrigin As String = "SELECT * FROM cuentas where CC = '" + accountOrigin + "'"
            Dim dataSetCuentaOrigen As DataSet = db.query(consultOrigin)

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

            balanceAccountOriginFinal = CStr(balanceAccountOrigin).Replace(",", ".")
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
        Dim updateUno As String = ""
        Dim updateDos As String = ""
        Dim updateTres As String = ""

        If (type = "Abono") Then
            referenType = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "C"
            referen = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "A"
            secondType = "Cargo"
        Else
            referenType = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "A"
            referen = CStr(datee.Day) + CStr(datee.Month) + yearPart + lastThreeNumOrigin + lastThreeNumDestination + "C"

        End If

        If (Not cuentaOrigen = "A11111111") Then


            updateUno =
            "UPDATE cuentas SET Saldo=" + CStr(saldoCuentaDestino) + " WHERE CC = '" + cuentaDestino + "';" +
            "UPDATE cuentas SET Saldo=" + CStr(saldoCuentaOrigen) + " WHERE CC = '" + cuentaOrigen + "';" +
            "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('" + type + "', '" + referen + "', '" + remitente + "', '" + today + "', '" + today + "', '" + concepto + "', '" + conceptoExtendido + "', " + cantidadOpuesta + ", " + CStr(saldoCuentaOrigen) + ", " + CStr(0) + ");"




            updateDos = "INSERT INTO cc_op(cod_op, cc, tipo, saldo) VALUES (PALABRACLAVE, '" + cuentaOrigen + "', '" + type + "', " + CStr(saldoCuentaOrigen) + ");" +
                                      "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('" + secondType + "', '" + referenType + "', '" + remitente + "', '" + today + "', '" + today + "', '" + concepto + "', '" + conceptoExtendido + "', " + cantidad + ", " + CStr(saldoCuentaDestino) + ", " + CStr(0) + ");"

            updateTres = "INSERT INTO cc_op(cod_op, cc, tipo, saldo) VALUES (PALABRACLAVE, '" + cuentaDestino + "', '" + secondType + "', " + CStr(saldoCuentaDestino) + ");"

        Else
            updateUno = "UPDATE cuentas SET Saldo=" + CStr(saldoCuentaDestino) + " WHERE CC = '" + cuentaDestino + "';"

            updateDos = "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('" + secondType + "', '" + referenType + "', '" + remitente + "', '" + today + "', '" + today + "', '" + concepto + "', '" + conceptoExtendido + "', " + cantidad + ", " + CStr(saldoCuentaDestino) + ", " + CStr(0) + ");"

            updateTres = "INSERT INTO cc_op(cod_op, cc, tipo, saldo) VALUES (PALABRACLAVE, '" + cuentaDestino + "', '" + secondType + "', " + CStr(saldoCuentaDestino) + ");"

        End If

        resultInserts = db.cudTransferencia(updateUno, updateDos, updateTres)

        msInfo(cuentaOrigen)

    End Sub


    'clear all form 
    Private Sub msInfo(resultado As String)
        If (resultado = "A11111111") Then
            If (Not resultInserts = 3) Then
                MsgBox("Error al guardar")
            End If

            resultInserts = 0
        Else
            If (Not resultInserts = 6) Then
                MsgBox("Error al guardar")
            End If

            resultInserts = 0
        End If

    End Sub

End Class