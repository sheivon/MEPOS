Imports System.Drawing

Public Class MSetting
    'props
    ''' <summary>
    ''' Get or Set the Warning stock ow amount
    ''' </summary>
    ''' <returns>low instock int</returns>
    Public Shared Property GetStockLowWarn
        Get
            Return My.Settings.lowstock
        End Get
        Set(value)
            My.Settings.lowstock = value
            My.Settings.Save()
        End Set
    End Property
    Public Shared Function GetBarcodeType() As String
        Return My.Settings.Barcode
    End Function
    Public Shared Function IsGradient() As Boolean
        Return My.Settings.BBarIsGradient
    End Function
    Public Shared Function EndColor() As Color
        Return My.Settings.BCRight
    End Function
    Public Shared Function StartColor() As Color
        Return My.Settings.BCLeft
    End Function
    ''' <summary>
    ''' Get the End Color if Gradient
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function LoginEndColor() As Color
        Return My.Settings.LCRight
    End Function
    ''' <summary>
    ''' Get the Start Color if Gradient
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function LoginStartColor() As Color
        Return My.Settings.LCLeft
    End Function
    ''' <summary>
    ''' Get if Login is Gradient style
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function LoginIsGradient() As Boolean
        Return My.Settings.LIsGradient
    End Function
    Public Shared Function PrintMark() As Boolean
        Return My.Settings.PrintW
    End Function
    Public Shared Function ShowPrintPreview() As Boolean
        Return My.Settings.PrintPreview
    End Function
    Public Shared Function GetUSD() As Double
        Return My.Settings.Curency
    End Function
    Public Shared Function GetEUR() As Double
        Return My.Settings.EUR
    End Function
    Public Shared Function GetConnectionstring() As String
        Return ConnectionMaker()
    End Function
    Public Shared ReadOnly Property Gettell As String
        Get
            Return My.Settings.tel
        End Get
    End Property
    Private Shared Function ConnectionMaker() As String
        Dim po = port, db = Database, ser = Server, un = username, pa = password
        Dim constring As String = ""
        If String.IsNullOrEmpty(ser) = False Then
            constring &= String.Format("Server={0};", ser)
        End If
        If String.IsNullOrEmpty(db) = False Then
            constring &= String.Format("Database={0};", db)
        End If
        If String.IsNullOrEmpty(po) = False Then
            If po.Length Then
                constring &= IIf(po = 0, "", String.Format("Port={0};", po))
            End If
        End If
        If String.IsNullOrEmpty(un) = False Then
            constring &= String.Format("User Id={0};", un)
        End If
        If String.IsNullOrEmpty(pa) = False Then
            constring &= String.Format("Password={0}", pa)
        End If
        Return constring
    End Function
    ''
    '' Props
    ''
    Public Shared Property Server As String
        Get
            Return My.Settings.server
        End Get
        Set(value As String)
            My.Settings.server = value
            My.Settings.Save()
        End Set
    End Property
    Public Shared Property port As String
        Get
            Return My.Settings.dbPort
        End Get
        Set(value As String)
            My.Settings.dbPort = value
            My.Settings.Save()
        End Set
    End Property
    Public Shared Property Database As String
        Get
            Return My.Settings.database
        End Get
        Set(value As String)
            My.Settings.database = value
            My.Settings.Save()
        End Set
    End Property
    Public Shared Property username As String
        Get
            Return My.Settings.dbUser
        End Get
        Set(value As String)
            My.Settings.dbUser = value
            My.Settings.Save()
        End Set
    End Property
    Public Shared Property password As String
        Get
            Return My.Settings.dbPass
        End Get
        Set(value As String)
            My.Settings.dbPass = value
            My.Settings.Save()
        End Set
    End Property
    Public Shared Property Themes As Color
        Get
            Return My.Settings.thems
        End Get
        Set(value As Color)
            My.Settings.thems = value
            My.Settings.Save()
        End Set
    End Property

End Class
