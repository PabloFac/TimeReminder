<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGetTheme
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New TimeReminder.RoundedButton()
        Me.btnOk = New TimeReminder.RoundedButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.panelColorPrincipalClaro = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.panelColorPrincipalOscuro = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.panelColorFondoMuyClaro = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panelColorFondoClaro = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panelColorFondo = New System.Windows.Forms.Panel()
        Me.panelColorFondoOscuro = New System.Windows.Forms.Panel()
        Me.panelTemas = New System.Windows.Forms.Panel()
        Me.btnCustom = New TimeReminder.RoundedButton()
        Me.btnLight = New TimeReminder.RoundedButton()
        Me.btnDark = New TimeReminder.RoundedButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelTextoPrincipal = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelColorClaro = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelColorOscuro = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelColorFondoMuyOscuro = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelColorPrincipal = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tglRounded = New TimeReminder.ToggleControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG = New System.Windows.Forms.ColorDialog()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelTemas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOk)
        Me.Panel4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 652)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(687, 60)
        Me.Panel4.TabIndex = 29
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancel.AutoCheckOnClick = False
        Me.btnCancel.BackColor = Global.TimeReminder.My.MySettings.Default.Color
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
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCancel.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnCancel.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnCancel.Location = New System.Drawing.Point(416, 15)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCancel.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCancel.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCancel.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCancel.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnCancel.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnCancel.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(1)
        Me.btnCancel.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnCancel.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.SubBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnOk.AutoCheckOnClick = False
        Me.btnOk.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnOk.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnOk.BorderSize = 1.0!
        Me.btnOk.Checked = False
        Me.btnOk.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnOk.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnOk.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnOk.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnOk.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOk.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOk.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnOk.Location = New System.Drawing.Point(546, 15)
        Me.btnOk.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnOk.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnOk.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnOk.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnOk.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnOk.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(1)
        Me.btnOk.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnOk.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnOk.Size = New System.Drawing.Size(100, 30)
        Me.btnOk.SubBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "Guardar"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.panelColorPrincipalClaro)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.panelColorPrincipalOscuro)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.panelColorFondoMuyClaro)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.panelColorFondoClaro)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.panelColorFondo)
        Me.Panel1.Controls.Add(Me.panelColorFondoOscuro)
        Me.Panel1.Controls.Add(Me.panelTemas)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.panelTextoPrincipal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.panelColorClaro)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.panelColorOscuro)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.panelColorFondoMuyOscuro)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.panelColorPrincipal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tglRounded)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 552)
        Me.Panel1.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label16.Location = New System.Drawing.Point(427, 183)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 21)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Color Principal Claro"
        '
        'panelColorPrincipalClaro
        '
        Me.panelColorPrincipalClaro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorPrincipalClaro.Location = New System.Drawing.Point(370, 178)
        Me.panelColorPrincipalClaro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorPrincipalClaro.Name = "panelColorPrincipalClaro"
        Me.panelColorPrincipalClaro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorPrincipalClaro.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label15.Location = New System.Drawing.Point(427, 263)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(166, 21)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Color Principal Oscuro"
        '
        'panelColorPrincipalOscuro
        '
        Me.panelColorPrincipalOscuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorPrincipalOscuro.Location = New System.Drawing.Point(370, 258)
        Me.panelColorPrincipalOscuro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorPrincipalOscuro.Name = "panelColorPrincipalOscuro"
        Me.panelColorPrincipalOscuro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorPrincipalOscuro.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label14.Location = New System.Drawing.Point(96, 351)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 21)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Color de Fondo (Muy Claro)"
        '
        'panelColorFondoMuyClaro
        '
        Me.panelColorFondoMuyClaro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorFondoMuyClaro.Location = New System.Drawing.Point(39, 346)
        Me.panelColorFondoMuyClaro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorFondoMuyClaro.Name = "panelColorFondoMuyClaro"
        Me.panelColorFondoMuyClaro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorFondoMuyClaro.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label13.Location = New System.Drawing.Point(96, 309)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 21)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Color de Fondo (Claro)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label12.Location = New System.Drawing.Point(96, 267)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 21)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Color de Fondo "
        '
        'panelColorFondoClaro
        '
        Me.panelColorFondoClaro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorFondoClaro.Location = New System.Drawing.Point(39, 304)
        Me.panelColorFondoClaro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorFondoClaro.Name = "panelColorFondoClaro"
        Me.panelColorFondoClaro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorFondoClaro.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label11.Location = New System.Drawing.Point(96, 225)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 21)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Color de Fondo (Oscuro)"
        '
        'panelColorFondo
        '
        Me.panelColorFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorFondo.Location = New System.Drawing.Point(39, 262)
        Me.panelColorFondo.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorFondo.Name = "panelColorFondo"
        Me.panelColorFondo.Size = New System.Drawing.Size(45, 30)
        Me.panelColorFondo.TabIndex = 21
        '
        'panelColorFondoOscuro
        '
        Me.panelColorFondoOscuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorFondoOscuro.Location = New System.Drawing.Point(39, 220)
        Me.panelColorFondoOscuro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorFondoOscuro.Name = "panelColorFondoOscuro"
        Me.panelColorFondoOscuro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorFondoOscuro.TabIndex = 30
        '
        'panelTemas
        '
        Me.panelTemas.Controls.Add(Me.btnCustom)
        Me.panelTemas.Controls.Add(Me.btnLight)
        Me.panelTemas.Controls.Add(Me.btnDark)
        Me.panelTemas.Location = New System.Drawing.Point(19, 116)
        Me.panelTemas.Name = "panelTemas"
        Me.panelTemas.Size = New System.Drawing.Size(380, 53)
        Me.panelTemas.TabIndex = 29
        '
        'btnCustom
        '
        Me.btnCustom.AutoCheckOnClick = True
        Me.btnCustom.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnCustom.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnCustom.BorderSize = 1.0!
        Me.btnCustom.Checked = False
        Me.btnCustom.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnCustom.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnCustom.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustom.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnCustom.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCustom.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCustom.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnCustom.Location = New System.Drawing.Point(244, 12)
        Me.btnCustom.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCustom.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCustom.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnCustom.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnCustom.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnCustom.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnCustom.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Padding = New System.Windows.Forms.Padding(1)
        Me.btnCustom.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnCustom.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnCustom.Size = New System.Drawing.Size(100, 30)
        Me.btnCustom.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnCustom.TabIndex = 16
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLight
        '
        Me.btnLight.AutoCheckOnClick = True
        Me.btnLight.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnLight.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnLight.BorderSize = 1.0!
        Me.btnLight.Checked = False
        Me.btnLight.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnLight.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnLight.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnLight.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnLight.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnLight.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnLight.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnLight.Location = New System.Drawing.Point(132, 12)
        Me.btnLight.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLight.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnLight.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnLight.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnLight.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnLight.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnLight.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Padding = New System.Windows.Forms.Padding(1)
        Me.btnLight.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnLight.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnLight.Size = New System.Drawing.Size(100, 30)
        Me.btnLight.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnLight.TabIndex = 14
        Me.btnLight.Text = "Light"
        Me.btnLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDark
        '
        Me.btnDark.AutoCheckOnClick = True
        Me.btnDark.BackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.btnDark.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnDark.BorderSize = 1.0!
        Me.btnDark.Checked = False
        Me.btnDark.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnDark.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.btnDark.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBorderColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("MouseDownBackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DataBindings.Add(New System.Windows.Forms.Binding("MouseOverForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDark.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.btnDark.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnDark.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnDark.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.btnDark.Location = New System.Drawing.Point(20, 12)
        Me.btnDark.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDark.MouseDownBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnDark.MouseDownBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor3
        Me.btnDark.MouseDownForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteLight
        Me.btnDark.MouseOverBackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnDark.MouseOverBorderColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.btnDark.MouseOverForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.btnDark.Name = "btnDark"
        Me.btnDark.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDark.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.btnDark.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.btnDark.Size = New System.Drawing.Size(100, 30)
        Me.btnDark.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.btnDark.TabIndex = 10
        Me.btnDark.Text = "Dark"
        Me.btnDark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.Label10.Location = New System.Drawing.Point(36, 489)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(490, 30)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "En ciertos tipos de pantallas, usar colores oscuros puede reducir el consumo de e" &
    "nergia." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En entornos de poca luz, utilizar un tema oscuro ayuda a que la vista n" &
    "o se canse tan rapido."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "ColorDarken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = Global.TimeReminder.My.MySettings.Default.ColorDarken
        Me.Label9.Location = New System.Drawing.Point(118, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(431, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Puede afectar la velocidad de renderizado del software en equipos de gama baja."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label8.Location = New System.Drawing.Point(427, 305)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 42)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Color de Texto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sobre Colores Principales"
        '
        'panelTextoPrincipal
        '
        Me.panelTextoPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTextoPrincipal.Location = New System.Drawing.Point(370, 300)
        Me.panelTextoPrincipal.Margin = New System.Windows.Forms.Padding(6)
        Me.panelTextoPrincipal.Name = "panelTextoPrincipal"
        Me.panelTextoPrincipal.Size = New System.Drawing.Size(45, 30)
        Me.panelTextoPrincipal.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label6.Location = New System.Drawing.Point(96, 435)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Color Claro General"
        '
        'panelColorClaro
        '
        Me.panelColorClaro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorClaro.Location = New System.Drawing.Point(39, 430)
        Me.panelColorClaro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorClaro.Name = "panelColorClaro"
        Me.panelColorClaro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorClaro.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label7.Location = New System.Drawing.Point(96, 393)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 21)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Color Oscuro General"
        '
        'panelColorOscuro
        '
        Me.panelColorOscuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorOscuro.Location = New System.Drawing.Point(39, 388)
        Me.panelColorOscuro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorOscuro.Name = "panelColorOscuro"
        Me.panelColorOscuro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorOscuro.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label5.Location = New System.Drawing.Point(96, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Color de Fondo (Muy Oscuro)"
        '
        'panelColorFondoMuyOscuro
        '
        Me.panelColorFondoMuyOscuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorFondoMuyOscuro.Location = New System.Drawing.Point(39, 178)
        Me.panelColorFondoMuyOscuro.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorFondoMuyOscuro.Name = "panelColorFondoMuyOscuro"
        Me.panelColorFondoMuyOscuro.Size = New System.Drawing.Size(45, 30)
        Me.panelColorFondoMuyOscuro.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label4.Location = New System.Drawing.Point(427, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Color Principal"
        '
        'panelColorPrincipal
        '
        Me.panelColorPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColorPrincipal.Location = New System.Drawing.Point(370, 220)
        Me.panelColorPrincipal.Margin = New System.Windows.Forms.Padding(6)
        Me.panelColorPrincipal.Name = "panelColorPrincipal"
        Me.panelColorPrincipal.Size = New System.Drawing.Size(45, 30)
        Me.panelColorPrincipal.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label2.Location = New System.Drawing.Point(35, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tema:"
        '
        'tglRounded
        '
        Me.tglRounded.AutoCheckOnClick = True
        Me.tglRounded.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglRounded.BorderColor = Global.TimeReminder.My.MySettings.Default.ColorDark
        Me.tglRounded.BorderSize = 1.0!
        Me.tglRounded.Checked = True
        Me.tglRounded.CheckedBackColor = Global.TimeReminder.My.MySettings.Default.Color
        Me.tglRounded.CheckedBorderColor = Global.TimeReminder.My.MySettings.Default.ColorDark
        Me.tglRounded.CheckedForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("BorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("CheckedForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("DisabledBorderColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("DisabledForeColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("RoundResolution", Global.TimeReminder.My.MySettings.Default, "RoundedResolution", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("Rounded", Global.TimeReminder.My.MySettings.Default, "RoundedButtons", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("CheckedBackColor", Global.TimeReminder.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("FrontColorChecked", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("FrontColorDisabled", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("FrontColor", Global.TimeReminder.My.MySettings.Default, "ColorLighten", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DataBindings.Add(New System.Windows.Forms.Binding("SubBackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tglRounded.DisabledBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglRounded.DisabledBorderColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.tglRounded.DisabledForeColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.tglRounded.FrontColor = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.tglRounded.FrontColorChecked = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.tglRounded.FrontColorDisabled = Global.TimeReminder.My.MySettings.Default.ColorLighten
        Me.tglRounded.FrontPadding = New System.Windows.Forms.Padding(0)
        Me.tglRounded.Location = New System.Drawing.Point(39, 36)
        Me.tglRounded.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.tglRounded.MouseDownBorderColor = System.Drawing.SystemColors.ControlDark
        Me.tglRounded.MouseDownForeColor = System.Drawing.SystemColors.ControlText
        Me.tglRounded.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.tglRounded.MouseOverBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tglRounded.MouseOverForeColor = System.Drawing.SystemColors.ControlText
        Me.tglRounded.Name = "tglRounded"
        Me.tglRounded.Padding = New System.Windows.Forms.Padding(5)
        Me.tglRounded.Rounded = Global.TimeReminder.My.MySettings.Default.RoundedButtons
        Me.tglRounded.RoundResolution = Global.TimeReminder.My.MySettings.Default.RoundedResolution
        Me.tglRounded.Size = New System.Drawing.Size(60, 30)
        Me.tglRounded.SubBackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.tglRounded.TabIndex = 13
        Me.tglRounded.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.Label3.Location = New System.Drawing.Point(118, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Usar esquinas redondeadas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = Global.TimeReminder.My.MySettings.Default.AccentColor2
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "AccentColor2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(687, 100)
        Me.Panel2.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AccentForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.TimeReminder.My.MySettings.Default.AccentForeColor
        Me.Label1.Location = New System.Drawing.Point(32, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Crea un Tema"
        '
        'DG
        '
        Me.DG.AnyColor = True
        Me.DG.FullOpen = True
        '
        'frmGetTheme
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Global.TimeReminder.My.MySettings.Default.ColorLight
        Me.ClientSize = New System.Drawing.Size(687, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TimeReminder.My.MySettings.Default, "ColorLight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.TimeReminder.My.MySettings.Default, "AbsoluteDark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ForeColor = Global.TimeReminder.My.MySettings.Default.AbsoluteDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGetTheme"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea un Tema - Time Reminder"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelTemas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDark As RoundedButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnOk As RoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tglRounded As ToggleControl
    Friend WithEvents btnLight As RoundedButton
    Friend WithEvents Label5 As Label
    Friend WithEvents panelColorFondoMuyOscuro As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents panelColorPrincipal As Panel
    Friend WithEvents btnCustom As RoundedButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents panelColorClaro As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents panelColorOscuro As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents panelTextoPrincipal As Panel
    Friend WithEvents DG As ColorDialog
    Friend WithEvents btnCancel As RoundedButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents panelTemas As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents panelColorFondoMuyClaro As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents panelColorFondoClaro As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents panelColorFondo As Panel
    Friend WithEvents panelColorFondoOscuro As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents panelColorPrincipalClaro As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents panelColorPrincipalOscuro As Panel
End Class
