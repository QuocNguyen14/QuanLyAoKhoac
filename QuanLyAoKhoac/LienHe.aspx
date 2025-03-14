<%@ Page Title="" Language="C#" MasterPageFile="~/KhungTrang.Master" AutoEventWireup="true" CodeBehind="LienHe.aspx.cs" Inherits="QuanLyAoKhoac.LienHe1" %>
<%@ Register src="UserUL/LienHeCT.ascx" tagname="LienHeCT" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:LienHeCT ID="LienHeCT1" runat="server" />
</asp:Content>
