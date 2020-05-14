using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap(object sender, EventArgs e)
        {
            
            DataTable dt = App_Data.Admin.DangNhap(txtEmail.Text, txtPass.Text);
            if (dt.Rows.Count > 0)
            {
                Session["iPK_AdminID"] = dt.Rows[0]["iPK_AdminID"];
                Session["sEmail"] = dt.Rows[0]["sEmail"];
                Session["sName"] = dt.Rows[0]["sName"];
                Session["sPassword"] = dt.Rows[0]["sPassword"];
                Session["LogIn"] = "1";
                if (dt.Rows[0]["iFK_QuyenID"].ToString() == "1")
                    Response.Redirect("Adminn.aspx");
                else
                    Session["iPK_AdminID"] =dt.Rows[0]["iPK_AdminID"];
                Response.Redirect("Index.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Đăng nhập thất bại')", true);
            }
        }
    }
}