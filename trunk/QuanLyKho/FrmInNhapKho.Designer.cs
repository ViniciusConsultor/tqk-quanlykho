namespace QuanLyKho
{
    partial class FrmInNhapKho
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
            this.crvInNhapKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInNhapKho
            // 
            this.crvInNhapKho.ActiveViewIndex = -1;
            this.crvInNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInNhapKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInNhapKho.Location = new System.Drawing.Point(0, 0);
            this.crvInNhapKho.Name = "crvInNhapKho";
            this.crvInNhapKho.ShowCloseButton = false;
            this.crvInNhapKho.ShowGotoPageButton = false;
            this.crvInNhapKho.ShowGroupTreeButton = false;
            this.crvInNhapKho.ShowPageNavigateButtons = false;
            this.crvInNhapKho.ShowParameterPanelButton = false;
            this.crvInNhapKho.ShowTextSearchButton = false;
            this.crvInNhapKho.ShowZoomButton = false;
            this.crvInNhapKho.Size = new System.Drawing.Size(857, 481);
            this.crvInNhapKho.TabIndex = 0;
            this.crvInNhapKho.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmInNhapKho
            // 
            this.ClientSize = new System.Drawing.Size(857, 481);
            this.Controls.Add(this.crvInNhapKho);
            this.DoubleBuffered = true;
            this.Name = "FrmInNhapKho";
            this.Text = "In Nhập Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInNhapHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInNhapKho;
    }
}