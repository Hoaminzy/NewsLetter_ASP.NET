using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.QLNewLetter.Letter
{
    public partial class LetterLoadControl1 : System.Web.UI.UserControl
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
                case "ThemMoiLetter":
                case "ChinhSuaLetter":
                    plLetter.Controls.Add(LoadControl("ThemMoiLetterLoadControl.ascx"));
                    break;
                case "HienThiLetter":
                    plLetter.Controls.Add(LoadControl("HienThiLetterLoadControl.ascx"));
                    break;
               
                default:
                    {
                        plLetter.Controls.Add(LoadControl("HienThiLetterLoadControl.ascx"));
                        break;
                    }
            }
        }
    }
}