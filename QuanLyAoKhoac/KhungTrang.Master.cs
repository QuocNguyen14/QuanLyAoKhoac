using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac
{
    public partial class KhungTrang : System.Web.UI.MasterPage
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext();
        public static List<DanhMucSP> ListDM = new List<DanhMucSP>();
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            var data = from p in ak.DanhMucSPs
                       where p.TrangThai == 1
                       orderby p.ViTri descending
                       select p;
            if (data != null && data.Count() > 0)
            {
                ListDM = data.ToList();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("TimKiem.aspx?GiaTriTim=" + txtTimKiem.Text);
        }
    }
}