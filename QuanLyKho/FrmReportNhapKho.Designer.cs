namespace QuanLyKho
{
    partial class FrmReportNhapKho
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
            this.crvNhapKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvNhapKho
            // 
            this.crvNhapKho.ActiveViewIndex = -1;
            this.crvNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhapKho.CausesValidation = false;
            this.crvNhapKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNhapKho.DisplayStatusBar = false;
            this.crvNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNhapKho.Location = new System.Drawing.Point(0, 0);
            this.crvNhapKho.Name = "crvNhapKho";
            this.crvNhapKho.Size = new System.Drawing.Size(889, 486);
            this.crvNhapKho.TabIndex = 0;
            this.crvNhapKho.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportNhapKho
            // 
            this.ClientSize = new System.Drawing.Size(889, 486);
            this.Controls.Add(this.crvNhapKho);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportNhapKho";
            this.Text = "In Nhập Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportNhapKho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNhapKho;

    }
}