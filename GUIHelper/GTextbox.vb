
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class GTextbox
    Inherits TextBox

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function



    <Localizable(True)>
    Public Property Cue() As String
        Get
            Return mCue
        End Get
        Set
            mCue = Value
            updateCue()
        End Set
    End Property

    Private Sub updateCue()
        If Me.IsHandleCreated AndAlso mCue IsNot Nothing Then
            SendMessage(Me.Handle, &H1501, New IntPtr(1), mCue)
        End If
    End Sub
    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        updateCue()
    End Sub
    Private mCue As String
End Class