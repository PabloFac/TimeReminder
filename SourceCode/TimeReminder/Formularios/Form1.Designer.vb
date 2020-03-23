<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnChangeTheme = New TimeReminder.RoundedButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInicio = New System.Windows.Forms.Label()
        Me.txtFin = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIntervalo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnActionBeep = New TimeReminder.RoundedButton()
        Me.btnActionNotify = New TimeReminder.RoundedButton()
        Me.btnActionCursorNotify = New TimeReminder.RoundedButton()
        Me.btnActionAtenuar = New TimeReminder.RoundedButton()
        Me.btnActionEquipo = New TimeReminder.RoundedButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panelTiempoRestante = New System.Windows.Forms.Panel()
        Me.txtTiempoRestante = New System.Windows.Forms.Label()
        Me.btnCancelTimer = New TimeReminder.RoundedButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RoundedButton1 = New TimeReminder.RoundedButton()
        Me.tglAtenuar = New TimeReminder.ToggleControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboDuracionNotificacion = New System.Windows.Forms.ComboBox()
        Me.btnEditIntervalo = New TimeReminder.RoundedButton()
        Me.btnEditFin = New TimeReminder.RoundedButton()
        Me.btnEditInicio = New TimeReminder.RoundedButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSalir = New TimeReminder.RoundedButton()
        Me.btnStart = New TimeReminder.RoundedButton()
        Me.BarIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.subMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TimeReminderPabloFaccianoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPanelDeControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.T = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.panelActions.SuspendLayout()
        Me.panelTiempoRestante.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.subMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.Panel1.Controls.Add(Me.btnChangeTheme)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 149)
        Me.Panel1.TabIndex = 0
        '
        'btnChangeTheme
        '
        Me.btnChangeTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangeTheme.AutoCheckOnClick = False
        Me.btnChangeTheme.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnChangeTheme.BorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnChangeTheme.BorderSize = 1.0!
        Me.btnChangeTheme.Checked = False
        Me.btnChangeTheme.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnChangeTheme.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnChangeTheme.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DataBindings.Add(New System.Windows.Forms.Binding("BorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeTheme.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnChangeTheme.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnChangeTheme.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnChangeTheme.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnChangeTheme.Location = New System.Drawing.Point(722, 93)
        Me.btnChangeTheme.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnChangeTheme.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnChangeTheme.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnChangeTheme.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnChangeTheme.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnChangeTheme.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnChangeTheme.Name = "btnChangeTheme"
        Me.btnChangeTheme.Padding = New System.Windows.Forms.Padding(1)
        Me.btnChangeTheme.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnChangeTheme.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnChangeTheme.Size = New System.Drawing.Size(125, 30)
        Me.btnChangeTheme.SubBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnChangeTheme.TabIndex = 15
        Me.btnChangeTheme.Text = "Cambiar Tema"
        Me.btnChangeTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.Label2.Location = New System.Drawing.Point(33, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "- by Pablo Facciano (2020)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.Label1.Location = New System.Drawing.Point(30, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time Reminder"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label3.Location = New System.Drawing.Point(33, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Periodo de Activación:"
        '
        'txtInicio
        '
        Me.txtInicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInicio.AutoSize = True
        Me.txtInicio.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtInicio.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.txtInicio.Location = New System.Drawing.Point(30, 73)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(83, 37)
        Me.txtInicio.TabIndex = 4
        Me.txtInicio.Text = "09:00"
        '
        'txtFin
        '
        Me.txtFin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFin.AutoSize = True
        Me.txtFin.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFin.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFin.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.txtFin.Location = New System.Drawing.Point(30, 123)
        Me.txtFin.Name = "txtFin"
        Me.txtFin.Size = New System.Drawing.Size(83, 37)
        Me.txtFin.TabIndex = 10
        Me.txtFin.Text = "18:00"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label6.Location = New System.Drawing.Point(33, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Intervalo:"
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIntervalo.AutoSize = True
        Me.txtIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtIntervalo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntervalo.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.txtIntervalo.Location = New System.Drawing.Point(30, 216)
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(83, 37)
        Me.txtIntervalo.TabIndex = 13
        Me.txtIntervalo.Text = "00:05"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label8.Location = New System.Drawing.Point(250, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Acción:"
        '
        'panelActions
        '
        Me.panelActions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelActions.AutoSize = True
        Me.panelActions.Controls.Add(Me.btnActionBeep)
        Me.panelActions.Controls.Add(Me.btnActionNotify)
        Me.panelActions.Controls.Add(Me.btnActionCursorNotify)
        Me.panelActions.Controls.Add(Me.btnActionAtenuar)
        Me.panelActions.Controls.Add(Me.btnActionEquipo)
        Me.panelActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelActions.Location = New System.Drawing.Point(254, 73)
        Me.panelActions.Name = "panelActions"
        Me.panelActions.Size = New System.Drawing.Size(200, 193)
        Me.panelActions.TabIndex = 17
        '
        'btnActionBeep
        '
        Me.btnActionBeep.AutoCheckOnClick = False
        Me.btnActionBeep.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnActionBeep.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnActionBeep.BorderSize = 1.0!
        Me.btnActionBeep.Checked = False
        Me.btnActionBeep.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionBeep.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionBeep.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionBeep.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnActionBeep.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionBeep.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionBeep.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnActionBeep.Location = New System.Drawing.Point(0, 0)
        Me.btnActionBeep.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActionBeep.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionBeep.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionBeep.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionBeep.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionBeep.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionBeep.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionBeep.Name = "btnActionBeep"
        Me.btnActionBeep.Padding = New System.Windows.Forms.Padding(1)
        Me.btnActionBeep.Rounded = False
        Me.btnActionBeep.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnActionBeep.Size = New System.Drawing.Size(200, 35)
        Me.btnActionBeep.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnActionBeep.TabIndex = 10
        Me.btnActionBeep.Tag = "0"
        Me.btnActionBeep.Text = "Beep (Sonido)"
        Me.btnActionBeep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActionNotify
        '
        Me.btnActionNotify.AutoCheckOnClick = False
        Me.btnActionNotify.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnActionNotify.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnActionNotify.BorderSize = 1.0!
        Me.btnActionNotify.Checked = False
        Me.btnActionNotify.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionNotify.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionNotify.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionNotify.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnActionNotify.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionNotify.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionNotify.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnActionNotify.Location = New System.Drawing.Point(0, 35)
        Me.btnActionNotify.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActionNotify.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionNotify.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionNotify.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionNotify.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionNotify.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionNotify.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionNotify.Name = "btnActionNotify"
        Me.btnActionNotify.Padding = New System.Windows.Forms.Padding(1)
        Me.btnActionNotify.Rounded = False
        Me.btnActionNotify.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnActionNotify.Size = New System.Drawing.Size(200, 35)
        Me.btnActionNotify.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnActionNotify.TabIndex = 11
        Me.btnActionNotify.Tag = "1"
        Me.btnActionNotify.Text = "Notificacion"
        Me.btnActionNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActionCursorNotify
        '
        Me.btnActionCursorNotify.AutoCheckOnClick = False
        Me.btnActionCursorNotify.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnActionCursorNotify.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnActionCursorNotify.BorderSize = 1.0!
        Me.btnActionCursorNotify.Checked = True
        Me.btnActionCursorNotify.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionCursorNotify.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionCursorNotify.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionCursorNotify.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnActionCursorNotify.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionCursorNotify.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionCursorNotify.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnActionCursorNotify.Location = New System.Drawing.Point(0, 70)
        Me.btnActionCursorNotify.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActionCursorNotify.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionCursorNotify.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionCursorNotify.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionCursorNotify.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionCursorNotify.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionCursorNotify.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionCursorNotify.Name = "btnActionCursorNotify"
        Me.btnActionCursorNotify.Padding = New System.Windows.Forms.Padding(1)
        Me.btnActionCursorNotify.Rounded = False
        Me.btnActionCursorNotify.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnActionCursorNotify.Size = New System.Drawing.Size(200, 35)
        Me.btnActionCursorNotify.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnActionCursorNotify.TabIndex = 12
        Me.btnActionCursorNotify.Tag = "2"
        Me.btnActionCursorNotify.Text = "Notif. en Cursor"
        Me.btnActionCursorNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActionAtenuar
        '
        Me.btnActionAtenuar.AutoCheckOnClick = False
        Me.btnActionAtenuar.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnActionAtenuar.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnActionAtenuar.BorderSize = 1.0!
        Me.btnActionAtenuar.Checked = False
        Me.btnActionAtenuar.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionAtenuar.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionAtenuar.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionAtenuar.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnActionAtenuar.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionAtenuar.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionAtenuar.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnActionAtenuar.Location = New System.Drawing.Point(0, 105)
        Me.btnActionAtenuar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActionAtenuar.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionAtenuar.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionAtenuar.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionAtenuar.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionAtenuar.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionAtenuar.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionAtenuar.Name = "btnActionAtenuar"
        Me.btnActionAtenuar.Padding = New System.Windows.Forms.Padding(1)
        Me.btnActionAtenuar.Rounded = False
        Me.btnActionAtenuar.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnActionAtenuar.Size = New System.Drawing.Size(200, 35)
        Me.btnActionAtenuar.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnActionAtenuar.TabIndex = 15
        Me.btnActionAtenuar.Tag = "3"
        Me.btnActionAtenuar.Text = "Atenuar Pantalla"
        Me.btnActionAtenuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActionEquipo
        '
        Me.btnActionEquipo.AutoCheckOnClick = False
        Me.btnActionEquipo.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnActionEquipo.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnActionEquipo.BorderSize = 1.0!
        Me.btnActionEquipo.Checked = False
        Me.btnActionEquipo.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionEquipo.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor1
        Me.btnActionEquipo.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActionEquipo.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnActionEquipo.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionEquipo.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionEquipo.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnActionEquipo.Location = New System.Drawing.Point(0, 140)
        Me.btnActionEquipo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActionEquipo.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionEquipo.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnActionEquipo.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnActionEquipo.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionEquipo.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnActionEquipo.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnActionEquipo.Name = "btnActionEquipo"
        Me.btnActionEquipo.Padding = New System.Windows.Forms.Padding(1)
        Me.btnActionEquipo.Rounded = False
        Me.btnActionEquipo.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnActionEquipo.Size = New System.Drawing.Size(200, 35)
        Me.btnActionEquipo.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnActionEquipo.TabIndex = 14
        Me.btnActionEquipo.Tag = "4"
        Me.btnActionEquipo.Text = "Bloquear Equipo"
        Me.btnActionEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label9.Location = New System.Drawing.Point(510, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Notificación:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label11.Location = New System.Drawing.Point(510, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Mostrar durante:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label12.Location = New System.Drawing.Point(510, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Titulo:"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTitle.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTitle.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.txtTitle.Location = New System.Drawing.Point(513, 162)
        Me.txtTitle.MaxLength = 255
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(159, 23)
        Me.txtTitle.TabIndex = 23
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMessage.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.txtMessage.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtMessage.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtMessage.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.txtMessage.Location = New System.Drawing.Point(688, 99)
        Me.txtMessage.MaxLength = 255
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(159, 150)
        Me.txtMessage.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label13.Location = New System.Drawing.Point(685, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Mensaje:"
        '
        'panelTiempoRestante
        '
        Me.panelTiempoRestante.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.panelTiempoRestante.Controls.Add(Me.txtTiempoRestante)
        Me.panelTiempoRestante.Controls.Add(Me.btnCancelTimer)
        Me.panelTiempoRestante.Controls.Add(Me.Label14)
        Me.panelTiempoRestante.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.panelTiempoRestante.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTiempoRestante.Location = New System.Drawing.Point(0, 149)
        Me.panelTiempoRestante.Name = "panelTiempoRestante"
        Me.panelTiempoRestante.Size = New System.Drawing.Size(888, 50)
        Me.panelTiempoRestante.TabIndex = 26
        Me.panelTiempoRestante.Visible = False
        '
        'txtTiempoRestante
        '
        Me.txtTiempoRestante.AutoSize = True
        Me.txtTiempoRestante.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTiempoRestante.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoRestante.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.txtTiempoRestante.Location = New System.Drawing.Point(168, 15)
        Me.txtTiempoRestante.Name = "txtTiempoRestante"
        Me.txtTiempoRestante.Size = New System.Drawing.Size(70, 21)
        Me.txtTiempoRestante.TabIndex = 28
        Me.txtTiempoRestante.Text = "00:00:46"
        '
        'btnCancelTimer
        '
        Me.btnCancelTimer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelTimer.AutoCheckOnClick = False
        Me.btnCancelTimer.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnCancelTimer.BorderColor = System.Drawing.Color.Empty
        Me.btnCancelTimer.BorderSize = 1.0!
        Me.btnCancelTimer.Checked = False
        Me.btnCancelTimer.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnCancelTimer.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnCancelTimer.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancelTimer.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnCancelTimer.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancelTimer.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancelTimer.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnCancelTimer.Location = New System.Drawing.Point(746, 10)
        Me.btnCancelTimer.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCancelTimer.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnCancelTimer.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnCancelTimer.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCancelTimer.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnCancelTimer.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnCancelTimer.Name = "btnCancelTimer"
        Me.btnCancelTimer.Padding = New System.Windows.Forms.Padding(1)
        Me.btnCancelTimer.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnCancelTimer.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnCancelTimer.Size = New System.Drawing.Size(101, 30)
        Me.btnCancelTimer.SubBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCancelTimer.TabIndex = 27
        Me.btnCancelTimer.Text = "Cancelar"
        Me.btnCancelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.Label14.Location = New System.Drawing.Point(33, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 21)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Proxima accion en "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RoundedButton1)
        Me.Panel3.Controls.Add(Me.tglAtenuar)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.comboDuracionNotificacion)
        Me.Panel3.Controls.Add(Me.txtMessage)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtTitle)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.panelActions)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnEditIntervalo)
        Me.Panel3.Controls.Add(Me.txtIntervalo)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.btnEditFin)
        Me.Panel3.Controls.Add(Me.txtFin)
        Me.Panel3.Controls.Add(Me.btnEditInicio)
        Me.Panel3.Controls.Add(Me.txtInicio)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 199)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(888, 291)
        Me.Panel3.TabIndex = 27
        '
        'RoundedButton1
        '
        Me.RoundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedButton1.AutoCheckOnClick = False
        Me.RoundedButton1.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.RoundedButton1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.RoundedButton1.BorderSize = 1.0!
        Me.RoundedButton1.Checked = False
        Me.RoundedButton1.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.RoundedButton1.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.RoundedButton1.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RoundedButton1.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.RoundedButton1.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.RoundedButton1.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.RoundedButton1.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.RoundedButton1.Location = New System.Drawing.Point(374, 33)
        Me.RoundedButton1.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.RoundedButton1.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.RoundedButton1.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.RoundedButton1.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.RoundedButton1.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.RoundedButton1.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.RoundedButton1.Name = "RoundedButton1"
        Me.RoundedButton1.Padding = New System.Windows.Forms.Padding(1)
        Me.RoundedButton1.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.RoundedButton1.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.RoundedButton1.Size = New System.Drawing.Size(80, 27)
        Me.RoundedButton1.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.RoundedButton1.TabIndex = 12
        Me.RoundedButton1.Text = "Probar"
        Me.RoundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tglAtenuar
        '
        Me.tglAtenuar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tglAtenuar.AutoCheckOnClick = True
        Me.tglAtenuar.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglAtenuar.BorderColor = Global.TimeReminder.My.MySettings.Default.ColorDark
        Me.tglAtenuar.BorderSize = 1.0!
        Me.tglAtenuar.Checked = True
        Me.tglAtenuar.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglAtenuar.CheckedBorderColor = System.Drawing.SystemColors.ControlDark
        Me.tglAtenuar.CheckedForeColor = System.Drawing.SystemColors.ControlText
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("BorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("FrontColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("FrontColorChecked", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglAtenuar.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.tglAtenuar.DisabledBorderColor = System.Drawing.Color.Transparent
        Me.tglAtenuar.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.tglAtenuar.FrontColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.tglAtenuar.FrontColorChecked = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.tglAtenuar.FrontColorDisabled = System.Drawing.SystemColors.ControlLight
        Me.tglAtenuar.FrontPadding = New System.Windows.Forms.Padding(0)
        Me.tglAtenuar.Location = New System.Drawing.Point(514, 223)
        Me.tglAtenuar.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglAtenuar.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglAtenuar.MouseDownForeColor = System.Drawing.SystemColors.ControlText
        Me.tglAtenuar.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.tglAtenuar.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.tglAtenuar.MouseOverForeColor = System.Drawing.SystemColors.ControlText
        Me.tglAtenuar.Name = "tglAtenuar"
        Me.tglAtenuar.Padding = New System.Windows.Forms.Padding(5)
        Me.tglAtenuar.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.tglAtenuar.RoundResolution = 100
        Me.tglAtenuar.Size = New System.Drawing.Size(60, 30)
        Me.tglAtenuar.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglAtenuar.TabIndex = 31
        Me.tglAtenuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label4.Location = New System.Drawing.Point(510, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Oscurecer Pantalla:"
        '
        'comboDuracionNotificacion
        '
        Me.comboDuracionNotificacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.comboDuracionNotificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDuracionNotificacion.FormattingEnabled = True
        Me.comboDuracionNotificacion.Items.AddRange(New Object() {"1 Segundo", "3 Segundos", "5 Segundos", "10 Segundos", "15 Segundos", "30 Segundos", "60 Segundos"})
        Me.comboDuracionNotificacion.Location = New System.Drawing.Point(514, 99)
        Me.comboDuracionNotificacion.Name = "comboDuracionNotificacion"
        Me.comboDuracionNotificacion.Size = New System.Drawing.Size(157, 23)
        Me.comboDuracionNotificacion.TabIndex = 26
        '
        'btnEditIntervalo
        '
        Me.btnEditIntervalo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditIntervalo.AutoCheckOnClick = False
        Me.btnEditIntervalo.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnEditIntervalo.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnEditIntervalo.BorderSize = 1.0!
        Me.btnEditIntervalo.Checked = False
        Me.btnEditIntervalo.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnEditIntervalo.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnEditIntervalo.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditIntervalo.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnEditIntervalo.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditIntervalo.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditIntervalo.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnEditIntervalo.Location = New System.Drawing.Point(128, 219)
        Me.btnEditIntervalo.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnEditIntervalo.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnEditIntervalo.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditIntervalo.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnEditIntervalo.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnEditIntervalo.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnEditIntervalo.Name = "btnEditIntervalo"
        Me.btnEditIntervalo.Padding = New System.Windows.Forms.Padding(1)
        Me.btnEditIntervalo.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnEditIntervalo.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnEditIntervalo.Size = New System.Drawing.Size(76, 30)
        Me.btnEditIntervalo.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnEditIntervalo.TabIndex = 14
        Me.btnEditIntervalo.Text = "Editar"
        Me.btnEditIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditFin
        '
        Me.btnEditFin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditFin.AutoCheckOnClick = False
        Me.btnEditFin.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnEditFin.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnEditFin.BorderSize = 1.0!
        Me.btnEditFin.Checked = False
        Me.btnEditFin.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnEditFin.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnEditFin.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditFin.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnEditFin.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditFin.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditFin.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnEditFin.Location = New System.Drawing.Point(128, 126)
        Me.btnEditFin.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnEditFin.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnEditFin.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditFin.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnEditFin.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnEditFin.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnEditFin.Name = "btnEditFin"
        Me.btnEditFin.Padding = New System.Windows.Forms.Padding(1)
        Me.btnEditFin.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnEditFin.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnEditFin.Size = New System.Drawing.Size(76, 30)
        Me.btnEditFin.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnEditFin.TabIndex = 11
        Me.btnEditFin.Text = "Editar"
        Me.btnEditFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditInicio
        '
        Me.btnEditInicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditInicio.AutoCheckOnClick = False
        Me.btnEditInicio.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnEditInicio.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnEditInicio.BorderSize = 1.0!
        Me.btnEditInicio.Checked = False
        Me.btnEditInicio.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnEditInicio.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnEditInicio.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEditInicio.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnEditInicio.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditInicio.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditInicio.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnEditInicio.Location = New System.Drawing.Point(128, 76)
        Me.btnEditInicio.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnEditInicio.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnEditInicio.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnEditInicio.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnEditInicio.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnEditInicio.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnEditInicio.Name = "btnEditInicio"
        Me.btnEditInicio.Padding = New System.Windows.Forms.Padding(1)
        Me.btnEditInicio.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnEditInicio.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnEditInicio.Size = New System.Drawing.Size(76, 30)
        Me.btnEditInicio.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnEditInicio.TabIndex = 9
        Me.btnEditInicio.Text = "Editar"
        Me.btnEditInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.Panel4.Controls.Add(Me.btnSalir)
        Me.Panel4.Controls.Add(Me.btnStart)
        Me.Panel4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 490)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(888, 60)
        Me.Panel4.TabIndex = 28
        '
        'btnSalir
        '
        Me.btnSalir.AutoCheckOnClick = False
        Me.btnSalir.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnSalir.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnSalir.BorderSize = 1.0!
        Me.btnSalir.Checked = False
        Me.btnSalir.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnSalir.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnSalir.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnSalir.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnSalir.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnSalir.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnSalir.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnSalir.Location = New System.Drawing.Point(37, 15)
        Me.btnSalir.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnSalir.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnSalir.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnSalir.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnSalir.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnSalir.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(1)
        Me.btnSalir.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnSalir.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnSalir.Size = New System.Drawing.Size(100, 30)
        Me.btnSalir.SubBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnStart.AutoCheckOnClick = False
        Me.btnStart.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnStart.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnStart.BorderSize = 1.0!
        Me.btnStart.Checked = False
        Me.btnStart.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnStart.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnStart.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnStart.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnStart.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnStart.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnStart.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnStart.Location = New System.Drawing.Point(747, 15)
        Me.btnStart.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnStart.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnStart.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnStart.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnStart.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnStart.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Padding = New System.Windows.Forms.Padding(1)
        Me.btnStart.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnStart.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnStart.Size = New System.Drawing.Size(100, 30)
        Me.btnStart.SubBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Comenzar"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BarIcon
        '
        Me.BarIcon.ContextMenuStrip = Me.subMenu
        Me.BarIcon.Icon = CType(resources.GetObject("BarIcon.Icon"), System.Drawing.Icon)
        Me.BarIcon.Text = "TimeReminder"
        Me.BarIcon.Visible = True
        '
        'subMenu
        '
        Me.subMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.subMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeReminderPabloFaccianoToolStripMenuItem, Me.VerPanelDeControlToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.subMenu.Name = "subMenu"
        Me.subMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.subMenu.ShowCheckMargin = True
        Me.subMenu.ShowImageMargin = False
        Me.subMenu.Size = New System.Drawing.Size(240, 86)
        '
        'TimeReminderPabloFaccianoToolStripMenuItem
        '
        Me.TimeReminderPabloFaccianoToolStripMenuItem.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.TimeReminderPabloFaccianoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TimeReminderPabloFaccianoToolStripMenuItem.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.TimeReminderPabloFaccianoToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.TimeReminderPabloFaccianoToolStripMenuItem.Name = "TimeReminderPabloFaccianoToolStripMenuItem"
        Me.TimeReminderPabloFaccianoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.TimeReminderPabloFaccianoToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.TimeReminderPabloFaccianoToolStripMenuItem.Text = "TimeReminder (PabloFacciano)"
        '
        'VerPanelDeControlToolStripMenuItem
        '
        Me.VerPanelDeControlToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VerPanelDeControlToolStripMenuItem.Name = "VerPanelDeControlToolStripMenuItem"
        Me.VerPanelDeControlToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.VerPanelDeControlToolStripMenuItem.Text = "&Ver Panel de Control"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.ToolStripSeparator1.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(236, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'T
        '
        Me.T.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.ClientSize = New System.Drawing.Size(888, 550)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panelTiempoRestante)
        Me.Controls.Add(Me.Panel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Reminder (Pablo Facciano)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelActions.ResumeLayout(False)
        Me.panelTiempoRestante.ResumeLayout(False)
        Me.panelTiempoRestante.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.subMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToggleControl1 As ToggleControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInicio As Label
    Friend WithEvents btnEditInicio As RoundedButton
    Friend WithEvents btnEditFin As RoundedButton
    Friend WithEvents txtFin As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEditIntervalo As RoundedButton
    Friend WithEvents txtIntervalo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents panelActions As FlowLayoutPanel
    Friend WithEvents btnActionBeep As RoundedButton
    Friend WithEvents btnActionNotify As RoundedButton
    Friend WithEvents btnActionCursorNotify As RoundedButton
    Friend WithEvents btnActionEquipo As RoundedButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents panelTiempoRestante As Panel
    Friend WithEvents btnCancelTimer As RoundedButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSalir As RoundedButton
    Friend WithEvents btnStart As RoundedButton
    Friend WithEvents txtTiempoRestante As Label
    Friend WithEvents comboDuracionNotificacion As ComboBox
    Friend WithEvents btnChangeTheme As RoundedButton
    Friend WithEvents BarIcon As NotifyIcon
    Friend WithEvents T As Timer
    Friend WithEvents subMenu As ContextMenuStrip
    Friend WithEvents VerPanelDeControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeReminderPabloFaccianoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tglAtenuar As ToggleControl
    Friend WithEvents Label4 As Label
    Friend WithEvents btnActionAtenuar As RoundedButton
    Friend WithEvents RoundedButton1 As RoundedButton
End Class
