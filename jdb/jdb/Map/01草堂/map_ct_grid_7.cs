﻿using jdb.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jdb.Map._01草堂
{
    public partial class map_ct_grid_7 : Form
    {
        public map_ct_grid_7()
        {
            InitializeComponent();
        }

        private void map_ct_grid_7_Load(object sender, EventArgs e)
        {
            button1.Tag = "1-GridNum-7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Button)sender;
            string[] cmd = x.Tag.ToString().Split('-');
            commUse.ShowForm(cmd[1], this.main, cmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
