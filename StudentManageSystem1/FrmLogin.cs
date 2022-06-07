using MySql.Data.MySqlClient;
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
    public partial class FrmLogin : Form
    {
        MySqlConnection cnn;
        int iCount = 3;
        int flag = 1;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection("server=127.0.0.1;database=studentmanage;user id=root;password=chao");
            cnn.Open();

            if ((TBname.Text == "") || (TBpwd.Text == ""))
            {
                MessageBox.Show("账号和密码不能为空！");
            }
            else
            {
                string str = "Select * from login where user='" + TBname.Text + "' and password='" + TBpwd.Text + "'";
                string user = "Select * from login where user='" + TBname.Text + "'";
                string pwd = "Select * from login where password='" + TBpwd.Text + "'";
                MySqlCommand cmd = new MySqlCommand(str, cnn);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    MessageBox.Show("登陆成功");
                    Close();
                }
                else
                {
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand cmduser = new MySqlCommand(user, cnn);
                    cmduser.CommandType = CommandType.Text;
                    MySqlDataReader sdruser = cmduser.ExecuteReader();
                    if (!sdruser.Read())
                    {
                        string st = "该用户名不存在！";
                        MessageBox.Show(st, "提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        iCount--;
                        if (iCount > 0)
                        {
                            string st = "密码输入错误！您还有" + iCount.ToString() + "次机会";
                            MessageBox.Show(st, "提示", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("次数已用尽！即将退出系统", "提示", MessageBoxButtons.OK);
                            cnn.Close();
                            Application.Exit();
                        }
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister FrmRegister = new FrmRegister();
            FrmRegister.ShowDialog();            
        }
    }
}
