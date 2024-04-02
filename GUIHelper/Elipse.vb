
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<DebuggerStepThrough>
Public Class Elipse
    ' Methods
    Public Shared Sub Apply(ByVal ctrl As Control, ByVal _Elipse As Integer)
        Dim num As Integer
        Dim num2 As Integer
        Try
            ctrl.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, _Elipse, _Elipse))
        Catch exception1 As Exception
        End Try
        Do While (num = num2)
            num2 = 1
            Dim num3 As Integer = num
            num = 1
            If (1 > num3) Then
                Exit Do
            End If
        Loop
    End Sub
    Public Shared Sub Apply(ByVal Form As Form, ByVal _Elipse As Integer)
        Dim num As Integer
        Dim num2 As Integer
        Try
            Form.FormBorderStyle = FormBorderStyle.None
            Form.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, Form.Width, Form.Height, _Elipse, _Elipse))
        Catch exception1 As Exception
        End Try
        Do While (num = num2)
            num2 = 1
            Dim num3 As Integer = num
            num = 1
            If (1 > num3) Then
                Exit Do
            End If
        Loop
    End Sub

    <DllImport("Gdi32.dll")> <Security.SecuritySafeCritical>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    ''' 
    ''' c# VARIAnt
    '''
    '[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    '    Private Static extern IntPtr CreateRoundRectRgn
    '    (
    '        int nLeftRect,     // x-coordinate of upper-left corner
    '        int nTopRect,      // y-coordinate of upper-left corner
    '        int nRightRect,    // x-coordinate of lower-right corner
    '        int nBottomRect,   // y-coordinate of lower-right corner
    '        int nWidthEllipse, // height of ellipse
    '        int nHeightEllipse // width Of ellipse
    '    );

    '    Public Form1()
    '    {
    '        InitializeComponent();
    '        this.FormBorderStyle = FormBorderStyle.None;
    '        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
    '    }

End Class