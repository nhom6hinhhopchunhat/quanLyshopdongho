using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLShopDongHo
{
    class LOPDUNGCHUNG
    {
        SqlConnection con;
       public LOPDUNGCHUNG()
        {
            con = new SqlConnection();
            con.ConnectionString = 
                @"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename = ""E:\HỌC TẬP\winform\QLShopDongHo\quanLyshopdongho\QLShopDongHo\QUANLYDONGHO.mdf""; Integrated Security = True";

        }
        public void moketnoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void dongketnoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable getDataTable(String sql)
        {
            moketnoi();
            SqlDataAdapter adp = new SqlDataAdapter(sql,con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            dongketnoi();
            return tb;
        }
        public void getDataSet(ref DataSet ds, string sql)
        {
            DataTable tb = this.getDataTable(sql);
            ds.Tables.Add(tb);
        }
        public int excuteSQL(String sql)
        {
            moketnoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            int k = (int)cmd.ExecuteNonQuery();
            dongketnoi();
            return k;

        }
    }
}
