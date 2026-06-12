<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="search_customer.aspx.cs" Inherits="Stock_management_system.search_customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 80%;
            border: 3px solid #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table align="center" cellpadding="4" cellspacing="8" class="auto-style2">
        <tr>
            <td>Enter Customer ID</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="SEARCH" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>Customer ID</td>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Customer Name</td>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Contact No.</td>
            <td colspan="2">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td colspan="2">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>City</td>
            <td colspan="2">
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>State</td>
            <td colspan="2">
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
</asp:Content>
