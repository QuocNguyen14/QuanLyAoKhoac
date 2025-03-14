<%@ Page Title="" Language="C#" MasterPageFile="~/KhungTrang.Master" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="QuanLyAoKhoac.TimKiem" %>
<%@ Register src="UserUL/KetQuaTimKiemCT.ascx" tagname="KetQuaTimKiemCT" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:KetQuaTimKiemCT ID="KetQuaTimKiemCT1" runat="server" />
</asp:Content>
