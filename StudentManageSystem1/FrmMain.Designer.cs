namespace StudentManageSystem1
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripBI = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripIQ = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripSS = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripSI = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripSSS = new System.Windows.Forms.ToolStripMenuItem();
            this.登录退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.登录退出ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 信息管理ToolStripMenuItem
            // 
            this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripBI,
            this.menustripIQ});
            this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            resources.ApplyResources(this.信息管理ToolStripMenuItem, "信息管理ToolStripMenuItem");
            // 
            // menustripBI
            // 
            this.menustripBI.Name = "menustripBI";
            resources.ApplyResources(this.menustripBI, "menustripBI");
            this.menustripBI.Click += new System.EventHandler(this.menustripBI_Click);
            // 
            // menustripIQ
            // 
            this.menustripIQ.Name = "menustripIQ";
            resources.ApplyResources(this.menustripIQ, "menustripIQ");
            this.menustripIQ.Click += new System.EventHandler(this.menustripIQ_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripSS,
            this.menustripSI,
            this.menustripSSS});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            resources.ApplyResources(this.成绩管理ToolStripMenuItem, "成绩管理ToolStripMenuItem");
            // 
            // menustripSS
            // 
            this.menustripSS.Name = "menustripSS";
            resources.ApplyResources(this.menustripSS, "menustripSS");
            this.menustripSS.Click += new System.EventHandler(this.menustripSS_Click);
            // 
            // menustripSI
            // 
            this.menustripSI.Name = "menustripSI";
            resources.ApplyResources(this.menustripSI, "menustripSI");
            this.menustripSI.Click += new System.EventHandler(this.menustripSI_Click);
            // 
            // menustripSSS
            // 
            this.menustripSSS.Name = "menustripSSS";
            resources.ApplyResources(this.menustripSSS, "menustripSSS");
            this.menustripSSS.Click += new System.EventHandler(this.menustripSSS_Click);
            // 
            // 登录退出ToolStripMenuItem
            // 
            this.登录退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripExit});
            this.登录退出ToolStripMenuItem.Name = "登录退出ToolStripMenuItem";
            resources.ApplyResources(this.登录退出ToolStripMenuItem, "登录退出ToolStripMenuItem");
            // 
            // menustripExit
            // 
            this.menustripExit.Name = "menustripExit";
            resources.ApplyResources(this.menustripExit, "menustripExit");
            this.menustripExit.Click += new System.EventHandler(this.menustripExit_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menustripBI;
        private System.Windows.Forms.ToolStripMenuItem menustripSS;
        private System.Windows.Forms.ToolStripMenuItem menustripExit;
        private System.Windows.Forms.ToolStripMenuItem menustripIQ;
        private System.Windows.Forms.ToolStripMenuItem menustripSI;
        private System.Windows.Forms.ToolStripMenuItem menustripSSS;
    }
}

