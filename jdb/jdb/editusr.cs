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
    public partial class editusr : Form
    {
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
        MySqlDataReader sdr;
        private int feature = 0;
        public editusr()
        {
            InitializeComponent();
        }

        private void editusr_Load(object sender, EventArgs e)
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


            sdr = db.GetDataReader("SELECT population.card_id, population.`name`, population.age, population.address, population.gender, population.census_address, population.block, population.note, population.educational, population.features FROM population WHERE population.id = " + this.pid);
            var x = sdr.Read();
          //  for (int i = 0; i < sdr.FieldCount; i++)
            
                ryinfo_card_id.Text = sdr[0].ToString();
                tb_names.Text = sdr[1].ToString();
                int age = sdr[2].ToString() != "" ? Convert.ToUInt16(sdr[2].ToString()) :0;
                ryinfo_age.Value = (age );
                ryinfo_address.Text = sdr[3].ToString();
                ryinfo_sex.Text = sdr[4].ToString() == "True"?"男":"女";
                ryinfo_hjdz.Text = sdr[5].ToString();
                string blockid = sdr[6].ToString();
                ryinfo_note.Text = sdr[7].ToString();
                ryinfo_edu.Text = sdr[8].ToString();
                string featuresstr = sdr[9].ToString();
            sdr.Close();
            sdr = db.GetDataReader("SELECT phone.phonenumber FROM phone WHERE phone.population = " + this.pid);
            int i = 0;
            while (sdr.Read())
            {
                i++;
                switch (i)
                {
                    case 1:
                        {
                            if (sdr[0].ToString() != "")
                            {
                                ryxx_p1.Text = sdr[0].ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (sdr[0].ToString() != "")
                            {
                                ryxx_p2.Text = sdr[0].ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        {
                            if (sdr[0].ToString() != "")
                            {
                                ryxx_p3.Text = sdr[0].ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            //for (int i = 0; i < sdr.HasRows; i++)
            //{
                
            //    switch (i)
            //    {
            //        case 1:
            //            {
            //                if (sdr[0].ToString() != "")
            //                {
            //                    ryxx_p1.Text = sdr[0].ToString();
            //                }
            //                else
            //                {
            //                    break;
            //                }
            //            }
            //            break;
            //        case 2:
            //            {
            //                if (sdr != null)
            //                {
            //                    ryxx_p2.Text = sdr[0].ToString();
            //                }
            //                else
            //                {
            //                    break;
            //                }
            //            }
            //            break;
            //        case 3:
            //            {
            //                if (sdr != null)
            //                {
            //                    ryxx_p3.Text = sdr[0].ToString();
            //                }
            //                else
            //                {
            //                    break;
            //                }
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //}
            sdr.Close();
            
                
            

           string xx = db.GetSingleObject("SELECT district.`name` FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id WHERE block.id = "+blockid).ToString();
            cb_district.Text = xx;
            cb_grid.Text = db.GetSingleObject("SELECT grid.`name` FROM grid INNER JOIN block ON block.grid = grid.id WHERE block.id = "+blockid).ToString();
         
               cb_block.Text = db.GetSingleObject("SELECT block.`name` FROM block WHERE block.id = "+blockid).ToString();
            cb_street.Text = db.GetSingleObject("SELECT street.streetName FROM block INNER JOIN street ON street.blockId = block.id WHERE block.id = "+blockid).ToString();
            if (featuresstr != "0")
            {
              sdr =  db.GetDataReader("SELECT features.vip, features.cleaner, features.old, features.old_alone, features.poor, features.resident, features.handicapped, features.unjob, features.dope, features.foreigner, features.released, features.correction FROM features WHERE features.id =" + featuresstr);
              sdr.Read();
                string vipstr = sdr[0].ToString();
                string cleanerstr = sdr[1].ToString();
                string oldstr = sdr[2].ToString();
                string oldalonestr = sdr[3].ToString();
                string poorstr = sdr[4].ToString();
                string residentstr = sdr[5].ToString();
                string handicappedstr = sdr[6].ToString();
                string unjobstr = sdr[7].ToString();
                string dopestr = sdr[8].ToString();
                string foreignerstr = sdr[9].ToString();
                string releasedstr = sdr[10].ToString();
                string correctionstr = sdr[11].ToString();
                sdr.Close();
                if (vipstr == "True")
                {
                    cb_vip.Checked = true;
                }
                if (cleanerstr == "True")
                {
                    cb_clear.Checked = true;
                }
                if (oldstr == "True")
                {
                    cb_old.Checked = true;
                }
                if (oldalonestr == "True")
                {
                    cb_alone.Checked = true;
                    cb_alone.Enabled = true;
                }



                if (poorstr != "")
                {
                    cb_dbry.Checked = true;
                    cb_dbry.Enabled = true;
                    dbry_id_tb.Enabled = true;
                    dbry_id_tb.Text = db.GetSingleObject("SELECT poor.poorid FROM features INNER JOIN poor ON features.poor = poor.id WHERE features.id = " + featuresstr).ToString();
                }
                if (residentstr != "")
                {
                    cb_photo.Enabled = true; cb_hzzz.Enabled = true; tb_yhzgx.Enabled = true; tb_mz.Enabled = true; tb_xjdz.Enabled = true; dtp_jlsj.Enabled = true; dtp_qfrq.Enabled = true;
                    cb_czrk.Checked = true;
                    sdr = db.GetDataReader("SELECT resident.ethnic, resident.now_date, resident.registration_date, resident.photo, resident.resident_addresss FROM resident INNER JOIN features ON features.resident = resident.id WHERE features.id = " + featuresstr);
                    sdr.Read();
                    tb_mz.Text = sdr[0].ToString();
                    dtp_jlsj.Text = sdr[1].ToString();
                    dtp_qfrq.Text = sdr[2].ToString();
                    if (sdr[3].ToString() == "True")
                    {
                        cb_photo.Checked = true; // cb_photo.Checked = sdr[3].ToString();
                    }
                    string addd = sdr[4].ToString();
                    sdr.Close();
                    sdr = db.GetDataReader("SELECT residentaddresss.address, residentaddresss.`host`, residentaddresss.relationship FROM resident INNER JOIN features ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE features.id = "+featuresstr);
                    if (sdr.Read()) {
                        tb_xjdz.Text = sdr[0].ToString(); 
                    if (sdr[1].ToString() != "1")
                    {
                        cb_hzzz.Text = "否";
                    }
                    else
                    {
                        cb_hzzz.Text = "是";
                    }
                    tb_yhzgx.Text = sdr[2].ToString();
                    }
                    sdr.Close();
                }
                if (handicappedstr != "")
                {
                    cb_handicapped.Checked = true;
                    cb_feature.Enabled = true;tb_cjz.Enabled = true;tb_dj.Enabled = true;tb_jkr.Enabled = true;tb_gx.Enabled = true;
                    sdr = db.GetDataReader("SELECT  handicapped.handicapped_id, handicapped.handicapped_type, handicapped.handicapped_level, handicapped.guardian_name, handicapped.guardian_relationship FROM handicapped INNER JOIN features ON features.handicapped = handicapped.id WHERE features.id = " + featuresstr);
                    sdr.Read();
                    tb_cjz.Text = sdr[0].ToString();
                    cb_feature.Text =  sdr[1].ToString() == "1"?"肢体":"精神";
                    tb_dj.Text = sdr[2].ToString();
                    tb_jkr.Text = sdr[3].ToString();
                    tb_gx.Text = sdr[4].ToString();
                    sdr.Close();
                }
                if (unjobstr != "")
                {
                    cb_unjob.Checked = true;
                    unjob_id_tb.Enabled = true; unjob_firstmonth_dtp.Enabled = true; unjob_time.Enabled = true; unjob_job.Enabled = true;
                    sdr = db.GetDataReader("SELECT unjob.insurance_id, unjob.first_month, unjob.old_factory, unjob.already FROM features INNER JOIN unjob ON features.unjob = unjob.id WHERE features.id = "+featuresstr);
                    sdr.Read();
                    unjob_id_tb.Text = sdr[0].ToString();
                    unjob_firstmonth_dtp.Text = sdr[1].ToString();
                    unjob_job.Text = sdr[2].ToString();
                    unjob_time.Text = sdr[3].ToString();
                    sdr.Close();
                }
                if (dopestr != "")
                {
                    cb_xdry.Checked = true;
                    xdry_hjpcs_tb.Enabled = true;xdry_ccfxrq_dtp.Enabled = true;xdry_dplb_tb.Enabled = true;xdry_ryxz_tb.Enabled = true;
                    sdr = db.GetDataReader("SELECT dope.dope_type, dope.police_address, dope.first_date, dope.`status` FROM features INNER JOIN dope ON features.dope = dope.id WHERE features.id =  " + featuresstr);
                    sdr.Read();
                    xdry_dplb_tb.Text = sdr[0].ToString();
                    xdry_hjpcs_tb.Text = sdr[1].ToString();
                    xdry_ccfxrq_dtp.Text = sdr[2].ToString();
                    xdry_ryxz_tb.Text = sdr[3].ToString();
                    sdr.Close();
                }
                if (foreignerstr != "")
                {
                    cb_jwry.Checked = true;
                    jwry_gj_tb.Enabled = true; jwry_zjhm_tb.Enabled = true;jwry_zjyxq_dtp.Enabled = true;jwry_qzyxq_dtp.Enabled = true;jwry_lksj_dtp.Enabled = true;jwry_f_cb.Enabled = true;
                    jwry_czjwr_cb.Enabled = true;jwry_jdr_tb.Enabled = true;jwry_lxr_tb.Enabled = true;jwry_lxrdh_tb.Enabled = true;jwry_qzlx_tb.Enabled = true;
                    sdr = db.GetDataReader("SELECT foreigner.citizenship, foreigner.card_id, foreigner.card_date, foreigner.card_type, foreigner.house_belongs, foreigner.contact, foreigner.registration_date, foreigner.associates, foreigner.associates_phone, foreigner.isforever, foreigner.leave_date FROM features INNER JOIN foreigner ON features.foreigner = foreigner.id WHERE features.id =  " + featuresstr);
                    sdr.Read();
                    jwry_gj_tb.Text = sdr[0].ToString();
                    jwry_zjhm_tb.Text = sdr[1].ToString();
                    jwry_zjyxq_dtp.Text = sdr[2].ToString();
                    jwry_qzlx_tb.Text = sdr[3].ToString();
                    jwry_f_cb.Text = sdr[4].ToString();
                    jwry_jdr_tb.Text = sdr[5].ToString();
                    jwry_qzyxq_dtp.Text = sdr[6].ToString();
                    jwry_lxr_tb.Text = sdr[7].ToString();
                    jwry_lxrdh_tb.Text = sdr[8].ToString();
                    if (sdr[9].ToString() == "1")
                    {
                        jwry_czjwr_cb.Checked = true;
                    }
                    jwry_lksj_dtp.Text = sdr[10].ToString();
                    sdr.Close();
                }
                if (releasedstr != "")
                {
                    cb_xfsfry.Checked = true;
                    xmsfry_zm_tb.Enabled = true; xmsfry_zxqq_dtp.Enabled = true; xmsfry_zxqz_dtp.Enabled = true; xmsfry_sfsj_dtp.Enabled = true; xmsfry_fxjyhdq_tb.Enabled = true;
                    sdr = db.GetDataReader("SELECT released.criminal, released.criminal_start_date, released.criminal_end_date, released.prison_address, released.free_date FROM features INNER JOIN released ON features.released = released.id WHERE features.id =  " + featuresstr);
                    sdr.Read();
                    xmsfry_zm_tb.Text = sdr[0].ToString();
                    xmsfry_zxqq_dtp.Text = sdr[1].ToString();
                    xmsfry_zxqz_dtp.Text = sdr[2].ToString();
                    xmsfry_fxjyhdq_tb.Text = sdr[3].ToString();
                    xmsfry_sfsj_dtp.Text = sdr[4].ToString();
                    sdr.Close();
                }
                if (correctionstr != "")
                {
                    cb_jzry.Checked = true;
                    jzry_zm_tb.Enabled = true; jzry_fzlx_tb.Enabled = true; jzry_ypxq.Enabled = true; jzry_jzlb_tb.Enabled = true; jzry_jxjy_tb.Enabled = true; jzry_jzqs_dtp.Enabled = true; jzry_jzqe_dtp.Enabled = true;
                    sdr = db.GetDataReader("SELECT correction.criminal, correction.criminal_type, correction.criminal_period, correction.correction_firstdate, correction.correction_enddate, correction.correction_type, correction.school_or_job FROM features INNER JOIN correction ON features.correction = correction.id WHERE features.id =   " + featuresstr);
                    sdr.Read();
                    jzry_zm_tb.Text = sdr[0].ToString();
                    jzry_fzlx_tb.Text = sdr[1].ToString();
                    jzry_ypxq.Text = sdr[2].ToString();
                    jzry_jzqs_dtp.Text = sdr[3].ToString();
                    jzry_jzqe_dtp.Text = sdr[4].ToString();
                    jzry_jzlb_tb.Text = sdr[5].ToString();
                    jzry_jxjy_tb.Text = sdr[6].ToString();
                    sdr.Close();
                }
            }
        }
        private string rebool(string str1, string str2)
        {
            string bools = string.Empty;
            return bools = (str1 == str2) ? "1" : "0";
        }
        private void save_Click(object sender, EventArgs e)
        {

            // string strfeaturesID = db.GetSingleObject("SELECT population.features FROM population WHERE population.id = " + this.pid).ToString();
            // //电话
            // db.GetSingleObject("DELETE FROM `phone` WHERE(`population`=" + this.pid + " )");
            // //更新特性
            // if (strfeaturesID != "0")
            // {

            //         string residentID = null;
            //         residentID = db.GetSingleObject("SELECT features.resident FROM features WHERE features.id = " + strfeaturesID).ToString();
            //         if (residentID != "")
            //         {
            //             string raddID = db.GetSingleObject("SELECT resident_addresss FROM resident WHERE resident.id =   " + residentID).ToString();
            //         if (raddID != "")
            //         {
            //             db.GetSingleObject("UPDATE `resident` SET `resident_addresss`=NULL WHERE (`id`='" + residentID + "') ").ToString();
            //             db.GetSingleObject("DELETE FROM `residentaddresss` WHERE (`id`='" + raddID + "')").ToString();
            //         }


            //             db.GetSingleObject(" UPDATE `features` SET `resident`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //             db.GetSingleObject("DELETE FROM `resident` WHERE (`id`='" + residentID + "')").ToString();

            //         }


            //         string handicapppedID = null;
            //         handicapppedID = db.GetSingleObject("SELECT features.handicapped FROM features WHERE features.id = " + strfeaturesID).ToString();
            //         if (handicapppedID != "")
            //         {
            //             db.GetSingleObject(" UPDATE `features` SET `handicapped`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //             db.GetSingleObject("DELETE FROM `handicapped` WHERE (`id`='" + handicapppedID + "')").ToString();
            //         }

            //     string foreignerID = null;
            //     foreignerID = db.GetSingleObject("SELECT features.foreigner FROM features WHERE features.id = " + strfeaturesID).ToString();
            //     if (foreignerID != "")
            //     {
            //         db.GetSingleObject(" UPDATE `features` SET `foreigner`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //         db.GetSingleObject("DELETE FROM `foreigner` WHERE (`id`='" + foreignerID + "')").ToString();
            //     }

            //     string poorID = null;
            //     poorID = db.GetSingleObject("SELECT features.poor FROM features WHERE features.id = " + strfeaturesID).ToString();
            //     if (poorID != "")
            //     {
            //         db.GetSingleObject(" UPDATE `features` SET `poor`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //         db.GetSingleObject("DELETE FROM `poor` WHERE (`id`='" + poorID + "')").ToString();
            //     }
            //     string correctionID = null;
            //     correctionID = db.GetSingleObject("SELECT features.correction FROM features WHERE features.id = " + strfeaturesID).ToString();
            //     if (correctionID != "")
            //     {
            //         db.GetSingleObject(" UPDATE `features` SET `correction`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //         db.GetSingleObject("DELETE FROM `correction` WHERE (`id`='" + correctionID + "')").ToString();
            //     }
            //     string releasedID = null;
            //     releasedID = db.GetSingleObject("SELECT features.released FROM features WHERE features.id = " + strfeaturesID).ToString();
            //     if (releasedID != "")
            //     {
            //         db.GetSingleObject(" UPDATE `features` SET `released`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //         db.GetSingleObject("DELETE FROM `released` WHERE (`id`='" + releasedID + "')").ToString();
            //     }
            //     string dopeID = null;
            //     dopeID = db.GetSingleObject("SELECT features.dope FROM features WHERE features.id = " + strfeaturesID).ToString();
            //     if (dopeID != "")
            //     {
            //         db.GetSingleObject(" UPDATE `features` SET `dope`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //         db.GetSingleObject("DELETE FROM `dope` WHERE (`id`='" + dopeID + "')").ToString();
            //     }
            //     string unjobID = null;
            //     unjobID = db.GetSingleObject("SELECT features.unjob FROM features WHERE features.id = " + strfeaturesID).ToString();
            //     if (unjobID != "")
            //     {
            //         db.GetSingleObject(" UPDATE `features` SET `unjob`= NULL WHERE(`id`= '" + strfeaturesID + "') ").ToString();
            //         db.GetSingleObject("DELETE FROM `unjob` WHERE (`id`='" + unjobID + "')").ToString();
            //     }
            //     db.GetSingleObject("UPDATE `population` SET `features` = NULL WHERE(`id`='"+this.pid+"')").ToString();
            //     db.GetSingleObject("DELETE FROM `features` WHERE (`id`='" + strfeaturesID + "')").ToString();
            // }

            //db.GetSingleObject("DELETE FROM `population` WHERE(`id`= '"+this.pid+"')").ToString();
            string strfeaturesID = db.GetSingleObject("SELECT population.features FROM population WHERE population.id = " + this.pid).ToString();
            //电话
            db.GetSingleObject("DELETE FROM `phone` WHERE(`population`=" + this.pid + " )");
            //更新特性
            if (strfeaturesID != "0")
            {

                string residentID = null;
                string raddID = null;
                residentID = db.GetSingleObject("SELECT features.resident FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (residentID != "")
                {
                    raddID = db.GetSingleObject("SELECT resident_addresss FROM resident WHERE resident.id =   " + residentID).ToString();
                    if (raddID != "")
                    {
                        db.GetSingleObject("UPDATE `resident` SET `resident_addresss`=NULL WHERE (`id`='" + residentID + "') ");
                        db.GetSingleObject("DELETE FROM `residentaddresss` WHERE (`id`='" + raddID + "')");
                    }


                    db.GetSingleObject("UPDATE `features` SET `resident`=NULL WHERE (`id`='" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `resident` WHERE (`id`='" + residentID + "')");

                }


                string handicapppedID = null;
                handicapppedID = db.GetSingleObject("SELECT features.handicapped FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (handicapppedID != "")
                {
                    db.GetSingleObject(" UPDATE `features` SET `handicapped`= NULL WHERE(`id`= '" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `handicapped` WHERE (`id`='" + handicapppedID + "')");
                }

                string foreignerID = null;
                foreignerID = db.GetSingleObject("SELECT features.foreigner FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (foreignerID != "")
                {

                    db.GetSingleObject(" UPDATE `features` SET `foreigner`= NULL WHERE(`id`= '" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `foreigner` WHERE (`id`='" + foreignerID + "')");
                }

                string poorID = null;
                poorID = db.GetSingleObject("SELECT features.poor FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (poorID != "")
                {
                    db.GetSingleObject(" UPDATE `features` SET `poor`= NULL WHERE(`id`= '" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `poor` WHERE (`id`='" + poorID + "')");
                }
                string correctionID = null;
                correctionID = db.GetSingleObject("SELECT features.correction FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (correctionID != "")
                {
                    db.GetSingleObject(" UPDATE `features` SET `correction`= NULL WHERE(`id`= '" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `correction` WHERE (`id`='" + correctionID + "')");
                }
                string releasedID = null;
                releasedID = db.GetSingleObject("SELECT features.released FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (releasedID != "")
                {
                    db.GetSingleObject(" UPDATE `features` SET `released`= NULL WHERE(`id`= '" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `released` WHERE (`id`='" + releasedID + "')");
                }
                string dopeID = null;
                dopeID = db.GetSingleObject("SELECT features.dope FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (dopeID != "")
                {
                    db.GetSingleObject(" UPDATE `features` SET `dope`= NULL WHERE(`id`= '" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `dope` WHERE (`id`='" + dopeID + "')");
                }
                string unjobID = null;
                unjobID = db.GetSingleObject("SELECT features.unjob FROM features WHERE features.id = " + strfeaturesID).ToString();
                if (unjobID != "")
                {
                    db.GetSingleObject(" UPDATE `features` SET `unjob`= NULL WHERE(`id`= '" + strfeaturesID + "') ");
                    db.GetSingleObject("DELETE FROM `unjob` WHERE (`id`='" + unjobID + "')");
                }
                db.GetSingleObject("UPDATE `population` SET `features` = NULL WHERE(`id`='" +this.pid + "')");
                db.GetSingleObject("DELETE FROM `features` WHERE (`id`='" + strfeaturesID + "')");
            }

            db.GetSingleObject("DELETE FROM `population` WHERE(`id`= '" + this.pid + "')");

            string sid = string.Empty;
            string strcmd = string.Empty;
            string strform = " INSERT INTO `features` (";
            string strobj = ") VALUES(";
            Dictionary<string, string> fid = new Dictionary<string, string>();
            List<string> l_strform = new List<string>();
            List<string> l_strobj = new List<string>();
            if (ryinfo_card_id.Text.Trim() == "" && jwry_zjhm_tb.Text.Trim() == "")
            {
                MessageBox.Show("身份证或者境外人员证件号码不能为空", "软件提示"); return;
            }
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
                strcmd = "INSERT INTO `population` (`card_id`, `name`, `age`, `address`, `gender`, `census_address`, `block`, `note`, `educational`,`features`) VALUES('" + ryinfo_card_id.Text + "', '" + tb_names.Text + "', '" + ryinfo_age.Value.ToString() + "', '" + ryinfo_address.Text + "', '" + rebool(ryinfo_sex.SelectedItem.ToString(), "男") + "', '" + ryinfo_hjdz.Text + "', '" + block.Value + "', '" + ryinfo_note.Text + "', '" + ryinfo_edu.Text + "','0')" + "; select @@identity AS id";
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
            MessageBox.Show("修改成功", "软件提示");
            feature = 0;
            this.Close();
            //更新院落
        }

        private void close_Click(object sender, EventArgs e)
        {
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
            if (cb_block.SelectedItem != null)
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

        private void cb_street_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void cb_old_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_old.Checked)
            {
                cb_alone.Enabled = true;
            }
            else
            {
                cb_alone.Checked = false;
                cb_alone.Enabled = true;
            }
        }
    }
}
