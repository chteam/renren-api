<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="getFriends.aspx.cs" Inherits="Friends_getFriends" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	得到当前登录用户的好友列表<br />
	<asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
	<br />
		<ol>
	<% 
		if(fs!=null)
		foreach ( XiaoNei.Friend x in this.fs) { %>
	<li><%=x.ID %>-<%=x.Name %>-<img src="<%=x.HeadUrl %>" /></li>
	<%} %>
	</ol>
</asp:Content>

