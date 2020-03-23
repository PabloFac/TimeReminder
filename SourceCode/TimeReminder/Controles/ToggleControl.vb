Public Class ToggleControl
    Inherits RoundedButton


#Region "Properties"

#Region "Colores"

#Region "Front Color"

    Private _frontColor As Color = SystemColors.ControlLightLight
    Public Property FrontColor As Color
        Get
            Return _frontColor
        End Get
        Set(value As Color)
            _frontColor = value
        End Set
    End Property

    Private _frontColorChecked As Color = SystemColors.ControlDark
    Public Property FrontColorChecked As Color
        Get
            Return _frontColorChecked
        End Get
        Set(value As Color)
            _frontColorChecked = value
        End Set
    End Property

    Private _frontColorDisabled As Color = SystemColors.ControlLight
    Public Property FrontColorDisabled As Color
        Get
            Return _frontColorDisabled
        End Get
        Set(value As Color)
            _frontColorDisabled = value
        End Set
    End Property

#End Region

#End Region

#Region "Otros"

    Private Property _frontPadding As Padding = New Padding(0)
    Public Property FrontPadding As Padding
        Get
            Return _frontPadding
        End Get
        Set(value As Padding)
            _frontPadding = value
            UpdateFrontPoints()
        End Set
    End Property

#End Region

#End Region

    Private frPoints As PointF() = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        If (frPoints Is Nothing) Then
            UpdateFrontPoints()
        End If

        With e.Graphics
            ' Color a utilizar
            Dim frColor As Color
            If (Not Me.Enabled) Then
                frColor = FrontColorDisabled
            ElseIf (Me.Checked) Then
                frColor = FrontColorChecked
            Else
                frColor = FrontColor
            End If
            ' FrontColor
            .FillPolygon(New SolidBrush(frColor), frPoints)
        End With

    End Sub

    Private Sub RoundedButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        UpdateFrontPoints()
    End Sub


    Private Function getForegroundRegionToPaint() As PointF()
        Dim radius As Single = (Height / 2)
        If Rounded Then

            Dim origin As PointF
            Dim y As Single = radius
            If Checked Then
                origin = New Point(Width - radius, y)
            Else
                origin = New Point(radius, y)
            End If

            Return getPointsOfCircle(RoundResolution, (ClientSize.Height / 2) - (FrontPadding.Top), origin).ToArray

        Else

            radius = (radius * 2)
            Dim topLeft, topRight, bottomLeft, bottomRight As PointF

            If Checked Then
                topLeft = New PointF(Width - radius - FrontPadding.Right, FrontPadding.Top)
            Else
                topLeft = New PointF(FrontPadding.Left, FrontPadding.Top)
            End If
            topRight = New PointF(topLeft.X + radius, topLeft.Y)
            bottomLeft = New PointF(topLeft.X, topLeft.Y + radius - FrontPadding.Vertical)
            bottomRight = New PointF(topLeft.X + radius, topLeft.Y + radius - FrontPadding.Vertical)



            Return {topLeft, topRight, bottomRight, bottomLeft, topLeft}

        End If
        Return Nothing
    End Function
    Public Sub UpdateFrontPoints()
        frPoints = getForegroundRegionToPaint()
    End Sub

    Private Sub ToggleControl_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        UpdateFrontPoints()
    End Sub
End Class
