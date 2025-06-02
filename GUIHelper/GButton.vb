Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class GButton
    Inherits Button
    Enum Style
        Gamboa
        Cicle
        Side
        Rounded
        Flat
    End Enum
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        '''
        ' Create pen.
        Dim blackPen As New Pen(Color.Fuchsia, 4)
        Dim Bsh As Brush = Brushes.Fuchsia
        Dim et As New Rectangle With {.Location = New Point(0, 0), .Size = New Size(ClientRectangle.Width, ClientRectangle.Height)}
        'et.Offset(1, 1)
        ' Create points that define polygon.(>>>,upp)
        Dim point1 As New Point(2, ClientSize.Height / 4.7)
        Dim point2 As New Point(ClientSize.Width / 2, 1) 'top point
        Dim point3 As New Point(ClientSize.Width - 2, ClientSize.Height / 4.7)
        Dim point4 As New Point(ClientSize.Width - 2, ClientSize.Height / 1.4) 'buttom side
        Dim point5 As New Point(ClientSize.Width / 2, ClientSize.Height - 3) ' buttom point
        Dim point6 As New Point(2, ClientSize.Height / 1.4) 'buttom side
        'Dim point7 As New Point(1, 100)
        Dim curvePoints As Point() = {point1, point2, point3, point4, point5, point6} ', point7}

        'side way 
        Dim p1 As New Point(2, ClientSize.Height / 2) 'sidestart
        Dim p2 As New Point(ClientSize.Width / 4.7, 2) 'up 1
        Dim p3 As New Point(ClientSize.Width / 1.3, 2) ' up end
        Dim p4 As New Point(ClientSize.Width - 2, ClientSize.Height / 2) 'sideend
        Dim p5 As New Point(ClientSize.Width / 1.3, ClientSize.Height - 2)
        Dim p6 As New Point(ClientSize.Width / 4.7, ClientSize.Height - 2)

        Dim sidepoints As Point() = {p1, p2, p3, p4, p5, p6}
        'drawing
        Dim grPath As GraphicsPath = New GraphicsPath()
        If UIStyle = Style.Gamboa Then
            ''' Draw polygon to screen.
            e.Graphics.DrawPolygon(blackPen, curvePoints)
            grPath.AddPolygon(curvePoints)
        ElseIf UIStyle = Style.Side Then
            e.Graphics.DrawPolygon(blackPen, sidepoints)
            grPath.AddPolygon(sidepoints)
        ElseIf UIStyle = Style.Flat
            grPath.AddRectangle(et)
        ElseIf UIStyle = Style.Rounded
            grPath.AddRectangle(et)
            Elipse.Apply(Me, 30)
        Else
            grPath.AddEllipse(3, 3, ClientSize.Width - 5, ClientSize.Height - 5)
        End If
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Lime, ButtonBorderStyle.Solid)
        Me.Region = New Region(grPath)
        MyBase.OnPaint(e)
    End Sub
    Protected Overrides Sub OnStyleChanged(e As EventArgs)
        Me.SetStyle(FlatStyle, True)
        MyBase.OnStyleChanged(e)
    End Sub
    <Description("Gets or sets the style of the Gbutton"), Category("Appearance"), Bindable(False), DefaultValue(GetType(Style), "Gamboa")>
    Public Property UIStyle As Style
        Get
            Return Me._style
        End Get
        Set(ByVal value As Style)
            If (value <> Me._style) Then
                Me._style = value
                Select Case Me._style
                    Case Style.Cicle
                        Me._style = Style.Cicle
                        Exit Select
                    Case Style.Gamboa
                        Me._style = Style.Gamboa
                        Exit Select
                    Case Style.Side
                        Me._style = Style.Side
                        Exit Select
                    Case Style.Flat
                        Me._style = Style.Flat
                        Exit Select
                    Case Else
                        Me._style = Style.Gamboa
                End Select
            End If
            Me.Refresh()
        End Set
    End Property
    Private Property _style As Style
End Class
