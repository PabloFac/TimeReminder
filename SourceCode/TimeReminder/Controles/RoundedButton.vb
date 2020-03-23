Public Class RoundedButton


#Region "Properties"

#Region "BorderColor"

    Private _borderSize As Single = 1
    Public Property BorderSize As Single
        Get
            Return _borderSize
        End Get
        Set(value As Single)
            _borderSize = value
        End Set
    End Property

    Private _borderColor As Color = SystemColors.ControlDark
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
        End Set
    End Property
    Private _borderDisabledColor As Color = Color.Transparent
    Public Property DisabledBorderColor As Color
        Get
            Return _borderDisabledColor
        End Get
        Set(value As Color)
            _borderDisabledColor = value
        End Set
    End Property
    Private _borderCheckedColor As Color = SystemColors.ControlDark
    Public Property CheckedBorderColor As Color
        Get
            Return _borderCheckedColor
        End Get
        Set(value As Color)
            _borderCheckedColor = value
        End Set
    End Property
    Private _mouseDownBorderColor As Color = SystemColors.ControlDark
    Public Property MouseDownBorderColor As Color
        Get
            Return _mouseDownBorderColor
        End Get
        Set(value As Color)
            _mouseDownBorderColor = value
        End Set
    End Property
    Private _mouseOverBorderColor As Color = SystemColors.ControlDarkDark
    Public Property MouseOverBorderColor As Color
        Get
            Return _mouseOverBorderColor
        End Get
        Set(value As Color)
            _mouseOverBorderColor = value
        End Set
    End Property

#End Region

#Region "BackColor"

    Private _subBackColor As Color = SystemColors.Control
    Public Property SubBackColor As Color
        Get
            Return _subBackColor
        End Get
        Set(value As Color)
            _subBackColor = value
        End Set
    End Property
    Private _disabledBackColor As Color = SystemColors.Control
    Public Property DisabledBackColor As Color
        Get
            Return _disabledBackColor
        End Get
        Set(value As Color)
            _disabledBackColor = value
        End Set
    End Property
    Private _checkedBackColor As Color = SystemColors.ControlDark
    Public Property CheckedBackColor As Color
        Get
            Return _checkedBackColor
        End Get
        Set(value As Color)
            _checkedBackColor = value
        End Set
    End Property
    Private _mouseDownBackColor As Color = SystemColors.ControlLight
    Public Property MouseDownBackColor As Color
        Get
            Return _mouseDownBackColor
        End Get
        Set(value As Color)
            _mouseDownBackColor = value
        End Set
    End Property
    Private _mouseOverBackColor As Color = SystemColors.Control
    Public Property MouseOverBackColor As Color
        Get
            Return _mouseOverBackColor
        End Get
        Set(value As Color)
            _mouseOverBackColor = value
        End Set
    End Property

#End Region

#Region "ForeColor"

    Private _disabledForeColor As Color = SystemColors.GrayText
    Public Property DisabledForeColor As Color
        Get
            Return _disabledForeColor
        End Get
        Set(value As Color)
            _disabledForeColor = value
        End Set
    End Property
    Private _checkedForeColor As Color = SystemColors.ControlText
    Public Property CheckedForeColor As Color
        Get
            Return _checkedForeColor
        End Get
        Set(value As Color)
            _checkedForeColor = value
        End Set
    End Property
    Private _mouseDownForeColor As Color = SystemColors.ControlText
    Public Property MouseDownForeColor As Color
        Get
            Return _mouseDownForeColor
        End Get
        Set(value As Color)
            _mouseDownForeColor = value
        End Set
    End Property
    Private _mouseOverForeColor As Color = SystemColors.ControlText
    Public Property MouseOverForeColor As Color
        Get
            Return _mouseOverForeColor
        End Get
        Set(value As Color)
            _mouseOverForeColor = value
        End Set
    End Property

#End Region

#Region "CheckBox"

    Protected Event CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

    Public Property AutoCheckOnClick As Boolean = False

    Private _checked As Boolean = False
    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            _checked = value
            RaiseEvent CheckedChanged(Me, New EventArgs())
        End Set
    End Property

#End Region

#Region "Otras"

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            UpdateDrawPoints()
        End Set
    End Property

    Private _textAlign As ContentAlignment = ContentAlignment.MiddleCenter
    Public Property TextAlign As ContentAlignment
        Get
            Return _textAlign
        End Get
        Set(value As ContentAlignment)
            _textAlign = value
            UpdateDrawPoints()
        End Set
    End Property

    Private _roundResolution As Integer = 100
    Public Property RoundResolution As Integer
        Get
            Return _roundResolution
        End Get
        Set(value As Integer)
            _roundResolution = value
            UpdateDrawPoints()
        End Set
    End Property

    Private _rounded As Boolean = True
    Public Property Rounded As Boolean
        Get
            Return _rounded
        End Get
        Set(value As Boolean)
            _rounded = value
            UpdateDrawPoints()
        End Set
    End Property

    Private _hasMouse As Boolean
    Public Property HasMouse As Boolean
        Get
            Return _hasMouse
        End Get
        Private Set(value As Boolean)
            _hasMouse = value
            Me.Invalidate()
        End Set
    End Property

    Private _isMouseDown As Boolean
    Public Property IsMouseDown As Boolean
        Get
            Return _isMouseDown
        End Get
        Private Set(value As Boolean)
            _isMouseDown = value
            Me.Invalidate()
        End Set
    End Property

    Private _textPadding As Padding = New Padding(0)
    Public Property TextPadding As Padding
        Get
            Return _textPadding
        End Get
        Private Set(value As Padding)
            _textPadding = value
            UpdateDrawPoints()
        End Set
    End Property

