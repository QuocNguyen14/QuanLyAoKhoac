using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac.UserUL
{
    public partial class DatHangCT : System.Web.UI.UserControl
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANAOConnectionString"].ConnectionString);
        public static SanPham infoSanPham = new SanPham();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loaddata();
            }
        }
        void loaddata()
        {
            try
            {
                long IdSanpham = Convert.ToInt64(Request.QueryString["IdDatHang"]);
                var data = from q in ak.SanPhams
                           where q.MaSp == IdSanpham
                           select q;
                if (data != null && data.Count() > 0)
                {
                    infoSanPham = data.First();
                    lblThongBao.Text = "Bạn đang đặt sản phẩm: " + infoSanPham.TenSp;
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void bntGuiDi_Click(object sender, EventArgs e)
        {
            DatHang infoDh = new DatHang();
            infoDh.MaHang = infoSanPham.MaSp;
            infoDh.TenKhach = txtHoTen.Text;
            infoDh.Soluong = Convert.ToInt32(txtSoLuong.Text);
            infoDh.Size = txtSize.Text;
            infoDh.SoDT = txtDT.Text;
            infoDh.DiaChi = txtDiaChi.Text;
            infoDh.TinhTrang = 0;


            ak.DatHangs.InsertOnSubmit(infoDh);
            ak.SubmitChanges();


            lblThongBao.Text = "Đặt Hàng Sản Phẩm: " + infoSanPham.TenSp + " Thành Công.";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ThongBao", "alert('Đặt Sản Phẩm: " + infoSanPham.TenSp + " Thành Công. Chân Thành Cảm Ơn')", true);
        }
    }
}