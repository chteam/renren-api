<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="setXNML.aspx.cs" Inherits="Profile_setXNML" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<p>
		profile:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	</p>
	<p>
		profile_action:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
	</p>
	<p>
		uid:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
	</p>
	<p>
		<asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
	</p>
	<pre>
		<asp:Literal ID="Literal1" runat="server"></asp:Literal>
	</pre>
</asp:Content>

