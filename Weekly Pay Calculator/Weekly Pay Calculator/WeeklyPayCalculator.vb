'Program Name:          Weekly Pay Calculator
'Developer:             Denis Prokopenko
'Date:                  October 14, 2013
'Purpose:               This application allows the user to put in 
'                       the number of ours he or she worked, and the
'                       hourly pay rate at wich he or she is paid,
'                       to see the total income made in that time.
Option Strict On

Public Class WeeklyPayCalculator
    Const intNumberOfMinutesInHour As Integer = 60

    Private Sub WeeklyPayCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This code is executed when the application is first loaded.

        txtTotalMinutes.Clear()     'clear txtTotalMinutes.
        txtHourlyPay.Clear()        'clear txtHourlyPay.
        lblHoursLabel.Text = ""     'clear the text in the lblHoursLabel.
        lblMinutesLabel.Text = ""   'clear the text in the lblMinutesLabel.
        lblTotal.Text = ""          'clear the text in the lblTotal.
        txtTotalMinutes.Focus()     'set focus to txtTotalMinutes.

        'Also loads the application with few shortcuts:
        '(1) "ENTER" key activates btnCalculate_Click event
        '(2) "ESCAPE" key activates btnExit_Click event

    End Sub

    Private Sub btnCalulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalulate.Click
        'This code is executed when the user clicks on the calculate button.
        'It makes room in RAM for the given dimentions, then _____

        Dim strTotalMinutes As String   'make room in RAM for a string value for strTotalMinutes = defined as a string.
        Dim intTotalMinutes As Integer  'make room in RAM for a integer value for intTotalMinutes = defined as a integer.

        Dim strHourlyPay As String      'make room in RAM for a string value for strHourlyPay = defined as a string.
        Dim decHourlyPay As Decimal     'make room in RAM for a decimal value for decHourlyPay = defined as a decimal.

        Dim decTotal As Decimal         'make room in RAM for a decimal value for decTotal = defined as a decimal.

        Dim intHours As Integer         'make room in RAM for a integer value for intHours = defined as a integer.
        Dim intMinutes As Integer       'make room in RAM for a integer value for intMinutes = defined as a integer.

        strTotalMinutes = txtTotalMinutes.Text                                  'the text in the text of total minutes is defined as a stringTotalMinutes.
        If IsNumeric(txtTotalMinutes.Text) Then                                 'if text of txtTotalMinutes is a (NUMBEER) then...
            intTotalMinutes = Convert.ToInt32(strTotalMinutes)                  'convert stringTotalMinutes to integerTotalMinutes.
        End If

        strHourlyPay = txtHourlyPay.Text                                        'the text in the text of hourly pay is defined as stringHourlyPay.
        If IsNumeric(txtHourlyPay.Text) Then                                    'if text of txtHourlyPay is a (NUMBEER) then...
            decHourlyPay = Convert.ToDecimal(strHourlyPay)                      'convert stringHorlyPay to decimalHourlyPay.
        End If

        decTotal = (intTotalMinutes * decHourlyPay) / intNumberOfMinutesInHour  'intTotalMinutes (times) decTotalHours then (divide) by constant = decTotal and placed in RAM.

        lblTotal.Text = decTotal.ToString("C")                                  'take decTotal out of ram and place it in curency form, hten place it in the text of lblTotal.

        '\ backwards slash is used for integer division, to display the division using only integer numbers.
        intHours = intTotalMinutes \ 60                                         'use integer division (\ backwards slash) discard anything after the decimal.
        lblHoursLabel.Text = intHours.ToString                                  'take intHours out of RAM and place it in the text of the lblHours.

        'MOD used to show the remainder of the division as an integer.
        intMinutes = intTotalMinutes Mod 60                                     'divide and discard anything that is infront of the decimal
        lblMinutesLabel.Text = intMinutes.ToString                              'take the intMinutes from RAM and place it in the text of the lblMinutes

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'This code is executed when the user clicks the Clear button.
        'It ____

        txtTotalMinutes.Clear()     'clears txtTotalMinutes.
        txtHourlyPay.Clear()        'clears txtHourlyPay.
        lblHoursLabel.Text = ""     'clears the text in the lblHoursLabel.
        lblMinutesLabel.Text = ""   'clears the text in the lblMinutesLabel.
        lblTotal.Text = ""          'clears the text in the lblTotal.
        txtTotalMinutes.Focus()     'sets focus to txtTotalMinutes.

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This code is executed when the user clicks the Exit button
        'It ____

        Close()                     'terminates the program

    End Sub
End Class
