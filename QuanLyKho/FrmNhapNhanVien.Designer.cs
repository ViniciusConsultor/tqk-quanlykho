namespace QuanLyKho
{
    partial class FrmNhapNhanVien
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
            this.btnThemNhanVien = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtCMND = new DevComponents.Editors.IntegerInput();
            this.txtDienThoai = new DevComponents.Editors.IntegerInput();
            this.dtNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbChucVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbBoPhan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTenNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Image = global::QuanLyKho.Properties.Resources.nhanvien;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingLeft = 50;
            this.labelX1.Size = new System.Drawing.Size(348, 49);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.btnThemNhanVien);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 340);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(348, 47);
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
            this.btnThoat.Location = new System.Drawing.Point(200, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 25);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Cancel";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNhanVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemNhanVien.Image = global::QuanLyKho.Properties.Resources.Connection;
            this.btnThemNhanVien.Location = new System.Drawing.Point(65, 10);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(90, 25);
            this.btnThemNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemNhanVien.TabIndex = 9;
            this.btnThemNhanVien.Text = "OK";
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtCMND);
            this.groupPanel2.Controls.Add(this.txtDienThoai);
            this.groupPanel2.Controls.Add(this.dtNgaySinh);
            this.groupPanel2.Controls.Add(this.txtDiaChi);
            this.groupPanel2.Controls.Add(this.cmbChucVu);
            this.groupPanel2.Controls.Add(this.cmbBoPhan);
            this.groupPanel2.Controls.Add(this.txtTenNhanVien);
            this.groupPanel2.Controls.Add(this.txtMaNV);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 49);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(348, 291);
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
            // txtCMND
            // 
            // 
            // 
            // 
            this.txtCMND.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCMND.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCMND.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCMND.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtCMND.Location = new System.Drawing.Point(102, 188);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(210, 20);
            this.txtCMND.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            // 
            // 
            // 
            this.txtDienThoai.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDienThoai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoai.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDienThoai.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtDienThoai.Location = new System.Drawing.Point(102, 160);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(210, 20);
            this.txtDienThoai.TabIndex = 6;
            // 
            // dtNgaySinh
            // 
            // 
            // 
            // 
            this.dtNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgaySinh.ButtonDropDown.Visible = true;
            this.dtNgaySinh.CustomFormat = "dd - MM - yyyy";
            this.dtNgaySinh.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtNgaySinh.IsPopupCalendarOpen = false;
            this.dtNgaySinh.Location = new System.Drawing.Point(102, 132);
            this.dtNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dtNgaySinh.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(210, 20);
            this.dtNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgaySinh.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Location = new System.Drawing.Point(102, 217);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 53);
            this.txtDiaChi.TabIndex = 8;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.DisplayMember = "Text";
            this.cmbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.ItemHeight = 14;
            this.cmbChucVu.Location = new System.Drawing.Point(102, 101);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(210, 20);
            this.cmbChucVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbChucVu.TabIndex = 4;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.DisplayMember = "Text";
            this.cmbBoPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.ItemHeight = 14;
            this.cmbBoPhan.Location = new System.Drawing.Point(102, 72);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(210, 20);
            this.cmbBoPhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbBoPhan.TabIndex = 3;
            // 
            // txtTenNhanVien
            // 
            // 
            // 
            // 
            this.txtTenNhanVien.Border.Class = "TextBoxBorder";
            this.txtTenNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNhanVien.Location = new System.Drawing.Point(102, 43);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(210, 20);
            this.txtTenNhanVien.TabIndex = 2;
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Location = new System.Drawing.Point(102, 14);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PreventEnterBeep = true;
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(210, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(11, 217);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 7;
            this.labelX9.Text = "Địa Chỉ :";
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
            this.labelX8.Text = "CMND :";
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
            this.labelX7.Text = "Điện Thoại :";
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
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Ngày Sinh :";
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
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Chức Vụ :";
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
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Bộ Phận :";
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
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Tên Nhân Viên :";
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
            this.labelX2.Size = new System.Drawing.Size(85, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã Nhân Viên :";
            // 
            // FrmNhapNhanVien
            // 
            this.AcceptButton = this.btnThemNhanVien;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(348, 387);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmNhapNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhapNhanVien_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbChucVu;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbBoPhan;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTenNhanVien;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        public DevComponents.DotNetBar.ButtonX btnThoat;
        public DevComponents.DotNetBar.ButtonX btnThemNhanVien;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgaySinh;
        public DevComponents.Editors.IntegerInput txtDienThoai;
        public DevComponents.Editors.IntegerInput txtCMND;
    }
}