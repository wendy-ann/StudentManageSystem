using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManageSystem1
{
    public partial class FrmIMS : Form
    {
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlCommandBuilder cb;
        DataSet myds;
        public FrmIMS()
        {
            InitializeComponent();
        }
        private void FrmIMS_Load(object sender, EventArgs e)
        {
            //string str = "server=127.0.0.1;database=studentmanage;user id=root;password=chao";
            //MySqlConnection conn = new MySqlConnection(str);
            //conn.Open();
            //MessageBox.Show("yes");
            cnn = new MySqlConnection("server=127.0.0.1;database=studentmanage;user id=root;password=chao");
            cnn.Open();
            string query = "select * from basicinformation";
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(query, cnn);
            cb = new MySqlCommandBuilder(adapter);

            myds = new DataSet();
            adapter.Fill(myds, "basicinformation");
            dataGridView1.DataSource = myds.Tables["basicinformation"];

            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Sex";
            dataGridView1.Columns[3].HeaderText = "Age";
            dataGridView1.Columns[4].HeaderText = "Tel";

        }

        private void btnInfoSave_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("", "",MessageBoxButtons.OK);
            adapter.Update(myds, "basicinformation");
            cnn.Close();
            Close();
        }

        private void btnInfoCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
