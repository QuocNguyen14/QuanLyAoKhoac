<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanTriSanPham.aspx.cs" Inherits="QuanLyAoKhoac.QuanTriSanPham" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet'>
    <title>Dự án website bán áo khoác nhóm 1</title>
    <link rel="stylesheet" href="./css/gird.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.6.0/css/all.min.css" integrity="sha512-Kc323vGBEqzTmouAECnVceyQqyqdsSiqLQISBL29aUW4U/M7pSPA/gEUZQqv1cwx4OnYxTxve5UMg5GT6L4JJg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <%--<script src="https://code.jquery.com/jquery-3.7.1.js"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div class="gridSanPham">
        <li><a href="Home.aspx">TRANG CHỦ</a></li>
        <asp:DataGrid ID="gridSanPham" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5" PagerStyle-Mode="NumericPages" DataKeyField="MaSp" OnItemCommand="gridSanPham_ItemCommand" OnPageIndexChanged="gridSanPham_PageIndexChanged">
            <Columns>
                <asp:TemplateColumn HeaderText="HinhAnh">
                    <ItemTemplate>
                        <img src='<%#"./img/imagesSP/"+ Eval("HinhAnh")%>' width="100" height="100" alt="hinhanh" />
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <Columns>
                <asp:TemplateColumn HeaderText="Tên Sản Phẩm">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkUpdate" runat="server" Text='<%#Eval("TenSp") %>' CommandName="GetUpDate" ></asp:LinkButton>                  
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <Columns>
                <asp:TemplateColumn HeaderText="Xóa/Cập Nhật">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkDelete" runat="server" Text="Xóa" CommandName="GetDelete" OnClientClick="return confirm('Bạn có muốn xóa sản phẩm không?')"></asp:LinkButton>
                        <br />
                        <asp:LinkButton ID="linkUpdate" runat="server" Text="Cập Nhật" CommandName="GetUpdate" ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
        </asp:DataGrid>
    </div>
    </form>
</body>
</html>
