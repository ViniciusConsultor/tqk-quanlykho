namespace QuanLyKho
{
    partial class FrmInXuatKho
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
            this.crvInXuatKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInXuatKho
            // 
            this.crvInXuatKho.ActiveViewIndex = -1;
            this.crvInXuatKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInXuatKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInXuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInXuatKho.Location = new System.Drawing.Point(0, 0);
            this.crvInXuatKho.Name = "crvInXuatKho";
            this.crvInXuatKho.ShowCloseButton = false;
            this.crvInXuatKho.ShowGotoPageButton = false;
            this.crvInXuatKho.ShowGroupTreeButton = false;
            this.crvInXuatKho.ShowPageNavigateButtons = false;
            this.crvInXuatKho.ShowParameterPanelButton = false;
            this.crvInXuatKho.ShowTextSearchButton = false;
            this.crvInXuatKho.ShowZoomButton = false;
            this.crvInXuatKho.Size = new System.Drawing.Size(700, 441);
            this.crvInXuatKho.TabIndex = 1;
            this.crvInXuatKho.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmInXuatKho
            // 
            this.ClientSize = new System.Drawing.Size(700, 441);
            this.Controls.Add(this.crvInXuatKho);
            this.DoubleBuffered = true;
            this.Name = "FrmInXuatKho";
            this.Text = "In Xuất Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInXuatKho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInXuatKho;
    }
}