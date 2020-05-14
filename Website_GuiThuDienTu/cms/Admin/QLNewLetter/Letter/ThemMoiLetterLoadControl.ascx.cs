using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Website_GuiThuDienTu.cms.Admin.QLNewLetter.Letter
{
    public partial class ThemMoiLetterLoadControl : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id  chỉnh sửa email
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
            {
                thaotac = Request.QueryString["thaotac"];
            }
            if (Request.QueryString["id"] != null)
            {
                id = Request.QueryString["id"];
            }

            if (!IsPostBack)
            {
                LayTaiKhoan();
                LayChuDe();
                HienThiThongTin(id);
            }
        }

        private void HienThiThongTin(string id)
        {
            //#region code thay đổi nút chỉnh sửa
        
            if (thaotac == "ChinhSuaLetter")
            {
                btnThemMoi.Text = "Chỉnh Sửa";
                cbThemNhieuEmail.Visible = false;
                DataTable dt = new DataTable();
                dt = App_Data.Letters.ThongTin_Letter_by_ID(id);
                if (dt.Rows.Count > 0)
                {
                    ddlChuDe.SelectedValue = dt.Rows[0]["iPK_ChuDeID"].ToString();
                    tbSubject.Text = dt.Rows[0]["sSubject"].ToString();
                    tbNgayViet.Text = dt.Rows[0]["dNgayTao"].ToString();
                    ddlNguoiViet.SelectedValue = dt.Rows[0]["iPK_AdminID"].ToString();
                    tbBody.Text = dt.Rows[0]["sBody"].ToString();
                   
                  
                }
                else
                {
                    btnThemMoi.Text = "Thêm Mới";
                    cbThemNhieuEmail.Visible = true;
                }
                btnThemMoi.Text = "Thêm Mới";
                cbThemNhieuEmail.Visible = true;
            }
        }
        private void LayChuDe()
        {
            DataTable dt = new DataTable();
            dt = App_Data.ChuDe.ThongTin_ChuDe();
            ddlChuDe.Items.Clear();
            ddlChuDe.Items.Add(new ListItem("Chọn chủ đề", "0"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlChuDe.Items.Add(new ListItem(dt.Rows[i]["sTenCD"].ToString(), dt.Rows[i]["iPK_MaCD"].ToString()));
            }
        }

        private void LayTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = App_Data.Admin.ThongTin_Admin();
            ddlNguoiViet.Items.Clear();
            ddlNguoiViet.Items.Add(new ListItem("Chọn tài khoản", "0"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlNguoiViet.Items.Add(new ListItem(dt.Rows[i]["sName"].ToString(), dt.Rows[i]["iPK_AdminID"].ToString()));
            }
        }
        protected void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (thaotac == "ThemMoiLetter")
            {
                App_Data.Letters.Letter_Insert(tbSubject.Text, tbBody.Text, ddlNguoiViet.SelectedValue, ddlChuDe.SelectedValue, tbNgayViet.Text);
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong'>Đã tạo Email thành công! <div>";
                if (cbThemNhieuEmail.Checked)
                {
                    ResetControl();
                }
                else
                {
                    Response.Redirect("Adminn.aspx?modul=QLNewLetter&&modulphu=Letter&&thaotac=HienThiLetter");
                }
            }
            else
            {
                //Code nút chỉnh sửa
                App_Data.Letters.Letter_Update(id, tbSubject.Text, tbBody.Text, ddlNguoiViet.SelectedValue, ddlNguoiViet.SelectedValue, tbNgayViet.Text);
                Response.Redirect("Adminn.aspx?modul=QLNewLetter&&modulphu=Letter&&thaotac=HienThiLetter");
            }
        }
        private void ResetControl()
        {
            tbSubject.Text = null;
            tbBody.Text = null;
            tbNgayViet.Text = DateTime.Now.ToString("MM/dd/YYYY");
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        protected void tbBody_TextChanged(object sender, EventArgs e)
        {

        }
    }
}