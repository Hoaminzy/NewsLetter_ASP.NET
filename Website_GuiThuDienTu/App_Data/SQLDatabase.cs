using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Website_GuiThuDienTu.App_Data
{
    public class SQLDatabase
    {
        private static string _connectionString = string.Empty;
        public static string ConnectionString
        {
            //Lấy chuỗi kết nối
            get
            {
                if (_connectionString.Equals(""))
                {
                    _connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
                }
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }
        public static OleDbConnection GetConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            return conn;
        }
        public static void ExcuteNoneQuery(OleDbCommand cmd)
        {
            //Thực hiện câu truy vấn k cần trả về kết quả
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                OleDbConnection conn = GetConnection();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable GetData(OleDbCommand cmd)
        {
            //Thực hiện câu truy vấn trả kề kết quả dưới dạng bảng

            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }

            }
            else
            {
                using (OleDbConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds.Tables[0];

                        }
                    }
                }
            }
        }
      
        public static DataSet GetData_OverDataSet(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            else
            {
                using(OleDbConnection conn = GetConnection()){
                    cmd.Connection = conn;
                    using(DataSet ds = new DataSet())
                    {
                        using(OleDbDataAdapter da = new OleDbDataAdapter())
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }
        }
            
    }