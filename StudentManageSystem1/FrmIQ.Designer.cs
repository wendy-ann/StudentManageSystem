namespace StudentManageSystem1
{
    partial class FrmIQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIQ));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQueryQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBquery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(673, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnQueryQuery
            // 
            this.btnQueryQuery.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryQuery.Location = new System.Drawing.Point(669, 60);
            this.btnQueryQuery.Name = "btnQueryQuery";
            this.btnQueryQuery.Size = new System.Drawing.Size(105, 35);
            this.btnQueryQuery.TabIndex = 1;
            this.btnQueryQuery.Text = "查 询";
            this.btnQueryQuery.UseVisualStyleBackColor = true;
            this.btnQueryQuery.Click += new System.EventHandler(this.btnQueryQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(96, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入您要查询的学生姓名：";
            // 
            // TBquery
            // 
            this.TBquery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBquery.Location = new System.Drawing.Point(499, 61);
            this.TBquery.Name = "TBquery";
            this.TBquery.Size = new System.Drawing.Size(138, 34);
            this.TBquery.TabIndex = 4;
            // 
            // FrmIQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.TBquery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQueryQuery);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmIQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQueryQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBquery;
    }
}