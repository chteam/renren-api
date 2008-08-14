<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="publishTemplatizedAction.aspx.cs" Inherits="Feed_publishTemplatizedAction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	默认FEEDid是1了，可以改一下<br />
	title"<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	<br />
	body:<asp:TextBox ID="TextBox2" runat="server">{'body':'恭喜你'}</asp:TextBox>
	<br />
	<asp:Button ID="Button1" runat="server" Text="Button" 
	onclick="Button1_Click" />
<br />
<asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

