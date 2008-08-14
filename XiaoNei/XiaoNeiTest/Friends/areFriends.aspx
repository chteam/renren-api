<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="areFriends.aspx.cs" Inherits="Friends_areFriends" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	uid1:<asp:TextBox ID="TextBox1" runat="server">45102821,45102821,45102821</asp:TextBox>
	<br />
	uid2:<asp:TextBox ID="TextBox2" runat="server">22440,45102821,1</asp:TextBox>
	<br />
	<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
	<br />
			<ol>
	<% 
		if(fis!=null)
		foreach ( XiaoNei.FriendInfo x in this.fis) { %>
	<li><%=x.ID1 %>-<%=x.ID2 %>-<%=x.areFriends.ToString() %></li>
	<%} %>
	</ol>
</asp:Content>

