Public Class EmpresaInicio
    Private Sub EmpresaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize Screen
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        ' Place bottom "X"
        Dim Height As Integer = Me.Size.Width
        BtnClose.Location = New Point(Height - BtnClose.Size.Width, 2)
        Dim x, y As Short
        x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' get x
        y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height ' get y
        LblCopyRight.Location = New Point((x / 2) - (LblCopyRight.Size.Width / 2), y - 75) ' Copyright Position

        pblogo.Location = New Point((x - pblogo.Width) \ 2, (y - pblogo.Height) \ 15)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "¿Está seguro que desea salir?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Cerrar Aplicación"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.
            Application.Exit()
        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "¿Está seguro que desea cerrar sesión?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Cerrar Sesión"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.
            Login.Show()
            Me.Close()
        End If
    End Sub


End Class
