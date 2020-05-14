using System;
using System.Data;
using System.Web.UI;

namespace Website_GuiThuDienTu.cms.Admin.SendLetter
{
    public partial class SendLetterLoadControl : System.Web.UI.UserControl
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

               
                case "HienThi":
                    {
                    plSendLetters.Controls.Add(LoadControl("HienThiSendLetterControl.ascx"));
                    break;
                    }
                    
                         case "GuiThu":
                    {
                        plSendLetters.Controls.Add(LoadControl("ThemMoiSendLetterControl.ascx"));
                        break;
                    }
                default:
                    {
                        plSendLetters.Controls.Add(LoadControl("HienThiSendLetterControl.ascx"));
                        break;
                    }

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
            if (modul == tenModul && thaotac == tenThaoTac)
                s = "current";
            return s;
        }
    }
        
    }
