using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using Website_GuiThuDienTu.App_Data;

namespace Website_GuiThuDienTu.App_Data
{
    public class ChuDe
    {
        public static void ChuDe_Insert(String sTenCD, String sCondition)
        {
            ///<summary>
            /// Them ChuDe
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("ChuDe_Insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sTenCD", sTenCD);
            cmd.Parameters.AddWithValue("@sCondition", sCondition);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }
        public static void ChuDe_Delete(String iPK_MaCD )
        {
            ///<summary>
            /// Xoa ChuDE
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("ChuDe_Delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_MaCD", iPK_MaCD);
            SQLDatabase.ExcuteNoneQuery(cmd);
        }
        public static void ChuDe_Update(String iPK_MaCD ,String sTenCD, String sCondition)
        {
            ///<summary>
            /// Them ChuDe
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("ChuDe_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_MaCD ", iPK_MaCD);
            cmd.Parameters.AddWithValue("@sTenCD", sTenCD);
            cmd.Parameters.AddWithValue("@sCondition", sCondition);
            SQLDatabase.ExcuteNoneQuery(cmd);

        }
        public static DataTable ThongTin_ChuDe()
        {
            ///<summary>
            /// Lay Thong Tin Chu De Thao Emails va Mat Khau
            /// </summary>
            OleDbCommand cmd = new OleDbCommand(" ThongTin_ChuDe");
            cmd.CommandType = CommandType.StoredProcedure;          
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable ThongTin_ChuDe_by_ID(String iPK_MaCD)
        {
            ///<summary>
            /// Lay Chu De Thao Emails va Mat Khau
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("ThongTin_ChuDe_by_ID");
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@iPK_MaCD ", iPK_MaCD);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable HienChiTietChuDe(int iPK_MaCD)
        {
            ///<summary>
            /// Lay Chu De Thao Emails va Mat Khau
            /// </summary>
            OleDbCommand cmd = new OleDbCommand("HienChiTietChuDe");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iPK_MaCD", iPK_MaCD);
            return SQLDatabase.GetData(cmd);
        }

    }
}