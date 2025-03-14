<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KetQuaTimKiemCT.ascx.cs" Inherits="QuanLyAoKhoac.UserUL.KetQuaTimKiemCT" %>
<!--content-->
    <main class="content">
        <div class="xuhuong"><h1><asp:Label ID="lblThongBao" runat="server"></asp:Label></h1></div>
        <div class="list-product">
             <%foreach (var item in listDm)
                                { %>
            <section class="item">
                <a href='<%="chitietsanpham.aspx?MaSp="+item.MaSp.ToString()%>' class="item-img">
                    <img src='<%="/img/imagesSP/"+item.HinhAnh %>' alt="" width="200">
                </a>
                <h3>
                    <a href="" class="item-title"><%=item.TenSp %></a>
                </h3>
                <div class="item-price">
                    <span><%=item.Gia.ToString() %><sup>đ</sup></span>
                    <span><del><%=item.GiaNiemYet.ToString() %></del><sup>đ</sup></span>
                </div>
                <div class="item-cmt"><a>Số Lượng</a> <%=item.SoLuong %></div>    
            </section>
            <%} %>
        </div>
    </main>