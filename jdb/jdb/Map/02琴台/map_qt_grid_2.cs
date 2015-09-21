using jdb.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace jdb.Map._02琴台
{
    public partial class map_qt_grid_2 : Form
    {
        public map_qt_grid_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void map_qt_grid_2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            button1.Tag = "2-GridNum-2";
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
