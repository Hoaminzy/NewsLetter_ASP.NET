using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Website_GuiThuDienTu.App_Data
{
    public class Admin_Chude
    {
        public static DataTable HienChuDe_ByUserID(String iPK_AdminID)
        {
           

            OleDbCommand cmd = new OleDbCommand("HienChuDe_ByUserID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@iPK_AdminID", iPK_AdminID));
            return SQLDatabase.GetData(cmd);

        }
        
        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="iPK_AdminID"></param>
        /// <returns></returns>
        public static DataTable HienChuDe_ChuaDangKy_ByUserID(String iPK_AdminID)
        {
            OleDbCommand cmd = new OleDbCommand("HienChuDe_ChuaDangKy_ByUserID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@iPK_AdminID", iPK_AdminID));
            return SQLDatabase.GetData(cmd);
        }

        public static void ThemChuDe_ByUserID(int iFK_AdminID,int iFK_MaCD)
        {
            OleDbCommand cmd = new OleDbCommand("ThemChuDe_ByUserID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@iFK_iAdminID", iFK_AdminID));
            cmd.Parameters.Add(new SqlParameter("@iFK_MaCD", iFK_MaCD));
            cmd.ExecuteNonQuery();
        }

        public static void XoaChuDe_ByUserID(int iFK_AdminID, int iFK_MaCD)
        {
            OleDbCommand cmd = new OleDbCommand("XoaChuDe_ByUserID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@iFK_AdminID", iFK_AdminID));
                cmd.Parameters.Add(new SqlParameter("@iFK_MaCD", iFK_MaCD));
                cmd.ExecuteNonQuery();
         
        }
    }
}