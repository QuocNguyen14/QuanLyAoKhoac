<%@ Page Title="" Language="C#" MasterPageFile="~/KhungTrang.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="QuanLyAoKhoac.ChiTietSanPham" %>
<%@ Register src="UserUL/ChiTietSanPhamCT.ascx" tagname="ChiTietSanPhamCT" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ChiTietSanPhamCT ID="ChiTietSanPhamCT1" runat="server" />
</asp:Content>
