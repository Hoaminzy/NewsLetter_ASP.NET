using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin
{
    
    public partial class AdminLoadControl : System.Web.UI.UserControl
    {
        private String modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["modul"] != null)
            {
                modul = Request.QueryString["modul"];
            }
            switch (modul)
            {
                case "QLyLetter":
                    plAdminLoadControl.Controls.Add(LoadControl("QLNewLetter/QLyLetterLoadControl.ascx"));
                    break;
                case "QLyTaiKhoan":
                    plAdminLoadControl.Controls.Add(LoadControl("QLyTaiKhoan/QLTaiKhoanLoadControl.ascx"));
                    break;
                case "SendLetter":
                    plAdminLoadControl.Controls.Add(LoadControl("SendLetter/SendLetterLoadControl.ascx"));
                    break;
                //case "DangXuat":
                //    plAdminLoadControl.Controls.Add(LoadControl("DangXuat/DangXuatLoadControl.ascx"));
                //    break;
                default:
                    {
                        plAdminLoadControl.Controls.Add(LoadControl("QLNewLetter/QLyLetterLoadControl.ascx"));
                        break;
                    }
              
            }
        }
        protected string DanhDau(string tenModul)
        {
            string s = "";

            /*Lấy giá trị querystring modul, modulphu, thaotac*/
            string modul = "";
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            /*So sánh nếu querystring bằng tên modul, modulphu, thaotac truyền vào thì trả về current --> đánh dấu là menu hiện tại*/
            if (modul == tenModul)
                s = "current";
            return s;
        }
    }
}