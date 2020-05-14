using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.QLNewLetter.ChuDe
{
    public partial class ChuDeLoadControl : System.Web.UI.UserControl
    {
        private String thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
            {
                thaotac = Request.QueryString["thaotac"];
            }
            switch (thaotac)
            {
                case "ChinhSuaChuDe":
                case "ThemMoiChuDe":
                    plChuDe.Controls.Add(LoadControl("ThemMoiChuDeLoadControl.ascx"));
                    break;
                case "HienThiChuDe":
                    plChuDe.Controls.Add(LoadControl("HienThiChuDeLoadControl.ascx"));
                    break;
               
                default:
                    {
                        plChuDe.Controls.Add(LoadControl("HienThiChuDeLoadControl.ascx"));
                        break;
                    }
            }
        }


    }
}