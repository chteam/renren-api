<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;</p>
<p>
    API KEY：<asp:TextBox ID="TextBox1" runat="server" Width="261px">7b4862666bad4eccb1f9053048b23428</asp:TextBox>
</p>
<p>
    Session Key：<asp:TextBox ID="TextBox2" runat="server" Width="278px">2.1c96445e0dddc5d4ce3e189bf67b1331.3600.1244642400-45102821</asp:TextBox>
</p>
<p>
    Secret：<asp:TextBox ID="TextBox3" runat="server" Width="283px">5e5907bf08f74fd5ad0e85c5ad5b5354</asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Begin" />
</p>
</asp:Content>

