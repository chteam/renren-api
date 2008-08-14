<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="getXNML.aspx.cs" Inherits="Profile_getXNML" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
有BUG
	<p>
		得到用户（当前会话用户或者是一个指定ID的用户）Profile中一个应用的XNML设置。</p>
	<p>
		&nbsp;uid:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	</p>
	<p>
		<asp:Button ID="Button1" runat="server" Text="获取" onclick="Button1_Click" />
	</p>
	<pre>
		<asp:Literal ID="Literal1" runat="server"></asp:Literal>
	</pre>
</asp:Content>

