<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMoney.aspx.cs" Inherits="practice_app.AddMoney" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="txtAccountID" type="text" name="AccountID" placeholder="Account ID" />
            <br />
            <input id="txtPassword" type="text" name="password" placeholder="Password" />
            <br />
            <input id="txtAmount" type="text" name="DepositAmount" placeholder="Amount" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

        </div>
    </form>
</body>
</html>
