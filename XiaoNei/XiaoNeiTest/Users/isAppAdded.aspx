<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="isAppAdded.aspx.cs" Inherits="Users_isAppAdded" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	判断用户（当前会话用户或者是一个指定ID的用户）是否已经添加了该应用。<br />
	<br />
	uid：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	不添为判断当前用户，添写判断的还未实现<br />
	<asp:Button ID="Button1" runat="server" Text="判断" onclick="Button1_Click" />
	<br />
	<asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

