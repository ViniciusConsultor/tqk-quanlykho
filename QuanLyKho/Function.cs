using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using System.Data;
using DevComponents.DotNetBar.Controls;

namespace QuanLyKho
{
    public class Function
    {
        public static void CloseForm()
        {
            Variable.stiSelected.Close();
        }

        public static void LoadDataGirdView(DataGridViewX dgv, DataTable dt)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dt;
        }
    }
}
