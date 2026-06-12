<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="my_purchases.aspx.cs" Inherits="Stock_management_system.my_purchases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" Height="201px" Width="334px">
    </asp:GridView>
</asp:Content>
