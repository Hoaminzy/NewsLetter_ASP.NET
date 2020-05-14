using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.QLTaiKhoan
{
    public partial class HienThiTaiKhoanLoadControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LayTaiKhoan();
            }
        }
        private void LayTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = App_Data.Admin.HienTaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrTaiKhoan.Text += @"
                <tr id='maDong_" + dt.Rows[i]["iPK_AdminID"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["iPK_AdminID"] + @"</td>
                    <td class='cotTen'>" + dt.Rows[i]["sName"] + @"</td>
                    <td class='cotEmail'>" + dt.Rows[i]["sEmail"] + @"</td>
                      <td class='cotPass'>" + dt.Rows[i]["sPassword"] + @"</td>
                       <td class='cotTinhtrang'>" + dt.Rows[i]["sCondition"] + @"</td>
                    <td class='cotQuyen'>" + dt.Rows[i]["sQuyen"] + @"</td>
                    <td class='cotCongCu'>
                        <a href='Adminn.aspx?modul=QLyTaiKhoan&&thaotac=ChinhSuaTaiKhoan&&id="+ dt.Rows[i]["iPK_AdminID"] + @"' class='sua' title='sua'></a>
                        
                    </td>
                </tr>";
            }

        }
    }
}