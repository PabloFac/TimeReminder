Public Class Form1

#Region "Propiedades"

    Private _startTime As TimeSpan
    Public Property StartTime As TimeSpan
        Get
            Return _startTime
        End Get
        Set(value As TimeSpan)
            _startTime = value
            txtInicio.Text = String.Format("{0}:{1}", value.ToString("hh"), value.ToString("mm"))
        End Set
    End Property
    Private _endTime As TimeSpan
    Public Property EndTime As TimeSpan
        Get
            Return _endTime
        End Get
        Set(value As TimeSpan)
            _endTime = value
            txtFin.Text = String.Format("{0}:{1}", value.ToString("hh"), value.ToString("mm"))
        End Set
    End Property
    Private _intervalTime As TimeSpan
    Public Property IntervalTime As TimeSpan
        Get
            Return _intervalTime
        End Get
        Set(value As TimeSpan)
            _intervalTime = value
            txtIntervalo.Text = String.Format("{0}:{1}", value.ToString("hh"), value.ToString("mm"))
        End Set
    End Property

    Private _action As Byte
    Public Property Action As Byte
        Get
            Return _action
        End Get
        Set(value As Byte)
            _action = value

            For Each B As RoundedButton In panelActions.Controls
                B.Checked = (B.Tag = value)
            Next

            panelActions.Refresh()
        End Set
    End Property

    Private _duracionNotificacion As TimeSpan
    Public Property DuracionNotificacion As TimeSpan
        Get
            Return _duracionNotificacion
        End Get
        Set(value As TimeSpan)
            _duracionNotificacion = value

            Dim index As Integer
            Select Case value
                Case TimeSpan.FromSeconds(1) : index = 0
                Case TimeSpan.FromSeconds(3) : index = 1
                Case TimeSpan.FromSeconds(5) : index = 2
                Case TimeSpan.FromSeconds(10) : index = 3
                Case TimeSpan.FromSeconds(15) : index = 4
                Case TimeSpan.FromSeconds(30) : index = 5
                Case TimeSpan.FromSeconds(60) : index = 6
            End Select
            comboDuracionNotificacion.SelectedIndex = index

        End Set
    End Property

#End Region

#Region "Controles de Configuracion"

    Private Sub btnChangeTheme_Click(sender As Object, e As EventArgs) Handles btnChangeTheme.Click
        Using frm As New frmGetTheme
            If (frm.ShowDialog() = DialogResult.OK) Then Application.Restart()
        End Using
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEditInicio_Click(sender As Object, e As EventArgs) Handles btnEditInicio.Click
        Dim input = InputTimespan(StartTime)
        If (input < EndTime) Then StartTime = input Else MsgBox("La hora de inicio debe ser menor que la hora de fin.", MsgBoxStyle.Critical, "Error")
    End Sub
    Private Sub btnEditFin_Click(sender As Object, e As EventArgs) Handles btnEditFin.Click
        Dim input = InputTimespan(EndTime)
        If (input > StartTime) Then EndTime = input Else MsgBox("La hora de fin debe ser mayor que la hora de inicio.", MsgBoxStyle.Critical, "Error")
    End Sub
    Private Sub btnEditInterval_Click(sender As Object, e As EventArgs) Handles btnEditIntervalo.Click
        Dim input = InputTimespan(IntervalTime)

        If (input > (EndTime - StartTime)) Then MsgBox("El intervalo debe ser menor o igual que la diferencia entre la hora de inicio y la hora de fin.", MsgBoxStyle.Critical, "Error") : Exit Sub
        If (input < TimeSpan.FromSeconds(60)) Then MsgBox("El intervalo debe ser mayor o igual a 1 minuto.", MsgBoxStyle.Critical, "Error") : Exit Sub

        IntervalTime = input
    End Sub
    Private Sub btnAction_Click(sender As RoundedButton, e As EventArgs) Handles _
        btnActionBeep.Click,
        btnActionNotify.Click,
        btnActionCursorNotify.Click,
        btnActionAtenuar.Click,
        btnActionEquipo.Click

        Action = sender.Tag
    End Sub
    Private Sub comboDuracionNotificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDuracionNotificacion.SelectedIndexChanged

        Dim ts As TimeSpan
        Select Case comboDuracionNotificacion.SelectedIndex
            Case 0 : ts = TimeSpan.FromSeconds(1)
            Case 1 : ts = TimeSpan.FromSeconds(3)
            Case 2 : ts = TimeSpan.FromSeconds(5)
            Case 3 : ts = TimeSpan.FromSeconds(10)
            Case 4 : ts = TimeSpan.FromSeconds(15)
            Case 5 : ts = TimeSpan.FromSeconds(30)
            Case 6 : ts = TimeSpan.FromSeconds(60)
        End Select
        If DuracionNotificacion <> ts Then DuracionNotificacion = ts

    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        SaveData()
        DoActionSelected()
    End Sub

