namespace StudentManageSystem1
{
    partial class FrmSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnScoreSave = new System.Windows.Forms.Button();
            this.btnScoreCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(674, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnScoreSave
            // 
            this.btnScoreSave.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScoreSave.Location = new System.Drawing.Point(173, 472);
            this.btnScoreSave.Name = "btnScoreSave";
            this.btnScoreSave.Size = new System.Drawing.Size(111, 43);
            this.btnScoreSave.TabIndex = 1;
            this.btnScoreSave.Text = "保 存";
            this.btnScoreSave.UseVisualStyleBackColor = true;
            this.btnScoreSave.Click += new System.EventHandler(this.btnScoreSave_Click);
            // 
            // btnScoreCancel
            // 
            this.btnScoreCancel.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScoreCancel.Location = new System.Drawing.Point(593, 472);
            this.btnScoreCancel.Name = "btnScoreCancel";
            this.btnScoreCancel.Size = new System.Drawing.Size(111, 43);
            this.btnScoreCancel.TabIndex = 2;
            this.btnScoreCancel.Text = "取 消";
            this.btnScoreCancel.UseVisualStyleBackColor = true;
            this.btnScoreCancel.Click += new System.EventHandler(this.btnScoreCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(101, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "您可以在此界面添加、修改、删除并保存学生成绩";
            // 
            // FrmSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScoreCancel);
            this.Controls.Add(this.btnScoreSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩管理";
            this.Load += new System.EventHandler(this.FrmSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnScoreSave;
        private System.Windows.Forms.Button btnScoreCancel;
        private System.Windows.Forms.Label label1;
    }
}