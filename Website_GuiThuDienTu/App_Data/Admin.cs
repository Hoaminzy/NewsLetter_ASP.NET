using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using Website_GuiThuDienTu.App_Data;

namespace Website_GuiThuDienTu.App_Data
{
    public class Admin
    {
        public static void Admin_Insert(String sEmail, String sPassword, String sName, String sCondition, String iFK_QuyenID)
        {
            ///<summary>
            /// Them Admin
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("Admin_Insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sEmail", sEmail);
            cmd.Parameters.AddWithValue("@sPassword", sPassword);
            cmd.Parameters.AddWithValue("@sName", sName);
            cmd.Parameters.AddWithValue("@sCondition", sCondition);
            cmd.Parameters.AddWithValue("@iFK_QuyenID", iFK_QuyenID);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }
        public static void Admin_Delete(String iPK_AdminID)
        {
            ///<summary>
            /// Xoa ADmin
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("Admin_Delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }

        public static void Admin_Update(String iPK_AdminID, String sEmail, String sPassword, String sName,String sCondition, int iFK_QuyenID)
        {
            ///<summary>
            /// Update Admin
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("Admin_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            cmd.Parameters.AddWithValue("@sEmail", sEmail);
            cmd.Parameters.AddWithValue("@sPassword", sPassword);
            cmd.Parameters.AddWithValue("@sName", sName);
            cmd.Parameters.AddWithValue("@sCondition", sCondition);
            cmd.Parameters.AddWithValue("@iFK_QuyenID", iFK_QuyenID);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }
        

             public static void DoiMatKhau_ByID(int iPK_AdminID, String sPassword)
        {
            ///<summary>
            /// Update Admin
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("DoiMatKhau_ByID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            cmd.Parameters.AddWithValue("@sPassword", sPassword);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }
        public static DataTable ThongTin_Admin()
        {
            ///<summary>
            /// Thong Tin Admin
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("ThongTin_Admin");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }

      

        public static DataTable HienTaiKhoan()
        {
            ///<summary>
            /// Thong Tin Admin
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("HienTaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable HienTaiKhoan_ByID(string iPK_AdminID)
        {
            ///<summary>
            /// Them Admin Theo Ma
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("HienTaiKhoan_ByID");
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);

          
        }
        public static DataTable DangNhap(String sEmail, String sPassword)
        {
            ///<summary>
            /// Them Admin Theo Email va Pass
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("DangNhap");
            cmd.Parameters.AddWithValue("@sEmail", sEmail);
            cmd.Parameters.AddWithValue("@sPassword", sPassword);
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
       
                    public static DataTable ThongTin_Admin_by_ID(int iPK_AdminID)
        {
            ///<summary>
            /// Them Admin Theo Email va Pass
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("ThongTin_Admin_by_ID");
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable HienChuDe_ChuaDangKy_ByUserID(int iPK_AdminID)
        {
            ///<summary>
            /// Them Admin Theo Email va Pass
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("HienChuDe_ChuaDangKy_ByUserID");
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }

   
    }
}