using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.QLNewLetter.Letter
{
    public partial class HienThiLetterLoadControl : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                 LayBaiViet();
               // BindRepeater();
               
            }
        }
        //////Save Button
        ////protected void btnsave_Click(object sender, EventArgs e)
        ////{
        ////    //Code For Update Data 
        ////    if (btnsave.Text == "Update")
        ////    {
        ////        DataTable dt = new DataTable();
        ////        dt = App_Data.Letters.Letter_Update();
        ////        clearcontrol();
        ////        BindRepeater();
        ////        btnsave.Text = "Save";
        ////    }
        ////    else
        ////    {
        ////        //Code For Inserting Data to Database Table
        ////        SqlCommand cmd = new SqlCommand();
        ////        cmd.Connection = conn;
        ////        cmd.Connection.Open();
        ////        cmd.CommandText = "usp_RepeaterDemo";
        ////        cmd.CommandType = CommandType.StoredProcedure;
        ////        cmd.Parameters.AddWithValue("@name", txtname.Text);
        ////        cmd.Parameters.AddWithValue("@username", txtusername.Text);
        ////        cmd.Parameters.AddWithValue("@password", txtpass.Text);
        ////        clearcontrol();
        ////        Response.Write("Record Inserted Successfully!");
        ////        cmd.ExecuteNonQuery();
        ////        conn.Close();
        ////        BindRepeater();
        ////    }
        ////}

        ////Method For Bind Data To Repeater Control
        //private void BindRepeater()
        //{

        //    DataTable dt = new DataTable();
        //   dt = App_Data.Letters.ThongTin_Letter();
        // //   NgayTao.Text = DateTime.Now.ToString("yyyy-MM-dd");


        //   //String dtnow = DateTime.Today.ToShortDateString();
        //   // ((Label)rpLetters.FindControl("NgayTao")).Text = dtnow;
        //    rpLetters.DataSource = dt;
        //    rpLetters.DataBind();

        //}
        //protected void OnItemCommand_repeater(object source, RepeaterCommandEventArgs e)
        //{
        //    //Code For Edit Record  
        //    //On Commad Name Supplied to the Image Button-- "Edit" Button 
        //    if (e.CommandName == "Edit")
        //    {
        //        ////Getting Id of the selected record
        //        //Label txtMa = (Label)e.Item.FindControl("lbltxtmaLetter");
        //        //Label txtSubj = (Label)e.Item.FindControl("lbtxtTenLetter");
        //        //Label txtNgayTao = (Label)e.Item.FindControl("lbtxtNgayTao");
        //        //txtMaLetter.Text = txtMa.Text;
        //        //txtSubj.Text = txtSubj.Text;
        //        //txtNgayTao.Text = txtNgayTao.Text;
        //        //btnsave.Text = "Update";

        //    }

        //    //Code For Delete Record
        //    //On Commad Name Supplied to the Image Button-- "Delete" Button 
        //    if (e.CommandName == "Delete")
        //    {

        //         DataTable dt = new DataTable();
        //        dt = App_Data.Letters.ThongTin_Letter();
        //        BindRepeater();
        //        Response.Write("Record Deleted SuccessFully!");
        //    }

        //    //Code For Insert Record
        //    //On Commad Name Supplied to the Link Button-- "Insert" Button 
        //    if (e.CommandName == "Insert")
        //    {
        //        TextBox txtUname = (TextBox)e.Item.FindControl("txtftrname");
        //        TextBox txtUusername = (TextBox)e.Item.FindControl("txtftrusername");
        //        TextBox txtUPassword = (TextBox)e.Item.FindControl("txtftrpassword");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.Connection.Open();
        //        cmd.CommandText = "usp_RepeaterDemo";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@name", txtUname.Text);
        //        cmd.Parameters.AddWithValue("@username", txtUusername.Text);
        //        cmd.Parameters.AddWithValue("@password", txtUPassword.Text);
        //        Response.Write("Record Inserted Successfully!");
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();
        //        BindRepeater();
        //    }
        //}



        private void LayBaiViet()
        {
            DataTable dt = new DataTable();
            dt = App_Data.Letters.ThongTin_Letter();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrEmail.Text += @"
          <tr id='maDong_" + dt.Rows[i]["iPK_LetterID"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["iPK_LetterID"] + @"</td>
                    <td class='cotSubject'>" + dt.Rows[i]["sSubject"] + @"</td>
                    <td class='cotNgayTao'>" + dt.Rows[i]["dNgayTao"] + @"</td>
                    <td class='cotCongCu'>
                        <a href='Adminn.aspx?modul=QLNewLetter&&modulphu=Letter&&thaotac=ChinhSuaLetter&id=" + dt.Rows[i]["iPK_LetterID"] + @"' class='sua' title='sua'></a>

                    </td>
                </tr>
        ";
            }
        }
    }
    
}