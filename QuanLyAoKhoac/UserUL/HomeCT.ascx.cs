using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac.UserUL
{
    public partial class HomeCT : System.Web.UI.UserControl
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANAOConnectionString"].ConnectionString);
        public static List<SanPham> ListSp = new List<SanPham>();
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            var data = from p in ak.SanPhams
                       where p.XuHuong == 1
                       select p;
            if (data != null && data.Count() > 0)
            {
                ListSp = data.ToList();
            }
        }
    }
}