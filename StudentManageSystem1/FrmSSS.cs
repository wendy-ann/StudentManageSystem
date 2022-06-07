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
    public partial class FrmSSS : Form
    {
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlCommandBuilder cb;
        DataSet myds;
        public FrmSSS()
        {
            InitializeComponent();
        }
        private void btnScoreSort_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection("server=127.0.0.1;database=studentmanage;user id=root;password=chao");
            cnn.Open();

            string query = "select * from score order by "+ comboBox1.Text+ " DESC";
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(query, cnn);
            cb = new MySqlCommandBuilder(adapter);

            myds = new DataSet();
            adapter.Fill(myds, "score");
            dataGridView1.DataSource = myds.Tables["score"];

            dataGridView1.Columns[0].HeaderText = "序号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "微积分";
            dataGridView1.Columns[3].HeaderText = "大学物理";
            dataGridView1.Columns[4].HeaderText = "集合论图论";
            dataGridView1.Columns[5].HeaderText = "中国近代史";
        }
        private void btnIDSort_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection("server=127.0.0.1;database=studentmanage;user id=root;password=chao");
            cnn.Open();


            string query = "select * from score order by "+"序号"+" DESC";
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(query, cnn);
            cb = new MySqlCommandBuilder(adapter);

            myds = new DataSet();
            adapter.Fill(myds, "score");
            dataGridView1.DataSource = myds.Tables["score"];

            dataGridView1.Columns[0].HeaderText = "序号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "微积分";
            dataGridView1.Columns[3].HeaderText = "大学物理";
            dataGridView1.Columns[4].HeaderText = "集合论图论";
            dataGridView1.Columns[5].HeaderText = "中国近代史";
        }
        private void btnScoreSortCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
