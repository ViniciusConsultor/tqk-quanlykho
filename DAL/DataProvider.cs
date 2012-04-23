using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DataProvider
    {
        private string _strConnect;

        protected string ConnectionString
        {
            get { return _strConnect; }
            set { _strConnect = value; }
        }

        protected SqlConnection con;
        protected SqlDataAdapter da = null;
        protected SqlCommand command;

        public DataProvider()
        {
            _strConnect = "server=.\\SQLEXPRESS;";
            _strConnect += "database=KHO_TQK;";
            _strConnect += "Trusted_Connection=True;";

        }
        /// <summary>
        /// Kết nối cơ sở dữ liệu
        /// </summary>
        public void Connect()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối được với Server\n" + ex.Message, "Lỗi chương trình");
            }
        }
        /// <summary>
        /// Đóng kết nối
        /// </summary>
        public void DisConnect()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thực thi câu truy vấn Select
        /// </summary>
        /// <param name="strQuery">Câu select</param>
        /// <returns>Số record thỏa câu truy vấn</returns>
        public DataTable ExecuteQuery(string strQuery)
        {
            Connect();
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(strQuery, con);
            da.Fill(ds);
            DisConnect();
            return ds.Tables[0];
        }
        /// <summary>
        /// Thực thi câu truy vấn Insert, Delete, Update
        /// </summary>
        /// <param name="strQuery">Câu Insert, Delete, Update</param>
        /// <returns>Nếu true: thành công, false: thất bại</returns>
        public bool ExecuteNonQuery(string strQuery)
        {
            Connect();
            command = new SqlCommand(strQuery, con);
            int intValue = command.ExecuteNonQuery();
            if (intValue < 1)
            {
                DisConnect();
                return false;
            }
            else
            {
                DisConnect();
                return true;
            }
        }
        /// <summary>
        /// Thực thi câu truy vấn và trả về 1 giá trị vô hướng
        /// </summary>
        /// <param name="strQuery">Câu select có giá trị cần trả về</param>
        /// <returns>Giá trị select</returns>
        public object ExecuteScalar(string strQuery)
        {
            Connect();
            command = new SqlCommand(strQuery, con);
            object obj = command.ExecuteScalar();
            DisConnect();
            return obj;
        }


        //internal bool ExecuteQuery()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
