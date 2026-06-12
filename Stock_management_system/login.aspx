<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Stock_management_system.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            border-style: solid;
            border-width: 3px;
        }
    </style>
</head>
<body>
    <center>
        <br />
        <h1>LOGIN </h1>
        <hr />
        <br />
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td>Enter ID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </center>
</body>
</html>
