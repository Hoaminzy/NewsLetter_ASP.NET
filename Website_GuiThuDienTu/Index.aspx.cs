using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu
{
    public partial class Index : System.Web.UI.Page
    {

        //private string modul = "";
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //    if (Request.QueryString["modul"] != null)
        //    {
        //        modul = Request.QueryString["modul"];
        //    }

        //    if (!IsPostBack)
        //    {
        //        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        //        {
        //            //Đã đăng nhập
        //            if (Session["DangNhap"] != null)
        //            {
        //                string id = Session["iPK_AdminID"].ToString();
        //                DataTable dt = new DataTable();
        //                dt = App_Data.Admin.ThongTin_Admin_by_ID(int.Parse(id));
        //                ltrTenNguoiDung.Text = dt.Rows[0]["sName"].ToString();
        //                ltrTenTK.Text = dt.Rows[0]["sName"].ToString();
        //                ltrEmail.Text = dt.Rows[0]["sEmail"].ToString();
        //                ThongTin_ChuDe_ChuaChon();
        //                ThongTin_ChuDe();

        //            }
        //        }

        //    }
        //}
        //protected void ThongTin_ChuDe_ChuaChon()
        //{
        //    string id = Session["iPK_AdminID"].ToString();
        //    DataTable dt = new DataTable();
        //    dt = App_Data.Admin_Chude.HIENCHUDE_CHUADANGKY_BYUSERID(int.Parse(id));
        //    tbChuDeQuanTam.Text = "";
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        ltrChuDeDangKy.Text += @"
        //        <tr >
        //            <td class='cotMa'>" + dt.Rows[i]["iFK_MaCD"] + @"</td>
        //            <td class='cotTen'>" + dt.Rows[i]["sTenCD"] + @"</td>
        //        </tr>";
        //        lbChuDeHuy.Items.Add(new ListItem(dt.Rows[i]["sTenCD"].ToString(), dt.Rows[i]["iFK_MaCD"].ToString()));
        //    }

        //}
        //protected void ThongTin_ChuDe()
        //{
        //    string id = Session["iPK_AdminID"].ToString();

        //    DataTable dt = new DataTable();
        //    dt = App_Data.ChuDe.ThongTin_ChuDe_by_ID(id);
        //    lbChuDe.Items.Clear();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        lbChuDe.Items.Add(new ListItem(dt.Rows[i]["sTenCD"].ToString(), dt.Rows[i]["iPK_MaCD"].ToString()));
        //    }
        //}



        //protected void lbnDangXuat_Click(object sender, EventArgs e)
        //{
        //    //Xóa các sesion đã lưu
        //    Session["DangNhap"] = null;
        //    Session["iPK_AdminID"] = null;
        //    Session["sEmail"] = null;
        //    Session["sName"] = null;
        //    //Đưa về trang đăng nhập

        //    Response.Redirect("Login.aspx");
        //}

        //protected void lbtCapNhat_Click(object sender, EventArgs e)
        //{
        //    string id = Session["iPK_AdminID"].ToString();
        //    foreach (ListItem item in lbChuDe.Items)
        //    {
        //        if (item.Selected)
        //        {
        //            App_Data.Admin_Chude.THEMCHUDE_BYUSERID(int.Parse(id),int.Parse( item.ToString()));
        //            Response.Redirect("Index.aspx");
        //        }
        //    }

        //}

        //protected void lbtHuy_Click(object sender, EventArgs e)
        //{
        //    string id = Session["iPK_AdminID"].ToString();
        //    foreach (ListItem item in lbChuDeHuy.Items)
        //    {
        //        if (item.Selected)
        //        {
        //            App_Data.Admin_Chude.XOACHUDE_BYUSERID(int.Parse(id), int.Parse(item.Value.ToString()));
        //            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong'>Đã xóa chủ đề " + item.ToString();
        //            ltrThongBao.Text = "đã xóa" + item.ToString();
        //            Response.Redirect("Index.aspx");
        //        }
        //        if (item.Selected.Equals(""))
        //        {
        //            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong'>Đã xóa chủ đề " + item.ToString();
        //        }
        //    }
        //}

        //protected void btnChange_Click(object sender, EventArgs e)
        //{
        //    if (txtNewPassword1.Text == "" || txtNewPassword2.Text == "" || txtOldPassword.Text == "")
        //    {
        //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mời điền đầy đủ các trường')", true);
        //    }
        //    else
        //    {
        //        if (Session["sPassword"].ToString() == txtOldPassword.Text)
        //        {
        //            if (txtNewPassword1.Text == txtNewPassword2.Text)
        //            {
        //                App_Data.Admin.DoiMatKhau_ByID(int.Parse(Session["iPK_AdminID"].ToString()), txtNewPassword1.Text);
        //                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Đổi mật khẩu thành công')", true);
        //            }
        //            else
        //            {
        //                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mật khẩu mới không trùng khớp')", true);
        //            }
        //        }
        //        else
        //        {
        //            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mật khẩu cũ không đúng')", true);
        //        }
        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LogIn"] != null && Session["LogIn"].ToString() == "1")
                {

                    string id = Session["iPK_AdminID"].ToString();
                    drdnSubject1.Items.Clear();
                    drdnSubject2.Items.Clear();
                    DataTable table = new DataTable();

                    table = data.admin_subject.HienChuDe_ByUserID(int.Parse(id));
                    drdnSubject2.DataSource = table;
                    drdnSubject2.DataTextField = "sTenCD";
                    drdnSubject2.DataValueField = "iPK_MaCD";
                    drdnSubject2.DataBind();

                    table = data.admin_subject.HienChuDe_ChuaDangKy_ByUserID(int.Parse(id));
                    drdnSubject1.DataSource = table;
                    drdnSubject1.DataTextField = "sTenCD";
                    drdnSubject1.DataValueField = "iPK_MaCD";
                    drdnSubject1.DataBind();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }
        }

        protected void btnAddSubject_Click(object sender, EventArgs e)
        {
            App_Data.Admin_Chude.ThemChuDe_ByUserID(int.Parse(Session["iPK_AdminID"].ToString()), int.Parse(drdnSubject1.SelectedValue));
           
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Đăng ký thành công'); window.location='Index.aspx';", true);

        }

        protected void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            App_Data.Admin_Chude.XoaChuDe_ByUserID(int.Parse(Session["iPK_AdminID"].ToString()), int.Parse(drdnSubject2.SelectedValue));
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Huỷ bỏ thành công'); window.location='Index.aspx';", true);
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPassword1.Text == "" || txtNewPassword2.Text == "" || txtOldPassword.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mời điền đầy đủ các trường')", true);
            }
            else
            {
                if (Session["sPassword"].ToString() == txtOldPassword.Text)
                {
                    if (txtNewPassword1.Text == txtNewPassword2.Text)
                    {
                        App_Data.Admin.DoiMatKhau_ByID(int.Parse(Session["iPK_AdminID"].ToString()), txtNewPassword1.Text);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Đổi mật khẩu thành công')", true);
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mật khẩu mới không trùng khớp')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mật khẩu cũ không đúng')", true);
                }
            }
        }

      
    }

}