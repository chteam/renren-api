<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="getAppUsers.aspx.cs" Inherits="Friends_getAppUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
返回已经添加了一个应用的好友的用户Id列表。	<br />
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

