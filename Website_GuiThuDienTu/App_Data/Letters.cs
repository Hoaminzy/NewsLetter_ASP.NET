using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using Website_GuiThuDienTu.App_Data;

namespace Website_GuiThuDienTu.App_Data
{
    public class Letters
    {
        public static void Letter_Insert(String sSubject, String sBody, String dNgayTao, String iPK_AdminID, String iPK_ChuDeID)
        {
            OleDbCommand cmd = new OleDbCommand("Letter_Insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sSubject", sSubject);
            cmd.Parameters.AddWithValue("@sBody", sBody);
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            cmd.Parameters.AddWithValue("@iPK_ChuDeID", iPK_ChuDeID);
            cmd.Parameters.AddWithValue("@dNgayTao", dNgayTao);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }
        public static void Letter_Update( String iPK_LetterID, String sSubject, String sBody, String dNgayTao, String iPK_AdminID, String iPK_ChuDeID)
        {
            OleDbCommand cmd = new OleDbCommand("Letter_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ iPK_LetterID", iPK_LetterID);
            cmd.Parameters.AddWithValue("@sSubject", sSubject);
            cmd.Parameters.AddWithValue("@sBody", sBody);
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            cmd.Parameters.AddWithValue("@iPK_ChuDeID", iPK_ChuDeID);
            cmd.Parameters.AddWithValue("@dNgayTao", dNgayTao);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }
        
               public static void Letter_Delete(String iPK_LetterID)
        {
            OleDbCommand cmd = new OleDbCommand("Letter_Delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_LetterID", iPK_LetterID);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }

        public static DataTable ThongTin_Letter()
        {
            OleDbCommand cmd = new OleDbCommand("ThongTin_Letter");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);

        }
        public static DataTable ThongTin_Letter_by_ID(String iPK_LetterID)
        {
            OleDbCommand cmd = new OleDbCommand("ThongTin_Letter_by_ID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_LetterID", iPK_LetterID);
            return SQLDatabase.GetData(cmd);

        }
        public static DataTable ThongTin_Letter_by_Admin(String iPK_AdminID)
        {
            OleDbCommand cmd = new OleDbCommand("ThongTin_Letter_by_Admin");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_AdminID", iPK_AdminID);
            return SQLDatabase.GetData(cmd);

        }
        public static DataTable ThongTin_Letter_by_ChuDe(String iPK_ChuDeID)
        {
            OleDbCommand cmd = new OleDbCommand("ThongTin_Letter_by_ChuDe");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_ChuDeID", iPK_ChuDeID);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable Tim_Email1(String iPK_LettersID)
        {
            OleDbCommand cmd = new OleDbCommand("Tim_Email1");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_LettersID", iPK_LettersID);
            return SQLDatabase.GetData(cmd);
        }
    }
    }