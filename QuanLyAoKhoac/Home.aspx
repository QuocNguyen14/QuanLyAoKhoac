<%@ Page Title="" Language="C#" MasterPageFile="~/KhungTrang.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QuanLyAoKhoac.Home" %>
<%@ Register src="UserUL/HomeCT.ascx" tagname="HomeCT" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:HomeCT ID="HomeCT1" runat="server" />
</asp:Content>
