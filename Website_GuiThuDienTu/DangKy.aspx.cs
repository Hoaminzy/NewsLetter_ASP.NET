using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
namespace Website_GuiThuDienTu
{
    public partial class DangKy : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        //con.Open(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDK_Click(object sender, EventArgs e)
        {
           
            if (DaTonTaiEmail(txtEmail.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Email này đã tồn tại. Bạ vui lòng điền Email khác!');", true);
            }
            else
            {
                App_Data.TaiKhoan.TaiKhoan_Insert(txtEmail.Text, txtMK.Text, txtTenTK.Text );
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Đã tạo tài khoản thành công');location.href='/DangNhap.aspx'; ", true);
                txtEmail.Text = "";
                txtMK.Text = "";
                txtTenTK.Text ="";
                Response.Redirect("DangNhap.aspx");
            }

        }

        private bool DaTonTaiEmail(string sEmail)
        {
            DataTable dt = new DataTable();
            dt = App_Data.TaiKhoan.ThongTin_TaiKhoan_by_Email(sEmail);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

       
    }
}