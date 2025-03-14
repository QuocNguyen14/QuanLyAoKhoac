<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CapNhatSanPham.aspx.cs" Inherits="QuanLyAoKhoac.CapNhatSanPham" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
</head>
<body>
    <form id="form1" runat="server">

    <div class="Update">
        <li style=" text-decoration: none;list-style: none;"><a href="Home.aspx" >TRANG CHỦ</a></li>
        <h1><asp:Label ID="lblThongBao" runat="server"></asp:Label></h1>
        <br />
        Tên sản shẩm:<asp:TextBox ID="txtTenSP" runat="server"></asp:TextBox>
        <br />
        Tên chi tiết:<asp:TextBox ID="txtTenCT" runat="server"></asp:TextBox>
        <br />
        Hình ảnh:<asp:FileUpload ID="fileHinhAnh" runat="server" />
        <br />
        Giá:<asp:TextBox ID="txtGia" runat="server"></asp:TextBox>
        <br />
        Mã Số:<asp:TextBox ID="txtMaSo" runat="server"></asp:TextBox>
        <br /> 
        Màu:<asp:TextBox ID="txtMau" runat="server"></asp:TextBox>
        <br />
        Size:<asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
        <br />
        Thời gian ưu đãi:<asp:TextBox ID="txtUudai" runat="server"></asp:TextBox>
        <br />
        Mô tả chi tiết:<FCKeditorV2:FCKeditor ID="FCKChiTiet" runat="server" BasePath="~/fckeditor/" Height="400px" Width="800px"></FCKeditorV2:FCKeditor>
        <br />
       
        <asp:Button ID="btnCapNhat" runat="server" Text="Cập Nhật" OnClick="btnCapNhat_Click" />


    </div>
    </form>
</body>
</html>