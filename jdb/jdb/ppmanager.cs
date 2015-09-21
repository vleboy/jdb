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
    public partial class ppmanager : Form
    {
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
        string searchstr = "SELECT district.`name` AS nd, " +
" grid.`name` AS ng, " +
" block.`name` AS nb, " +
" street.streetName AS ns, " +
" population.`name` AS na ," +
" population.card_id, " +
" population.address, " +
" CASE population.educational  WHEN '党员' THEN '是' ELSE '否' end  AS educational ," +
" population.note FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN street ON street.blockId = block.id INNER JOIN population ON population.block = block.id";

        string searchstr_f = "street.streetName AS ns, CASE features.vip WHEN true THEN '是' ELSE '否'end AS vip, " +
"CASE features.cleaner  WHEN true THEN '是' ELSE '否' end  AS cleaner, " +
"CASE features.old  WHEN true THEN '是' ELSE '否' end  AS old," +
"CASE features.old_alone  WHEN true THEN '是' ELSE '否' end  AS old_alone, " +
"CASE features.poor  WHEN poor THEN '是' ELSE '否' end  AS poor, " +
"CASE features.resident  WHEN resident THEN '是' ELSE '否' end  AS resident, " +
"CASE features.handicapped  WHEN handicapped THEN '是' ELSE '否' end  AS handicapped, " +
"CASE features.unjob  WHEN unjob THEN '是' ELSE '否' end  AS unjob, " +
"CASE features.dope  WHEN dope THEN '是' ELSE '否' end  AS dope, " +
"CASE features.foreigner  WHEN foreigner THEN '是' ELSE '否' end  AS foreigner, " +
"CASE features.released  WHEN released THEN '是' ELSE '否' end  AS released, " +
"CASE features.correction  WHEN correction THEN '是' ELSE '否' end  AS correction ";
          string searchstr2 = null;
        public ppmanager()
        {
            InitializeComponent();
        }
        //protected override void WndProc(ref Message m)

        //{

        //    if (m.Msg == 0x0014) // 禁掉清除背景消息

        //        return;

        //    base.WndProc(ref m);

        //}
       

        private void ppmanager_Load(object sender, EventArgs e)
        {

            searchstr2 = searchstr;

            this.ControlBox = false;


            if (this.main.qx)
            {
                this.添加人员ToolStripMenuItem.Visible = true;
            }












            string sqlcmd = "SELECT district.`name` AS nd, "+
" grid.`name` AS ng, "+
" block.`name` AS nb, "+
" street.streetName AS ns, "+
" CASE features.vip WHEN true THEN '是' ELSE '否'end AS vip, " +
"CASE features.cleaner  WHEN true THEN '是' ELSE '否' end  AS cleaner, " +
"CASE features.old  WHEN true THEN '是' ELSE '否' end  AS old," +
"CASE features.old_alone  WHEN true THEN '是' ELSE '否' end  AS old_alone, " +
"CASE features.poor  WHEN poor THEN '是' ELSE '否' end  AS poor, " +
"CASE features.resident  WHEN resident THEN '是' ELSE '否' end  AS resident, " +
"CASE features.handicapped  WHEN handicapped THEN '是' ELSE '否' end  AS handicapped, " +
"CASE features.unjob  WHEN unjob THEN '是' ELSE '否' end  AS unjob, " +
"CASE features.dope  WHEN dope THEN '是' ELSE '否' end  AS dope, " +
"CASE features.foreigner  WHEN foreigner THEN '是' ELSE '否' end  AS foreigner, " +
"CASE features.released  WHEN released THEN '是' ELSE '否' end  AS released, " +
"CASE features.correction  WHEN correction THEN '是' ELSE '否' end  AS correction, " +
" population.`name` AS na ," +
" population.card_id, " +
" population.address, " +
" CASE population.educational  WHEN '党员' THEN '是' ELSE '否' end  AS educational ,"+
" population.note FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN street ON street.blockId = block.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id ";
            
            
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            sdr = db.GetDataReader("SELECT district.`name`,district.`id` FROM district");
           
         
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }

            
            sssq_cb.DataSource = items;
            items.Clear();
            sdr.Close();


           
            sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sswg_cb.DataSource = items;
            items.Clear();
            sdr.Close();

         
            sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = 1");
            
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            
            ssyl_cb.DataSource = items;
            //  items.Clear();
            sdr.Close();
            if (this.cmd != null)
            {
                switch (this.cmd)
                {
                    case "1"://党员
                        {
                            sqlcmd += "WHERE population.educational = '党员' ";
                        }
                        break;
                    case "2"://藏维族人员
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 ";
                        }
                        break;
                    case "3"://重点人员
                        {
                            sqlcmd += "WHERE features.vip >= 1 ";
                        }
                        break;
                    case "4"://矫正人员
                        {
                            sqlcmd += "WHERE features.correction >= 1";
                        }
                        break;
                    case "5"://刑释人员
                        {
                            sqlcmd += "WHERE features.released >= 1";
                        }
                        break;
                    case "6"://吸毒人员
                        {
                            sqlcmd += "WHERE features.dope >= 1";
                        }
                        break;
                    case "7"://境外人员
                        {
                            sqlcmd += "WHERE features.foreigner >= 1";
                        }
                        break;
                    case "8"://失业人员
                        {
                            sqlcmd += "WHERE features.unjob >= 1";
                        }
                        break;
                    case "9"://优抚人员
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "10"://残疾人
                        {
                            sqlcmd += "WHERE features.handicapped >= 1";
                        }
                        break;
                    case "11"://精神残疾
                        {
                            sqlcmd += "WHERE features.handicapped >= 1";
                        }
                        break;
                    case "12"://老年人
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL";
                        }
                        break;
                    case "13"://空巢老人
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 ";
                        }
                        break;
                    case "14"://低保户数
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "15"://低保人员
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    default:
                        break;
                }

                if (this.district != "0")
                {
                    sqlcmd += " AND district.id = '" + this.district + "'";
                    if (this.grid != "0")
                    {

                        sqlcmd += " AND grid.id =" + this.grid;
                        if (this.block != "0")
                        {
                            sqlcmd += " AND block.id = '" + this.block + "'";

                        }
                    }
                }
            }
            else
            {
               // sqlcmd += "WHERE population.educational = '党员' AND  district.id = '1'";
              
            }
            dgv.DataSource = db.GetDataSet(sqlcmd, "t").Tables["t"];


        }
       
        private void sssq_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
               commUse.district_gird_block(sssq_cb, sswg_cb, "district", "grid");
           
                
      
        }

        private void sswg_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
                commUse.district_gird_block(sswg_cb, ssyl_cb, "grid", "block");
            
           
        }

        private void cbox_sssq_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_sssq.Checked)
            {
                sssq_cb.Enabled = true;
            }
            else
            {
                sssq_cb.Enabled = false;
            }
        }

        private void cbox_grid_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_grid.Checked)
            {
               sswg_cb.Enabled = true;
            }
            else
            {
                sswg_cb.Enabled = false;
            }
        }

        private void cb_block_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_block.Checked)
            {
                ssyl_cb.Enabled = true;
            }
            else
            {
                ssyl_cb.Enabled = false;
            }
        }

        private void ssyl_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 添加人员toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 添加人员ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;

            commUse.ShowForm(x.Tag.ToString(), this.main,null);
        }

        private void search_Click(object sender, EventArgs e)
        {
            int index = 0;
            searchstr += " WHERE population.id IS NOT NULL ";

            if (namebox.Text.Trim() != "")
            {
                searchstr += " AND population.`name` = '"+namebox.Text.Trim()+"' "; //添加名字赛选
            }
            if (cidbox.Text.Trim() != "")
            {
                searchstr += " AND population.card_id = '"+cidbox.Text.Trim()+"' "; //身份证筛选
            }
            if (cbox_sssq.Checked)
            {
                searchstr += " AND district.id = "+ ((item)sssq_cb.SelectedItem).Value.ToString(); //社区筛选
            }
            if (cbox_grid.Checked)
            {
                searchstr += " AND grid.id = "+ ((item)sswg_cb.SelectedItem).Value.ToString(); //网格筛选
            }
            if (cb_block.Checked)
            {
                searchstr += " AND block.id = "+ ((item)ssyl_cb.SelectedItem).Value.ToString();//所属院落筛选

            }
            if (cb_ldry.Checked)
            {
                searchstr += " AND features.resident IS NULL";//筛选不为常驻人口
                index++;
            }
            else if (cb_czry.Checked)
            {
                searchstr += " AND features.resident IS NOT NULL"; //筛选常驻人口
                index++;// INNER JOIN features ON population.features = features.id "
            }
            if (cb_cjr.Checked)
            {
                index++;
                if (cb_cjr_j.Checked)
                {
                    searchstr += ""; //筛选精神残疾
                }
                else
                {
                    searchstr += " AND features.handicapped IS NOT NULL"; //筛选非精神残疾
                }
            }
            if (cb_old.Checked)
            {
                index++;
                searchstr += " AND features.old IS NOT NULL ";
                if (cb_old_k.Checked)
                {
                    searchstr += " AND features.old_alone IS NOT NULL"; //筛选空巢老人
                }
                
            }
            if (cb_jz.Checked)
            {
                index++;
                searchstr += " AND features.correction IS NOT NULL"; //筛选矫正人员
            }
            if (cb_clear.Checked)
            {
                index++;
                searchstr += " AND features.cleaner IS NOT NULL";//筛选藏维族人员
            }
            if (cb_xmry.Checked)
            {
                index++;
                searchstr += " AND features.released IS NOT NULL"; //筛选刑满人员
            }
            if (cb_syry.Checked)
            {
                index++;
                searchstr += " AND features.unjob IS NOT NULL"; //筛选失业人员
            }
            if (cb_dbry.Checked)
            {
                index++;
                searchstr += " AND features.poor IS NOT NULL";//筛选低保人员
            }
            if (cb_vip.Checked)
            {
                index++;
                searchstr +=  " AND features.vip IS NOT NULL"; //筛选重要人员
            }
            if (cb_dope.Checked)
            {
                index++;
                searchstr += " AND features.dope IS NOT NULL"; //筛选吸毒人员

            }
            if (cb_dy.Checked)
            {
                searchstr += " AND population.educational = '党员'";//筛选党员
            }
            if (index > 0)
            {
                searchstr = searchstr.Replace("street.streetName AS ns", searchstr_f);
                searchstr = searchstr.Replace("WHERE", "INNER JOIN features ON population.features = features.id WHERE ");
            }



            dgv.DataSource = db.GetDataSet(searchstr, "t").Tables["t"];
            searchstr = searchstr2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cjr.Checked)
            {
                cb_cjr_j.Enabled = true;
            }
            else
            {
                cb_cjr_j.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_old.Checked)
            {
                cb_old_k.Enabled = true;
            }
            else
            {
                cb_old_k.Enabled = false;
            }
        }

        private void cb_ldry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ldry.Checked)
            {
                cb_czry.Enabled = false;
                cb_czry.Checked = false;
            }
            else
            {
                cb_czry.Enabled = true;
            }
        }

        private void cb_czry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_czry.Checked)
            {
                cb_ldry.Enabled = false;
                cb_ldry.Checked = false;
            }
            else
            {
                cb_ldry.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = db.GetDataSet(searchstr2, "t").Tables["t"];
        }
    }
}
