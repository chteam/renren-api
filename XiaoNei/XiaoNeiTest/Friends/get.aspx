<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="get.aspx.cs" Inherits="Friends_get" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
得到当前登录用户的好友列表，得到的只是含有好友uid的列表。

	<asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
	
	<br />
	<ol>
	<% 
		if(uis!=null)
		foreach (int x in this.uis) { %>
	<li><%=x %></li>
	<%} %>
	</ol>
</asp:Content>

