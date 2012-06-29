using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using BLL;

namespace QuanLyKho
{
    public partial class FrmCTCongNoChi : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCTCongNoChi()
        {
            InitializeComponent();
        }

        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        PhieuChiBLL bllPhieuChi = new PhieuChiBLL();
        NhapKhoBLL bllNhapKho = new NhapKhoBLL();

        private void FrmCTCongNoChi_Load(object sender, EventArgs e)
        {
            string strIDKhachHang = lbNhaCungCap.Tag.ToString();
            NhaCungCapDTO dtoNhaCungCap = new NhaCungCapDTO();
            dtoNhaCungCap = bllNhaCungCap.GetNhaCungCapByID(strIDKhachHang);
            DateTime dtBatDau = DateTime.Parse(lbTuNgay.Text);
            DateTime dtKetThuc = DateTime.Parse(lbDenNgay.Text);
            DataTable dtPhieuChi = new DataTable();
            dtPhieuChi = bllPhieuChi.TimKiemChiTiet(strIDKhachHang, dtBatDau, dtKetThuc);
            DataTable dtNhapKho = new DataTable();
            dtNhapKho = bllNhapKho.TimKiemCTDuNo(dtBatDau, dtKetThuc, strIDKhachHang);
            int intRowCount = dtNhapKho.Rows.Count + dtPhieuChi.Rows.Count + 3;
            int intRun = 0;
            for (int i = 0; i < intRowCount; i++)
            {
                dgvChiTiet.Rows.Add();
            }
            // Lấy dư nợ khách hàng
            dgvChiTiet.Rows[0].Cells[2].Value = "Dư nợ của khách hàng";
            // Nếu dư nợ - thì cần phải thanh toán
            // Nếu dư nợ + thì đã thanh toán
            if (dtoNhaCungCap.DuNo < 0)
                dgvChiTiet.Rows[0].Cells[3].Value = Math.Abs(dtoNhaCungCap.DuNo);
            else if (dtoNhaCungCap.DuNo > 0)
                dgvChiTiet.Rows[0].Cells[4].Value = dtoNhaCungCap.DuNo;
            // Lấy chi tiết phiếu xuất
            double dbTongTienXuat = 0;
            for (int i = 0; i < dtNhapKho.Rows.Count; i++)
            {
                intRun++;
                dgvChiTiet.Rows[intRun].Cells[0].Value = dtNhapKho.Rows[i]["NGAYNHAP"].ToString();
                dgvChiTiet.Rows[intRun].Cells[1].Value = dtNhapKho.Rows[i]["MANHAPKHO"].ToString();
                dgvChiTiet.Rows[intRun].Cells[2].Value = "Tiền cần thanh toán";
                double dbTienXuat = double.Parse(dtNhapKho.Rows[i]["THANHTIEN"].ToString());
                dbTongTienXuat += dbTienXuat;
                dgvChiTiet.Rows[intRun].Cells[3].Value = dtNhapKho.Rows[i]["THANHTIEN"].ToString();
            }
            intRun++;
            dgvChiTiet.Rows[intRun].Cells[2].Value = "Tổng tiền cần thanh toán: ";
            dgvChiTiet.Rows[intRun].Cells[3].Value = dbTongTienXuat;
            // Lấy chi tiết phiếu thu
            double dbTongTienThu = 0;
            for (int i = 0; i < dtPhieuChi.Rows.Count; i++)
            {
                intRun++;
                dgvChiTiet.Rows[intRun].Cells[0].Value = dtPhieuChi.Rows[i]["NGAYLAP"].ToString();
                dgvChiTiet.Rows[intRun].Cells[1].Value = dtPhieuChi.Rows[i]["MAPHIEUCHI"].ToString();
                dgvChiTiet.Rows[intRun].Cells[2].Value = "Đã thanh toán";
                double dbThuTien = double.Parse(dtPhieuChi.Rows[i]["SOTIEN"].ToString());
                dbTongTienThu += dbThuTien;
                dgvChiTiet.Rows[intRun].Cells[4].Value = dtPhieuChi.Rows[i]["SOTIEN"].ToString();
            }
            intRun++;
            dgvChiTiet.Rows[intRun].Cells[2].Value = "Tổng tiền đã thanh toán: ";
            dgvChiTiet.Rows[intRun].Cells[4].Value = dbTongTienThu;
            intRun++;
            dgvChiTiet.Rows[intRun].Cells[2].Value = "Còn lại: ";
            double dbDuNo = dbTongTienThu - dbTongTienXuat + dtoNhaCungCap.DuNo;
            if (dbDuNo < 0)
                dgvChiTiet.Rows[intRun].Cells[3].Value = Math.Abs(dbDuNo);
            else if (dbDuNo > 0)
                dgvChiTiet.Rows[intRun].Cells[4].Value = dbDuNo;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string strNgay = "Từ ngày " + lbTuNgay.Text + " đến ngày " + lbDenNgay.Text;
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
            head.Value2 = "	BÁO CÁO CHI TIẾT CÔNG NỢ PHẢI TRẢ NHÀ CUNG CẤP"; 
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

            Microsoft.Office.Interop.Excel.Range nhaCungCap = oSheet.get_Range("A5", "E5");
            nhaCungCap.MergeCells = true;
            nhaCungCap.Value2 = "Tên nhà cung cấp: " + lbNhaCungCap.Text;
            nhaCungCap.Font.Bold = true;
            nhaCungCap.Font.Name = "Tahoma";
            nhaCungCap.Font.Size = "14";
            nhaCungCap.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range chungTu = oSheet.get_Range("A7", "B7");
            chungTu.MergeCells = true;
            chungTu.Value2 = "Chứng Từ";
            chungTu.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            
            Microsoft.Office.Interop.Excel.Range Ngay = oSheet.get_Range("A8", "A8");
            Ngay.Value2 = "Ngày";
            Ngay.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range soChungTu = oSheet.get_Range("B8", "B8");
            soChungTu.Value2 = "Số Chứng Từ";
            soChungTu.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range dienGiai = oSheet.get_Range("C7", "C8");
            dienGiai.MergeCells = true;
            dienGiai.Value2 = "Diễn Giải";
            dienGiai.ColumnWidth = 25.0;
            dienGiai.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range duDauKy = oSheet.get_Range("D7", "E7");
            duDauKy.MergeCells = true;
            duDauKy.Value2 = "Dư Đầu Kỳ";

            Microsoft.Office.Interop.Excel.Range phaiThanhToan = oSheet.get_Range("D8", "D8");
            phaiThanhToan.Value2 = "Phải Thanh Toán";
            phaiThanhToan.ColumnWidth = 20.0;
            phaiThanhToan.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range daThanhToan = oSheet.get_Range("E8", "E8");
            daThanhToan.Value2 = "Đã Thanh Toán";
            daThanhToan.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A7", "E8");
            rowHead.Font.Bold = true; 
            // Kẻ viền           
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;            
            // Thiết lập màu nền            
            rowHead.Interior.ColorIndex = 15;            
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Đưa dữ liệu trên datagridview vào mảng
            object[,] objCells = new object[dgvChiTiet.RowCount, dgvChiTiet.ColumnCount];
            for (int i = 0; i < dgvChiTiet.RowCount; i++)
            {
                DataGridViewRow row = dgvChiTiet.Rows[i];
                for (int j = 0; j < dgvChiTiet.ColumnCount; j++)
                { 
                    objCells[i, j] = row.Cells[j].Value;
                }
            }
            //Thiết lập vùng cần đưa dữ liệu vào
            int rowStart = 9;
            int columnStart = 1;
            int rowEnd = 9 + dgvChiTiet.RowCount - 1;
            int columnEnd = dgvChiTiet.ColumnCount;
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
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1,c3 );     
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //oExcel.Quit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}