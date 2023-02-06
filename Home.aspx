<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="practice_app.javascript.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="Css/Home.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="details">
            welcome to home page
            <br />
            <br />
            <table>
                <tr>
                    <td>Name:<asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>Phone Number:<asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>Balance:<asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
        </div>
        <div class="options">
            <asp:Button ID="Button1" runat="server" Text="add money" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="withdraw money" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="log out" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="delete account" />
        </div>
    </form>
</body>
</html>
