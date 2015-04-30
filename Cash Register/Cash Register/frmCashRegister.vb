Public Class frmCashRegister
    Const codecTax As Decimal = 0.075D

    Private Sub frmCashRegister_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtName.Clear()
        txtPrice.Clear()
        lblItemName.Text = ""
        lblItemPriceLabel.Text = ""
        lblPlusTaxLabel.Text = ""
        lblTotalLabel.Text = ""
        txtName.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim strName As String

        Dim strPrice As String
        Dim decPrice As Decimal

        Dim decTax As Decimal

        Dim decTotal As Decimal

        strName = txtName.Text
        lblItemName.Text = strName.ToString

        strPrice = txtPrice.Text
        decPrice = Convert.ToDecimal(strPrice)
        lblItemPriceLabel.Text = decPrice.ToString("C")

        decTax = decPrice * codecTax
        lblPlusTaxLabel.Text = decTax.ToString("C")

        decTotal = decPrice + decTax
        lblTotalLabel.Text = decTotal.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtPrice.Clear()
        lblItemName.Text = ""
        lblItemPriceLabel.Text = ""
        lblPlusTaxLabel.Text = ""
        lblTotalLabel.Text = ""
        txtName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Close()

    End Sub
End Class
