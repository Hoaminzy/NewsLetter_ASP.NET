using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.QLNewLetter.ChuDe
{
    public partial class ThemMoiChuDeLoadControl : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id danh mục chỉnh sửa
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
            drdnCondition.Items.Add("Đã kích hoạt");
            drdnCondition.Items.Add("Khoá");
            if (!IsPostBack)
            {
              
                HienThiThongTin(id);
            }
        }

        private void HienThiThongTin(string id)
        {
            if (thaotac == "ChinhSuaChuDe")
            {
                btnThemMoi.Text = "Update";
                cbThemNhieuChuDe.Visible = false;
                DataTable dt = new DataTable();
                dt = App_Data.ChuDe.ThongTin_ChuDe_by_ID(id);
                if (dt.Rows.Count > 0)
                {
                    tbTenChuDe.Text = dt.Rows[0]["sTenCD"].ToString();
                    drdnCondition.Text = dt.Rows[0]["sCondition"].ToString();
                }
            }
            else
            {
                btnThemMoi.Text = "Thêm Mới";
                cbThemNhieuChuDe.Visible = true;
            }
           
        }

        protected void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (thaotac == "ChinhSuaChuDe")
            {
                btnThemMoi.Text = "Update";
                //đây là nút chỉnh sửa
                App_Data.ChuDe.ChuDe_Update(id, tbTenChuDe.Text, drdnCondition.SelectedValue);
                Response.Redirect("Adminn.aspx?modul=QLNewLetter&&modulphu=ChuDe&thaotac=HienThiChuDe");
            }
            else
            {
                btnThemMoi.Text = "Thêm Mới";
              
                if(tbTenChuDe.Text!="" || drdnCondition.Text != "")
                {
                    App_Data.ChuDe.ChuDe_Insert(tbTenChuDe.Text, drdnCondition.Text);
                }
                else
                {
                    tbTenChuDe.Focus();
                }
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Thêm mới thành công')", true);

                if (cbThemNhieuChuDe.Checked)
                {
                    ResetControl();
                }
                else
                {
                    Response.Redirect("Adminn.aspx?modul=QLNewLetter&&modulphu=ChuDe&&thaotac=HienThiChuDe");
                }
            }
        }
        private void ResetControl()
        {
            tbTenChuDe.Text = "";
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            tbTenChuDe.Text = "";
            Response.Redirect("Adminn.aspx?modul=QLNewLetter&&modulphu=ChuDe&thaotac=HienThiChuDe");
        }
    }
}