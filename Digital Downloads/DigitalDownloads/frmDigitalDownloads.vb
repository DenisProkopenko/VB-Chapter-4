'Program Name:          Digital Downloads
'Developer:             Denis Prokopenko
'Date:                  September 23, 2013
'Purpose:               This application can calculate and
'                       display the correct cost per download.

Option Strict On

Public Class frmDigitalDownloads

    'Cost per download - used in multiple procedures.
    Const _codecPricePerDownload As Decimal = 0.99D                                     'Price per download

    Private Sub btnCalculateCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateCost.Click
        'this code is executed when the user clicks the Calculate Cost button
        'It ____

        'Key words:
        'Dim = the entries folowing are defined as variables
        'As String = variable defined as string (A B C D) (str)
        'As Integer = variable defined as integer (1 2 3 4) (int)
        'As Decimal = variable defined as decimal (.1 .2 .3 .4) (dec)

        Dim strNumberOfSongs As String              'make room in memory for a string value for strNumberOfSongs = defined as a string
        Dim intNumberOfSongs As Integer             'make room in memory for integer value for intNumberOfSongs = defined as an integer
        Dim decTotalCostOfDownloads As Decimal      'make room in memory for decimal value for decTotalCostOfDownloads = defined as a decimal

        'This event is exected when the user clicks the 
        'Calculate Cost button. It___

        strNumberOfSongs = textNumberOfDownloads.Text                           'read text in NumberOfDownloads as a string
        If IsNumeric(textNumberOfDownloads.Text) Then                           'if the value in the text of textNumberOfDownloads is a numeric value (1, 2, 3, 4, 5...) then go to next step to convert
            intNumberOfSongs = Convert.ToInt32(strNumberOfSongs)                'convert Number of songs string to integer and place it in intNumberOfSongs RAM space
        End If

        decTotalCostOfDownloads = intNumberOfSongs * _codecPricePerDownload     'take integer value of NumberOfSongs and (multiply) it by PricePerDownload, then place it in decTotalCostOfDownloads RAM space
        lblTotalCostOfDownloads.Text = decTotalCostOfDownloads.ToString("C")    'take the value from decTotalCostOfDownloads RAM space and display it in lblTotalCostOfDownloads text as string

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'This code is executed when the user clicks the
        'Clear button. It ___

        textNumberOfDownloads.Text = ("")           'reset text to empty
        lblTotalCostOfDownloads.Text = ""           'reset label to empty
        textNumberOfDownloads.Focus()               'reset the blinking cursor to where the text needs to be entered

    End Sub

    Private Sub frmDigitalDownloads_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This event is trigered when the Digital Downloads 
        'application is first exected. It ___

        lblCostPerDownload.Text = _codecPricePerDownload.ToString("C")          'text property of the label = decimal price, convert decimal to currency string 
        lblTotalCostOfDownloads.Text = ""                                       'total cost is displayed as empty
        textNumberOfDownloads.Focus()                                           'blinking cursor set to where the text needs to be entered

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This code is executed when the user clicks the 
        'Exit button. It ___

        Close()                                     'closes the application

    End Sub
End Class
