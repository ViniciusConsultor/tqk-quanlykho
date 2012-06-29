namespace QuanLyKho
{
    partial class FrmInPhieuThu
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
            this.cvrPhieuThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cvrPhieuThu
            // 
            this.cvrPhieuThu.ActiveViewIndex = -1;
            this.cvrPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvrPhieuThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvrPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvrPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.cvrPhieuThu.Name = "cvrPhieuThu";
            this.cvrPhieuThu.ShowCloseButton = false;
            this.cvrPhieuThu.ShowGotoPageButton = false;
            this.cvrPhieuThu.ShowGroupTreeButton = false;
            this.cvrPhieuThu.ShowPageNavigateButtons = false;
            this.cvrPhieuThu.ShowParameterPanelButton = false;
            this.cvrPhieuThu.ShowTextSearchButton = false;
            this.cvrPhieuThu.ShowZoomButton = false;
            this.cvrPhieuThu.Size = new System.Drawing.Size(730, 431);
            this.cvrPhieuThu.TabIndex = 1;
            this.cvrPhieuThu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmInPhieuThu
            // 
            this.ClientSize = new System.Drawing.Size(730, 431);
            this.Controls.Add(this.cvrPhieuThu);
            this.DoubleBuffered = true;
            this.Name = "FrmInPhieuThu";
            this.Text = "In Phiếu Thu";
            this.Load += new System.EventHandler(this.FrmInPhieuThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cvrPhieuThu;
    }
}