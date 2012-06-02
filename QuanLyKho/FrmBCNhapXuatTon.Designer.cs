namespace QuanLyKho
{
    partial class FrmBCNhapXuatTon
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
            this.crvNhapXuatTon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crpXuatNhapTon1 = new QuanLyKho.Report.crpXuatNhapTon();
            this.SuspendLayout();
            // 
            // crvNhapXuatTon
            // 
            this.crvNhapXuatTon.ActiveViewIndex = 0;
            this.crvNhapXuatTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhapXuatTon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNhapXuatTon.DisplayBackgroundEdge = false;
            this.crvNhapXuatTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNhapXuatTon.Location = new System.Drawing.Point(0, 0);
            this.crvNhapXuatTon.Name = "crvNhapXuatTon";
            this.crvNhapXuatTon.ReportSource = this.crpXuatNhapTon1;
            this.crvNhapXuatTon.ShowCloseButton = false;
            this.crvNhapXuatTon.ShowGotoPageButton = false;
            this.crvNhapXuatTon.ShowGroupTreeButton = false;
            this.crvNhapXuatTon.ShowPageNavigateButtons = false;
            this.crvNhapXuatTon.ShowParameterPanelButton = false;
            this.crvNhapXuatTon.ShowTextSearchButton = false;
            this.crvNhapXuatTon.ShowZoomButton = false;
            this.crvNhapXuatTon.Size = new System.Drawing.Size(976, 450);
            this.crvNhapXuatTon.TabIndex = 0;
            this.crvNhapXuatTon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmBCNhapXuatTon
            // 
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.crvNhapXuatTon);
            this.DoubleBuffered = true;
            this.Name = "FrmBCNhapXuatTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo nhập xuất tồn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNhapXuatTon;
        private Report.crpXuatNhapTon crpXuatNhapTon1;
    }
}