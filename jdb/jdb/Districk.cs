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
    public partial class Districk : Form
    {
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        public Districk()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true);

            InitializeComponent(); 
        }

        private void Districk_Load(object sender, EventArgs e)
        {

           this .WindowState = FormWindowState.Maximized;
          
            this.ControlBox = false; //最大化，最小化和关闭按钮及icon均无


            laYardValue.Text = db.GetSingleObject("SELECT COUNT(id) FROM block").ToString();
            laFamilyValue.Text = db.GetSingleObject("SELECT COUNT(residentaddresss.`host`) FROM residentaddresss WHERE residentaddresss.`host` = 1").ToString();
            laCommunityPopulationValue.Text = db.GetSingleObject("SELECT COUNT(population.`name`) FROM population").ToString();
            laFamilyPopulationValue.Text = db.GetSingleObject("SELECT count(resident.id) FROM resident").ToString();
            laMobilePopulationValue.Text = (Convert.ToUInt16(laCommunityPopulationValue.Text) - Convert.ToUInt16(laFamilyPopulationValue.Text)).ToString();
            laCommunistValue.Text = db.GetSingleObject("SELECT count(population.educational) FROM population WHERE population.educational = '党员'").ToString();
            laOlderValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.old IS NOT NULL").ToString();
            laAloneOlderValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.old_alone = 1 ").ToString();
            laHandicappedValue.Text = db.GetSingleObject("SELECT count(handicapped.id) FROM handicapped").ToString();
            laMentalValue.Text = db.GetSingleObject("SELECT count(handicapped.id) FROM handicapped WHERE handicapped.handicapped_type = '0'").ToString();
            laEmphasisValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.vip IS NOT NULL").ToString();
            laForeignerValue.Text = db.GetSingleObject("SELECT count(foreigner.id) FROM foreigner").ToString();
            laLowestFmailyValue.Text = db.GetSingleObject("SELECT Count(residentaddresss.`host`)" +
            "FROM poor INNER JOIN features ON features.poor = poor.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE poor.poorid IS NOT NULL").ToString();
            laLowestPeopleValue.Text = db.GetSingleObject("SELECT count(poor.id) FROM poor").ToString();
            laCleanerValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.cleaner IS NOT NULL").ToString();
            laPriorityValue.Text = db.GetSingleObject("SELECT count(poor.id) FROM poor").ToString();
            laUnemploymentValue.Text = db.GetSingleObject("SELECT Count(unjob.id) FROM unjob").ToString();
            laDopeValue.Text = db.GetSingleObject("SELECT Count(dope.id) FROM dope").ToString();
            laCorrectValue.Text = db.GetSingleObject("SELECT Count(correction.id) FROM correction").ToString();
            laReleaseValue.Text = db.GetSingleObject("SELECT Count(released.id) FROM released").ToString();


        }

        private void laCTL_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { "1" };
            commUse.ShowForm(x.Tag.ToString(), this.main,s);
        }

        private void laQTL_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { "2" };
            commUse.ShowForm(x.Tag.ToString(), this.main,s );
        }

        private void laFLL_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { "3" };
            commUse.ShowForm(x.Tag.ToString(), this.main, s);
        }

        private void laSXQ_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { "4" };
            commUse.ShowForm(x.Tag.ToString(), this.main, s);
        }

        private void laCommunityPopulationTitle_Click(object sender, EventArgs e)
        {

        }
        private void laClick_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Label)sender;
            string[] s = { "0", "0","0","0",x.Tag.ToString()};
            commUse.ShowForm("ppm", this.main, s);
        }
    }
}
