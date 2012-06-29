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
    public partial class FrmCongNoThu : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCongNoThu()
        {
            InitializeComponent();
        }

        KhachHangBLL bllKhachHang = new KhachHangBLL();
        MatHangBLL bllMatHang = new MatHangBLL();
        XuatKhoBLL bllXuatKho = new XuatKhoBLL();
        PhieuThuBLL bllPhieuThu = new PhieuThuBLL();

        private void FrmTCXuatHang_Load(object sender, EventArgs e)
        {
            //cmbMatHang.DataSource = bllMatHang.GetAllMatHang();
            //cmbMatHang.DisplayMember = "TENMATHANG";
            //cmbMatHang.ValueMember = "MAMATHANG";

            cmbKhachHang.DataSource = bllKhachHang.GetAllKhachHang();
            cmbKhachHang.DisplayMember = "TENKHACHHANG";
            cmbKhachHang.ValueMember = "MAKHACHHANG";
        }

        private void cbxMatHang_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbxMatHang.Checked == true)
            //    cmbMatHang.Enabled = true;
            //else
            //    cmbMatHang.Enabled = false;
        }

        private void cbxNhaCC_CheckedChanged(object sender, EventArgs e)
        {
             if (cbxNhaCC.Checked == true)
                cmbKhachHang.Enabled = true;
            else
                cmbKhachHang.Enabled = false;
        }

        private void dgvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (dgvMatHang.Rows.Count > 0)
                dgvMatHang.Rows.Clear();
            DateTime dtNgayBD = dtTuNgay.Value;
            DateTime dtNgayKT = dtDenNgay.Value;
            string strKhachHang = "0";
            if (cbxNhaCC.Checked == true)
                strKhachHang = cmbKhachHang.SelectedValue.ToString();
            DataTable dtXuatKho = new DataTable();
            dtXuatKho = bllXuatKho.TimKiem(dtNgayBD, dtNgayKT, strKhachHang);
            for (int i = 0; i < dtXuatKho.Rows.Count; i++)
            {
                dgvMatHang.Rows.Add();
                string strIDKhachHang = dtXuatKho.Rows[i]["MAKHACHHANG"].ToString();
                KhachHangDTO dtoKhachHang = new KhachHangDTO();
                dtoKhachHang = bllKhachHang.GetKhachHangByID(strIDKhachHang);
                dgvMatHang.Rows[i].Cells[0].Value = dtoKhachHang.TenKH;
                dgvMatHang.Rows[i].Cells[0].Tag = strIDKhachHang;
                // Nếu dư nợ - thì cần phải thanh toán
                // Nếu dư nợ + thì đã thanh toán
                if (dtoKhachHang.DuNo < 0)
                    dgvMatHang.Rows[i].Cells[1].Value = Math.Abs(dtoKhachHang.DuNo);
                else if (dtoKhachHang.DuNo > 0)
                    dgvMatHang.Rows[i].Cells[2].Value = dtoKhachHang.DuNo;
                else
                {
                    dgvMatHang.Rows[i].Cells[1].Value = 0;
                    dgvMatHang.Rows[i].Cells[2].Value = 0;
                }
                // Phải thanh toán
                double dbPhaiThanhToan = double.Parse(dtXuatKho.Rows[i]["THANHTIEN"].ToString());
                dgvMatHang.Rows[i].Cells[3].Value = dbPhaiThanhToan;
                // Đã thanh toán
                double dbDaThanhToan = 0;
                DataTable dtPhieuThu = new DataTable();
                dtPhieuThu = bllPhieuThu.TimKiem(strIDKhachHang, dtNgayBD, dtNgayKT);
                if (dtPhieuThu.Rows.Count > 0)
                {
                    dbDaThanhToan = double.Parse(dtPhieuThu.Rows[0]["THANHTIEN"].ToString());
                    dgvMatHang.Rows[i].Cells[4].Value = dbDaThanhToan;
                }
                // Tính dư nợ cuối kỳ và đầu kỳ
                double dbDuNo = dtoKhachHang.DuNo - (dbPhaiThanhToan - dbDaThanhToan);
                if(dbDuNo < 0)
                    dgvMatHang.Rows[i].Cells[5].Value = Math.Abs(dbDuNo);
                else
                    dgvMatHang.Rows[i].Cells[6].Value = dbDuNo;
                btnChiTiet.Enabled = true;
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmCTCongNoThu frm = new FrmCTCongNoThu();
            int intSelect = dgvMatHang.SelectedRows[0].Index;
            string strTenKhachHang = dgvMatHang.Rows[intSelect].Cells[0].Value.ToString();
            string strIDKhachHang = dgvMatHang.Rows[intSelect].Cells[0].Tag.ToString();
            frm.lbDenNgay.Text = dtDenNgay.Value.ToShortDateString();
            frm.lbTuNgay.Text = dtTuNgay.Value.ToShortDateString();
            frm.lbKhachHang.Text = strTenKhachHang;
            frm.lbKhachHang.Tag = strIDKhachHang;
            frm.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string strNgay = "Từ ngày " + dtTuNgay.Value.ToShortDateString() + " đến ngày " + dtDenNgay.Value.ToShortDateString();
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;             //Tạo mới một Excel WorkBook             
            oExcel.Visible = true;
            //oExcel.DisplayAlerts = false;
            //oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            //oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing)); 
            oBook = oExcel.Workbooks.Add(System.Reflection.Missing.Value);
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Công Nợ";

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A3", "E3");
            head.MergeCells = true;
            head.Value2 = "BÁO CÁO TỔNG HỢP CÔNG NỢ PHẢI THU CỦA KHÁCH HÀNG";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range thoiGian = oSheet.get_Range("A4", "E4");
            thoiGian.MergeCells = true;
            thoiGian.Value2 = strNgay;
            thoiGian.Font.Bold = true;
            thoiGian.Font.Name = "Tahoma";
            thoiGian.Font.Size = "14";
            thoiGian.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

               // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range khachHang = oSheet.get_Range("A6", "A7");
            khachHang.MergeCells = true;
            khachHang.Value2 = "Khách hàng";
            khachHang.ColumnWidth = 50;
            khachHang.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range dauKy = oSheet.get_Range("B6", "C6");
            dauKy.MergeCells = true;
            dauKy.Value2 = "Dư đầu kỳ";
            dauKy.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range phaiThanhToanDK = oSheet.get_Range("B7", "B7");
            phaiThanhToanDK.Value2 = "Phải thanh toán";
            phaiThanhToanDK.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range daThanhToanDK = oSheet.get_Range("C7", "C7");
            daThanhToanDK.Value2 = "Đã thanh toán";
            daThanhToanDK.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range trongKy = oSheet.get_Range("D6", "E6");
            trongKy.MergeCells = true;
            trongKy.Value2 = "Phát sinh trong kỳ";
            trongKy.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range phaiThanhToanTK = oSheet.get_Range("D7", "D7");
            phaiThanhToanTK.Value2 = "Phải thanh toán";
            phaiThanhToanTK.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range daThanhToanTK = oSheet.get_Range("E7", "E7");
            daThanhToanTK.Value2 = "Đã thanh toán";
            daThanhToanTK.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cuoiKy = oSheet.get_Range("F6", "G6");
            cuoiKy.MergeCells = true;
            cuoiKy.Value2 = "Phát sinh trong kỳ";
            cuoiKy.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range phaiThanhToanCK = oSheet.get_Range("F7", "F7");
            phaiThanhToanCK.Value2 = "Phải thanh toán";
            phaiThanhToanCK.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range daThanhToanCK = oSheet.get_Range("G7", "G7");
            daThanhToanCK.Value2 = "Đã thanh toán";
            daThanhToanCK.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A6", "G7");
            rowHead.Font.Bold = true;
            // Kẻ viền           
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền            
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Đưa dữ liệu trên datagridview vào mảng
            object[,] objCells = new object[dgvMatHang.RowCount - 1, dgvMatHang.ColumnCount];
            for (int i = 0; i < dgvMatHang.RowCount - 1; i++)
            {
                DataGridViewRow row = dgvMatHang.Rows[i];
                for (int j = 0; j < dgvMatHang.ColumnCount; j++)
                {
                    objCells[i, j] = row.Cells[j].Value;
                }
            }
            //Thiết lập vùng cần đưa dữ liệu vào
            int rowStart = 8;
            int columnStart = 1;
            int rowEnd = 8 + dgvMatHang.RowCount - 2;
            int columnEnd = dgvMatHang.ColumnCount;
            // Ô bắt đầu điền dữ liệu            
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu            
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu            
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập   
            range.Value2 = objCells;
            // Kẻ viền        
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT       
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //oExcel.Quit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}