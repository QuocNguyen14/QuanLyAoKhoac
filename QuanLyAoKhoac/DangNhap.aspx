<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="QuanLyAoKhoac.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./css/gird.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="Admin">
        <h1><asp:Label ID="lblThongBao" runat="server"></asp:Label></h1>
        <br />
        Tên đăng nhập:<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        Mật khẩu:<asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng Nhập" OnClick="btnDangNhap_Click"></asp:Button>
    </div>
    </form>
</body>
</html>

