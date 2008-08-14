<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="getOsInfo.aspx.cs" Inherits="Invitations_getOsInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<p>
		invite_ids:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	</p>
	<p>
		<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
	</p>
</asp:Content>

