<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LienHeCT.ascx.cs" Inherits="QuanLyAoKhoac.UserUL.LienHeCT" %>
<!--content-->
    <section class="product">
        <div class="containerr">
            <div class="productt-top row">
                <p><asp:Label ID="lblThongBao" runat="server"></asp:Label></p>
            </div>
            <div style="text-align:center">
                <div>
                    Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <br />
                    Họ tên:<asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
                    <br />
                    Số điện thoại:<asp:TextBox ID="txtDT" runat="server"></asp:TextBox>
                    <br />
                    Địa chỉ:<asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                    <br />
                    Ngày lien hệ:<asp:TextBox ID="txtNgayLienHe" runat="server"></asp:TextBox>
                    <br />
                </div>
                
                <div class="send">
                    <asp:Button ID="bntGuiDi" runat="server" Text="Gửi Đi" OnClick="bntGuiDi_Click" />
                </div>
                    
            </div>
        </div>
    </section>