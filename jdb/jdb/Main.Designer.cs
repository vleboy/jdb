namespace jdb
{
    partial class Main
    {
        public bool qx = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理员登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地图模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员登陆ToolStripMenuItem,
            this.显示模式ToolStripMenuItem,
            this.人员管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理员登陆ToolStripMenuItem
            // 
            this.管理员登陆ToolStripMenuItem.Name = "管理员登陆ToolStripMenuItem";
            this.管理员登陆ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.管理员登陆ToolStripMenuItem.Text = "管理员登陆";
            this.管理员登陆ToolStripMenuItem.Click += new System.EventHandler(this.管理员登陆ToolStripMenuItem_Click);
            // 
            // 显示模式ToolStripMenuItem
            // 
            this.显示模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列表模式ToolStripMenuItem,
            this.地图模式ToolStripMenuItem});
            this.显示模式ToolStripMenuItem.Name = "显示模式ToolStripMenuItem";
            this.显示模式ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.显示模式ToolStripMenuItem.Text = "显示模式";
            // 
            // 列表模式ToolStripMenuItem
            // 
            this.列表模式ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.列表模式ToolStripMenuItem.Name = "列表模式ToolStripMenuItem";
            this.列表模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.列表模式ToolStripMenuItem.Tag = "list";
            this.列表模式ToolStripMenuItem.Text = "列表模式";
            this.列表模式ToolStripMenuItem.Click += new System.EventHandler(this.列表模式ToolStripMenuItem_Click);
            // 
            // 地图模式ToolStripMenuItem
            // 
            this.地图模式ToolStripMenuItem.Name = "地图模式ToolStripMenuItem";
            this.地图模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.地图模式ToolStripMenuItem.Tag = "map";
            this.地图模式ToolStripMenuItem.Text = "地图模式";
            this.地图模式ToolStripMenuItem.Click += new System.EventHandler(this.地图模式ToolStripMenuItem_Click);
            // 
            // 人员管理ToolStripMenuItem
            // 
            this.人员管理ToolStripMenuItem.Name = "人员管理ToolStripMenuItem";
            this.人员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.人员管理ToolStripMenuItem.Tag = "rygl";
            this.人员管理ToolStripMenuItem.Text = "人员管理";
            this.人员管理ToolStripMenuItem.Visible = false;
            this.人员管理ToolStripMenuItem.Click += new System.EventHandler(this.人员管理ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "list";
            this.Text = "社会智能管理数据系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理员登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地图模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员管理ToolStripMenuItem;
    }
}

