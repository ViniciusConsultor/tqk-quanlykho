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
    public partial class FrmXuatKho : DevComponents.DotNetBar.Office2007Form
    {
        public FrmXuatKho()
        {
            InitializeComponent();
        }

        CFunction cf = new CFunction();
        KhachHangBLL bllKhachHang = new KhachHangBLL();
        MatHangBLL bllMatHang = new MatHangBLL();
        DonViTinhBLL bllDonVITinh = new DonViTinhBLL();
        XuatKhoBLL bllXuatKho = new XuatKhoBLL();
        MucThueBLL bllMucThue = new MucThueBLL();
        CT_XuatKhoBLL bllCTXuatKho = new CT_XuatKhoBLL();

        private void InitForm()
        {

            try
            {
                string strMaXuatKho = cf.CreateId("MXK", "XUATKHO");
                txtMaPhieuXuat.Text = strMaXuatKho;
                string strMaNhanVien = Variable.strMaNhanVien;
                if (strMaNhanVien == "")
                    strMaNhanVien = "Chưa đăng nhập";
                txtMaNhanVien.Text = strMaNhanVien;

                dtNgayLap.Text = DateTime.Now.ToShortDateString();
                dtNgayNhap.Text = DateTime.Now.ToShortDateString();

                LoadCMBKhachHang();

                colMaMatHang.DataSource = bllMatHang.GetAllMatHang();
                colMaMatHang.DisplayMember = "MAMATHANG";
                colMaMatHang.ValueMember = "MAMATHANG";

                colTenMatHang.DataSource = bllMatHang.GetAllMatHang();
                colTenMatHang.DisplayMember = "TENMATHANG";
                colTenMatHang.ValueMember = "MAMATHANG";

                colDonViTinh.DataSource = bllDonVITinh.GetDonViTinh();
                colDonViTinh.DisplayMember = "DONVITINH";
                colDonViTinh.ValueMember = "MADONVITINH";

                cmbMucThue.DataSource = bllMucThue.GetMucThue();
                cmbMucThue.DisplayMember = "SOTHUE";
                cmbMucThue.ValueMember = "MATHUE";

            }
            catch { }

        }

        private void LoadCMBKhachHang()
        {
            cmbMaKhachHang.DataSource = bllKhachHang.GetAllKhachHang();
            cmbMaKhachHang.DisplayMember = "MAKHACHHANG";
            cmbMaKhachHang.ValueMember = "MAKHACHHANG";

            cmbTenKhachHang.DataSource = bllKhachHang.GetAllKhachHang();
            cmbTenKhachHang.DisplayMember = "TENKHACHHANG";
            cmbTenKhachHang.ValueMember = "MAKHACHHANG";
        }

        private void FrmXuatKho_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void dgvMatHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int intIndexColumn = dgvMatHang.CurrentCell.ColumnIndex;
                int intIndexRow = dgvMatHang.CurrentRow.Index;
                if (intIndexColumn == 0 || intIndexColumn == 1)
                {
                    string strMaMatHang = dgvMatHang.CurrentCell.Value.ToString();
                    MatHangDTO dtoMatHang = new MatHangDTO();
                    dtoMatHang = bllMatHang.GetMatHangByID(strMaMatHang);
                    dgvMatHang.Rows[intIndexRow].Cells["colMaMatHang"].Value = dtoMatHang.MaMH;
                    dgvMatHang.Rows[intIndexRow].Cells["colTenMatHang"].Value = dtoMatHang.TenMH;
                    dgvMatHang.Rows[intIndexRow].Cells["colDonViTinh"].Value = dtoMatHang.MaDonViTinh;
                    dgvMatHang.Rows[intIndexRow].Cells["colTon"].Value = dtoMatHang.SoLuongTon;
                }
                if (intIndexColumn == 2 || intIndexColumn == 4)
                {

                    int intSoLuong = int.Parse(dgvMatHang.Rows[intIndexRow].Cells["colSoLuong"].Value.ToString());
                    double dbDonGia = double.Parse(dgvMatHang.Rows[intIndexRow].Cells["colGia"].Value.ToString());
                    double dbThanhTien = (intSoLuong * dbDonGia);// + (intSoLuong * dbDonGia * (1.00 * intMucThue / 100));
                    dgvMatHang.Rows[intIndexRow].Cells["colThanhTien"].Value = dbThanhTien;
                    // Tính lại tổng số tiền và thuế
                    txtTongTien.Value = TinhTongTien();
                    double dbChietKhau = txtTongTien.Value * (double.Parse(cmbMucThue.Text) / 100);
                    txtTienSauThue.Text = (TinhTongTien() + dbChietKhau).ToString();
                }
            }
            catch { }
        }

        double TinhTongTien()
        {
            double dbTongTien = 0;
            int intCountRow = dgvMatHang.Rows.Count;
            if (intCountRow == 2)
                dbTongTien = double.Parse(dgvMatHang.Rows[0].Cells["colThanhTien"].Value.ToString());
            else
            {
                for (int i = 0; i < intCountRow - 1; i++)
                {
                    dbTongTien = dbTongTien + double.Parse(dgvMatHang.Rows[i].Cells["colThanhTien"].Value.ToString());
                }
            }
            return dbTongTien;
        }

        string CheckSoLuong()
        {
            string strError = "";
            string strMessage = "Không đủ hàng để xuất các mặt hàng : ";
            for (int i = 0; i < dgvMatHang.RowCount - 1; i++)
            {
                string strMaMatHang = dgvMatHang.Rows[i].Cells["colMaMatHang"].Value.ToString();
                int intSoLuongTon = int.Parse(dgvMatHang.Rows[i].Cells["colTon"].Value.ToString()); ;
                int intSoLuongXuat = int.Parse(dgvMatHang.Rows[i].Cells["colSoLuong"].Value.ToString());
                if (intSoLuongXuat > intSoLuongTon)
                {
                    strError += strMaMatHang + " ";
                }
            }
            if (strError == "")
                return strError;
            else
            {
                strError = strMessage + strError;
                return strError;
            }
        }

        private void cmbMucThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTongTien.Text != "")
                {
                    double dbChietKhau = txtTongTien.Value * (double.Parse(cmbMucThue.Text) / 100);
                    double dbThanhTien = txtTongTien.Value + dbChietKhau;
                    txtTienSauThue.Text = dbThanhTien.ToString();
                }
            }
            catch { }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            FrmNhapKhachHang frm = new FrmNhapKhachHang();
            frm.btnThemKhachHang.Tag = "add";
            string strMaKhachHang = cf.CreateId("KHA", "KHACHHANG");
            frm.txtMaKH.Text = strMaKhachHang;
            frm.ShowDialog();
            LoadCMBKhachHang();
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {

            string strError = CheckSoLuong();
            if (strError != "")
            {
                MessageBox.Show(strError, "Thông báo");
            }
            else
            {
                #region Xuất kho
                XuatKhoDTO dtoNhapKho = LayThongTinXuatKho();
                string strNhapKho = bllXuatKho.InsertXuatKho(dtoNhapKho);
                bool blFlag = false;
                if (strNhapKho != "ok")
                {
                    MessageBox.Show(strNhapKho);
                }
                else
                {
                    int intCountRow = dgvMatHang.Rows.Count;
                    int intRun = 1;
                    if (intCountRow == 2)
                        intRun = 2;
                    else
                        intRun = dgvMatHang.Rows.Count;
                    // Lưu thông tin chi tiết nhập kho
                    for (int i = 0; i < intRun - 1; i++)
                    {
                        CT_XuatKhoDTO dtoCTXuat = LayThongTinChiTietXuatKho(dtoNhapKho, i);
                        // Lưu từng mặt hàng
                        bool kq = bllCTXuatKho.InsertCT_XuatKho(dtoCTXuat);
                        if (kq == false)
                            MessageBox.Show("Mã hàng " + dtoCTXuat.MaMatHang + " không lưu được", "Nhập kho");
                        else
                        {
                            // cập nhật lại số lượng tồn cho từng mặt hàng
                            int intSoLuong = int.Parse(dgvMatHang.Rows[i].Cells["colSoLuong"].Value.ToString());
                            bllMatHang.UpdateTonXuat(dtoCTXuat.MaMatHang, intSoLuong);
                            // Lưu lại vào bảng tồn kho
                        }
                    }
                    MessageBox.Show("Đã xuất cho khách hàng", "Xuất kho");
                    blFlag = true;
                    btnIn.Enabled = true;
                }
                #endregion

                #region Xuất phiếu thu
                if (blFlag == true)
                {
                    if (MessageBox.Show("Bạn có muốn xuất phiếu thu không?", "Xuất phiếu thu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        FrmPhieuThu frm = new FrmPhieuThu();
                        Variable.intSelectedIndexPhieuThu = cmbMaKhachHang.SelectedIndex;
                        frm.cmbKhachHang.Enabled = false;
                        frm.btnThem.Enabled = false;
                        frm.txtSoTien.Text = txtTienSauThue.Text;
                        frm.txtLyDoThu.Text = "Thu cho phiếu xuất " + txtMaPhieuXuat.Text;
                        frm.ShowDialog();
                    }
                }
                #endregion
            }
        }

        private XuatKhoDTO LayThongTinXuatKho()
        {
            XuatKhoDTO dtoXuatKho = new XuatKhoDTO();
            dtoXuatKho.MaXuatKho = txtMaPhieuXuat.Text;
            dtoXuatKho.GhiChu = txtGhiChu.Text;
            dtoXuatKho.MaKhachHang = cmbMaKhachHang.Text;
            dtoXuatKho.MaNV = txtMaNhanVien.Text;
            dtoXuatKho.NgayLapHD = dtNgayLap.Value.ToShortDateString();
            dtoXuatKho.NgayXuat = dtNgayNhap.Value.ToShortDateString();
            dtoXuatKho.SoHoaDon = txtSoHoaDon.Text;
            dtoXuatKho.GiaoHang = txtNguoiNhan.Text;
            dtoXuatKho.LyDoXuat = txtLyDoNhap.Text;
            dtoXuatKho.MaThue = cmbMucThue.SelectedValue.ToString();
            dtoXuatKho.ThanhTien = txtTienSauThue.Value;
            return dtoXuatKho;
        }

        private CT_XuatKhoDTO LayThongTinChiTietXuatKho(XuatKhoDTO dtoNhapKho, int i)
        {
            CT_XuatKhoDTO dtoCTXuat = new CT_XuatKhoDTO();
            dtoCTXuat.MaCTXuatKho = cf.CreateId("CTX", "CT_XUATKHO");
            dtoCTXuat.MaXuatKho = dtoNhapKho.MaXuatKho;
            double dbGia = double.Parse(dgvMatHang.Rows[i].Cells["colGia"].Value.ToString());
            dtoCTXuat.GiaTien = dbGia;
            dtoCTXuat.MaMatHang = dgvMatHang.Rows[i].Cells["colMaMatHang"].Value.ToString();
            dtoCTXuat.SoLuongXuat = int.Parse(dgvMatHang.Rows[i].Cells["colSoLuong"].Value.ToString());
            dtoCTXuat.ThanhTien = double.Parse(dgvMatHang.Rows[i].Cells["colThanhTien"].Value.ToString());
            dtoCTXuat.TinhTrang = "1";
            return dtoCTXuat;
        }

        private void cmbTenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDKhachHang = cmbTenKhachHang.SelectedValue.ToString();
                int intIndexSelect = cmbTenKhachHang.SelectedIndex;
                KhachHangDTO dtoKhachHang = bllKhachHang.GetKhachHangByID(strIDKhachHang);
                txtDiaChi.Text = dtoKhachHang.DiaChi;
                txtDienThoai.Text = dtoKhachHang.SDT;
                //txtMaSoThue.Text = dtoNhaCungCap.MaSoThue;
                cmbMaKhachHang.SelectedIndex = intIndexSelect;
            }
            catch { }
        }

        private void cmbMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDKhachHang = cmbMaKhachHang.SelectedValue.ToString();
                int intIndexSelect = cmbMaKhachHang.SelectedIndex;
                KhachHangDTO dtoKhachHang = bllKhachHang.GetKhachHangByID(strIDKhachHang);
                txtDiaChi.Text = dtoKhachHang.DiaChi;
                txtDienThoai.Text = dtoKhachHang.SDT;
                //txtMaSoThue.Text = dtoNhaCungCap.MaSoThue;
                cmbTenKhachHang.SelectedIndex = intIndexSelect;
            }
            catch
            {
                cmbMaKhachHang.SelectedIndex = 0;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            try
            {
                string strMaXuatKho = cf.CreateId("MXK", "XUATKHO");
                txtMaPhieuXuat.Text = strMaXuatKho;
                string strMaNhanVien = Variable.strMaNhanVien;
                if (strMaNhanVien == "")
                    strMaNhanVien = "Chưa đăng nhập";
                txtMaNhanVien.Text = strMaNhanVien;
                cmbMaKhachHang.SelectedIndex = 0;
                txtNguoiNhan.Text = "";
                txtSoHoaDon.Text = "";
                txtLyDoNhap.Text = "";
                txtGhiChu.Text = "";
                if (dgvMatHang.RowCount > 0)
                    dgvMatHang.Rows.Clear();
                txtTienSauThue.Value = 0;
                txtTongTien.Value = 0;
                cmbMucThue.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmInNhapKho frm = new FrmInNhapKho();
            frm.Tag = txtMaPhieuXuat.Text;
            frm.ShowDialog();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int intIndex = dgvMatHang.SelectedCells[0].RowIndex;
                dgvMatHang.Rows.RemoveAt(intIndex);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để xóa hoặc dòng không có thông tin", "Thông báo");
            }
        }

        private void dgvMatHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double dbTongTien = TinhTongTien();
            double dbThue = dbTongTien * (double.Parse(cmbMucThue.Text) / 100);
            txtTongTien.Value = dbTongTien;
            txtTienSauThue.Text = (dbTongTien + dbThue).ToString();
        }
    }
}
        