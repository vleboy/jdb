using jdb.ComClass;
using jdb.dataClass;
using jdb.sundries;
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
    public partial class addusr : Form
    {
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
        MySqlDataReader sdr;
        private int feature = 0;
       

        public addusr()
        {
            InitializeComponent();
        }

        private void addusr_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            sdr = db.GetDataReader("SELECT district.`name`,district.`id` FROM district");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sdr.Close();
            cb_district.DataSource = items;
               items.Clear();
          

            sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sdr.Close();
            cb_grid.DataSource = items;
              items.Clear();
           
            sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sdr.Close();
            cb_block.DataSource = items;
              items.Clear();
           
            sdr = db.GetDataReader("SELECT street.streetName, street.streetId FROM block INNER JOIN street ON street.blockId = block.id WHERE block.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            
            sdr.Close();
            cb_street.DataSource = items;
            items.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_czrk_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_czrk.Checked)
            {
                feature += 1;
                cb_photo.Enabled = true;
                cb_hzzz.Enabled = true;
               
                tb_mz.Enabled = true;
                tb_xjdz.Enabled = true;
                tb_yhzgx.Enabled = true;
                dtp_jlsj.Enabled = true;
                dtp_qfrq.Enabled = true;
            }
            else
            {
                feature -= 1;
                cb_photo.Enabled = false;
                cb_hzzz.Enabled = false;
                
                tb_mz.Enabled = false;
                tb_xjdz.Enabled = false;
                tb_yhzgx.Enabled = false;
                dtp_jlsj.Enabled = false;
                dtp_qfrq.Enabled = false;
            }
        }

        private void cb_handicapped_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_handicapped.Checked)
            {
                feature += 1;
                cb_feature.Enabled = true;
              
                tb_cjz.Enabled = true;
                tb_dj.Enabled = true;
                tb_jkr.Enabled = true;
                tb_gx.Enabled = true;

            }
            else
            {
                feature -= 1;
                cb_feature.Enabled = false;
               
                tb_cjz.Enabled = false;
                tb_dj.Enabled = false;
                tb_jkr.Enabled = false;
                tb_gx.Enabled = false;
            }
        }

        private void cb_jwry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_jwry.Checked)
            {
                feature += 1;
                jwry_czjwr_cb.Enabled = true;
                jwry_f_cb.Enabled = true;
                jwry_gj_tb.Enabled = true;
                jwry_jdr_tb.Enabled = true;
                jwry_lksj_dtp.Enabled = true;
                jwry_lxrdh_tb.Enabled = true;
                jwry_lxr_tb.Enabled = true;
                jwry_qzlx_tb.Enabled = true;
                jwry_zjhm_tb.Enabled = true;
                jwry_qzyxq_dtp.Enabled = true;
                jwry_zjyxq_dtp.Enabled = true;

            }
            else
            {
                feature -= 1;
                jwry_czjwr_cb.Enabled = false;
                jwry_f_cb.Enabled = false;
                jwry_gj_tb.Enabled = false;
                jwry_jdr_tb.Enabled = false;
                jwry_lksj_dtp.Enabled = false;
                jwry_lxrdh_tb.Enabled = false;
                jwry_lxr_tb.Enabled = false;
                jwry_qzlx_tb.Enabled = false;
                jwry_zjhm_tb.Enabled = false;
                jwry_qzyxq_dtp.Enabled = false;
                jwry_zjyxq_dtp.Enabled = false;
            }
        }

        private void cb_dbry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dbry.Checked)
            {
                feature += 1;
                dbry_id_tb.Enabled = true;

            }
            else
            {
                feature -= 1;
                dbry_id_tb.Enabled = false;
            }
        }

        private void cb_xfsfry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_xfsfry.Checked)
            {
                feature += 1;
                xmsfry_zxqz_dtp.Enabled = true;
                xmsfry_fxjyhdq_tb.Enabled = true;
                xmsfry_sfsj_dtp.Enabled = true;
                xmsfry_zm_tb.Enabled = true;
                xmsfry_zxqq_dtp.Enabled = true;


            }
            else
            {
                feature -= 1;
                xmsfry_zxqz_dtp.Enabled = false;
                xmsfry_fxjyhdq_tb.Enabled = false;
                xmsfry_sfsj_dtp.Enabled = false;
                xmsfry_zm_tb.Enabled = false;
                xmsfry_zxqq_dtp.Enabled = false;
            }
        }

        private void cb_jzry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_jzry.Checked)
            {
                feature += 1;
                jzry_fzlx_tb.Enabled = true;
                jzry_jxjy_tb.Enabled = true;
                jzry_jzlb_tb.Enabled = true;
                jzry_jzqe_dtp.Enabled = true;
                jzry_jzqs.Enabled = true;
                jzry_jzqs_dtp.Enabled = true;
                jzry_ypxq.Enabled = true;
                jzry_zm_tb.Enabled = true;


            }
            else
            {
                feature -= 1;
                jzry_fzlx_tb.Enabled = false;
                jzry_jxjy_tb.Enabled = false;
                jzry_jzlb_tb.Enabled = false;
                jzry_jzqe_dtp.Enabled = false;
                jzry_jzqs.Enabled = false;
                jzry_jzqs_dtp.Enabled = false;
                jzry_ypxq.Enabled = false;
                jzry_zm_tb.Enabled = false;
            }
        }

        private void cb_xdry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_xdry.Checked)
            {
                feature += 1;
                xdry_ccfxrq_dtp.Enabled = true;
                xdry_dplb_tb.Enabled = true;
                xdry_hjpcs_tb.Enabled = true;
                xdry_ryxz_tb.Enabled = true;
            }
            else
            {
                feature -= 1;
                xdry_ccfxrq_dtp.Enabled = false;
                xdry_dplb_tb.Enabled = false;
                xdry_hjpcs_tb.Enabled = false;
                xdry_ryxz_tb.Enabled = false;
            }
        }

        private void cb_unjob_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_unjob.Checked)
            {
                feature += 1;
                unjob_firstmonth_dtp.Enabled = true;
                unjob_id_tb.Enabled = true;
                unjob_job.Enabled = true;
                unjob_time.Enabled = true;
                unjob_time_Title.Enabled = true;
            }
            else
            {
                feature -= 1;
                unjob_firstmonth_dtp.Enabled = false;
                unjob_id_tb.Enabled = false;
                unjob_job.Enabled = false;
                unjob_time.Enabled = false;
                unjob_time_Title.Enabled = false;
            }
        }
        private string rebool(string str1, string str2)
        {
            string bools = string.Empty;
            return bools = (str1 == str2) ? "1" : "0";
        }
        private void save_Click(object sender, EventArgs e)
        {
            string sid = string.Empty;
            string strcmd = string.Empty;
            string strform = " INSERT INTO `features` (";
            string strobj = ") VALUES(";
            Dictionary<string, string> fid = new Dictionary<string, string>();
            List<string> l_strform = new List<string>();
            List<string> l_strobj = new List<string>();
            if (feature != 0)
            {
                if (cb_czrk.Checked)
                {
                    if (tb_xjdz.Text.Trim() != "")//添加常住地址
                    {

                        strcmd = "INSERT INTO `residentaddresss` (`address`, `host`, `relationship`) VALUES ('" +
                            tb_xjdz.Text.Trim() + "','" + rebool(cb_hzzz.SelectedItem.ToString(), "是") + "', '" + tb_yhzgx.Text.Trim() + "')" + ";select @@identity AS id";
                        var id = db.GetSingleObject(strcmd);
                        sid = id.ToString();

                    }
                    //常住人员特性添加
                    strcmd = "INSERT INTO `resident` (`ethnic`, `now_date`, `registration_date`, `photo`,  `resident_addresss`) VALUES ('" +
                        tb_mz.Text.Trim() + "', '" + dtp_jlsj.Text.ToString() + "', '" + dtp_qfrq.Text.ToString() + "', '" + rebool(cb_photo.Checked.ToString(), "True") + "', '" +
                       sid + "')" + "; select @@identity AS id";
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("resident", sid);
                }
                //残疾人特性添加
                if (cb_handicapped.Checked)
                {
                    strcmd = "INSERT INTO `handicapped` ( `handicapped_id`, `handicapped_type`, `handicapped_level`, `guardian_name`, `guardian_relationship`) VALUES ('" + tb_cjz.Text.Trim() + "', '" + rebool(cb_feature.SelectedItem.ToString(), "肢体") + "', '" + tb_dj.Text.Trim() + "', '" + tb_jkr.Text.Trim() + "', '" + tb_gx.Text.Trim() + "')" + "; select @@identity AS id"; ;
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("handicapped", sid);
                }
                //境外人员添加
                if (cb_jwry.Checked)
                {
                    strcmd = "INSERT INTO `foreigner` (`citizenship`, `card_id`, `card_date`, `card_type`, "
                        + "`house_belongs`, `registration_date`, `contact`, `associates`, `associates_phone`, `isforever`, `leave_date`) VALUES ('" +
                       jwry_gj_tb.Text.Trim() + "', '" + jwry_zjhm_tb.Text.Trim() + "', '" + jwry_zjyxq_dtp.Text.ToString() + "', '" + jwry_qzlx_tb.Text.Trim() + "', '" +
                       jwry_f_cb.SelectedItem.ToString() + "', '" + jwry_qzyxq_dtp.Text.ToString() + "', '" + jwry_jdr_tb.Text.Trim() + "', '" + jwry_lxr_tb.Text.Trim() + "', '" +
                       jwry_lxrdh_tb.Text.Trim() + "', '" + rebool(jwry_czjwr_cb.Checked.ToString(), "True") + "', '" + jwry_lksj_dtp.Text.ToString() + "')" + "; select @@identity AS id";
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("foreigner", sid);
                }
                //低保人员添加
                if (cb_dbry.Checked)
                {
                    strcmd = "INSERT INTO `poor` (`poorid`) VALUES ('" + dbry_id_tb.Text.Trim() + "')" + "; select @@identity AS id"; ;
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("poor", sid);
                }

                //校正人员添加
                if (cb_jzry.Checked)
                {
                    strcmd = "INSERT INTO `correction` (`criminal`, `criminal_type`, `criminal_period`, `correction_firstdate`, `correction_enddate`, `correction_type`, `school_or_job`) VALUES ('" +
                        jzry_zm_tb.Text.Trim() + "', '" + jzry_fzlx_tb.Text.Trim() + "', '" + jzry_ypxq.Text.Trim() + "', '" + jzry_jzqs_dtp.Text.ToString() + "', '" + jzry_jzqe_dtp.Text.ToString() + "', '" +
                        jzry_jzlb_tb.Text.Trim() + "', '" + jzry_jxjy_tb.Text.Trim() + "')" + "; select @@identity AS id";
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("correction", sid);
                }
                //刑满释放人员添加
                if (cb_xfsfry.Checked)
                {
                    strcmd = "INSERT INTO `released` (`criminal`, `criminal_start_date`, `criminal_end_date`, `prison_address`, `free_date`) VALUES ('" +
                        xmsfry_zm_tb.Text.Trim() + "', '" + xmsfry_zxqq_dtp.Text.ToString() + "', '" + xmsfry_zxqz_dtp.Text.ToString() + "', '" + xmsfry_fxjyhdq_tb.Text.Trim() + "', '" + xmsfry_sfsj_dtp.Text.ToString() + "')" + "; select @@identity AS id";
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("released", sid);
                }
                //吸毒人员添加
                if (cb_xdry.Checked)
                {
                    strcmd = "INSERT INTO `dope` (`police_address`, `first_date`, `dope_type`, `status`) VALUES ('" + xdry_hjpcs_tb.Text.Trim() + "', '" + xdry_ccfxrq_dtp.Text.ToString() + "', '" + xdry_dplb_tb.Text.Trim() + "', '" + xdry_ryxz_tb.Text.Trim() + "')" + "; select @@identity AS id";
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("dope", sid);
                }
                //失业人员添加
                if (cb_unjob.Checked)
                {
                    strcmd = "INSERT INTO `unjob` (`insurance_id`, `first_month`, `old_factory`, `already`) VALUES ('" + unjob_id_tb.Text.Trim() + "', '" + unjob_firstmonth_dtp.Text.ToString() + "', '" + unjob_job.Text.Trim() + "', '" + unjob_time.Text.Trim() + "')" + "; select @@identity AS id";
                    sid = db.GetSingleObject(strcmd).ToString();
                    fid.Add("unjob", sid);
                }
                if (cb_old.Checked)
                {
                    l_strform.Add("`old`");
                    l_strobj.Add("1");
                    if (cb_alone.Checked)
                    {
                        l_strform.Add("`old_alone`");
                        l_strobj.Add("1");
                    }
                }
                if (cb_clear.Checked)
                {
                    l_strform.Add("`cleaner`");
                    l_strobj.Add("1");
                }
                if (cb_vip.Checked)
                {
                    l_strform.Add("`vip`");
                    l_strobj.Add("1");

                }
                if (fid != null)
                {

                    foreach (var item in fid)
                    {
                        l_strform.Add("`" + item.Key + "`");
                        l_strobj.Add(item.Value);

                    }
                }
                string[] l_stoform = l_strform.ToArray();
                string[] l_stobj = l_strobj.ToArray();
                strform += string.Join(",", l_stoform);
                strobj += string.Join(",", l_stobj);

                strcmd = strform.TrimEnd(',') + strobj.TrimEnd(',');
                strcmd += ")" + "; select @@identity AS id";

                sid = db.GetSingleObject(strcmd).ToString();
            }

            item block = (item)cb_block.SelectedItem;
            if (sid == "" || sid == "0")
            {
                strcmd = "INSERT INTO `population` (`card_id`, `name`, `age`, `address`, `gender`, `census_address`, `block`, `note`, `educational`) VALUES('" + ryinfo_card_id.Text + "', '" + tb_names.Text + "', '" + ryinfo_age.Value.ToString() + "', '" + ryinfo_address.Text + "', '" + rebool(ryinfo_sex.SelectedItem.ToString(), "男") + "', '" + ryinfo_hjdz.Text + "', '" + block.Value + "', '" + ryinfo_note.Text + "', '" + ryinfo_edu.Text + "')" + "; select @@identity AS id";
            }
            else
            {
                strcmd = "INSERT INTO `population` (`card_id`, `name`, `age`, `address`, `gender`, `census_address`, `block`, `note`, `educational`,`features`) VALUES('" + ryinfo_card_id.Text + "', '" + tb_names.Text + "', '" + ryinfo_age.Value.ToString() + "', '" + ryinfo_address.Text + "', '" + rebool(ryinfo_sex.SelectedItem.ToString(), "男") + "', '" + ryinfo_hjdz.Text + "', '" + block.Value + "', '" + ryinfo_note.Text + "', '" + ryinfo_edu.Text + "','" + sid + "')" + "; select @@identity AS id";
            }


            sid = db.GetSingleObject(strcmd).ToString();

            if (ryxx_p1.Text != "")
            {
                strcmd = " INSERT INTO `phone` (`phonenumber`, `population`) VALUES('" + ryxx_p1.Text.Trim() + "', '" + sid + "')" + "; select @@identity AS id";
                db.GetSingleObject(strcmd).ToString();
            }
            if (ryxx_p2.Text != "")
            {
                strcmd = " INSERT INTO `phone` (`phonenumber`, `population`) VALUES('" + ryxx_p2.Text.Trim() + "', '" + sid + "')" + "; select @@identity AS id";
                db.GetSingleObject(strcmd).ToString();
            }
            if (ryxx_p3.Text != "")
            {
                strcmd = " INSERT INTO `phone` (`phonenumber`, `population`) VALUES('" + ryxx_p3.Text.Trim() + "', '" + sid + "')" + "; select @@identity AS id";
                db.GetSingleObject(strcmd).ToString();
            }
            MessageBox.Show("添加成功", "软件提示");
            feature = 0;
            this.Close();
        }

        private void cb_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            commUse.district_gird_block(cb_district, cb_grid, "district", "grid");
        }

        private void cb_grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            commUse.district_gird_block(cb_grid, cb_block, "grid", "block");
        }

        private void cb_block_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = null;
            List<item> items = new List<item>();
            if (cb_block.SelectedItem != null )
            {
                item it = (item)cb_block.SelectedItem;
                index = it.Value;
                sdr = db.GetDataReader("SELECT street.streetName , street.streetId FROM street INNER JOIN block ON street.blockId = block.id WHERE block.id = " + index);
                while (sdr.Read())
                {
                    item its = new item(sdr[0].ToString(), sdr[1].ToString());
                    items.Add(its);
                }
                sdr.Close();
                cb_street.DataSource = items;
            }
           


        }
    }
}
