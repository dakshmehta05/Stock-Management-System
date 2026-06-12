<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="Stock_management_system.view" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table align="center" cellspacing="1" class="auto-style2">
        <tr>
            <td><b>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="BOUGHT" OnCheckedChanged="RadioButton1_CheckedChanged" AutoPostBack="True" GroupName="a" />
            </td>
            <td><b>
                <asp:RadioButton ID="RadioButton2" runat="server" Text="SOLD" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="True" GroupName="a" />
            </td>
        </tr>
    </table>
    <br />
    
                <asp:GridView ID="GridView1" runat="server" Height="234px" Width="440px">
                </asp:GridView>
    <br />
    <table align="center" cellspacing="4" cellpadding="4" border="1">
        <tr>
            <td>Total Amount</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label></td>
        </tr>
    </table>
            
                </asp:Content>
