using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using Website_GuiThuDienTu.App_Data;

namespace Website_GuiThuDienTu.App_Data
{
    public class TaiKhoan_ChuDe
    {
        public static void TK_CD_INSERT( String iFK_TaiKhoanID, String iFK_MaCD)
        {
            OleDbCommand cmd = new OleDbCommand("TK_CD_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_TaiKhoanID",iFK_TaiKhoanID);
            cmd.Parameters.AddWithValue("@iFK_MaCD", iFK_MaCD);
            SQLDatabase.ExcuteNoneQuery(cmd);
        }

        public static void TK_CD_UPDATE(String iFK_TaiKhoanID, String iFK_MaCD)
        {
            OleDbCommand cmd = new OleDbCommand("TK_CD_UPDATE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_TaiKhoanID", iFK_TaiKhoanID);
            cmd.Parameters.AddWithValue("@iFK_MaCD", iFK_MaCD);
            SQLDatabase.ExcuteNoneQuery(cmd);
        }
        public static void TK_CD_DELETE(String iFK_TaiKhoanID, String iFK_MaCD)
        {
            OleDbCommand cmd = new OleDbCommand("TK_CD_DELETE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_TaiKhoanID", iFK_TaiKhoanID);
            cmd.Parameters.AddWithValue("@iFK_MaCD", iFK_MaCD);
            SQLDatabase.ExcuteNoneQuery(cmd);
        }
        public static DataTable ThongTin_TK_CD()
        {
            OleDbCommand cmd = new OleDbCommand("TK_CD_DELETE");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable ThongTin_TKCD_by_TK(String iFK_TaiKhoanID)
        {
            OleDbCommand cmd = new OleDbCommand("ThongTin_TKCD_by_TK");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_TaiKhoanID ", iFK_TaiKhoanID);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable ThongTin_TKCD_by_CD(String iFK_MaCD)
        {
            OleDbCommand cmd = new OleDbCommand("ThongTin_TKCD_by_CD");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_MaCD", iFK_MaCD);
            return SQLDatabase.GetData(cmd);
        }
        /// <summary>
        /// Lấy thông tin TKCD by IDTaiKhhoan lấy Email
        /// </summary>
        /// <param name="iFK_TaiKhoanID"></param>
        /// <returns></returns>
        public static DataTable ThongTin_TKCD_By_CD_Set_Email(String iFK_TaiKhoanID)
        {
            OleDbCommand cmd = new OleDbCommand("ThongTin_TKCD_By_CD_Set_Email");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_TaiKhoanID", iFK_TaiKhoanID);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable TK_CD_SELCT_MA(String iFK_TaiKhoanID)
        {
            OleDbCommand cmd = new OleDbCommand("TK_CD_SELCT_MA");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_TaiKhoanID", iFK_TaiKhoanID);
            return SQLDatabase.GetData(cmd);
        }
      
             public static DataTable TK_CD_ID(String iFK_TaiKhoanID)
        {
            OleDbCommand cmd = new OleDbCommand("TK_CD_ID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_TaiKhoanID", iFK_TaiKhoanID);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable Tim_Email1(String iPK_LettersID)
        {
            OleDbCommand cmd = new OleDbCommand(" Tim_Email1");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_LettersID", iPK_LettersID);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable TAIKHOAN_BY_CHUDE(String iFK_MaCD)
        {
            OleDbCommand cmd = new OleDbCommand("TAIKHOAN_BY_CHUDE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iFK_MaCD", iFK_MaCD);
            return SQLDatabase.GetData(cmd);
        }

    }
}