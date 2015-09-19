using jdb.ComClass;
using jdb.dataClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jdb
{
    public partial class Grids : Form
    {
        private float nowFontSize =24;
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;



        public Grids()
        {

           

            InitializeComponent();
            
        }

        protected override void WndProc(ref Message m)

        {

            if (m.Msg == 0x0014) // 禁掉清除背景消息

                return;

            base.WndProc(ref m);

        }


        private void addGrids()
        {
            char s = '①';
            List<string> cmd = new List<string>();
            for (int i = 0; i < Convert.ToUInt16(this.grid); i++)
            {
                Label label = new Label();
                label.Font = new System.Drawing.Font("微软雅黑", nowFontSize);
                label.AutoSize = true;
                label.BorderStyle = BorderStyle.None;
                label.Text = ((char)(s +  i)).ToString();
                label.Tag =this.district+"-GridNum-"+(i+1).ToString();
                flowLayoutPanel1.Controls.Add(label);
                label.Click += new EventHandler(GridsClick);
                
            }
        }
        void GridsClick (object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] cmd = x.Tag.ToString().Split('-');
            commUse.ShowForm(cmd[1], this.main,cmd );
        }
        private void Grids_Load(object sender, EventArgs e)
        {
            int d = Convert.ToInt16(this.district);
            int g = Convert.ToInt16(this.grid);
            int b = Convert.ToInt16((this.block is string) ? block.ToString() : "0");
            this.ControlBox = false;
            this.laTitle.Text = db.GetSingleObject("SELECT district.`name` FROM district WHERE district.id = " + this.district) + "网络汇总表";
            addGrids();

            laDwsjValue.Text = db.GetSingleObject("SELECT gridmanager.secretary FROM gridmanager WHERE gridmanager.id = " + this.district).ToString();
            laJwhzrValue.Text = db.GetSingleObject("SELECT gridmanager.director FROM gridmanager WHERE gridmanager.id = " + this.district).ToString();
            laDwsjTelValue.Text = db.GetSingleObject("SELECT gridmanager.secretary_code FROM gridmanager WHERE gridmanager.id = " + this.district).ToString();
            laJwhzrTelValue.Text = db.GetSingleObject("SELECT gridmanager.director_code FROM gridmanager WHERE gridmanager.id = " + this.district).ToString();
            laDwsjPhoneValue.Text = db.GetSingleObject("SELECT gridmanager.secretary_phone FROM gridmanager WHERE gridmanager.id = " + this.district).ToString();
            laJwhzrPhoneValue.Text = db.GetSingleObject("SELECT gridmanager.director_phone FROM gridmanager WHERE gridmanager.id = " + this.district).ToString();
           
            laYardValue.Text = db.GetSingleObject("SELECT Count(population.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE district.id = " + this.district).ToString();
            laFamilyValue.Text = db.GetSingleObject("SELECT Count(population.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE residentaddresss.`host` = '1' AND district.id = " + this.district).ToString();
            laCommunityPopulationValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE district.id = " + this.district).ToString();
            laFamilyPopulationValue.Text = db.GetSingleObject("SELECT Count(resident.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id WHERE district.id = " + this.district).ToString();
            laMobilePopulationValue.Text = (Convert.ToUInt16(laCommunityPopulationValue.Text) - Convert.ToUInt16(laFamilyPopulationValue.Text)).ToString();
         
            laCommunistValue.Text = db.GetSingleObject("SELECT Count(population.educational) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE district.id = " + this.district + " AND population.educational = '党员'").ToString();
            laOlderValue.Text = db.GetSingleObject("SELECT Count(features.old) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE district.id =" + this.district).ToString();
            laAloneOlderValue.Text = db.GetSingleObject("SELECT Count(features.old_alone) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE " + this.district + " AND features.old_alone = '1'").ToString();
            laHandicappedValue.Text = db.GetSingleObject("SELECT Count(handicapped.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE district.id = " + this.district).ToString();
            laMentalValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE district.id = " + this.district + " AND handicapped.handicapped_type = 0").ToString();
            laEmphasisValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE district.id = " + this.district).ToString();
            laForeignerValue.Text = db.GetSingleObject("SELECT count(foreigner.id) FROM foreigner").ToString();
            laLowestFmailyValue.Text = db.GetSingleObject("SELECT Count(residentaddresss.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE district.id = " + this.district).ToString();
            laLowestPeopleValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE district.id = " + this.district).ToString();
            laCleanerValue.Text = db.GetSingleObject("SELECT Count(features.cleaner) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE district.id = " + this.district + " AND features.cleaner = '1'").ToString();
            laPriorityValue.Text = db.GetSingleObject("SELECT Count(features.vip) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE district.id = " + this.district + " AND features.vip = '1'").ToString();
            laUnemploymentValue.Text = db.GetSingleObject("SELECT Count(unjob.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN unjob ON features.unjob = unjob.id WHERE district.id = " + this.district).ToString();
            laDopeValue.Text = db.GetSingleObject("SELECT Count(dope.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN dope ON features.dope = dope.id WHERE district.id = " + this.district).ToString();
            laCorrectValue.Text = db.GetSingleObject("SELECT Count(correction.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN correction ON features.correction = correction.id WHERE district.id = " + this.district).ToString();
            laReleaseValue.Text = db.GetSingleObject("SELECT Count(released.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN released ON features.released = released.id WHERE district.id = " + this.district).ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.HorizontalScroll.Visible || flowLayoutPanel1.VerticalScroll.Visible)
            {
                nowFontSize -= 1;
                foreach (var label in flowLayoutPanel1.Controls)
                {
                    var lbl = label as Label;
                    if (lbl != null)
                    {
                        Font font = lbl.Font;
                        lbl.Font = new Font(font.FontFamily, nowFontSize);
                    }
                }
            }
        }

        private void laClick_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { this.district, "0", "0", "0", x.Tag.ToString() };
            commUse.ShowForm("ppm", this.main, s);
        }
    }
}
