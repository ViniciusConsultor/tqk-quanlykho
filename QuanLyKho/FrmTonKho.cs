using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;
using DTO;

namespace QuanLyKho
{
    public partial class FrmTonKho : DevComponents.DotNetBar.Office2007Form
    {
        public FrmTonKho()
        {
            InitializeComponent();
        }

        MatHangBLL bllMatHang = new MatHangBLL();
        NhapKhoBLL bllNhapKho = new NhapKhoBLL();
        XuatKhoBLL bllXuatKho = new XuatKhoBLL();

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (dgvResults.Rows.Count > 0)
                dgvResults.Rows.Clear();
            DataTable dtMatHang = new DataTable();
            DateTime dateNgayBD = dtNgayBD.Value;
            DateTime dateNgayKT = dtNgayKT.Value;
            dtMatHang = bllMatHang.GetAllMatHang();
            // Add dòng
            for (int i = 0; i < dtMatHang.Rows.Count; i++)
            {
                dgvResults.Rows.Add();
            }
            for (int i = 0; i < dtMatHang.Rows.Count; i++)
            {
                //Lấy dữ liệu
                string strMaMatHang = dtMatHang.Rows[i]["MAMATHANG"].ToString();
                string strTenMatHang = dtMatHang.Rows[i]["TENMATHANG"].ToString();
                string strDonViTinh = dtMatHang.Rows[i]["DONVITINH"].ToString();
                int intSLTon = int.Parse(dtMatHang.Rows[i]["TONDAU"].ToString());
                int intSLNhap = 0;
                DataTable dtTongNhap = bllNhapKho.TimKiemTongNhap(dateNgayBD, dateNgayKT, strMaMatHang);
                if(dtTongNhap.Rows.Count > 0)
                    intSLNhap = int.Parse(dtTongNhap.Rows[0]["SOLUONGNHAP"].ToString());
                int intSLXuat = 0;
                DataTable dtTongXuat = bllXuatKho.TimKiemTongXuat(dateNgayBD, dateNgayKT, strMaMatHang);
                if(dtTongXuat.Rows.Count > 0)
                    intSLXuat = int.Parse(dtTongXuat.Rows[0]["SOLUONGXUAT"].ToString());
                int intTon = intSLTon + intSLNhap - intSLXuat;
                // Đưa vào lưới
                dgvResults.Rows[i].Cells[0].Value = i + 1;
                dgvResults.Rows[i].Cells[1].Value = strMaMatHang;
                dgvResults.Rows[i].Cells[2].Value = strTenMatHang;
                dgvResults.Rows[i].Cells[3].Value = strDonViTinh;
                dgvResults.Rows[i].Cells[4].Value = intSLTon;
                dgvResults.Rows[i].Cells[6].Value = intSLNhap;
                dgvResults.Rows[i].Cells[8].Value = intSLXuat;
                dgvResults.Rows[i].Cells[10].Value = intTon;
            }
            btnIn.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvResults.Rows.Count > 0)
            {
                dgvResults.Rows.Clear();
            }
            btnIn.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook             
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Tồn Kho";
            // Tạo phần đầu nếu muốn      
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = "BÁO CÁO NHẬP XUẤT TỒN HÀNG HÓA THEO THÁNG NĂM";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range ngay = oSheet.get_Range("A2", "J2");
            ngay.MergeCells = true;
            ngay.Value2 = "Từ ngày " + dtNgayBD.Value.ToShortDateString() + " đến ngày " + dtNgayKT.Value.ToShortDateString();
            ngay.Font.Bold = true;
            ngay.Font.Name = "Tahoma";
            ngay.Font.Size = "18";
            ngay.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột        
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Số TT"; 
            cl1.ColumnWidth = 8.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã Mặt Hàng";
            cl2.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tên Mặt Hàng"; 
            cl3.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Đơn Vị Tính";
            cl4.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tồn Đầu";
            cl5.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Thành Tiền";
            cl6.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Số Lượng Nhập";
            cl7.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Thành Tiền";
            cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Số Lượng Xuất";
            cl9.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Thành Tiền";
            cl10.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Còn Lại";
            cl11.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");
            cl12.Value2 = "Thành Tiền";
            cl12.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "L3");
            rowHead.Font.Bold = true;
            // Kẻ viền         
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền         
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,     
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.   
            object[,] arr = new object[dgvResults.Rows.Count, dgvResults.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng       
            for (int r = 0; r < dgvResults.Rows.Count; r++)
            {
                DataGridViewRow dr = dgvResults.Rows[r];
                for (int c = 0; c < dgvResults.Columns.Count; c++)
                {
                    arr[r, c] = dr.Cells[c].Value;
                }
            }
            //Thiết lập vùng điền dữ liệu    
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dgvResults.Rows.Count - 1;
            int columnEnd = dgvResults.Columns.Count;
            // Ô bắt đầu điền dữ liệu       
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu  
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu     
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập      
            range.Value2 = arr;
            // Kẻ viền       
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT     
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}