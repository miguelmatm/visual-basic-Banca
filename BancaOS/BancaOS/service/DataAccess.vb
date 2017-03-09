Imports MySql.Data.MySqlClient
Public Class DataAccess
    Public Function connect()
        Dim txtConnection As String = "Server=127.0.0.1; " &
            "Database=bancaonline; Uid=root; Pwd=;"
        Dim connection As New MySqlConnection(txtConnection)
        Try
            connection.Open()
        Catch ex As Exception
            MsgBox("Error al conectar con la BD")
        End Try
        Return connection
    End Function
    Public Sub disconnect(conex As MySqlConnection)
        Try
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar con la BD")
        End Try
    End Sub

    Public Function cud(Cons As String)
        Dim num As Integer
        Dim conex As MySqlConnection

        conex = connect()

        Dim comn As New MySqlCommand(Cons, conex)

        Try
            num = comn.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox("Error al ejecutar la consulta 1")
        End Try

        disconnect(conex)

        Return num
    End Function
    Public Function query(qu As String)
        Dim ds As New DataSet
        Dim conex As MySqlConnection

        conex = connect()

        Dim adap As New MySqlDataAdapter(qu, conex)

        Try
            adap.Fill(ds, "Users")
        Catch ex As Exception
            'MsgBox("Error al ejecutar la consulta 2")
        End Try

        disconnect(conex)

        Return ds
    End Function

    Public Function cudTransferencia(ConsUno As String, ConsDos As String, ConsTres As String)
        Dim num As Integer
        Dim conex As MySqlConnection
        Dim allCorrect = 0

        Try
            conex = connect()


            Dim transaction = conex.BeginTransaction()
            Dim comn As New MySqlCommand(ConsUno, conex)
            num = comn.ExecuteNonQuery()

            allCorrect += num
            Dim ultimoId = comn.LastInsertedId

            ConsDos = ConsDos.Replace("PALABRACLAVE", ultimoId)
            comn = New MySqlCommand(ConsDos, conex)
            num = comn.ExecuteNonQuery()

            allCorrect += num
            ultimoId = comn.LastInsertedId

            ConsTres = ConsTres.Replace("PALABRACLAVE", ultimoId)
            comn = New MySqlCommand(ConsTres, conex)
            num = comn.ExecuteNonQuery()
            allCorrect += num

            transaction.Commit()

        Catch ex As Exception
            'MsgBox("Error al ejecutar la consulta 1")
        End Try

        disconnect(conex)

        Return allCorrect
    End Function
End Class