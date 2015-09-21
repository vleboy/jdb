using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using jdb.ComClass;
namespace jdb.Map._03芳邻
{
    public partial class map_fl_grid_1 : Form
    {
        public map_fl_grid_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void map_fl_grid_1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            button1.Tag = "3-GridNum-1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Button)sender;
            string[] cmd = x.Tag.ToString().Split('-');
            commUse.ShowForm(cmd[1], this.main, cmd);
        }
    }
}
