using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.QLTaiKhoan
{
    public partial class ThemMoiTaiKhoanLoadControl : System.Web.UI.UserControl
    {
        private string thaotac = "";
       string id = "";//lấy id của danh mục cần chỉnh sửa
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["iPK_AdminID"] != null)
            {
               id  = Request.QueryString["iPK_AdminID"];
            }
           
            if (!IsPostBack)
            {
                drdnCondition.Items.Add("Đã kích hoạt");
                drdnCondition.Items.Add("Khoá");
                drdnRole.Items.Add("Quản trị viên");
                drdnRole.Items.Add("Người dùng");
                //if (thaotac == "ChinhSuaTaiKhoan")
                //{
                //    btnUpdate.Text = "Update";

                //    DataTable td = new DataTable();
                //    td = App_Data.Admin.HienTaiKhoan_ByID(id);

                //    if (td.Rows.Count > 0)
                //    {
                //        txtEmail.Text = td.Rows[0]["sEmail"].ToString();
                //        txtPassword.Text = td.Rows[0]["sPassword"].ToString();
                //        txtUserName.Text = td.Rows[0]["sName"].ToString();
                //        drdnCondition.Text = td.Rows[0]["sCondition"].ToString();
                //        drdnRole.Text = td.Rows[0]["sQuyen"].ToString();
                //    }
                //}
                //else
                //{
                //    btnUpdate.Text = "Thêm Mới";
                //}
                LoadDL(id);
            }
        }
      protected void LoadDL(string id)
        {
            if (thaotac == "ChinhSuaTaiKhoan")
            {
                btnUpdate.Text = "Update";

                DataTable td = new DataTable();
                td = App_Data.Admin.HienTaiKhoan_ByID(id);

                if (td.Rows.Count > 0)
                {
                    txtEmail.Text = td.Rows[0]["sEmail"].ToString();
                    txtPassword.Text = td.Rows[0]["sPassword"].ToString();
                    txtUserName.Text = td.Rows[0]["sName"].ToString();
                    drdnCondition.Text = td.Rows[0]["sCondition"].ToString();
                    drdnRole.Text = td.Rows[0]["sQuyen"].ToString();
                }
            }
            else
            {
                btnUpdate.Text = "Thêm Mới";
            }
        }
      
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (thaotac == "ChinhSuaTaiKhoan") {
                btnUpdate.Text = "Chỉnh Sửa";
               int iFK_QuyenID=0;
                if (drdnRole.Text == "Quản trị viên")
                {
                   iFK_QuyenID = 1;
                    
                 
                    if (txtEmail.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || drdnCondition.Text == "")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Không để trống')", true);
                    }
                    else
                    {
                        App_Data.Admin.Admin_Update(id, txtEmail.Text, txtPassword.Text, txtUserName.Text, drdnCondition.SelectedValue, iFK_QuyenID);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cập nhật thành công'); window.location='HienThiTaiKhoanLoadControl.ascx';", true);

                    }
                  
                }
                else
                {
                    iFK_QuyenID = 2;
                   

                    if (txtEmail.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || drdnCondition.Text == "")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Không để trống')", true);
                    }
                    else
                    {
                        App_Data.Admin.Admin_Update(id, txtEmail.Text, txtPassword.Text, txtUserName.Text, drdnCondition.SelectedValue, iFK_QuyenID);
                    }
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cập nhật thành công'); window.location='HienThiTaiKhoanLoadControl.ascx';", true);
                }

            }
            else
            {

                btnUpdate.Text = "Thêm Mới";
               
                if (txtEmail.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || drdnCondition.Text == "")
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Không để trống')", true);
                }
                else
                {
                    App_Data.Admin.Admin_Insert(txtEmail.Text, txtPassword.Text, txtUserName.Text, drdnCondition.Text, drdnRole.Text);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Thêm thành công'); window.location='HienThiTaiKhoanLoadControl.ascx';", true);

                }

            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}