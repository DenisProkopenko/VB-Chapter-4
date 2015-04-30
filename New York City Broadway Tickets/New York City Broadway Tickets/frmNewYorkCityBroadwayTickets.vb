' Program Name: New York City Broadway Tickets
' Developer:    Denis Prokopenko
' Date:         October 7, 2013
' Purpose:      This application allows the user
'               buy any number of tickets for a
'               New York City Brodway, and see the
'               Total.

Option Strict On

Public Class frmNewYorkCityBroadwayTickets

    Const _codecPricePerTicket As Decimal = 153.5D

    Private Sub btnCalculateCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateCost.Click
        'This code is executed when the user clicks on the Calculate Cost
        'button. It ___

        'Key words:
        'Dim = the entries folowing are defined as variables
        'As String = variable defined as string (A B C D) (str)
        'As Integer = variable defined as integer (1 2 3 4) (int)
        'As Decimal = variable defined as decimal (.1 .2 .3 .4) (dec)

        Dim strNumberOfTickets As String                                'make room in memory for a string value for strNumberOfTickets = defined as a string
        Dim intNumberOfTickets As Integer                               'make room in memory for integer value for intNumberOfTickets = defined as an integer
        Dim decTotal As Decimal                                         'make room in memory for decimal value for decTotal = defined as a decimal

        strNumberOfTickets = txtNumberOfTickets.Text                    'read text in NumberOfTickets as a string
        If IsNumeric(txtNumberOfTickets.Text) Then                      'If text is Numerical (0, 1, 2, 3, 4, 5...) Then go to next step and calculate
            intNumberOfTickets = Convert.ToInt32(strNumberOfTickets)    'convert strNumberOfTickets to Integer (1, 2, 3, 4, 5...)
        End If

        decTotal = intNumberOfTickets * _codecPricePerTicket            'use the converted intNumberOfTickets and (Multiply) * by the Price Per Ticket codec and set it to decTotal RAM space
        lblTotal.Text = decTotal.ToString("C")                          'converts decTotal to an equivalent string value and displays it in the text portion of the lblTotal

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtNumberOfTickets.Clear()                                      'clear txtNumberOfTickets
        lblTotal.Text = ""                                              'empty the text in lblTotal
        txtNumberOfTickets.Focus()                                      'set blinking cursor to txtNumberOfTickets

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Close()                                                         'close the application

    End Sub

    Private Sub frmNewYorkCityBroadwayTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblPricePerTicket.Text = _codecPricePerTicket.ToString("C")     'load _codecPricePerTicket into text prtion of the lblPricePerTicket
        lblTotal.Text = ""                                              'load text portion of the lblTotal as empty
        txtNumberOfTickets.Focus()                                      'load with blinking cursor set in txtNumberOfTickets

    End Sub
End Class
