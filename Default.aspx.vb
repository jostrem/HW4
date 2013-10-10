Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declaring the Variables for each field.
        Dim hoursworked As Double
        Dim wage As Double
        Dim pretax As Double
        Dim posttax As Double
        Dim grosspay As Double
        Dim netincome As Double
        Dim taxablePay As Double
        Dim tax As Double
        Dim pay As Double


        'variables linked to text boxes
        hoursworked = tbHoursWorked.Text
        wage = tbWage.Text
        pretax = tbPreTax.Text
        posttax = tbPostTax.Text

        'convert to dbl
        hoursworked = CDbl(tbHoursWorked.Text)
        wage = CDbl(tbWage.Text)
        pretax = CDbl(tbPreTax.Text)
        posttax = CDbl(tbPostTax.Text)

        tbWage.Text = FormatCurrency(wage)


        'generating gross pay
        grosspay = hoursworked * wage


        'generate taxable pay
        taxablePay = grosspay - pretax

        'if statement for grossPay
        If grosspay < 500 Then
            taxablePay = taxablePay * 0.18
        Else : tax = taxablePay * 0.22
        End If

        'calc pay
        pay = taxablePay - tax

        netincome = pay - posttax


        'formatting lbl
        lblSalaryPay.Text = FormatCurrency(netincome)

    End Sub
End Class
