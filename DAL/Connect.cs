using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        private static Connect _instance;
        public static Connect Instance
        {
            get
            {
                if( _instance == null)
                {
                    _instance = new Connect();
                }
                return _instance;
            }
        }
        //Khai báo kết nối db
        private string connectionString = @"Data Source=(local);Initial Catalog=QLHD;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(@"Data Source=(local);Initial Catalog=QLHD;Integrated Security=True");
        //mở kết nối
        public void openConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //đóng kết nối
        public void cloesConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        //return chuỗi kết nối
        public SqlConnection GetSqlConnection()
        {
            //openConnection();
            SqlConnection con=new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        SqlCommand cmd;
        public int ThucThiCL(string caulenh)//Thực thi câu lệnh đơn dữ liệu
        {
            openConnection();
            cmd = new SqlCommand(caulenh, connection);
            int i= cmd.ExecuteNonQuery();// trả về số lượng dòng đã được thực thi
            cloesConnection();
            return i;
        }
        //kiểm tra câu lệnh truyền vào thực thi đúng hay không?
        public bool Excute(string s)
        {
            try
            {
                openConnection();
                cmd = new SqlCommand(s, connection);
                cmd.ExecuteNonQuery();
                cloesConnection();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        
        //kiểm tra trùng mã trước khi thêm xuống?
        public int ExcuteNonQuery(string s, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = s;
                cmd.Parameters.AddRange(para);
                adap.InsertCommand = cmd;
                return cmd.ExecuteNonQuery();// nhiều dòng
            }
            catch { }
            return -1;
        }
        //Đọc dữ liệu 
        public SqlCommand ExcuteReader(string s, SqlParameter[] para)
        {
            SqlCommand cmd=new SqlCommand();
            try
            {
                cmd.Connection = GetSqlConnection();
                cmd.CommandText = s;
                cmd.Parameters.AddRange(para);
                return cmd;
            }catch(Exception ex) { }
            return null;
        }
        //trả về số dòng của bảng
        public int TongBanGhi(string strSelect)
        {
            DataTable dtTong = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(strSelect, connection);
            adap.Fill(dtTong);
            int sbg = dtTong.Rows.Count;
            return sbg;

        }
        //trả về kiểu datatable cho bảng
        public DataTable get_DaTaTable(string clSelect)
        {
            SqlDataAdapter adap = new SqlDataAdapter(clSelect, connection);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataSet getdataset(string clSelect, string name)//trả về kiểu object cho bảng 
        {
            adap = new SqlDataAdapter(clSelect, connection);
            ds = new DataSet();
            adap.Fill(ds, name);
            return ds;
        }
        DataSet ds;
        SqlDataAdapter adap;
        public object getdata(string clSelect, string name)//trả về kiểu object cho bảng 
        {
            adap = new SqlDataAdapter(clSelect, connection);
            ds = new DataSet();
            adap.Fill(ds, name);
            return ds.Tables[name];
        }
/*        //nhận datatable
        public void SetDatatable(DataSet dt)
        {
            ds = new DataSet();
            ds = dt;
        }*/
        //nhận datatable
        public DataTable GetTable(string name)
        {
            return ds.Tables[name];
        }
        //nhận dataset
        public DataSet dataset()
        {
            return ds;
        }
        //nhận Adapter
        public SqlDataAdapter Adapter()
        {
            return adap;
        }
/*        //nhận Adapter từ From
        public SqlDataAdapter SetAdaper(string sql)
        {
            adap =new SqlDataAdapter(sql,connection);
            return adap;
        }*/
        //insert
        public void Insert(string s, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = s;
                cmd.Parameters.AddRange(para);
                adap.InsertCommand = cmd;
                cmd.ExecuteNonQuery();// nhiều dòng
            }
            catch { }
        }
        //update
        public void Update(string s, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = s;
                cmd.Parameters.AddRange(para);
                adap.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();// nhiều dòng
            }
            catch { }
        }
        //delete
        public void Delete(string s, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = s;
                cmd.Parameters.AddRange(para);
                adap.DeleteCommand = cmd;
                cmd.ExecuteNonQuery();//nhiều dòng
            }
            catch { }
        }
    }
}
