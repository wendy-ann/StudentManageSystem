namespace StudentManageSystem1
{
    partial class FrmSI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSI));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBnamequery = new System.Windows.Forms.TextBox();
            this.TBidquery = new System.Windows.Forms.TextBox();
            this.btnNameQuery = new System.Windows.Forms.Button();
            this.btnIdQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(773, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(65, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入学生姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(65, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "请输入学生序号：";
            // 
            // TBnamequery
            // 
            this.TBnamequery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBnamequery.Location = new System.Drawing.Point(329, 48);
            this.TBnamequery.Name = "TBnamequery";
            this.TBnamequery.Size = new System.Drawing.Size(140, 34);
            this.TBnamequery.TabIndex = 4;
            // 
            // TBidquery
            // 
            this.TBidquery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBidquery.Location = new System.Drawing.Point(329, 106);
            this.TBidquery.Name = "TBidquery";
            this.TBidquery.Size = new System.Drawing.Size(140, 34);
            this.TBidquery.TabIndex = 5;
            // 
            // btnNameQuery
            // 
            this.btnNameQuery.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNameQuery.Location = new System.Drawing.Point(556, 50);
            this.btnNameQuery.Name = "btnNameQuery";
            this.btnNameQuery.Size = new System.Drawing.Size(205, 33);
            this.btnNameQuery.TabIndex = 6;
            this.btnNameQuery.Text = "按姓名查询";
            this.btnNameQuery.UseVisualStyleBackColor = true;
            this.btnNameQuery.Click += new System.EventHandler(this.btnNameQuery_Click);
            // 
            // btnIdQuery
            // 
            this.btnIdQuery.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIdQuery.Location = new System.Drawing.Point(556, 107);
            this.btnIdQuery.Name = "btnIdQuery";
            this.btnIdQuery.Size = new System.Drawing.Size(205, 32);
            this.btnIdQuery.TabIndex = 7;
            this.btnIdQuery.Text = "按序号查询";
            this.btnIdQuery.UseVisualStyleBackColor = true;
            this.btnIdQuery.Click += new System.EventHandler(this.btnIdQuery_Click);
            // 
            // FrmSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnIdQuery);
            this.Controls.Add(this.btnNameQuery);
            this.Controls.Add(this.TBidquery);
            this.Controls.Add(this.TBnamequery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBnamequery;
        private System.Windows.Forms.TextBox TBidquery;
        private System.Windows.Forms.Button btnNameQuery;
        private System.Windows.Forms.Button btnIdQuery;
    }
}