namespace QuanLyKho
{
    partial class FrmNhapKhoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtDienThoaiBan = new DevComponents.Editors.IntegerInput();
            this.txtDienThoaiDD = new DevComponents.Editors.IntegerInput();
            this.cmbNhanVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFax = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenKho = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaKho = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiDD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Image = global::QuanLyKho.Properties.Resources.Kho;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingLeft = 50;
            this.labelX1.PaddingRight = 50;
            this.labelX1.Size = new System.Drawing.Size(338, 48);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "THÔNG TIN KHO HÀNG";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.btnOK);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 369);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(338, 46);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QuanLyKho.Properties.Resources.DeleteAll;
            this.btnThoat.Location = new System.Drawing.Point(193, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 25);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.Image = global::QuanLyKho.Properties.Resources.Connection;
            this.btnOK.Location = new System.Drawing.Point(63, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtDienThoaiBan);
            this.groupPanel2.Controls.Add(this.txtDienThoaiDD);
            this.groupPanel2.Controls.Add(this.cmbNhanVien);
            this.groupPanel2.Controls.Add(this.txtGhiChu);
            this.groupPanel2.Controls.Add(this.txtDiaChi);
            this.groupPanel2.Controls.Add(this.txtFax);
            this.groupPanel2.Controls.Add(this.txtTenKho);
            this.groupPanel2.Controls.Add(this.txtMaKho);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 48);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(338, 321);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 2;
            // 
            // txtDienThoaiBan
            // 
            // 
            // 
            // 
            this.txtDienThoaiBan.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDienThoaiBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoaiBan.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDienThoaiBan.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtDienThoaiBan.Location = new System.Drawing.Point(100, 72);
            this.txtDienThoaiBan.Name = "txtDienThoaiBan";
            this.txtDienThoaiBan.Size = new System.Drawing.Size(221, 20);
            this.txtDienThoaiBan.TabIndex = 10;
            // 
            // txtDienThoaiDD
            // 
            // 
            // 
            // 
            this.txtDienThoaiDD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDienThoaiDD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoaiDD.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDienThoaiDD.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtDienThoaiDD.Location = new System.Drawing.Point(100, 101);
            this.txtDienThoaiDD.Name = "txtDienThoaiDD";
            this.txtDienThoaiDD.Size = new System.Drawing.Size(221, 20);
            this.txtDienThoaiDD.TabIndex = 11;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbNhanVien.DisplayMember = "Text";
            this.cmbNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.ItemHeight = 14;
            this.cmbNhanVien.Location = new System.Drawing.Point(101, 130);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(221, 20);
            this.cmbNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbNhanVien.TabIndex = 12;
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(100, 248);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(221, 48);
            this.txtGhiChu.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Location = new System.Drawing.Point(100, 188);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(221, 51);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtFax
            // 
            // 
            // 
            // 
            this.txtFax.Border.Class = "TextBoxBorder";
            this.txtFax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFax.Location = new System.Drawing.Point(100, 159);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(221, 20);
            this.txtFax.TabIndex = 13;
            // 
            // txtTenKho
            // 
            // 
            // 
            // 
            this.txtTenKho.Border.Class = "TextBoxBorder";
            this.txtTenKho.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKho.Location = new System.Drawing.Point(100, 43);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(221, 20);
            this.txtTenKho.TabIndex = 9;
            // 
            // txtMaKho
            // 
            // 
            // 
            // 
            this.txtMaKho.Border.Class = "TextBoxBorder";
            this.txtMaKho.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaKho.Location = new System.Drawing.Point(100, 14);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.ReadOnly = true;
            this.txtMaKho.Size = new System.Drawing.Size(221, 20);
            this.txtMaKho.TabIndex = 8;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(11, 248);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 7;
            this.labelX9.Text = "Ghi Chú :";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(11, 188);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "Địa Chỉ :";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(11, 159);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "Fax :";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(11, 130);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(84, 23);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Người Liên Hệ :";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(11, 101);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(84, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Điện Thoại DĐ :";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(11, 72);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(84, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Điện Thoại Bàn :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Tên Kho :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã Kho :";
            // 
            // FrmNhapKhoHang
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(338, 415);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmNhapKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Hàng";
            this.Load += new System.EventHandler(this.FrmNhapKhoHang_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiDD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        public DevComponents.DotNetBar.ButtonX btnThoat;
        public DevComponents.DotNetBar.ButtonX btnOK;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbNhanVien;
        public DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFax;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTenKho;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMaKho;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.Editors.IntegerInput txtDienThoaiBan;
        public DevComponents.Editors.IntegerInput txtDienThoaiDD;
    }
}