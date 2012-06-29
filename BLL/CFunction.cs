using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DAL;
namespace BLL
{
    public class CFunction
    {
        DataProvider dp = new DataProvider();
        /// <summary>
        /// Tạo id - khóa chính
        /// </summary>
        /// <param name="strFormat">Chuỗi định dạng</param>
        /// <param name="pTable">Bảng muốn tạo khóa chính</param>
        /// <returns>Khóa chính</returns>
        public string CreateId(string strFormat, string pTable)
        {
            string id;
            DataProvider dp = new DataProvider();
            DataTable dt = new DataTable();
            dt = GetAll(pTable);
            int rowCount = dt.Rows.Count + 1;
            string row;
            if (rowCount < 10)
            {
                row = "000" + rowCount.ToString();
            }
            else if (rowCount >= 10 && rowCount < 100)
            {
                row = "00" + rowCount.ToString();
            }
            else if (rowCount >= 100 && rowCount < 1000)
            {
                row = "0" + rowCount.ToString();
            }
            else
                row = rowCount.ToString();
            id = strFormat.ToString() + row.ToString();
            return id;
        }
        /// <summary>
        /// Gắn cột Số TT vào tập dữ liệu
        /// </summary>
        /// <param name="SourceTable">Tập dữ liệu muốn gắn cột số tt</param>
        /// <returns>Tập dữ liệu đã được gắn cột STT</returns>
        public DataTable AutoNumberedTable(DataTable SourceTable)
        {

            DataTable ResultTable = new DataTable();
            DataColumn AutoNumberColumn = new DataColumn();
            AutoNumberColumn.ColumnName = "Số TT";
            AutoNumberColumn.DataType = typeof(int);
            AutoNumberColumn.AutoIncrement = true;
            AutoNumberColumn.AutoIncrementSeed = 1;
            AutoNumberColumn.AutoIncrementStep = 1;
            ResultTable.Columns.Add(AutoNumberColumn);
            ResultTable.Merge(SourceTable);
            return ResultTable;
        }
        /// <summary>
        /// Lấy tất cả dữ liệu của bảng
        /// </summary>
        /// <param name="pTable">Bảng cần lấy dữ liệu</param>
        /// <returns>Dữ liệu bảng cần lấy</returns>
        public DataTable GetAll(string pTable)
        {
            string strQuery = "Select * From " + pTable;
            return dp.ExecuteQuery(strQuery);
        }
        /// <summary>
        /// Lấy giá trị của bảng dựa vào ID
        /// </summary>
        /// <param name="pTable">Tên bảng cần lấy</param>
        /// <param name="pColum">Cột chứa giá trị ID</param>
        /// <param name="pID">Cần lấy theo ID nào</param>
        /// <returns></returns>
        public DataTable GetValueByID(string pTable, string pColum, string pID)
        {
            string strQuery = "Select * From " + pTable;
            strQuery += " Where " + pColum + " = '" + pID + "'";
            return dp.ExecuteQuery(strQuery);
        }

        

    }
}