#End Region

#End Region

    Private textLocation As PointF
    Private bgPoints As PointF()

    Public Sub New()
        InitializeComponent()
        Me.ResizeRedraw = True
        UpdateDrawPoints()
    End Sub

    Protected Sub Me_OnClick() Handles Me.Click
        If AutoCheckOnClick Then Checked = Not Checked
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        If bgPoints Is Nothing Then
            UpdateDrawPoints()
        End If

        setHighQualityGraphics(e.Graphics)
            With e.Graphics

                ' Elegir Colores
                Dim bgColor As Color = Color.Transparent
                Dim borderColor As Color = Color.Transparent
                Dim txtColor As Color = Color.Transparent
                If (Not Me.Enabled) Then
                    bgColor = Me.DisabledBackColor
                    borderColor = Me.DisabledBorderColor
                    txtColor = Me.DisabledForeColor
                ElseIf (Me.IsMouseDown) Then
                    bgColor = Me.MouseDownBackColor
                    borderColor = Me.MouseDownBorderColor
                    txtColor = Me.MouseDownForeColor
                ElseIf (Me.HasMouse) Then
                    bgColor = Me.MouseOverBackColor
                    borderColor = Me.MouseOverBorderColor
                    txtColor = Me.MouseOverForeColor
                ElseIf (Me.Checked) Then
                    bgColor = Me.CheckedBackColor
                    borderColor = Me.CheckedBorderColor
                    txtColor = Me.CheckedForeColor
                Else
                    bgColor = Me.BackColor
                    borderColor = Me.BorderColor
                    txtColor = Me.ForeColor
                End If

                ' SubBackColor
                .Clear(SubBackColor)
                ' Border
                If (borderColor <> Color.Transparent) And (Me.BorderSize <> 0) Then .DrawPolygon(New Pen(borderColor, Me.BorderSize), bgPoints)
                ' Background
                If (bgColor <> Color.Transparent) Then .FillPolygon(New SolidBrush(bgColor), bgPoints)
                ' Text
                If (txtColor <> Color.Transparent) And (Trim(Me.Text) <> String.Empty) Then .DrawString(Me.Text, Me.Font, New SolidBrush(txtColor), textLocation)

            End With


    End Sub

    Private Sub HandleHasMouse() Handles Me.MouseEnter, Me.Enter
        HasMouse = True
    End Sub
    Private Sub HandleNotHasMouse() Handles Me.MouseLeave
        HasMouse = False
    End Sub
    Private Sub HandleIsMouseDown() Handles Me.MouseDown
        IsMouseDown = True
    End Sub
    Private Sub HandleIsNotMouseDown() Handles Me.MouseUp
        IsMouseDown = False
    End Sub


    Private Function getTextLocation() As PointF

        Dim textSize As SizeF = TextRenderer.MeasureText(Me.Text, Me.Font)
        Dim X, Y As Single

        ' Coordenadas X
        Dim xLeft, xCenter, xRight As Single
        xLeft = TextPadding.Left
        xCenter = (Width / 2) - (textSize.Width / 2)
        xRight = Width - textSize.Width - TextPadding.Right
        ' Coordenadas Y
        Dim yTop, yMiddle, yBottom As Single
        yTop = TextPadding.Top
        yMiddle = (Height / 2) - (textSize.Height / 2)
        yBottom = Height - textSize.Height - TextPadding.Bottom

        ' Build a pair
        Select Case Me.TextAlign
            Case ContentAlignment.TopLeft
                X = xLeft
                Y = yTop
            Case ContentAlignment.TopCenter
                X = xCenter
                Y = yTop
            Case ContentAlignment.TopRight
                X = xRight
                Y = yTop
            Case ContentAlignment.MiddleLeft
                X = xLeft
                Y = yMiddle
            Case ContentAlignment.MiddleCenter
                X = xCenter
                Y = yMiddle
            Case ContentAlignment.MiddleRight
                X = xRight
                Y = yMiddle
            Case ContentAlignment.BottomLeft
                X = xLeft
                Y = yBottom
            Case ContentAlignment.BottomCenter
                X = xCenter
                Y = yBottom
            Case ContentAlignment.BottomRight
                X = xRight
                Y = yBottom
        End Select

        Return New Point(X, Y)
    End Function
    Private Function getBackgroundRegionToPaint() As PointF()
        If Rounded Then

            Dim radius As Single = (Height / 2) - (Padding.Bottom)
            Dim circleLeft = getPointsOfCircle(RoundResolution, radius, New Point(Padding.Left + radius, Padding.Top + radius))
            Dim circleRight = getPointsOfCircle(RoundResolution, radius, New Point(Width - radius - Padding.Right, Padding.Top + radius))
            Dim arcLeft = getSecondHalfListOfPoints(circleLeft)
            Dim arcRight = getFirstHalfListOfPoints(circleRight)
            Dim pointsFinal As PointF() = arcLeft.Concat(arcRight).ToArray()

            Return pointsFinal

        Else

            Dim topLeft As New PointF(Padding.Left, Padding.Top)
            Dim topRight As New PointF(Width - Padding.Right, Padding.Top)
            Dim bottomLeft As New PointF(Padding.Left, Height - Padding.Bottom)
            Dim bottomRight As New PointF(Width - Padding.Right, Height - Padding.Bottom)

            Return {topLeft, topRight, bottomRight, bottomLeft}

        End If
        Return Nothing
    End Function
    Private Sub RoundedButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        UpdateDrawPoints()
    End Sub

    Public Sub UpdateDrawPoints()
        textLocation = getTextLocation()
        bgPoints = getBackgroundRegionToPaint()
    End Sub


End Class
