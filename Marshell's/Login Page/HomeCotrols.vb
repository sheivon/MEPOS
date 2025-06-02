Imports Entities
Imports InvoicePrinter
Imports InvoicePrinter.Customer

Public Class HomeCotrols
    Private Property Users As Users
    Sub New(user As Users)

        ' This call is required by the designer.
        InitializeComponent()
        DoubleBuffered = True
        Users = user
        ' Add any initialization after the InitializeComponent() call. 
    End Sub
    Private Property Toside As Boolean = False
    Private Sub GButton2_Click(sender As Object, e As EventArgs) Handles GButton2.Click
        Form1.Clear()
        Form1.OptionPanel.Controls.Add(New frmCustomers(Users) With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub GButton4_Click(sender As Object, e As EventArgs) 
        Form1.btnProduct.PerformClick()
    End Sub

    Private Sub GButton3_Click(sender As Object, e As EventArgs)
        Form1.Clear()
        Form1.OptionPanel.Controls.Add(New OwingCustomers With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Form1.Clear()
        Form1.OptionPanel.Controls.Add(New Cart.Cart(Users) With {.Dock = DockStyle.Fill})
    End Sub


End Class
