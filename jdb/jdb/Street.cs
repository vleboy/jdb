using jdb.dataClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jdb.ComClass
{
    public partial class Street : Form
    {
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        public Street()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Street_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
           string cmd =  "SELECT block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = " + this.grid;
           string block = db.GetSingleObject(cmd).ToString() ;
            this.block = (Convert.ToInt16(this.block) - 1 + Convert.ToInt16(block)).ToString();
        }

        private void laClick_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { this.district, this.grid, this.block, "0", x.Tag.ToString() };
            commUse.ShowForm("ppm", this.main, s);
        }
    }
}
