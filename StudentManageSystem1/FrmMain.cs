using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManageSystem1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin Frmlogin = new FrmLogin();
            Frmlogin.ShowDialog();
        }

        private void menustripIQ_Click(object sender, EventArgs e)
        {
            FrmIQ FrmIQ = new FrmIQ();
            FrmIQ.ShowDialog();
        }

        private void menustripBI_Click(object sender, EventArgs e)
        {
            FrmIMS FrmIMS = new FrmIMS();
            FrmIMS.ShowDialog();
        }

        private void menustripSS_Click(object sender, EventArgs e)
        {
            FrmSS FrmSS = new FrmSS();
            FrmSS.ShowDialog();
        }

        private void menustripSI_Click(object sender, EventArgs e)
        {
            FrmSI FrmSI = new FrmSI();
            FrmSI.ShowDialog();
        }

        private void menustripExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("您确定要退出学生管理系统吗？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void menustripSSS_Click(object sender, EventArgs e)
        {
            FrmSSS FrmSSS = new FrmSSS();
            FrmSSS.ShowDialog();
        }
    }
}
