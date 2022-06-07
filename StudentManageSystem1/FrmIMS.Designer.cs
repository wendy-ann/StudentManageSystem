namespace StudentManageSystem1
{
    partial class FrmIMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfoSave = new System.Windows.Forms.Button();
            this.btnInfoCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(727, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "您可以在该表中添加、修改、删除并保存学生信息";
            // 
            // btnInfoSave
            // 
            this.btnInfoSave.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInfoSave.Location = new System.Drawing.Point(178, 487);
            this.btnInfoSave.Name = "btnInfoSave";
            this.btnInfoSave.Size = new System.Drawing.Size(128, 39);
            this.btnInfoSave.TabIndex = 2;
            this.btnInfoSave.Text = "保 存";
            this.btnInfoSave.UseVisualStyleBackColor = true;
            this.btnInfoSave.Click += new System.EventHandler(this.btnInfoSave_Click);
            // 
            // btnInfoCancel
            // 
            this.btnInfoCancel.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInfoCancel.Location = new System.Drawing.Point(588, 487);
            this.btnInfoCancel.Name = "btnInfoCancel";
            this.btnInfoCancel.Size = new System.Drawing.Size(128, 39);
            this.btnInfoCancel.TabIndex = 3;
            this.btnInfoCancel.Text = "取 消";
            this.btnInfoCancel.UseVisualStyleBackColor = true;
            this.btnInfoCancel.Click += new System.EventHandler(this.btnInfoCancel_Click);
            // 
            // FrmIMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnInfoCancel);
            this.Controls.Add(this.btnInfoSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmIMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.FrmIMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfoSave;
        private System.Windows.Forms.Button btnInfoCancel;
    }
}