namespace StudentManageSystem1
{
    partial class FrmSSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSSS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScoreSort = new System.Windows.Forms.Button();
            this.btnScoreSortCancel = new System.Windows.Forms.Button();
            this.btnIDSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(771, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "将课程";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "微积分",
            "大学物理",
            "集合论图论",
            "中国近代史"});
            this.comboBox1.Location = new System.Drawing.Point(178, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(356, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "的成绩由高到低排序";
            // 
            // btnScoreSort
            // 
            this.btnScoreSort.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScoreSort.Location = new System.Drawing.Point(56, 481);
            this.btnScoreSort.Name = "btnScoreSort";
            this.btnScoreSort.Size = new System.Drawing.Size(193, 41);
            this.btnScoreSort.TabIndex = 4;
            this.btnScoreSort.Text = "按成绩排序";
            this.btnScoreSort.UseVisualStyleBackColor = true;
            this.btnScoreSort.Click += new System.EventHandler(this.btnScoreSort_Click);
            // 
            // btnScoreSortCancel
            // 
            this.btnScoreSortCancel.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScoreSortCancel.Location = new System.Drawing.Point(705, 481);
            this.btnScoreSortCancel.Name = "btnScoreSortCancel";
            this.btnScoreSortCancel.Size = new System.Drawing.Size(122, 41);
            this.btnScoreSortCancel.TabIndex = 5;
            this.btnScoreSortCancel.Text = "取 消";
            this.btnScoreSortCancel.UseVisualStyleBackColor = true;
            this.btnScoreSortCancel.Click += new System.EventHandler(this.btnScoreSortCancel_Click);
            // 
            // btnIDSort
            // 
            this.btnIDSort.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIDSort.Location = new System.Drawing.Point(361, 481);
            this.btnIDSort.Name = "btnIDSort";
            this.btnIDSort.Size = new System.Drawing.Size(187, 41);
            this.btnIDSort.TabIndex = 6;
            this.btnIDSort.Text = "按学号排序";
            this.btnIDSort.UseVisualStyleBackColor = true;
            this.btnIDSort.Click += new System.EventHandler(this.btnIDSort_Click);
            // 
            // FrmSSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnIDSort);
            this.Controls.Add(this.btnScoreSortCancel);
            this.Controls.Add(this.btnScoreSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩排序";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScoreSort;
        private System.Windows.Forms.Button btnScoreSortCancel;
        private System.Windows.Forms.Button btnIDSort;
    }
}