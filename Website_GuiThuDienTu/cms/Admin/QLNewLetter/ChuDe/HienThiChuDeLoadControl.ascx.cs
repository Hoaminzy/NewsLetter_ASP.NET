using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.QLNewLetter.ChuDe
{
    public partial class HienThiChuDeLoadControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCD();
            }
        }
        private void LoadCD()
        {
            DataTable dt = new DataTable();
            dt = App_Data.ChuDe.ThongTin_ChuDe();
            //rpChuDe.DataSource = dt;
            //rpChuDe.DataBind();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrChuDe.Text += @"
        <tr id='maDong_" + dt.Rows[i]["iPK_MaCD"] + @"'>
            <td class='cotMa'>" + dt.Rows[i]["iPK_MaCD"] + @"</td>
            <td class='cotTen'>" + dt.Rows[i]["sTenCD"] + @"</td>
            <td class='cotCongCu'>
                <a href ='Adminn.aspx?modul=QuanLyNewsLetters&modulphu=ChuDe&thaotac=ChinhSuaChuDe&id=" + dt.Rows[i]["iPK_MaCD"] + @"' class='sua' title='sua'></a>
            </td>
        </tr>
";
            }
        }
    }
}
