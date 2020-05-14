using System;
namespace Website_GuiThuDienTu.cms.Admin.QLNewLetter
{
    public partial class QLyLetterLoadControl : System.Web.UI.UserControl
    {
        private String modulphu = "";
        private String thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
            {
                modulphu = Request.QueryString["modulphu"];
            }
            switch (modulphu)
            {
                case "ChuDe":
                    plLetterLoadControl.Controls.Add(LoadControl("ChuDe/ChuDeLoadControl.ascx"));
                    break;
                //case "Letter":
                //    plLetterLoadControl.Controls.Add(LoadControl("Letter/LetterLoadControl.ascx"));
                //    break;
                default:
                    {
                        plLetterLoadControl.Controls.Add(LoadControl("ChuDe/ChuDeLoadControl.ascx"));
                        break;
                    }
            }

            //if (Request.QueryString["thaotac"] != null)
            //{
            //    thaotac = Request.QueryString["thaotac"];
            //}
            //switch (thaotac)
            //{
            //    case "ThemMoiChuDe":
            //        plLetterLoadControl.Controls.Add(LoadControl("ChuDe/ThemMoiChuDeLoadControl.ascx"));
            //        break;
            //    case "ThemMoiLetter":
            //        plLetterLoadControl.Controls.Add(LoadControl("Letter/ThemMoiLetterLoadControl.ascx"));
            //        break;
            //    default:
            //        {
            //            plLetterLoadControl.Controls.Add(LoadControl("ChuDe/ThemMoiChuDeLoadControl.ascx"));
            //            break;
            //        }
            //}
        }
        protected string DanhDau(string tenModul, string tenModulPhu, string tenThaoTac)
        {
            string s = "";

            /*Lấy giá trị querystring modul, modulphu, thaotac*/
            string modul = "";
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            string modulphu = "";
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];

            string thaotac = "";
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];

            /*So sánh nếu querystring bằng tên modul, modulphu, thaotac truyền vào thì trả về current --> đánh dấu là menu hiện tại*/
            if (modul == tenModul && modulphu == tenModulPhu && thaotac == tenThaoTac)
                s = "current";
            return s;
        }
    }
}