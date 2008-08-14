<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="getLoggedInUser.aspx.cs" Inherits="Users_getLoggedInUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	得到当前session的用户ID，返回的ID值应该在session有效期内被存储，从而避免重复地调用该方法。 
	 
<br />
	<asp:Button ID="Button1" runat="server" Text="获取" onclick="Button1_Click" />
<br />
<asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

