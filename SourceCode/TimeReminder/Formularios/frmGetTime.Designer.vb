<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGetTime
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.footer = New System.Windows.Forms.Panel()
        Me.btnCancel = New TimeReminder.RoundedButton()
        Me.btnOK = New TimeReminder.RoundedButton()
        Me.content = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.table = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMinuteDown = New TimeReminder.RoundedButton()
        Me.btnHourDown = New TimeReminder.RoundedButton()
        Me.btnMinuteUp = New TimeReminder.RoundedButton()
        Me.btnHourUp = New TimeReminder.RoundedButton()
        Me.txtHour = New System.Windows.Forms.Label()
        Me.txtMinute = New System.Windows.Forms.Label()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.footer.SuspendLayout()
        Me.content.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.table.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'footer
        '
        Me.footer.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.footer.Controls.Add(Me.btnCancel)
        Me.footer.Controls.Add(Me.btnOK)
        Me.footer.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(1, 155)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(241, 54)
        Me.footer.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.AutoCheckOnClick = False
        Me.btnCancel.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnCancel.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnCancel.BorderSize = 1.0!
        Me.btnCancel.Checked = False
        Me.btnCancel.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnCancel.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnCancel.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnCancel.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnCancel.Location = New System.Drawing.Point(17, 10)
        Me.btnCancel.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCancel.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCancel.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnCancel.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnCancel.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(1)
        Me.btnCancel.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnCancel.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.SubBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.AutoCheckOnClick = False
        Me.btnOK.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnOK.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnOK.BorderSize = 1.0!
        Me.btnOK.Checked = False
        Me.btnOK.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnOK.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnOK.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOK.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnOK.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOK.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOK.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOK.Location = New System.Drawing.Point(123, 10)
        Me.btnOK.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnOK.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnOK.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOK.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnOK.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnOK.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Padding = New System.Windows.Forms.Padding(1)
        Me.btnOK.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnOK.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnOK.Size = New System.Drawing.Size(100, 35)
        Me.btnOK.SubBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "Aceptar"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'content
        '
        Me.content.AutoScroll = True
        Me.content.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.content.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.content.Controls.Add(Me.Panel1)
        Me.content.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.content.Location = New System.Drawing.Point(1, 1)
        Me.content.Name = "content"
        Me.content.Size = New System.Drawing.Size(241, 154)
        Me.content.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.table)
        Me.Panel1.Location = New System.Drawing.Point(20, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 130)
        Me.Panel1.TabIndex = 7
        '
        'table
        '
        Me.table.ColumnCount = 2
        Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table.Controls.Add(Me.btnMinuteDown, 1, 2)
        Me.table.Controls.Add(Me.btnHourDown, 0, 2)
        Me.table.Controls.Add(Me.btnMinuteUp, 1, 0)
        Me.table.Controls.Add(Me.btnHourUp, 0, 0)
        Me.table.Controls.Add(Me.txtHour, 0, 1)
        Me.table.Controls.Add(Me.txtMinute, 1, 1)
        Me.table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table.Location = New System.Drawing.Point(0, 0)
        Me.table.Margin = New System.Windows.Forms.Padding(0)
        Me.table.Name = "table"
        Me.table.RowCount = 3
        Me.table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table.Size = New System.Drawing.Size(200, 130)
        Me.table.TabIndex = 6
        '
        'btnMinuteDown
        '
        Me.btnMinuteDown.AutoCheckOnClick = False
        Me.btnMinuteDown.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnMinuteDown.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnMinuteDown.BorderSize = 1.0!
        Me.btnMinuteDown.Checked = False
        Me.btnMinuteDown.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnMinuteDown.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnMinuteDown.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteDown.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnMinuteDown.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteDown.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMinuteDown.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMinuteDown.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnMinuteDown.Location = New System.Drawing.Point(105, 91)
        Me.btnMinuteDown.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMinuteDown.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnMinuteDown.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnMinuteDown.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteDown.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnMinuteDown.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnMinuteDown.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteDown.Name = "btnMinuteDown"
        Me.btnMinuteDown.Padding = New System.Windows.Forms.Padding(1)
        Me.btnMinuteDown.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnMinuteDown.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnMinuteDown.Size = New System.Drawing.Size(90, 34)
        Me.btnMinuteDown.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnMinuteDown.TabIndex = 14
        Me.btnMinuteDown.Text = ""
        Me.btnMinuteDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHourDown
        '
        Me.btnHourDown.AutoCheckOnClick = False
        Me.btnHourDown.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnHourDown.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnHourDown.BorderSize = 1.0!
        Me.btnHourDown.Checked = False
        Me.btnHourDown.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnHourDown.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnHourDown.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourDown.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnHourDown.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourDown.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHourDown.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHourDown.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnHourDown.Location = New System.Drawing.Point(5, 91)
        Me.btnHourDown.Margin = New System.Windows.Forms.Padding(5)
        Me.btnHourDown.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnHourDown.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnHourDown.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourDown.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnHourDown.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnHourDown.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourDown.Name = "btnHourDown"
        Me.btnHourDown.Padding = New System.Windows.Forms.Padding(1)
        Me.btnHourDown.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnHourDown.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnHourDown.Size = New System.Drawing.Size(90, 34)
        Me.btnHourDown.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnHourDown.TabIndex = 14
        Me.btnHourDown.Text = ""
        Me.btnHourDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinuteUp
        '
        Me.btnMinuteUp.AutoCheckOnClick = False
        Me.btnMinuteUp.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnMinuteUp.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnMinuteUp.BorderSize = 1.0!
        Me.btnMinuteUp.Checked = False
        Me.btnMinuteUp.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnMinuteUp.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnMinuteUp.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnMinuteUp.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnMinuteUp.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteUp.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMinuteUp.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMinuteUp.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnMinuteUp.Location = New System.Drawing.Point(105, 5)
        Me.btnMinuteUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMinuteUp.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnMinuteUp.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnMinuteUp.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteUp.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnMinuteUp.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnMinuteUp.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnMinuteUp.Name = "btnMinuteUp"
        Me.btnMinuteUp.Padding = New System.Windows.Forms.Padding(1)
        Me.btnMinuteUp.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnMinuteUp.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnMinuteUp.Size = New System.Drawing.Size(90, 33)
        Me.btnMinuteUp.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnMinuteUp.TabIndex = 14
        Me.btnMinuteUp.Text = ""
        Me.btnMinuteUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHourUp
        '
        Me.btnHourUp.AutoCheckOnClick = False
        Me.btnHourUp.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnHourUp.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnHourUp.BorderSize = 1.0!
        Me.btnHourUp.Checked = False
        Me.btnHourUp.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnHourUp.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnHourUp.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnHourUp.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnHourUp.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourUp.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHourUp.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHourUp.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnHourUp.Location = New System.Drawing.Point(5, 5)
        Me.btnHourUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnHourUp.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnHourUp.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnHourUp.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourUp.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnHourUp.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnHourUp.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnHourUp.Name = "btnHourUp"
        Me.btnHourUp.Padding = New System.Windows.Forms.Padding(1)
        Me.btnHourUp.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnHourUp.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnHourUp.Size = New System.Drawing.Size(90, 33)
        Me.btnHourUp.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnHourUp.TabIndex = 14
        Me.btnHourUp.Text = ""
        Me.btnHourUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHour
        '
        Me.txtHour.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtHour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHour.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHour.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.txtHour.Location = New System.Drawing.Point(3, 43)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(94, 43)
        Me.txtHour.TabIndex = 5
        Me.txtHour.Text = "12"
        Me.txtHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMinute
        '
        Me.txtMinute.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtMinute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMinute.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinute.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.txtMinute.Location = New System.Drawing.Point(103, 43)
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(94, 43)
        Me.txtMinute.TabIndex = 6
        Me.txtMinute.Text = "59"
        Me.txtMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelContainer
        '
        Me.panelContainer.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.panelContainer.Controls.Add(Me.content)
        Me.panelContainer.Controls.Add(Me.footer)
        Me.panelContainer.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 0)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Padding = New System.Windows.Forms.Padding(1)
        Me.panelContainer.Size = New System.Drawing.Size(243, 210)
        Me.panelContainer.TabIndex = 3
        '
        'frmGetTime
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.ClientSize = New System.Drawing.Size(243, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelContainer)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGetTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Seleccionar Tiempo"
        Me.footer.ResumeLayout(False)
        Me.content.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.table.ResumeLayout(False)
        Me.panelContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents footer As Panel
    Friend WithEvents btnCancel As RoundedButton
    Friend WithEvents btnOK As RoundedButton
    Friend WithEvents content As Panel
    Friend WithEvents table As TableLayoutPanel
    Friend WithEvents txtHour As Label
    Friend WithEvents txtMinute As Label
    Friend WithEvents btnMinuteDown As RoundedButton
    Friend WithEvents btnHourDown As RoundedButton
    Friend WithEvents btnMinuteUp As RoundedButton
    Friend WithEvents btnHourUp As RoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelContainer As Panel
End Class
