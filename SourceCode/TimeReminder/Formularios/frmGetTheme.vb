Public Class frmGetTheme

    Sub LoadSettings()

        tglRounded.Checked = My.Settings.RoundedButtons

        ' Color Principal
        panelColorPrincipalClaro.BackColor = My.Settings.AccentColor1
        panelColorPrincipal.BackColor = My.Settings.AccentColor2
        panelColorPrincipalOscuro.BackColor = My.Settings.AccentColor3
        panelTextoPrincipal.BackColor = My.Settings.AccentForeColor
        ' Color General
        panelColorClaro.BackColor = My.Settings.AbsoluteLight
        panelColorOscuro.BackColor = My.Settings.AbsoluteDark
        ' Color de Fondo
        panelColorFondoMuyOscuro.BackColor = My.Settings.ColorDarken
        panelColorFondoOscuro.BackColor = My.Settings.ColorDark
        panelColorFondo.BackColor = My.Settings.Color
        panelColorFondoClaro.BackColor = My.Settings.ColorLight
        panelColorFondoMuyClaro.BackColor = My.Settings.ColorLighten


    End Sub
    Sub SaveSettings()

        My.Settings.RoundedButtons = tglRounded.Checked

        ' Color Principal
        My.Settings.AccentColor1 = panelColorPrincipalClaro.BackColor
        My.Settings.AccentColor2 = panelColorPrincipal.BackColor
        My.Settings.AccentColor3 = panelColorPrincipalOscuro.BackColor
        My.Settings.AccentForeColor = panelTextoPrincipal.BackColor
        ' Color General
        My.Settings.AbsoluteLight = panelColorClaro.BackColor
        My.Settings.AbsoluteDark = panelColorOscuro.BackColor
        ' Color de Fondo
        My.Settings.ColorDarken = panelColorFondoMuyOscuro.BackColor
        My.Settings.ColorDark = panelColorFondoOscuro.BackColor
        My.Settings.Color = panelColorFondo.BackColor
        My.Settings.ColorLight = panelColorFondoClaro.BackColor
        My.Settings.ColorLighten = panelColorFondoMuyClaro.BackColor

        SaveAndReloadSettings()

    End Sub
    Sub SaveAndReloadSettings()
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Sub AccentBlue()

        panelColorPrincipalClaro.BackColor = Color.FromArgb(25, 135, 209)
        panelColorPrincipal.BackColor = Color.FromArgb(0, 122, 204)
        panelColorPrincipalOscuro.BackColor = Color.FromArgb(0, 109, 183)

    End Sub
    Sub ThemeDark()
        ' Color Principal
        AccentBlue()
        panelTextoPrincipal.BackColor = Color.White
        ' Color General
        panelColorClaro.BackColor = Color.FromArgb(20, 20, 20)
        panelColorOscuro.BackColor = Color.FromArgb(240, 240, 240)
        ' Color de Fondo
        panelColorFondoMuyOscuro.BackColor = Color.FromArgb(50, 50, 50)
        panelColorFondoOscuro.BackColor = Color.FromArgb(60, 60, 60)
        panelColorFondo.BackColor = Color.FromArgb(70, 70, 70)
        panelColorFondoClaro.BackColor = Color.FromArgb(80, 80, 80)
        panelColorFondoMuyClaro.BackColor = Color.FromArgb(90, 90, 90)

    End Sub
    Sub ThemeLight()
        ' Color Principal
        AccentBlue()
        panelTextoPrincipal.BackColor = Color.White
        ' Color General
        panelColorClaro.BackColor = Color.White
        panelColorOscuro.BackColor = Color.Black
        ' Color de Fondo
        panelColorFondoMuyOscuro.BackColor = SystemColors.ControlDarkDark
        panelColorFondoOscuro.BackColor = SystemColors.ControlDark
        panelColorFondo.BackColor = SystemColors.ControlLight
        panelColorFondoClaro.BackColor = SystemColors.Control
        panelColorFondoMuyClaro.BackColor = SystemColors.ControlLightLight
    End Sub

    Private Sub frmGetTheme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        SaveSettings()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CambiarColor_Click(sender As Panel, e As EventArgs) Handles _
            panelColorClaro.Click,
            panelColorOscuro.Click,
            panelColorFondoClaro.Click,
            panelColorFondoMuyClaro.Click,
            panelColorFondoMuyOscuro.Click,
            panelColorFondoOscuro.Click,
            panelColorPrincipal.Click,
            panelColorPrincipalClaro.Click,
            panelColorPrincipalOscuro.Click,
            panelTextoPrincipal.Click

        DG.Color = sender.BackColor
        If (DG.ShowDialog = DialogResult.OK) Then
            sender.BackColor = DG.Color

            btnLight.Checked = False
            btnDark.Checked = False
            btnCustom.Checked = True
            panelTemas.Refresh()

        End If
    End Sub

    Private Sub btnDark_Click(sender As Object, e As EventArgs) Handles btnDark.Click
        ThemeDark()
        btnLight.Checked = False
        btnCustom.Checked = False
        panelTemas.Refresh()
    End Sub
    Private Sub btnLight_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        ThemeLight()
        btnDark.Checked = False
        btnCustom.Checked = False
        panelTemas.Refresh()
    End Sub
    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        btnDark.Checked = False
        btnLight.Checked = False
        panelTemas.Refresh()
    End Sub

End Class