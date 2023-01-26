<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_singup.aspx.cs" Inherits="practice_app.login_singup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css/login_signup.css" rel="stylesheet" />
    <title>Sign in</title>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div id="page">
                <div id="login">
                    <h1>Welcome to XXX bank</h1>
                    <h3>Enter your credentials</h3>
                    <asp:TextBox ID="Account_ID" placeholder="Account ID"  runat="server" Height="25px" Width="233px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="password" placeholder="Password" runat="server" Height="25px" Width="233px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="SIGN IN" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="Button2" runat="server" Text="SIGN UP" OnClientClick="return false;" />
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="IDvalidate" runat="server" ControlToValidate="Account_ID" ErrorMessage="Account ID is required." /><br />
                    <asp:RequiredFieldValidator ID="PasswordValidate" runat="server" ControlToValidate="password" ErrorMessage="password is required." />
                </div>
                <div id="signup">
                    <h1>SIGN UP</h1>
                    <h3>Enter your details</h3>
                    <asp:TextBox ID="Name" placeholder="User Name" runat="server" Height="25px" Width="233px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="PhoneNumber" placeholder="Phone Number" runat="server" Height="25px" Width="233px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="Password_signup" placeholder="Password" runat="server" Height="25px" Width="233px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="SIGN UP" OnClick="Button3_Click"  />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="SIGN IN" OnClientClick="return false;"/>
                    <br />
                    </div>
            </div>
        </center>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
    <script>
        $(document).ready(function(){
            $("#signup").hide();
            $("#Button2").click(function () {
                $("#login").slideUp(800);
                $("#signup").slideDown(800);
            });
            $("#Button4").click(function () {
                $("#signup").slideUp(800);
                $("#login").slideDown(800);
            })
        });
    </script>
</body>
</html>
