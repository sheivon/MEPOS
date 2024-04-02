Imports InvoicePrinter
Imports InvoicePrinter.Customer

Public Class HomeCotrols
    Private Property Users As String
    Private Property UsrID As Integer
    Sub New(user As String, ID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        DoubleBuffered = True
        Users = user
        UsrID = ID
        ' Add any initialization after the InitializeComponent() call. 
    End Sub
    Private Property Toside As Boolean = False
    Private Sub GButton2_Click(sender As Object, e As EventArgs) Handles GButton2.Click
        Form1.Clear()
        Form1.OptionPanel.Controls.Add(New CostomersFrm(UsrID) With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub GButton4_Click(sender As Object, e As EventArgs) Handles GButton4.Click
        Form1.btnProduct.PerformClick()
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Form1.btnAUser.PerformClick()
    End Sub

    Private Sub GButton3_Click(sender As Object, e As EventArgs)
        Form1.Clear()
        Form1.OptionPanel.Controls.Add(New OwingCustomers With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Form1.Clear()
        Form1.OptionPanel.Controls.Add(New Cart.CartFrm(Users, UsrID) With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Form1.btnInventry.PerformClick()
    End Sub

End Class
