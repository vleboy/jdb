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

using System.Windows.Forms;

namespace jdb
{
    public partial class Blocks : Form
    {
        private float nowFontSize = 24;
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        private string gridid = null;//(Convert.ToInt16(this.grid) + 10 * (Convert.ToInt16(this.district)) - 10).ToString();
        public Blocks()
        {
            InitializeComponent();
        }

        private void Blocks_Load(object sender, EventArgs e)
        {
            gridid = (Convert.ToInt16(this.grid) +( -1*((Convert.ToInt16(this.district)-1) > 0 ?1:0 )) + (10 * (Convert.ToInt16(this.district))) - 10).ToString();
            this.grid = gridid;
            string s = null;
            this.ControlBox = false;
            s = s + db.GetSingleObject("SELECT grid.`name` FROM grid INNER JOIN district ON grid.district = district.id WHERE district.id = "+this.district+" AND grid.id = " + gridid);
            this.laTitle.Text = s+"汇总表";
            addGrids();
            laResponsibleValue.Text = db.GetSingleObject("SELECT blockmanager.manager FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.id = " + gridid).ToString();
            laPoliceValue.Text = db.GetSingleObject("SELECT blockmanager.police FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.id = " + gridid).ToString();
            laResponsibleTelValue.Text = db.GetSingleObject("SELECT blockmanager.manager_code FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.id = " + gridid).ToString();
            laPolicePhoneValue.Text = db.GetSingleObject("SELECT blockmanager.police_phone FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.id = " + gridid ).ToString();
            laResponsiblePhoneValue.Text = db.GetSingleObject("SELECT blockmanager.manager_phone FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE  grid.id = " + gridid).ToString();


            laYardValue.Text = db.GetSingleObject("SELECT Count(population.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE grid.id = " + gridid).ToString();
            laFamilyValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE residentaddresss.`host` = '1' AND grid.id = " + gridid).ToString();
            laCommunityPopulationValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE grid.id = " + gridid).ToString();
            laFamilyPopulationValue.Text = db.GetSingleObject("SELECT Count(resident.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id WHERE grid.id = " + gridid).ToString();
            laMobilePopulationValue.Text = (Convert.ToUInt16(laCommunityPopulationValue.Text) - Convert.ToUInt16(laFamilyPopulationValue.Text)).ToString();
            laCommunistValue.Text = db.GetSingleObject("SELECT Count(population.educational) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE grid.id ="+gridid+" AND population.educational = '党员'").ToString();
            laOlderValue.Text = db.GetSingleObject("SELECT Count(features.old) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE grid.id = " + gridid).ToString();
            laAloneOlderValue.Text = db.GetSingleObject("SELECT Count(features.old_alone) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE grid.id = " + gridid +" AND features.old_alone = '1'").ToString();
            laHandicappedValue.Text = db.GetSingleObject("SELECT Count(handicapped.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE grid.id = " + gridid).ToString();
            laMentalValue.Text = db.GetSingleObject("SELECT Count(handicapped.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE  grid.id = " + gridid + " AND handicapped.handicapped_type = 0").ToString();
            laEmphasisValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE grid.id = " + gridid).ToString();
            laForeignerValue.Text = db.GetSingleObject("SELECT count(foreigner.id) FROM foreigner").ToString();
            laLowestFmailyValue.Text = db.GetSingleObject("SELECT Count(residentaddresss.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE grid.id = " + gridid).ToString();
            laLowestPeopleValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE grid.id = " + gridid).ToString();
            laCleanerValue.Text = db.GetSingleObject("SELECT Count(features.cleaner) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE  grid.id = " + gridid + " AND features.cleaner = '1'").ToString();
            laPriorityValue.Text = db.GetSingleObject("SELECT Count(features.vip) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE grid.id = " + gridid + " AND features.vip = '1'").ToString();
            laUnemploymentValue.Text = db.GetSingleObject("SELECT Count(unjob.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN unjob ON features.unjob = unjob.id WHERE grid.id = " + gridid).ToString();
            laDopeValue.Text = db.GetSingleObject("SELECT Count(dope.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN dope ON features.dope = dope.id WHERE grid.id = " + gridid).ToString();
            laCorrectValue.Text = db.GetSingleObject("SELECT Count(correction.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN correction ON features.correction = correction.id WHERE grid.id = " + gridid).ToString();
            laReleaseValue.Text = db.GetSingleObject("SELECT Count(released.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN released ON features.released = released.id WHERE grid.id = " + gridid).ToString();


        }
        private void addGrids()
        {
            List<string> l = new List<string>();
            string s = "SELECT block.`name` FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id WHERE district.id = " + this.district + " AND grid.`id` =" + gridid; 
            sdr = db.GetDataReader(s);
            while (sdr.Read())
            {
                l.Add(sdr[0].ToString());
            }
            sdr.Close();
          for (int i = 0; i < l.Count; i++)
            {

                Label label = new Label();
                label.Font = new System.Drawing.Font("微软雅黑", nowFontSize);
                label.AutoSize = true;
                label.BorderStyle = BorderStyle.None;
                label.Text = l[i];
                label.Tag = this.district + "-GridsNum-" + gridid + "-BlockNum-" + (i+1).ToString();
                flowLayoutPanel1.Controls.Add(label);
                label.Click += new EventHandler(BlocksClick);
            }
        }
        void BlocksClick(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] cmd = x.Tag.ToString().Split('-');
            commUse.ShowForm(cmd[3], this.main, cmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        private void laClick_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { this.district, this.grid, "0", "0", x.Tag.ToString() };
            commUse.ShowForm("ppm", this.main, s);
        }
    }
}
