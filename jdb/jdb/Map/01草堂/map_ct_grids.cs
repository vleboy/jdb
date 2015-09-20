using jdb.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM;

namespace jdb.Map._01草堂
{
    public partial class map_ct_grids : Form
    {
        public map_ct_grids()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void map_ct_grids_Load(object sender, EventArgs e)
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

            mytm1.Tag = "ct_blocks_1";
            mytm2.Tag = "ct_blocks_2";
            mytm3.Tag = "ct_blocks_3";
            mytm4.Tag = "ct_blocks_4";
            mytm5.Tag = "ct_blocks_5";
            mytm6.Tag = "ct_blocks_6";
            mytm7.Tag = "ct_blocks_7";
            mytm8.Tag = "ct_blocks_8";
            mytm9.Tag = "ct_blocks_9";
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
            string[] s = { "1" };
            commUse.ShowForm(x.Tag.ToString(), this.main, s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
