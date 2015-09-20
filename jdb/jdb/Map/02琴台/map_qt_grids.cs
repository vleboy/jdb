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

namespace jdb.Map._02琴台
{
    public partial class map_qt_grids : Form
    {
        public map_qt_grids()
        {
            InitializeComponent();
        }

        private void map_qt_grids_Load(object sender, EventArgs e)
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

            mytm1.Tag = "qt_blocks_1";
            mytm2.Tag = "qt_blocks_2";
            mytm3.Tag = "qt_blocks_3";
            mytm4.Tag = "qt_blocks_4";
            mytm5.Tag = "qt_blocks_5";
            mytm6.Tag = "qt_blocks_6";
            mytm7.Tag = "qt_blocks_7";
            mytm8.Tag = "qt_blocks_8";
            mytm9.Tag = "qt_blocks_9";
            mytm10.Tag = "qt_blocks_10";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Button)sender;
            string[] s = { "2" };
            commUse.ShowForm(x.Tag.ToString(), this.main, s);
        }
        private void mytm_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (mytm)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }
    }
}
