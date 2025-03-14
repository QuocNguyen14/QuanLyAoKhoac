using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyAoKhoac
{
    public partial class QuanTriSanPham : System.Web.UI.Page
    {
        QuanLyAoKhoacDataContext ak = new QuanLyAoKhoacDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANAOConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                KiemTradangNhap();
                loaddata();
            }
        }

        void loaddata()
        {
            var data = from p in ak.SanPhams
                       select p;
            if (data != null)
            {
                gridSanPham.DataSource = data.ToList();
                gridSanPham.DataBind();
            }
        }
        void KiemTradangNhap()
        {
            if (Session["UserName"] != "" && Session["MatKhau"] != "")
            {
                var data = from q in ak.CauHinhs
                           where q.TenBien == "UserAdmin"
                           && q.GiaTri == Session["UserName"]
                           select q;
                if (data != null && data.Count() > 0)
                {
                    var dataP = from a in ak.CauHinhs
                                where a.TenBien == "Pass"
                                && a.GiaTri == Session["MatKhau"]
                                select a;

                    if (dataP == null || dataP.Count() == 0)
                    {
                        Response.Redirect("DangNhap.aspx");
                    }
                }
                else
                {
                    Response.Redirect("DangNhap.aspx");
                }
            }
            else
            {
                Response.Redirect("DangNhap.aspx");
            }
        }
        protected void gridSanPham_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            gridSanPham.CurrentPageIndex = e.NewPageIndex;
            loaddata();
        }
        protected void gridSanPham_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (((LinkButton)e.CommandSource).CommandName == "GetDelete")
            {

                long idSPSelect = Convert.ToInt64(gridSanPham.DataKeys[e.Item.ItemIndex].ToString());
                var data = from p in ak.SanPhams
                           where p.MaSp == idSPSelect
                           select p;

                if (data != null)
                {
                    SanPham infoSanPham = data.First();

                    ak.SanPhams.DeleteOnSubmit(infoSanPham);
                    ak.SubmitChanges();

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ThongBao", "alert('Xóa Sản Phẩm " + infoSanPham.TenSp + " thành công!!!')", true);
                    loaddata();

                }

            }
            if (((LinkButton)e.CommandSource).CommandName == "GetUpdate")
            {
                string strIdSelect = gridSanPham.DataKeys[e.Item.ItemIndex].ToString();
                Response.Redirect("CapNhatSanPham.aspx?IDSanPham=" + strIdSelect);
            }
        }
    }
}