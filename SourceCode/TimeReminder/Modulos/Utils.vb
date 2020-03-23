Imports System.Runtime.InteropServices

Module Utils

    Public Function getFirstHalfListOfPoints(lista As List(Of PointF)) As List(Of PointF)
        Return lista.GetRange(0, Math.Round(lista.Count / 2))
    End Function
    Public Function getSecondHalfListOfPoints(lista As List(Of PointF)) As List(Of PointF)
        Return lista.GetRange(Math.Round(lista.Count / 2), (lista.Count - Math.Round(lista.Count / 2)))
    End Function


    ' Graphics
    Public Function getPointsOfCircle(count As Integer, radius As Single, Optional origin As PointF = Nothing) As List(Of PointF)

        '
        If (count < 3) Then count = 3
        If (origin = Nothing) Then origin = New PointF()

        '
        Dim stepSize As Single = 360 / count
        Dim points As New List(Of PointF)

        '
        For angle = -90 To 270 Step stepSize
            points.Add(getOnePointOfCircle(radius, angle, origin))
        Next

        '
        Return points

    End Function
    Public Function getOnePointOfCircle(radius As Single, angle As Single, Optional origin As PointF = Nothing) As PointF
        If (origin = Nothing) Then origin = New PointF()

        Dim _angle = angle * (Math.PI / 180) ' Convert from Degrees To Radians
        Dim x As Single = origin.X + (radius * Math.Cos(_angle))
        Dim y As Single = origin.Y + (radius * Math.Sin(_angle))

        Return New PointF(x, y)
    End Function
    Public Sub setHighQualityGraphics(ByRef g As Graphics)
        With g

            .CompositingMode = Drawing2D.CompositingMode.SourceOver
            .CompositingQuality = Drawing2D.CompositingQuality.AssumeLinear
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            .PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            .TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        End With
    End Sub

    ' Modals
    Public Function InputTimespan() As TimeSpan
        Using f As New frmGetTime
            f.QuickForm = True
            f.TimeSelected = New TimeSpan(0, 0, 0)
            If (f.ShowDialog = DialogResult.OK) Then
                Return f.TimeSelected
            End If
        End Using
        Return Nothing
    End Function
    Public Function InputTimespan(ts As TimeSpan) As TimeSpan
        Using f As New frmGetTime
            f.QuickForm = True
            f.TimeSelected = ts
            If (f.ShowDialog = DialogResult.OK) Then
                Return f.TimeSelected
            End If
        End Using
        Return Nothing
    End Function

    ' Otros

    Public Sub AtenuarPantalla()
        frmAtenuador.Show()
    End Sub

    Private Declare Function LockWorkStation Lib "user32.dll" () As Long
    Public Sub BloquearEquipo()
        LockWorkStation
    End Sub


End Module
