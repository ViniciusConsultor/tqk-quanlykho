using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyKho
{
    public partial class FrmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int CheckExist(SuperTabControl tabControlName, string tabName)
        {
            int re = -1;
            for (int i = 0; i < tabControlName.Tabs.Count; i++)
            {
                if (tabControlName.Tabs[i].Name == tabName)
                {
                    re = i;
                    break;
                }
            }
            return re;
        }

        void TabCreating(string strTextSuperTabItem, string strNameSuperTabItem, string strNameSuperTabControlPanel, Office2007RibbonForm Form)
        {
            SuperTabItem sti = new SuperTabItem();
            sti.Name = strNameSuperTabItem;
            sti.Text = strTextSuperTabItem;
            SuperTabControlPanel stcp = new SuperTabControlPanel();
            stcp.Name = strNameSuperTabControlPanel;
            stcp.Dock = DockStyle.Fill;
            stcMenu.Controls.Add(stcp);
            sti.AttachedControl = stcp;
            stcMenu.SelectedPanel = stcp;
            stcMenu.Tabs.Add(sti);
            Form.TopLevel = false;
            Form.Parent = stcp;
            Form.Show();
            Form.Dock = DockStyle.Fill;
            stcMenu.SelectedTab = sti;
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            TabCreating("Nhân Viên", "stiNhanVien", "stcpNhanVien", frm);
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDoanhNghiep_Click(object sender, EventArgs e)
        {
            FrmTTDoanhNghiep frmDoanhNghiep = new FrmTTDoanhNghiep();
            frmDoanhNghiep.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmThayDoiMatKhau frmThayDoiMatKhau = new FrmThayDoiMatKhau();
            frmThayDoiMatKhau.ShowDialog();
        }

    }
}