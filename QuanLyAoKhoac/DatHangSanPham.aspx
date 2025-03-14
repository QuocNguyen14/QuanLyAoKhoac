<%@ Page Title="" Language="C#" MasterPageFile="~/KhungTrang.Master" AutoEventWireup="true" CodeBehind="DatHangSanPham.aspx.cs" Inherits="QuanLyAoKhoac.DatHangSanPham" %>
<%@ Register src="UserUL/DatHangCT.ascx" tagname="DatHangCT" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:DatHangCT ID="DatHangCT1" runat="server" />
</asp:Content>
