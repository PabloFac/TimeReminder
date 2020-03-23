Public Class frmGetTime



#Region "Propiedades"


    Private _quickForm As Boolean = True
    Public Property QuickForm As Boolean
        Get
            Return _quickForm
        End Get
        Set(value As Boolean)
            _quickForm = value
            If (QuickForm) Then
                FormBorderStyle = FormBorderStyle.None
                panelContainer.Padding = New Padding(2)
                CenterToMouse()
            Else
                FormBorderStyle = FormBorderStyle.FixedSingle
                panelContainer.Padding = New Padding(0)
                Me.CenterToScreen()
            End If
        End Set
    End Property


    Private TS As TimeSpan
    Public Property TimeSelected As TimeSpan
        Get
            Return TS
        End Get
        Set(value As TimeSpan)
            TS = value
            ShowTime()
        End Set
    End Property


#End Region



    Private Sub ShowTime()
        txtHour.Text = TS.Hours
        txtMinute.Text = TS.Minutes
    End Sub

    Public Sub CenterToMouse()
        Me.Location = New Point(Cursor.Position.X - (Width / 2), Cursor.Position.Y - (Height / 2))
    End Sub





    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub btnHourDown_Click(sender As Object, e As EventArgs) Handles btnHourDown.Click, btnHourDown.DoubleClick
        If (TS.Hours > 0) Then
            TS = TS.Add(TimeSpan.FromHours(-1))
            ShowTime()
        End If
    End Sub
    Private Sub btnHourUp_Click(sender As Object, e As EventArgs) Handles btnHourUp.Click, btnHourUp.DoubleClick
        If (TS.Hours < 23) Then
            TS = TS.Add(TimeSpan.FromHours(1))
            ShowTime()
        End If
    End Sub
    Private Sub btnMinuteUp_Click(sender As Object, e As EventArgs) Handles btnMinuteUp.Click, btnMinuteUp.DoubleClick
        If (TS.Minutes < 59) Then
            TS = TS.Add(TimeSpan.FromMinutes(1))
            ShowTime()
        End If
    End Sub
    Private Sub btnMinuteDown_Click(sender As Object, e As EventArgs) Handles btnMinuteDown.Click, btnMinuteDown.DoubleClick
        If (TS.Minutes > 0) Then
            TS = TS.Add(TimeSpan.FromMinutes(-1))
            ShowTime()
        End If
    End Sub


End Class