<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSanPhamCT.ascx.cs" Inherits="QuanLyAoKhoac.UserUL.ChiTietSanPhamCT" %>

    <!--content-->
    <section class="product">
        <div class="container">
            <div class="product-top row">
                <p>Trang Chủ</p><span>&#8594;</span><p>Nam</p><span>&#8594;</span><p><%=infosanpham.TenSp %></p>
            </div>
            <div class="product-content row">
                <div class="product-content-left row">
                    <div class="product-content-left-big-img">
                        <img src='<%="./img/imagesSP/"+infosanpham.HinhAnh %>' alt="">
                    </div>
                 <%--<div class="product-content-left-small-img">
                        <img src='<%="./img/imagesCT/"+infosanpham.HinhAnhSmall %>' alt="">
                    </div>--%>
                </div>
                <div class="product-content-right">
                    <div class="product-content-right-product-name row">
                        <h1><%=infosanpham.TenCt %></h1>
                        <p>Mã số: </p><p><%=infosanpham.MaSo %></p>
                    </div>
                    <div class="product-content-right-product-name-price">
                        <p><%=infosanpham.Gia.ToString() %><sup>đ</sup></p>
                    </div>
                    <div class="product-content-right-product-color">
                        <p><span style="font-weight: bold;">Màu sắc: </span><%=infosanpham.Color %> 
                    </div>
                    <div class="product-content-right-product-size">
                        <p style="font-weight: bold;">Size:</p>
                        <div class="size">
                            <span><%=infosanpham.Size %></span>
                        </div>
                    </div>
                    <div class="quantity">
                        <p style="font-weight: bold;">Số lượng:</p>
                        <input type="number" min="0" value="1">
                    </div>
                    <p style="color: red;">Vui lòng chọn size</p>
                    <div class="product-content-right-product-buttom">
                        <button><p><a href='<%="DatHangSanPham.aspx?IdDatHang="+infosanpham.MaSp.ToString() %>'><i class='bx bxs-shopping-bag'></i>Mua Hàng</a></p></button>
                        <button><p><a href="http://localhost:51776/Home.aspx" style="color:#000">TÌM TẠI CỬA HÀNG</a></p></button>
                    </div>
                    <div class="product-content-right-product-icon">
                        <div class="product-content-right-product-icon-item">
                            <i class='bx bxs-phone-call'></i><p><a style="color:#000" href='<%="LienHe.aspx?IDLienHe="+infosanpham.MaSp.ToString() %>'>Hotline</a></p>
                        </div>
                        <%--<div class="product-content-right-product-icon-item">
                            <i class='bx bx-message-rounded-dots'></i><p>Chat</p>
                        </div>
                        <div class="product-content-right-product-icon-item">
                            <i class='bx bx-envelope'></i><p>Mail</p>
                        </div>--%>
                    </div>
                    <div class="product-content-right-bottom">
                        <div class="product-content-right-bottom-top">
                            <i class='bx bx-chevron-down'></i>
                        </div>
                        <div class="product-content-right-bottom-content-big">
                            <div class="product-content-right-bottom-content-title row">
                                <div class="product-content-right-bottom-content-title-item chitiet">
                                    <p>Chi Tiết</p>
                                </div>
                                <div class="product-content-right-bottom-content-title-item uudai">
                                    <p>Ưu đãi</p>
                                </div>
                                <div class="product-content-right-bottom-content-title-item">
                                    <p>Tham khảo size</p>
                                </div>
                            </div>
                            <div class="product-content-right-bottom-content">
                                <div class="product-content-right-bottom-content-chitiet">
                                    <%=infosanpham.MoTaChiTiet %> <br>
                                   
                                </div>
                                <div class="product-content-right-bottom-content-uudai">
                                    <%=infosanpham.UuDai %>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
