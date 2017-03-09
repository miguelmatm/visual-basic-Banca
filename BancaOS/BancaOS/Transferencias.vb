Public Class Transferencias

    Dim da As New DataAccess
    Dim resultadoInsert

    ''Metodo que sirve para rellenar todos los combobox del formulario.
    ''Los combobox se rellenan en tiempo de ejecucion para facilitar el trabajo de edicion de contenido.
    ''Los combobox "cbCuentaDestino" y "cbCuentaOrigen" permaneceran innactivos mientras no se haya seleccionado ningun objeto.
    ''Habra restricciones a la hora de escribir en ciertos campos sensibles. Todos esos campos estan protegidos por mascaras.
    Private Sub Transferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnl.Location = New Point((Me.Width - pnl.Width) \ 2, (Me.Height - pnl.Height) \ 2)
        lblTittle.Location = New Point((pnl.Width - lblTittle.Width) \ 2, (lblTittle.Height))

        rellenarEmpresaOrigen()
        rellenarEmpresaDestino()
        rellenarPeriodica()
        rellenarConceptos()
        ponerFecha()

    End Sub

    Private Sub ponerFecha()
        mtbFecha.Text = DateTime.Now.ToShortDateString()
    End Sub

    ''Metodo que sirve para cambiar la funcionalidad del funcionario dependiendo si hemos checkeado el checkbox "chbDomiciliacionMasiva".
    ''Si el checkbox esta activo entonces los combobox "cbEmpresaOrigen", "cbCuentaDestino", "cbCuentaOrigen", "cbEmpresaOrigen" se deshabilitaran ya que no resultan necesarios.
    ''Si el checkbox esta innactivo entonces todo sera rellenable.
    Private Sub chbDomiciliacionMasiva_CheckedChanged(sender As Object, e As EventArgs) Handles chbDomiciliacionMasiva.CheckedChanged
        If chbDomiciliacionMasiva.Checked = True Then
            cbEmpresaOrigen.Enabled = False
            cbEmpresaDestino.Enabled = False
            cbCuentaOrigen.Enabled = False
            cbCuentaDestino.Enabled = False
            cbConcepto.SelectedIndex = 1
            cbConcepto.Enabled = False
        ElseIf chbDomiciliacionMasiva.Checked = False Then
            cbEmpresaOrigen.Enabled = True
            cbEmpresaDestino.Enabled = True
            cbConcepto.SelectedIndex = 0
            cbConcepto.Enabled = True

            If Not String.IsNullOrEmpty(cbEmpresaOrigen.SelectedItem) And cbEmpresaOrigen.SelectedItem <> "Ninguna" Then
                cbCuentaDestino.Enabled = True
            End If

            If Not String.IsNullOrEmpty(cbEmpresaOrigen.SelectedItem) And cbEmpresaOrigen.SelectedItem <> "Ninguna" Then
                cbCuentaOrigen.Enabled = True
            End If

        End If

    End Sub

    ''Metodo que sirve para cuando se selecciona una empresa rellenar el combobox "cbCuentaOrigen" donde selecionaremos la cuenta.
    ''En el metodo haremos una consulta a la base de datos y recibiremos un dataset que nos servira para rellenar el combobox.
    Private Sub cbEmpresaOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpresaOrigen.SelectedIndexChanged

        cbCuentaOrigen.Items.Clear()
        If cbEmpresaOrigen.Text <> "Ninguna" Then
            cbCuentaOrigen.Enabled = True
            cbPeriodica.SelectedIndex = 0

            Dim DsConsulta As DataSet
            Dim consulta = "SELECT cc FROM cuentas WHERE cif_emp= (SELECT cif FROM empresas WHERE nombre='" & cbEmpresaOrigen.SelectedItem.ToString & "')"
            DsConsulta = da.query(consulta)

            For Each row As DataRow In DsConsulta.Tables(0).Rows
                Dim cc As String = row("cc")
                cbCuentaOrigen.Items.Add(cc)
            Next

        Else
            cbCuentaOrigen.Enabled = False
        End If

    End Sub

    ''Metodo que sirve para cuando se selecciona una empresa rellenar el combobox "cbCuentaDestino" donde selecionaremos la cuenta.
    ''En el metodo haremos una consulta a la base de datos y recibiremos un dataset que nos servira para rellenar el combobox.
    Private Sub cbEmpresaDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEmpresaDestino.SelectedIndexChanged
        If cbEmpresaDestino.Text <> "Ninguna" Then
            cbCuentaDestino.Enabled = True

            cbCuentaDestino.Items.Clear()
            Dim DsConsulta As DataSet
            Dim consulta = "SELECT cc FROM cuentas WHERE usado=1 and cif_emp= (SELECT cif FROM empresas WHERE nombre='" & cbEmpresaDestino.SelectedItem.ToString & "')"
            DsConsulta = da.query(consulta)

            For Each row As DataRow In DsConsulta.Tables(0).Rows
                Dim cc As String = row("cc")
                cbCuentaDestino.Items.Add(cc)
            Next

        Else
            cbCuentaDestino.Enabled = False

        End If

    End Sub

    'Metodo que sirve para ejecutar la transaccion. Dependiendo si es del tipo "Domiciliacion masiva" o no, se ejecutaran unas acciones o otras.
    'Las tablas a las que se dirige este metodo son "operaciones", "cc_op" y "cuentas". En cada una ejecutara una accion diferente.
    'En el caso de "operaciones" insertara un registro para dejar constancia de la transacciones.
    'En el caso de "cuentas" se actualizara el saldo, restando o sumando respectivamente segun el usuario.
    'En el caso de "cc_op" se insertara un registro para dejar constancia de la transaccione.
    Private Sub operacionBanco(cuentaOrigen, cuentaDestino)

        Dim dataSetCuentaOrigen As DataSet
        Dim dataSetCuentaDestino As DataSet
        Dim balanceCuentaOrigen As Single = 0.0
        Dim balanceCuentaDestino As Single = 0.0
        Dim calculoBalanceCorrecto As Boolean = True

        Dim cadenaCantidad = mtbCantidad.Text
        Dim doubleCantidad As Single = 0.0
        Dim enteroCantidad = Trim(cadenaCantidad.Substring(0, 12))
        Dim decimalCantidad = ""
        Try
            decimalCantidad = Trim(cadenaCantidad.Substring(13, 2))
        Catch ex As Exception
        End Try

        If decimalCantidad = "" Then
            cadenaCantidad = enteroCantidad + "." + "00"
            doubleCantidad = enteroCantidad + "," + "00"
        Else
            cadenaCantidad = enteroCantidad + "." + decimalCantidad
            doubleCantidad = enteroCantidad + "," + decimalCantidad
        End If



        If cuentaOrigen <> "A11111111" Then

            Dim consultaOrigen As String = "SELECT * FROM cuentas where CC = '" + cuentaOrigen + "'"
            dataSetCuentaOrigen = da.query(consultaOrigen)

            If (Not dataSetCuentaOrigen.Tables.Count = 0) Then
                If (dataSetCuentaOrigen.Tables(0).Rows.Count = 1) Then
                    For Each row As DataRow In dataSetCuentaOrigen.Tables(0).Rows

                        balanceCuentaOrigen = Format(CSng(row("Saldo")) - CSng(doubleCantidad))

                    Next
                Else
                    calculoBalanceCorrecto = False
                End If
            Else
                calculoBalanceCorrecto = False
            End If

        End If

        Dim consultaDestino As String = "SELECT * FROM cuentas where CC = '" + cuentaDestino + "'"
        dataSetCuentaDestino = da.query(consultaDestino)

        If (Not dataSetCuentaDestino.Tables.Count = 0) Then
            If (dataSetCuentaDestino.Tables(0).Rows.Count = 1) Then
                For Each row As DataRow In dataSetCuentaDestino.Tables(0).Rows
                    If cbConcepto.Text = "Retirada de efectivo" Then
                        balanceCuentaDestino = Format(CDbl(row("Saldo")) - CDbl(doubleCantidad))
                    Else
                        balanceCuentaDestino = Format(CSng(row("Saldo")) + CSng(doubleCantidad))
                    End If

                Next
            Else
                calculoBalanceCorrecto = False
            End If
        Else
            calculoBalanceCorrecto = False
        End If

        Dim balanceCuentaDestinoFinal = CStr(balanceCuentaDestino)
        Dim balanceCuentaOrigenFinal = CStr(balanceCuentaOrigen)
        Dim cantidadFinal = cadenaCantidad

        If calculoBalanceCorrecto Then

            Dim fechaActual = CDate(mtbFecha.Text)
            Dim cadenaFecha = Replace(mtbFecha.Text, "/", "-")
            Dim añoActual = CStr(fechaActual.Year).Substring(CStr(fechaActual.Year).Length() - 2, 2)
            Dim ultimosNumerosCuentaOrigen = cuentaOrigen.Substring(cuentaOrigen.Length - 3, 3)
            Dim ultimosNumerosCuentaDestino = cuentaDestino.Substring(cuentaDestino.Length - 3, 3)
            Dim referente = CStr(fechaActual.Day) + CStr(fechaActual.Month) + añoActual + ultimosNumerosCuentaOrigen + ultimosNumerosCuentaDestino
            Dim referenteTipoAbono = referente + "Abono"
            Dim referenteTipoCargo = referente + "Cargo"

            Dim periodica = "0"
            Dim proximaFecha As String

            If cbPeriodica.SelectedItem <> "No periodica" And Not String.IsNullOrEmpty(cbPeriodica.SelectedItem) Then
                periodica = CStr(cbPeriodica.SelectedItem).Substring(0, 2)
                proximaFecha = cadenaFecha

            End If

            If cbConcepto.SelectedItem = "Ingreso de efectivo" Or chbDomiciliacionMasiva.Checked Then

                Dim updateUno As String = "UPDATE cuentas SET Saldo='" + Replace(CStr(balanceCuentaDestino), ",", ".") + "' WHERE CC = '" + cuentaDestino + "';"

                Dim updateDos As String = "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('Abono', '" + referenteTipoAbono + "', '" + tbRemitente.Text + "', '" + cadenaFecha + "', '" + cadenaFecha + "', '" + CStr(cbConcepto.SelectedItem) + "', '" + tbConceptoExtendido.Text + "', '" + cadenaCantidad + "', '" + Replace(CStr(balanceCuentaDestino), ",", ".") + "', '" + periodica + "');"

                Dim updateTres As String = "INSERT INTO cc_op VALUES (PALABRACLAVE, '" + cuentaDestino + "', 'Abono', '" + Replace(CStr(balanceCuentaDestino), ",", ".") + "');"

                If periodica <> "0" Then
                    updateTres += "INSERT INTO transfperiod VALUES (PALABRACLAVE, '" + cuentaOrigen + "', '" + cuentaDestino + "', '" + proximaFecha + "', '" + cadenaCantidad + "', " + periodica + ");"
                End If

                resultadoInsert = da.cudTransferencia(updateUno, updateDos, updateTres)

            ElseIf cbConcepto.SelectedItem = "Retirada de efectivo" Then

                Dim updateUno As String = "UPDATE cuentas SET Saldo='" + Replace(CStr(balanceCuentaDestino), ",", ".") + "' WHERE CC = '" + cuentaDestino + "';"

                Dim updateDos As String = "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('Cargo', '" + referenteTipoCargo + "', '" + tbRemitente.Text + "', '" + cadenaFecha + "', '" + cadenaFecha + "', '" + CStr(cbConcepto.SelectedItem) + "', '" + tbConceptoExtendido.Text + "', '" + cadenaCantidad + "', '" + Replace(CStr(balanceCuentaDestino), ",", ".") + "', '" + periodica + "');"

                Dim updateTres As String = "INSERT INTO cc_op VALUES (PALABRACLAVE, '" + cuentaDestino + "', 'Cargo', '" + Replace(CStr(balanceCuentaDestino), ",", ".") + "');"

                If periodica <> "0" Then
                    updateTres += "INSERT INTO transfperiod VALUES (PALABRACLAVE, '" + cuentaOrigen + "', '" + cuentaDestino + "', '" + proximaFecha + "', '" + cadenaCantidad + "', " + periodica + ");"
                End If

                resultadoInsert = da.cudTransferencia(updateUno, updateDos, updateTres)

            Else

                Dim updateUno As String =
                "UPDATE cuentas SET Saldo='" + Replace(CStr(balanceCuentaDestino), ",", ".") + "' WHERE CC = '" + cuentaDestino + "';" +
                "UPDATE cuentas SET Saldo='" + Replace(CStr(balanceCuentaOrigen), ",", ".") + "' WHERE CC = '" + cuentaOrigen + "';" +
                "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('Abono', '" + referenteTipoAbono + "', '" + tbRemitente.Text + "', '" + cadenaFecha + "', '" + cadenaFecha + "', '" + CStr(cbConcepto.SelectedItem) + "', '" + tbConceptoExtendido.Text + "', '" + cadenaCantidad + "', '" + Replace(CStr(balanceCuentaDestino), ",", ".") + "', '" + periodica + "');"

                Dim updateDos As String = "INSERT INTO cc_op VALUES (PALABRACLAVE, '" + cuentaDestino + "', 'Abono', '" + Replace(CStr(balanceCuentaDestino), ",", ".") + "');" +
                                            "INSERT INTO operaciones(tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES ('Cargo', '" + referenteTipoCargo + "', '" + tbRemitente.Text + "', '" + cadenaFecha + "', '" + cadenaFecha + "', '" + CStr(cbConcepto.SelectedItem) + "', '" + tbConceptoExtendido.Text + "', '" + cadenaCantidad + "', '" + Replace(CStr(balanceCuentaOrigen), ",", ".") + "', '" + periodica + "');"

                Dim updateTres As String = "INSERT INTO cc_op VALUES (PALABRACLAVE, '" + cuentaOrigen + "', 'Cargo', '" + Replace(CStr(balanceCuentaOrigen), ",", ".") + "');"

                If periodica <> "0" Then
                    updateTres += "INSERT INTO transfperiod VALUES (PALABRACLAVE, '" + cuentaOrigen + "', '" + cuentaDestino + "', '" + proximaFecha + "', '" + cadenaCantidad + "', " + periodica + ");"
                End If

                resultadoInsert = da.cudTransferencia(updateUno, updateDos, updateTres)

            End If
        End If

    End Sub

    ''Metodo que sirve para refactorizar un condicional del metodo "btEnviar_Click"
    ''Devolvera "True" si la fecha es correcta, la cuentas de origen y destino no son iguales y ningun campo esta en blanco.
    Private Function permitirEnviar()

        Dim fechaActual As Date = DateTime.Now
        Dim fechaPuesta As Date

        Dim cadenaCantidad = mtbCantidad.Text
        Dim enteroCantidad = Trim(cadenaCantidad.Substring(0, 12))
        Dim decimalCantidad = ""
        Try
            decimalCantidad = Trim(cadenaCantidad.Substring(13, 2))
        Catch ex As Exception
        End Try

        If decimalCantidad = "" Then
            cadenaCantidad = enteroCantidad + "." + "00"
        Else
            cadenaCantidad = enteroCantidad + "." + decimalCantidad
        End If


        If IsDate(mtbFecha.Text) Then
            fechaPuesta = mtbFecha.Text + " 23:59:59"

            If (IsDate(mtbFecha.Text)) And (fechaPuesta >= fechaActual) And IsNumeric(cadenaCantidad) Then

                If chbDomiciliacionMasiva.CheckState = CheckState.Checked Then

                    If (Not String.IsNullOrEmpty(cbConcepto.SelectedItem)) And (Not String.IsNullOrEmpty(cbPeriodica.SelectedItem)) And (mtbCantidad.Text <> "") And (tbRemitente.Text <> "") And (tbConceptoExtendido.Text <> "") Then

                        Return True

                    End If

                Else
                    If cbConcepto.SelectedIndex = 2 Or cbConcepto.SelectedIndex = 4 Then
                        If Not String.IsNullOrEmpty(cbCuentaDestino.SelectedItem) Or cbCuentaDestino.SelectedIndex = 0 Then
                            If (Not String.IsNullOrEmpty(cbConcepto.SelectedItem)) And (mtbCantidad.Text <> "") And (tbRemitente.Text <> "") And (tbConceptoExtendido.Text <> "") Then

                                Return True

                            End If
                        End If

                    Else

                        If (Not String.IsNullOrEmpty(cbCuentaOrigen.SelectedItem) Or cbCuentaOrigen.SelectedIndex = 0) And (Not String.IsNullOrEmpty(cbCuentaDestino.SelectedItem) Or cbCuentaDestino.SelectedIndex = 0) Then

                            If (cbCuentaOrigen.SelectedItem <> cbCuentaDestino.SelectedItem) Then

                                If (Not String.IsNullOrEmpty(cbConcepto.SelectedItem)) And (mtbCantidad.Text <> "") And (tbRemitente.Text <> "") And (tbConceptoExtendido.Text <> "") Then

                                    Return True

                                End If

                            End If
                        End If

                    End If

                End If

            End If
        End If

        Return False

    End Function

    ''Metodo que sirve para rellenar el combobox "cbEmpresaOrigen" en tiempo de ejecucion. Esto es necesario ya que los datos son obtenidos por la BD.
    ''Este combobox permite al usuario elegir de una lista de empresa donde se situa la cuenta del usuario que hara la transaccion.
    Private Sub rellenarEmpresaOrigen()

        Dim consulta As String
        Dim dsConsulta As DataSet

        consulta = "SELECT nombre FROM empresas WHERE activa=1"
        dsConsulta = da.query(consulta)

        For Each row As DataRow In dsConsulta.Tables(0).Rows
            Dim nombre As String = row("nombre")
            cbEmpresaOrigen.Items.Add(nombre)
        Next

    End Sub

    ''Metodo que sirve para rellenar el combobox "cbEmpresaDestino" en tiempo de ejecucion. Esto es necesario ya que los datos son obtenidos por la BD.
    ''Este combobox permite al usuario elegir de una lista de empresa donde se situa la cuenta del usuario que recibira la transaccion.
    Private Sub rellenarEmpresaDestino()

        Dim consulta As String
        Dim dsConsulta As DataSet

        consulta = "SELECT nombre FROM empresas WHERE activa=1"
        dsConsulta = da.query(consulta)

        For Each row As DataRow In dsConsulta.Tables(0).Rows
            Dim nombre As String = row("nombre")
            cbEmpresaDestino.Items.Add(nombre)
        Next

    End Sub

    ''Metodo que sirve para rellenar el combobox "cbPeriodica" en tiempo de ejecucion.
    ''Este combobox permite al usuario el tiempo en el cual quiere que se repita la misma transaccion.
    Private Sub rellenarPeriodica()

        Dim periodos = New String() {"No periodica", "10 Dias", "20 Dias", "30 Dias (Mensual)", "60 Dias(Bimensual)", "90 Dias(Trimestral)"}

        cbPeriodica.Text = "Selecciona un periodo..."
        For index = 0 To periodos.GetUpperBound(0)
            cbPeriodica.Items.Add(periodos(index))
        Next

    End Sub

    ''Metodo que sirve para rellenar el combobox "cbConcepto" en tiempo de ejecucion.
    ''Este combobox permite al usuario el tipo de transaccion que quiere ejecutar.
    Private Sub rellenarConceptos()

        Dim conceptos = New String() {"Abono en cuenta", "Domiciliación", "Ingreso de efectivo", "Pago con tarjeta", "Retirada de efectivo"}

        cbConcepto.DisplayMember = "Selecciona un concepto..."
        For index = 0 To conceptos.GetUpperBound(0)
            cbConcepto.Items.Add(conceptos(index))
        Next

    End Sub

    Private Sub btEnviar_Click(sender As Object, e As EventArgs) Handles btEnviar.Click

        If permitirEnviar() Then
            If cbConcepto.SelectedItem = "Ingreso de efectivo" Or cbConcepto.SelectedItem = "Retirada de efectivo" Then

                operacionBanco("A11111111", cbCuentaDestino.Text)
                MessageBox.Show("Operacion realizada correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf chbDomiciliacionMasiva.Checked Then

                Dim consulta As String
                Dim dsConsulta As DataSet

                consulta = "SELECT CC FROM cuentas WHERE usado=1"
                dsConsulta = da.query(consulta)

                For Each row As DataRow In dsConsulta.Tables(0).Rows
                    Dim cuentaDestino As String = row("CC")
                    operacionBanco("A11111111", cuentaDestino)
                Next
                MessageBox.Show("Operacion realizada correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                operacionBanco(cbCuentaOrigen.Text, cbCuentaDestino.Text)
                MessageBox.Show("Operacion realizada correctamente", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else

            MessageBox.Show("Operacion invalida", "Banca Online", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnretry_Click(sender As Object, e As EventArgs) Handles btnretry.Click
        BancaPaginaInicio.Show()
        Me.Close()
    End Sub
End Class