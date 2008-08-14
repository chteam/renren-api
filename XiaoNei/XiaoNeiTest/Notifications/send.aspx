<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
 ValidateRequest="false"
 AutoEventWireup="true" CodeFile="send.aspx.cs" Inherits="Notifications_send" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	toids:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	<br />
	notification:<asp:TextBox ID="TextBox2" runat="server">
	
	hello,<xn:name uid="200032219" linked=s"true"/> ，去看看这部电影<a href="http://www.tudou.com/programs/view/Tzpw9PIj8zM/">狮子王</a>
	</asp:TextBox>
	<br />
	<br />
	<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
		style="height: 26px" Text="Button" />
	<br />
	<asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

