using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using Website_GuiThuDienTu.App_Data;

namespace Website_GuiThuDienTu.App_Data
{
   
        public class TaiKhoan
        {
            public static void TaiKhoan_Insert(String sEmail, String sPassword, String sName)
            {
                ///<summary>
                /// Them du lieu
                /// </summary>
                OleDbCommand cmd = new OleDbCommand("TaiKhoan_Insert");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sEmail", sEmail);
                cmd.Parameters.AddWithValue("@sPassword", sPassword);
                cmd.Parameters.AddWithValue("@sName", sName);
                SQLDatabase.ExcuteNoneQuery(cmd);

            }
            public static void TaiKhoan_Delete(String iPK_TaiKhoanID)
            {
                ///<summary>
                /// Xoa Theo ma duoc truyen vao
                /// </summary>
                OleDbCommand cmd = new OleDbCommand("TaiKhoan_Delete");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iPK_TaiKhoanID", iPK_TaiKhoanID);
                SQLDatabase.ExcuteNoneQuery(cmd);

            }
            public static void TaiKhoan_Update(String iPK_TaiKhoanID, String sEmail, String sPassword, String sName)
            {
                ///<summary>
                /// Update du lieu
                /// </summary>
                OleDbCommand cmd = new OleDbCommand("TaiKhoan_Update");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iPK_TaiKhoanID", iPK_TaiKhoanID);
                cmd.Parameters.AddWithValue("@sEmail", sEmail);
                cmd.Parameters.AddWithValue("@sPassword", sPassword);
                cmd.Parameters.AddWithValue("@sName", sName);
                SQLDatabase.ExcuteNoneQuery(cmd);

            }
            public static DataTable ThongTin_TaiKhoan()
            {
                ///<summary>
                /// Lay Thong Tin Tai Khoan
                /// </summary>
                OleDbCommand cmd = new OleDbCommand("ThongTin_TaiKhoan");
                cmd.CommandType = CommandType.StoredProcedure;

                return SQLDatabase.GetData(cmd);

            }
        /*  public static DataTable TAIKHOAN_BY_CHUDE(String iFK_MaCD)
          {
              ///<summary>
              /// Lay Thong Tin Tai Khoan
              /// </summary>
              OleDbCommand cmd = new OleDbCommand("TAIKHOAN_BY_CHUD");

              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@iFK_MaCD", iFK_MaCD);
              return SQLDatabase.GetData(cmd);

          }*/
        public static DataTable ThongTin_TaiKhoan_by_ID(String iPK_TaiKhoanID)
        {
            ///<summary>
            /// Lay Thong Tin Tai Khoan Thao Ma
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("ThongTin_TaiKhoan_by_ID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_TaiKhoanID", iPK_TaiKhoanID);
            return SQLDatabase.GetData(cmd);

        }
        public static DataTable ThongTin_TaiKhoan_by_Email(String sEmail)
            {
                ///<summary>
                /// Lay Thong Tin Tai Khoan Thao Emails
                /// </summary>
                OleDbCommand cmd = new OleDbCommand("ThongTin_TaiKhoan_by_Email");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sEmail", sEmail);
                return SQLDatabase.GetData(cmd);

            }
            public static DataTable ThongTin_TaiKhoan_by_Email_MatKhau(String sEmail, String sPassword)
            {
                ///<summary>
                /// Lay Thong Tin Tai Khoan Thao Emails va Mat Khau
                /// </summary>
                OleDbCommand cmd = new OleDbCommand("ThongTin_TaiKhoan_by_Email_MatKhau");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sEmail", sEmail);
                cmd.Parameters.AddWithValue("@sPassword", sPassword);
                return SQLDatabase.GetData(cmd);

            }
        }
    }
