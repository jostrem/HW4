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

        'convert wage to currency
        tbWage.Text = FormatCurrency(wage)
        tbPreTax.Text = FormatCurrency(pretax)
        tbPostTax.Text = FormatCurrency(posttax)



        'generating gross pay
        grosspay = hoursworked * wage


        'generate taxable pay
        taxablePay = grosspay - pretax

        'if statement for grossPay
        If grosspay < 500 Then
            tax = taxablePay * 0.18
        Else
            tax = taxablePay * 0.22
        End If

        'calc pay
        pay = taxablePay - tax

        netincome = pay - posttax


        'formatting lbl
        lblSalaryPay.Text = FormatCurrency(netincome)

    End Sub

    Protected Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        'reset button clears everything
        tbWage.Text = ""
        tbHoursWorked.Text = ""
        tbPreTax.Text = ""
        tbPostTax.Text = ""

        lblSalaryPay.Text = ""


    End Sub
End Class
