Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class GNotifyIcon
    Public Property Icon As Icon
    Public Property Text As String
    Public Event Click As EventHandler
    Public Event DoubleClick As EventHandler
    Public Property ContextMenu As ContextMenu
    Public Property ContextMenuStrip As ContextMenuStrip
    Public Sub ShowBalloonTip(timeout As Integer, tipTitle As String, tipText As String, tipIcon As ToolTipIcon)

    End Sub
End Class