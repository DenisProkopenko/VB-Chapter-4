' Program Name: Taxi Fare
' Developer:    Denis Prokopenko
' Date:         October 7, 2013
' Purpose:      This application allows the user
'               plug in millage into the application
'               to see the taxi fare price.

Option Strict On

Public Class frmTaxiMeter
    Const _codecPricePerMile As Decimal = 2.25D     'constant price, never changes
    Const _codecConstantPrice As Decimal = 1.25D    'constant price, never changes

    Private Sub frmTaxiMeter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This code is executed when the application first loads.
        'it ____

        lblPricePerMile.Text = _codecPricePerMile.ToString("C")                 'show price per mile in the text of lblPricePerMile
        lblConstantPrice.Text = _codecConstantPrice.ToString("C")               'show the constant price in the text of lblConstantPrice
        lblTotal.Text = ""                                                      'text of the lblTotal is empty
        txtMiles.Focus()                                                        'blinking cursor on txtMiles

        'Extra functions load with the program
        '(1) "ENTER" button activates the btnCalculate_Click event
        '(2) "ESCAPE" button activates the btnExit_Click event

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'This code is executes when the user clicks on the Calculate button
        'It ____

        Dim strMiles As String          'make room in RAM for a string value for strmiles = defined as a string
        Dim decMiles As Decimal         'make room in RAM for an integer value for intMiles = defined as a integer
        Dim decTotal As Decimal         'make room in RAM for a decimal value for decTotal = defined as a decimal

        strMiles = txtMiles.Text                                                'text int eh text box of Miles is treated as a string
        If IsNumeric(txtMiles.Text) Then                                        'if text of the txtMiles are (NUMBERS) then...
            decMiles = Convert.ToDecimal(strMiles)                              'convert strMiles to decMiles
            decTotal = (decMiles * _codecPricePerMile) + _codecConstantPrice    'then do the multiplication and addition, and store it in RAM decTotal
        End If

        lblTotal.Text = decTotal.ToString("C")                                  'take decTotal from RAM, place it in the currency formation, and place it in the text portion of the lblTotal

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'This code is executed then the user clicks on the clear button.
        'It ____

        txtMiles.Clear()                'clear text box
        lblTotal.Text = ""              'clear the text of the lblTotal
        txtMiles.Focus()                'blinking cursor at text box

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This code is executed when the user clicks on the Exit button.
        'It ____

        Close()                         'terminates the program

    End Sub
End Class
