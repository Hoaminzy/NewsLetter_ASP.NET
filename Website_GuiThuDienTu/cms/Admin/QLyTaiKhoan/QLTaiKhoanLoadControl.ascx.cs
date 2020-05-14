using System;
namespace Website_GuiThuDienTu.cms.Admin.QLyTaiKhoan
{
    public partial class QLTaiKhoanLoadControl : System.Web.UI.UserControl
    {

        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
            {
                thaotac = Request.QueryString["thaotac"];
            }
            switch (thaotac)
            {
                case "ChinhSuaTaiKhoan":
                    //plContent.Controls.Add(LoadControl("ChinhSuaTaiKhoanLoadControl.ascx"));
                    //break;
                case "ThemMoiTaiKhoan":
                    plContent.Controls.Add(LoadControl("ThemMoiTaiKhoanLoadControl.ascx"));
                    break;
               
                case "HienThiTaiKhoan":
                    plContent.Controls.Add(LoadControl("HienThiTaiKhoanLoadControl.ascx"));
                    break;
                default:
                    plContent.Controls.Add(LoadControl("HienThiTaiKhoanLoadControl.ascx"));
                    break;
            }
        }
        protected string DanhDau(string tenModul, string tenThaoTac)
        {
            string s = "";

            /*Lấy giá trị querystring modul, modulphu, thaotac*/
            string modul = "";
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            string thaotac = "";
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];

            /*So sánh nếu querystring bằng tên modul, modulphu, thaotac truyền vào thì trả về current --> đánh dấu là menu hiện tại*/
            if (modul == tenModul  && thaotac == tenThaoTac)
                s = "current";
            return s;
        }
    }
}