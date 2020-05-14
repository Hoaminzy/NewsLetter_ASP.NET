using System;
using System.Web.UI;

namespace Website_GuiThuDienTu
{
    public partial class Adminn: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LogIn"].ToString() == "1")
            {
       //Đã đăng nhập
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Bạn chưa đăng nhập'); window.location='Login.aspx';", true);
            }
            if (!IsPostBack) {
                //lbDangXuat.Visible = false;
                ltThongBaoAcc.Text = "Xin Chào " + Session["sName"].ToString();
            }
           
        }
        protected void ltDangXuat_click(object sender, EventArgs e)
        {
            //Xóa các session đã lưu
            Session["LogIn"] = null;
            //Session["TenDangNhap"] = null;
            Session["sName"] = "";
            Session["Count"] = 0;
            Session["Time"] = DateTime.Now;
            Session["Lock"] = false;

            //đẩy về trang đăng nhập
            Response.Redirect("Login.aspx");
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