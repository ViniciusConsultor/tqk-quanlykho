namespace QuanLyKho
{
    partial class FrmNhapMatHang
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
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtTonDau = new DevComponents.Editors.IntegerInput();
            this.txtMoTa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbDonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKhoHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNhomHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTenMH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaMH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonDau)).BeginInit();
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
            this.labelX1.Image = global::QuanLyKho.Properties.Resources._1447_eraser_48x48;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingLeft = 60;
            this.labelX1.PaddingRight = 50;
            this.labelX1.Size = new System.Drawing.Size(349, 38);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "THÔNG TIN MẶT HÀNG";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 306);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(349, 49);
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
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QuanLyKho.Properties.Resources.DeleteAll;
            this.btnThoat.Location = new System.Drawing.Point(199, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 25);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Cancel";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::QuanLyKho.Properties.Resources.Connection;
            this.btnThem.Location = new System.Drawing.Point(66, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 25);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "OK";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtTonDau);
            this.groupPanel2.Controls.Add(this.txtMoTa);
            this.groupPanel2.Controls.Add(this.cmbDonViTinh);
            this.groupPanel2.Controls.Add(this.cmbKhoHang);
            this.groupPanel2.Controls.Add(this.cmbNhomHang);
            this.groupPanel2.Controls.Add(this.txtTenMH);
            this.groupPanel2.Controls.Add(this.txtMaMH);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 38);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(349, 268);
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
            // txtTonDau
            // 
            // 
            // 
            // 
            this.txtTonDau.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTonDau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTonDau.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTonDau.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtTonDau.Location = new System.Drawing.Point(90, 161);
            this.txtTonDau.Name = "txtTonDau";
            this.txtTonDau.Size = new System.Drawing.Size(223, 20);
            this.txtTonDau.TabIndex = 6;
            // 
            // txtMoTa
            // 
            // 
            // 
            // 
            this.txtMoTa.Border.Class = "TextBoxBorder";
            this.txtMoTa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMoTa.Location = new System.Drawing.Point(90, 190);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(223, 51);
            this.txtMoTa.TabIndex = 7;
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.DisplayMember = "Text";
            this.cmbDonViTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDonViTinh.FormattingEnabled = true;
            this.cmbDonViTinh.ItemHeight = 14;
            this.cmbDonViTinh.Location = new System.Drawing.Point(90, 132);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(223, 20);
            this.cmbDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbDonViTinh.TabIndex = 5;
            // 
            // cmbKhoHang
            // 
            this.cmbKhoHang.DisplayMember = "Text";
            this.cmbKhoHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoHang.FormattingEnabled = true;
            this.cmbKhoHang.ItemHeight = 14;
            this.cmbKhoHang.Location = new System.Drawing.Point(90, 103);
            this.cmbKhoHang.Name = "cmbKhoHang";
            this.cmbKhoHang.Size = new System.Drawing.Size(223, 20);
            this.cmbKhoHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbKhoHang.TabIndex = 4;
            // 
            // cmbNhomHang
            // 
            this.cmbNhomHang.DisplayMember = "Text";
            this.cmbNhomHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNhomHang.FormattingEnabled = true;
            this.cmbNhomHang.ItemHeight = 14;
            this.cmbNhomHang.Location = new System.Drawing.Point(90, 74);
            this.cmbNhomHang.Name = "cmbNhomHang";
            this.cmbNhomHang.Size = new System.Drawing.Size(223, 20);
            this.cmbNhomHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbNhomHang.TabIndex = 3;
            // 
            // txtTenMH
            // 
            // 
            // 
            // 
            this.txtTenMH.Border.Class = "TextBoxBorder";
            this.txtTenMH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenMH.Location = new System.Drawing.Point(90, 45);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(223, 20);
            this.txtTenMH.TabIndex = 2;
            // 
            // txtMaMH
            // 
            // 
            // 
            // 
            this.txtMaMH.Border.Class = "TextBoxBorder";
            this.txtMaMH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaMH.Location = new System.Drawing.Point(90, 16);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(223, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(9, 190);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "Mô Tả :";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(9, 161);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "Tồn Đầu :";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(9, 132);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Đơn Vị Tính :";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(9, 103);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Kho Hàng :";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 74);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Nhóm Hàng :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(82, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Tên Mặt Hàng :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã Mặt Hàng :";
            // 
            // FrmNhapMatHang
            // 
            this.AcceptButton = this.btnThem;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(349, 355);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmNhapMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mặt Hàng";
            this.Load += new System.EventHandler(this.FrmNhapMatHang_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTonDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public DevComponents.DotNetBar.ButtonX btnThoat;
        public DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMoTa;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbDonViTinh;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoHang;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbNhomHang;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTenMH;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMaMH;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.Editors.IntegerInput txtTonDau;
    }
}