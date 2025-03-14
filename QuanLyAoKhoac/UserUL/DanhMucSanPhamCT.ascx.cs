using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac.UserUL
{
    public partial class DanhMucSanPhamCT : System.Web.UI.UserControl
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANAOConnectionString"].ConnectionString);
        public static List<SanPham> listDm = new List<SanPham>();
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            try
            {
                long IdDm = Convert.ToInt64(Request.QueryString["MaDm"]);
                var data = from q in ak.SanPhams
                           where q.MaDm == IdDm
                           select q;
                if (data != null && data.Count() > 0)
                {
                    listDm = data.ToList();
                }
                var dataDm = from q in ak.DanhMucSPs
                             where q.MaDm == IdDm
                             select q;
                if (data != null)
                {
                    lblTenDanhMuc.Text = dataDm.First().TenDm;
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}