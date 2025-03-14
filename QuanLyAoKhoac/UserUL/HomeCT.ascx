<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomeCT.ascx.cs" Inherits="QuanLyAoKhoac.UserUL.HomeCT" %>
<!--content-->
<main class="content">
    <div class="xuhuong" style="text-align:center;margin-bottom:30px;"><h1>Sảm Phẩm Xu Hướng</h1></div>
    <div class="list-product">
        <%foreach (var item in ListSp)
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
