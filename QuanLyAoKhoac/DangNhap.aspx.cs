using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblThongBao.Text = "Vui lòng nhập thông tin quản trị website!";
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext();
            var data = from q in ak.CauHinhs
                       where q.TenBien == "UserAdmin" && q.GiaTri == txtUser.Text
                       select q;
            if (data != null && data.Count() > 0)
            {
                var dataP = from a in ak.CauHinhs
                            where a.TenBien == "Pass" && a.GiaTri == txtMatKhau.Text
                            select a;
                if (dataP != null && dataP.Count() > 0)
                {
                    Session["UserName"] = txtUser.Text;
                    Session["MatKhau"] = txtMatKhau.Text;
                    Response.Redirect("QuanTriSanPham.aspx");
                }
                else
                {
                    lblThongBao.Text = "Vui lòng nhập lại mật khẩu!";
                }
            }
            else
            {
                lblThongBao.Text = "Vui lòng nhập lại tên đăng nhập!";
            }
        }
    }
}