#End Region

#Region "Controles de Timer"

    Sub MostrarPanelDeControl()
        If T.Enabled Then
            btnStart.Text = "Ocultar"
        Else
            btnStart.Text = "Comenzar"
        End If
        Me.Show()
    End Sub

    Private Sub VerPanelDeControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPanelDeControlToolStripMenuItem.Click
        MostrarPanelDeControl()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btnCancelTimer_Click(sender As Object, e As EventArgs) Handles btnCancelTimer.Click
        CancelProgram()
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        SaveData()
        If T.Enabled Then
            Me.Hide()
        Else
            StartProgram()
        End If
    End Sub

    Private Sub BarIcon_DoubleClick(sender As Object, e As EventArgs) Handles BarIcon.DoubleClick
        MostrarPanelDeControl()
    End Sub

#End Region

#Region "Proceso Timer"

    Private LastNotification As Date
    Private Function getTiempoRestante() As TimeSpan
        Return ((LastNotification + My.Settings.IntervalTime) - Now)
    End Function
    Private Function isTimeForNewNotification() As Boolean
        If LastNotification = Nothing Then LastNotification = Now : Return False

        Return (Now > (LastNotification + My.Settings.IntervalTime))

    End Function

    Private Function isInTimeRange() As Boolean
        Return ((Now.TimeOfDay >= StartTime) And (Now.TimeOfDay <= EndTime))
    End Function

    Sub StartProgram()
        Me.Hide()
        LastNotification = Now
        T.Start()
    End Sub
    Sub CancelProgram()
        T.Stop()
        panelTiempoRestante.Visible = False
        btnStart.Text = "Comenzar"
        btnStart.Refresh()
    End Sub

    Private Sub T_Tick(sender As Object, e As EventArgs) Handles T.Tick
        If Not isInTimeRange() Then Exit Sub
        Dim notifyNow = isTimeForNewNotification()

        If notifyNow Then DoActionSelected()

        If Me.Visible Then
            panelTiempoRestante.Visible = True
            txtTiempoRestante.Text = getTiempoRestante.ToString("hh\:mm\:ss\.ff")
        End If

    End Sub

    Private Sub DoActionSelected()
        LastNotification = Now
        Dim action As Byte = My.Settings.IntervalAction
        Select Case action
            Case 0 : Beep()
            Case 1 : MostrarNotificacionComun()
            Case 2 : MostrarNotificacionEnCursor()
            Case 3 : AtenuarPantalla()
            Case 4 : BloquearEquipo()
        End Select
    End Sub

    Sub MostrarNotificacionComun()

        BarIcon.ShowBalloonTip(My.Settings.NotifyDuration.TotalMilliseconds, My.Settings.NotifyTitle, My.Settings.NotifyText, ToolTipIcon.None)

    End Sub
    Sub MostrarNotificacionEnCursor()
        If My.Settings.NotifyAtenuarPantalla Then AtenuarPantalla()
        frmNotificacion.Show()
    End Sub

#End Region

#Region " Formulario y Datos "

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveData()

        If e.CloseReason = CloseReason.UserClosing Then
            If (MsgBox("Estas seguro de salir?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Salir")) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

    Sub LoadData()

        StartTime = My.Settings.StartTime
        EndTime = My.Settings.EndTime
        IntervalTime = My.Settings.IntervalTime
        Action = My.Settings.IntervalAction
        DuracionNotificacion = My.Settings.NotifyDuration
        txtTitle.Text = My.Settings.NotifyTitle
        txtMessage.Text = My.Settings.NotifyText
        tglAtenuar.Checked = My.Settings.NotifyAtenuarPantalla

    End Sub
    Sub SaveData()

        My.Settings.StartTime = StartTime
        My.Settings.EndTime = EndTime
        My.Settings.IntervalTime = IntervalTime
        My.Settings.IntervalAction = Action
        My.Settings.NotifyDuration = DuracionNotificacion
        My.Settings.NotifyTitle = txtTitle.Text
        My.Settings.NotifyText = txtMessage.Text
        My.Settings.NotifyAtenuarPantalla = tglAtenuar.Checked
        My.Settings.Save()

    End Sub


#End Region


End Class
