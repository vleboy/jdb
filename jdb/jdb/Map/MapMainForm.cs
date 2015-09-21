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

namespace jdb.Map
{
    public partial class MapMainForm : Form
    {
        public MapMainForm()
        {
            InitializeComponent();
        }

        private void MapMainForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            mytm1.Parent = pictureBox1;
            mytm2.Parent = pictureBox1;
            mytm3.Parent = pictureBox1;
            mytm4.Parent = pictureBox1;

          



        }

        private void mytm1_Click(object sender, EventArgs e)
        {
           
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
            commUse.ShowForm(x.Tag.ToString(), this.main,null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
