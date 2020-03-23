Public Class frmAtenuador

    Private Sub frmAtenuador_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size
        Me.BringToFront()
    End Sub

    Private Sub frmAtenuador_MouseMove() Handles Me.MouseDown
        Me.Close()
    End Sub

End Class