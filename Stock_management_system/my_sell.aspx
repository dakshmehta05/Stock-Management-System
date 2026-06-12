<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="my_sell.aspx.cs" Inherits="Stock_management_system.my_sell" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" Height="148px" Width="375px">
    </asp:GridView>
</asp:Content>
