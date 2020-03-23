Public Class frmNotificacion

    Public Margen As Integer = 30

    Private Sub frmNotificacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblHora.Text = Now.ToString("HH:mm")
        CentrarFormularioEnCursor()
        Me.BringToFront()
        AutoClose.Interval = My.Settings.NotifyDuration.TotalMilliseconds
        AutoClose.Start()
        AutoCenter.Start()
    End Sub

    Private Sub T_Tick(sender As Object, e As EventArgs) Handles AutoClose.Tick
        AutoClose.Stop()
        AutoCenter.Stop()
        If My.Settings.NotifyAtenuarPantalla Then frmAtenuador.Close()
        Me.Close()
    End Sub

    Sub CentrarFormularioEnCursor()
        Me.Location = New Point(Cursor.Position.X - (Width / 2), Cursor.Position.Y - Height - Margen)
    End Sub

    Private Sub AutoCenter_Tick(sender As Object, e As EventArgs) Handles AutoCenter.Tick
        CentrarFormularioEnCursor()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class