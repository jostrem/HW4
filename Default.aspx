<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>

        Jacob's Salary Calculator
    </title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p>
           Salary Calculator</p>         
        <p>
            &nbsp;</p>
        <p>
            Hours Worked:<asp:TextBox ID="tbHoursWorked" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvHoursWorked" runat="server" ControlToValidate="tbHoursWorked" ErrorMessage="**Please enter hours worked"></asp:RequiredFieldValidator>
        </p>
        <p>
            Wage:<asp:TextBox ID="tbWage" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvWage" runat="server" ControlToValidate="tbWage" ErrorMessage="**Please enter wage"></asp:RequiredFieldValidator>
        </p>
        <p>
            Pre-tax Deductions:<asp:TextBox ID="tbPreTax" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPreTax" runat="server" ControlToValidate="tbPreTax" ErrorMessage="**Please enter Pre-Tax Deductions"></asp:RequiredFieldValidator>
        </p>
        <p>
            Post-tax Deductions:<asp:TextBox ID="tbPostTax" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPostTax" runat="server" ControlToValidate="tbPostTax" ErrorMessage="**Please enter Post-Tax Deductions"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ID="btnCalc" runat="server" Text="Calculate" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" />
        </p>
        <p>
            Net Income: <asp:Label ID="lblSalaryPay" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
