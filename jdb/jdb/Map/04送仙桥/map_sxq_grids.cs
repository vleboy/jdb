using jdb.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using TM;

namespace jdb.Map._04送仙桥
{
    public partial class map_sxq_grids : Form
    {
        public map_sxq_grids()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void map_sxq_grids_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            mytm1.Parent = pictureBox1;
            mytm2.Parent = pictureBox1;
            mytm3.Parent = pictureBox1;
            mytm4.Parent = pictureBox1;
            mytm5.Parent = pictureBox1;
            mytm6.Parent = pictureBox1;
            mytm7.Parent = pictureBox1;
            mytm8.Parent = pictureBox1;
            mytm9.Parent = pictureBox1;
            mytm10.Parent = pictureBox1;
            mytm1.Tag = "sxq_blocks_1";
            mytm2.Tag = "sxq_blocks_2";
            mytm3.Tag = "sxq_blocks_3";
            mytm4.Tag = "sxq_blocks_4";
            mytm5.Tag = "sxq_blocks_5";
            mytm6.Tag = "sxq_blocks_6";
            mytm7.Tag = "sxq_blocks_7";
            mytm8.Tag = "sxq_blocks_8";
            mytm9.Tag = "sxq_blocks_9";
            mytm10.Tag = "sxq_blocks_10";
        }
        private void mytm_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (mytm)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Button)sender;
            string[] s = { "4" };
            commUse.ShowForm(x.Tag.ToString(), this.main, s);
        }
    }
}
