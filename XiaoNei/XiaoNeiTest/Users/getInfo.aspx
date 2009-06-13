<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="getInfo.aspx.cs" Inherits="Users_getInfo" %>

<%@ Register Assembly="System.Web.DynamicData, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
	Namespace="System.Web.DynamicData" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	得到用户信息，当对方设置了隐私权限，只能返回 name、sex、headurl等数据。<br />
	<br />
	uid:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>可以多项用，分隔
	<br />
	fields:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>任选，用，分隔<br />
	name,sex,birthday,tinyurl,headurl,mainurl,hometown_location,work_history,university_history,hs_history,contact_info,books,movies,music
	<br />
	format:<asp:DropDownList ID="DropDownList1" runat="server">
		<asp:ListItem>Xml</asp:ListItem>
		<asp:ListItem>Json</asp:ListItem>
	</asp:DropDownList>
	<br />
	<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="读取" />
	<pre>
	<asp:Literal ID="Literal1" runat="server"></asp:Literal>
	</pre>
</asp:Content>

