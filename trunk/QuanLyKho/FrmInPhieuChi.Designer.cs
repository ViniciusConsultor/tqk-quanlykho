namespace QuanLyKho
{
    partial class FrmInPhieuChi
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
            this.cvrPhieuChi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cvrPhieuChi
            // 
            this.cvrPhieuChi.ActiveViewIndex = -1;
            this.cvrPhieuChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvrPhieuChi.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvrPhieuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvrPhieuChi.Location = new System.Drawing.Point(0, 0);
            this.cvrPhieuChi.Name = "cvrPhieuChi";
            this.cvrPhieuChi.ShowCloseButton = false;
            this.cvrPhieuChi.ShowGotoPageButton = false;
            this.cvrPhieuChi.ShowGroupTreeButton = false;
            this.cvrPhieuChi.ShowPageNavigateButtons = false;
            this.cvrPhieuChi.ShowParameterPanelButton = false;
            this.cvrPhieuChi.ShowTextSearchButton = false;
            this.cvrPhieuChi.ShowZoomButton = false;
            this.cvrPhieuChi.Size = new System.Drawing.Size(773, 479);
            this.cvrPhieuChi.TabIndex = 0;
            this.cvrPhieuChi.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmInPhieuChi
            // 
            this.ClientSize = new System.Drawing.Size(773, 479);
            this.Controls.Add(this.cvrPhieuChi);
            this.DoubleBuffered = true;
            this.Name = "FrmInPhieuChi";
            this.Text = "In Phiếu Chi";
            this.Load += new System.EventHandler(this.FrmInPhieuChi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cvrPhieuChi;
    }
}