using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.SendLetter
{
    public partial class HienThiSendLetterControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                    lstbSubject.Items.Clear();
                    DataTable table = new DataTable();
                    table = App_Data.ChuDe.ThongTin_ChuDe();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (table.Rows[i]["sCondition"].ToString() == "Đã kích hoạt")
                            lstbSubject.Items.Add(table.Rows[i]["sTenCD"].ToString());
                    }
                }
      
}
        protected void lstbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["iPK_MaCD"] = lstbSubject.SelectedIndex;
            DataTable table = new DataTable();
            table = App_Data.ChuDe.HienChiTietChuDe(lstbSubject.SelectedIndex+1);
            if (table.Rows.Count > 0)
            {
                Response.Redirect("Adminn.aspx?modul=SendLetter&&thaotac=GuiThu");
               
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "message", "alert('Chủ đề chưa có người dùng đăng ký'); window.location='Adminn.aspx?modul=SendLetter&&thaotac=GuiThu';", true);
            }
        }
   
    }
}