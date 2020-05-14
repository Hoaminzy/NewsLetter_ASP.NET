using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Website_GuiThuDienTu.data
{
    public class admin_subject
    {
        public static DataTable HienChuDe_ByUserID(int iPK_AdminID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            conn.Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                cmd.Connection = conn;
                cmd.CommandText = "HienChuDe_ByUserID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@iPK_AdminID", iPK_AdminID));
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                conn.Close();
                return table;
            }
           
        }

        public static DataTable HienChuDe_ChuaDangKy_ByUserID(int iPK_AdminID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            conn.Open();
            using (SqlCommand command = new SqlCommand())
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Connection = conn;
                command.CommandText = "HienChuDe_ChuaDangKy_ByUserID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@iPK_AdminID", iPK_AdminID));
                adapter.SelectCommand = command;
                adapter.Fill(table);
                conn.Close();
                return table;
            }
           
        }


    }
}