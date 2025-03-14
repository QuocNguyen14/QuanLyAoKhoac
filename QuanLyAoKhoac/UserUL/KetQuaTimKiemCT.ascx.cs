using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac.UserUL
{
    public partial class KetQuaTimKiemCT : System.Web.UI.UserControl
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext();
        public static List<SanPham> listDm = new List<SanPham>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loaddata();
        }
        void loaddata()
        {
            try
            {
                string strTimKiem = Request.QueryString["GiaTriTim"];
                var data = from q in ak.SanPhams
                           where q.TenSp.Contains(strTimKiem)
                           select q;
                if (data != null && data.Count() > 0)
                {
                    listDm = data.ToList();
                }
                lblThongBao.Text = "Kết quả tìm kiếm sản phẩm: " + strTimKiem;
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}