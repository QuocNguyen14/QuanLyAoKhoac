using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac.UserUL
{
    public partial class ChiTietSanPhamCT : System.Web.UI.UserControl
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANAOConnectionString"].ConnectionString);
        public static SanPham infosanpham = new SanPham();
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            try
            {
                long IdSanpham = Convert.ToInt64(Request.QueryString["MaSp"]);
                var data = from q in ak.SanPhams
                           where q.MaSp == IdSanpham
                           select q;
                if (data != null && data.Count() > 0)
                {
                    infosanpham = data.First();
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}