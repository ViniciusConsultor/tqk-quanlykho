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
    public partial class FrmNhapKho : DevComponents.DotNetBar.Office2007Form
    {

        CFunction cf = new CFunction();
        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        MatHangBLL bllMatHang = new MatHangBLL();
        DonViTinhBLL bllDonVITinh = new DonViTinhBLL();
        NhapKhoBLL bllNhapKho = new NhapKhoBLL();
        MucThueBLL bllMucThue = new MucThueBLL();
        CT_NhapKhoBLL bllCTNhapKho = new CT_NhapKhoBLL();

        public FrmNhapKho()
        {
            InitializeComponent();
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {

            try
            {
                string strMaNhapKho = cf.CreateId("MNK", "NHAPKHO");
                txtMaPhieuNhap.Text = strMaNhapKho;
                string strMaNhanVien = Variable.strMaNhanVien;
                if (strMaNhanVien == "")
                    strMaNhanVien = "Chưa đăng nhập";
                txtMaNhanVien.Text = strMaNhanVien;

                dtNgayLap.Text = DateTime.Now.ToShortDateString();
                dtNgayNhap.Text = DateTime.Now.ToShortDateString();

                LoadCMBNhaCungCap();

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

        private void LoadCMBNhaCungCap()
        {
            cmbMaNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
            cmbMaNhaCungCap.DisplayMember = "MANHACUNGCAP";
            cmbMaNhaCungCap.ValueMember = "MANHACUNGCAP";

            cmbTenNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
            cmbTenNhaCungCap.DisplayMember = "TENNHACUNGCAP";
            cmbTenNhaCungCap.ValueMember = "MANHACUNGCAP";
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
            frmNhapNCC.btnThem.Tag = "add";
            string strMaNCC = cf.CreateId("CCA", "NHACUNGCAP");
            frmNhapNCC.txtMaNCC.Text = strMaNCC;
            frmNhapNCC.ShowDialog();
            LoadCMBNhaCungCap();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmInNhapKho frm = new FrmInNhapKho();
            frm.Tag = txtMaPhieuNhap.Text;
            frm.ShowDialog();
        }

        private void cmbMaNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDNhaCungCap = cmbMaNhaCungCap.SelectedValue.ToString();
                int intIndexSelect = cmbMaNhaCungCap.SelectedIndex;
                NhaCungCapDTO dtoNhaCungCap = bllNhaCungCap.GetNhaCungCapByID(strIDNhaCungCap);
                txtDiaChi.Text = dtoNhaCungCap.DiaChi;
                txtDienThoai.Text = dtoNhaCungCap.SoDienThoai;
                //txtMaSoThue.Text = dtoNhaCungCap.MaSoThue;
                cmbTenNhaCungCap.SelectedIndex = intIndexSelect;
            }
            catch {
                cmbMaNhaCungCap.SelectedIndex = 0;
            }
        }

        private void cmbTenNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDNhaCungCap = cmbTenNhaCungCap.SelectedValue.ToString();
                int intIndexSelect = cmbTenNhaCungCap.SelectedIndex;
                NhaCungCapDTO dtoNhaCungCap = bllNhaCungCap.GetNhaCungCapByID(strIDNhaCungCap);
                txtDiaChi.Text = dtoNhaCungCap.DiaChi;
                txtDienThoai.Text = dtoNhaCungCap.SoDienThoai;
                //txtMaSoThue.Text = dtoNhaCungCap.MaSoThue;
                cmbMaNhaCungCap.SelectedIndex = intIndexSelect;
            }
            catch { }
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

        private void btnLuuKho_Click(object sender, EventArgs e)
        {
            #region Nhập kho
            NhapKhoDTO dtoNhapKho = LayThongTinNhapKho();
            string strNhapKho = bllNhapKho.InsertNhapKho(dtoNhapKho);
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
                    CT_NhapKhoDTO dtoCTNhap = LayThongTinChiTietNhapKho(dtoNhapKho, i);
                    // Lưu từng mặt hàng
                    bool kq = bllCTNhapKho.InsertCT_NhapKho(dtoCTNhap);
                    if (kq == false)
                        MessageBox.Show("Mã hàng " + dtoCTNhap.MaMatHang + " không lưu được", "Nhập kho");
                    else
                    {
                        // cập nhật lại số lượng tồn cho từng mặt hàng
                        int intSoLuong = int.Parse(dgvMatHang.Rows[i].Cells["colSoLuong"].Value.ToString());
                        bllMatHang.UpdateTonNhap(dtoCTNhap.MaMatHang, intSoLuong);
                        // Lưu lại vào bảng tồn kho
                    }
                }
                MessageBox.Show("Đã lưu vào kho", "Nhập kho");
                blFlag = true;
                btnIn.Enabled = true;
            }
            #endregion

            #region Xuất phiếu chi
            if (blFlag == true)
            {
                if (MessageBox.Show("Bạn có muốn xuất phiếu chi hay không?", "Xuất phiếu chi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    FrmPhieuChi frm = new FrmPhieuChi();
                    Variable.intSelectedIndexPhieuChi = cmbMaNhaCungCap.SelectedIndex;
                    frm.cmbNhaCC.Enabled = false;
                    frm.txtSoTien.Text = txtTienSauThue.Text;
                    frm.txtLyDoChi.Text = "Chi cho phiếu nhập " + txtMaPhieuNhap.Text;
                    frm.btnThemNhaCC.Enabled = false;
                    frm.ShowDialog();
                }
            }
            #endregion
        }

        private CT_NhapKhoDTO LayThongTinChiTietNhapKho(NhapKhoDTO dtoNhapKho, int i)
        {
            CT_NhapKhoDTO dtoCTNhap = new CT_NhapKhoDTO();
            dtoCTNhap.MaCTNhapKho = cf.CreateId("CTN", "CT_NHAPKHO");
            dtoCTNhap.MaNhapKho = dtoNhapKho.MaNhapKho;
            double dbGia = double.Parse(dgvMatHang.Rows[i].Cells["colGia"].Value.ToString());
            dtoCTNhap.GiaNhap = dbGia;
            dtoCTNhap.MaMatHang = dgvMatHang.Rows[i].Cells["colMaMatHang"].Value.ToString();
            dtoCTNhap.SoLuongNhap = int.Parse(dgvMatHang.Rows[i].Cells["colSoLuong"].Value.ToString());
            dtoCTNhap.ThanhTien = double.Parse(dgvMatHang.Rows[i].Cells["colThanhTien"].Value.ToString());
            dtoCTNhap.TinhTrang = "1";
            return dtoCTNhap;
        }

        private NhapKhoDTO LayThongTinNhapKho()
        {
            NhapKhoDTO dtoNhapKho = new NhapKhoDTO();
            dtoNhapKho.MaNhapKho = txtMaPhieuNhap.Text;
            dtoNhapKho.GhiChu = txtGhiChu.Text;
            dtoNhapKho.MaNCC = cmbMaNhaCungCap.Text;
            dtoNhapKho.MaNV = txtMaNhanVien.Text;
            dtoNhapKho.NgayLapHD = dtNgayLap.Value.ToShortDateString();
            dtoNhapKho.NgayNhap = dtNgayNhap.Value.ToShortDateString();
            dtoNhapKho.SoHoaDon = txtSoHoaDon.Text;
            dtoNhapKho.NguoiNhan = txtNguoiNhan.Text;
            dtoNhapKho.LyDoNhap = txtLyDoNhap.Text;
            dtoNhapKho.MaThue = cmbMucThue.SelectedValue.ToString();
            dtoNhapKho.ThanhTien = txtTienSauThue.Value;
            return dtoNhapKho;
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            try
            {
                string strMaNhapKho = cf.CreateId("MNK", "NHAPKHO");
                txtMaPhieuNhap.Text = strMaNhapKho;
                string strMaNhanVien = Variable.strMaNhanVien;
                if (strMaNhanVien == "")
                    strMaNhanVien = "Chưa đăng nhập";
                txtMaNhanVien.Text = strMaNhanVien;
                cmbMaNhaCungCap.SelectedIndex = 0;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void dgvMatHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double dbTongTien = TinhTongTien();
            double dbThue = dbTongTien *(double.Parse(cmbMucThue.Text) / 100);
            txtTongTien.Value = dbTongTien;
            txtTienSauThue.Text = (dbTongTien + dbThue).ToString();
        }
    }
}