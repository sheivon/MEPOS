Imports System.Drawing
Imports System.Windows.Forms

Public Class LoginColorSettings
    Private Property LC As Color = My.Settings.LCLeft
    Private Property RC As Color = My.Settings.LCRight
    Private Property B As Boolean = My.Settings.LIsGradient
    Private Sub GButton2_Click(sender As Object, e As EventArgs) Handles GButton2.Click
        'this is the Left color
        Dim C1 As New Windows.Forms.ColorDialog()
        If C1.ShowDialog() = DialogResult.OK Then
            LC = C1.Color
            GButton2.BackColor = LC
        End If
        Call SetColor(LC, RC)
    End Sub

    Private Sub GButton3_Click(sender As Object, e As EventArgs) Handles GButton3.Click
        'this is the right color
        Dim C2 As New ColorDialog()
        GButton3.BackColor = C2.Color
        If C2.ShowDialog() = DialogResult.OK Then
            RC = C2.Color
            GButton3.BackColor = RC
        End If
        Call SetColor(LC, RC)
    End Sub
    Private Sub SetColor(Left As Color, Right As Color)
        GGrandiantPanel1.GradientEndColor = Right
        GGrandiantPanel1.GradientStartColor = Left
    End Sub

    Private Sub GButton4_Click(sender As Object, e As EventArgs) Handles GButton4.Click
        If Not B = True Then
            B = True
            GButton4.Text = "Clasic"
            GGrandiantPanel1.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Else
            B = False
            GButton4.Text = "Gradiant"
            GGrandiantPanel1.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Clasic
        End If
    End Sub

    Private Sub GButton1_Click(sender As Object, e As EventArgs) Handles GButton1.Click
        'save settings
        My.Settings.LIsGradient = B
        My.Settings.LCLeft = GGrandiantPanel1.GradientStartColor
        My.Settings.LCRight = GGrandiantPanel1.GradientEndColor
        My.Settings.Save()
    End Sub

    Private Sub BottomBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GGrandiantPanel1.GradientEndColor = RC
        GGrandiantPanel1.GradientStartColor = LC
        If B = True Then
            GGrandiantPanel1.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
            GButton4.Text = "Clasic"
        Else
            GButton4.Text = "Gradiant"
            GGrandiantPanel1.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Clasic
        End If
    End Sub

End Class
