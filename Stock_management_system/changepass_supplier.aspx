<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changepass_supplier.aspx.cs" Inherits="Stock_management_system.changepass_supplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
    </style>
</head>
<body>
    <center>
        <br />
        <h3 align="center">Password Change</h3>
        <br />
        <hr />

    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td>Enter Old Password</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Verify</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Enter New Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Re-Enter New Password</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="SAVE CHANGES" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    </center>
</body>
</html>
