using jdb.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jdb
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 列表模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;

            commUse.ShowForm(x.Tag.ToString(), this,null);
        }

        private void 地图模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;

            commUse.ShowForm(x.Tag.ToString(), this,null);
        }
        protected override CreateParams CreateParams

        {

            get

            {

                CreateParams cp = base.CreateParams;

                cp.ExStyle |= 0x02000000;

                return cp;

            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            CommonUse commUse = new CommonUse();
            var x = (Form)sender;
            commUse.ShowForm(x.Tag.ToString(), this,null);

        }

        private void 管理员登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login SubForm = new Login();
            SubForm.ChangeTextVal += new DelegateChangeTextVal(ChangeTextVal);
            SubForm.ShowDialog();

        }
        public void ChangeTextVal(string TextVal)
        {
            if (TextVal == "1")
            {
                this.qx = true;
                this.人员管理ToolStripMenuItem.Visible = true;
            }; 
            
        }

        private void 人员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;
            string[] s = {"0","0","0","0",null };
            commUse.ShowForm("ppm", this,s);
        }
    }
}
