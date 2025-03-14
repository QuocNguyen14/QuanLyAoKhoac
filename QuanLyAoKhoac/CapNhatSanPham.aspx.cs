using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac
{
    public partial class CapNhatSanPham : System.Web.UI.Page
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANAOConnectionString"].ConnectionString);
        public static SanPham infosanpham = new SanPham();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loaddata();
        }
        void loaddata()
        {
            try
            {
                if (Request.QueryString["IDSanPham"] != "")
                {
                    long IdSanpham = Convert.ToInt64(Request.QueryString["IDSanPham"]);
                    var data = from q in ak.SanPhams
                               where q.MaSp == IdSanpham
                               select q;
                    if (data != null && data.Count() > 0)
                    {
                        infosanpham = data.First();
                        lblThongBao.Text = "Bạn đang cập nhật sản phẩm: " + infosanpham.TenSp;
                        txtTenSP.Text = infosanpham.TenSp;
                        txtTenCT.Text = infosanpham.TenCt;
                        txtGia.Text = infosanpham.Gia.ToString();
                        txtMaSo.Text = infosanpham.MaSo;
                        txtMau.Text = infosanpham.Color;
                        txtSize.Text = infosanpham.Size;
                        txtUudai.Text = infosanpham.UuDai;
                        FCKChiTiet.Value = HttpUtility.HtmlDecode(infosanpham.MoTaChiTiet);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            var data = from q in ak.SanPhams
                       where q.MaSp == infosanpham.MaSp
                       select q;
            if (data != null)
            {
                SanPham infoCapNhat = data.First();
                infoCapNhat.TenSp = txtTenSP.Text;
                infoCapNhat.TenCt = txtTenCT.Text;
                infoCapNhat.Gia = Convert.ToInt64(txtGia.Text);
                infoCapNhat.MaSo = txtMaSo.Text;
                infoCapNhat.Color = txtMau.Text;
                infoCapNhat.Size = txtSize.Text;
                infoCapNhat.UuDai = txtUudai.Text;
                if (fileHinhAnh.HasFile)
                {
                    infoCapNhat.HinhAnh = fileHinhAnh.FileName;
                    fileHinhAnh.SaveAs(Server.MapPath("img\\imagesSP\\") + fileHinhAnh.FileName);
                }
                infoCapNhat.MoTaChiTiet = HttpUtility.HtmlEncode(FCKChiTiet.Value);
                ak.SubmitChanges();
                lblThongBao.Text = "Cập nhật thành công!";
            }
        }
    }
}