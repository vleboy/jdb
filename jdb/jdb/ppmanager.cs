using jdb.ComClass;
using jdb.dataClass;
using jdb.sundries;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace jdb
{
    public partial class ppmanager : Form
    {
        private int CurrentRowIndex { get; set; }
        private int CurrentColumnIndex { get; set; }
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
        string searchstr = "SELECT district.`name` AS nd, " +
" grid.`name` AS ng, " +
" block.`name` AS nb, " +
"street.streetName AS ns, CASE features.vip WHEN true THEN '是' ELSE '否'end AS '重点人员', " +
"CASE features.cleaner  WHEN true THEN '是' ELSE '否' end  AS '藏维族人员', " +
"CASE features.old  WHEN true THEN '是' ELSE '否' end  AS '老年人'," +
"CASE features.old_alone  WHEN true THEN '是' ELSE '否' end  AS '空巢老人', " +
"CASE features.poor  WHEN poor THEN '是' ELSE '否' end  AS '低保人员', " +
"CASE features.resident  WHEN resident THEN '是' ELSE '否' end  AS '常住人员', " +
"CASE features.handicapped  WHEN handicapped THEN '是' ELSE '否' end  AS '残疾人', " +
"CASE features.unjob  WHEN unjob THEN '是' ELSE '否' end  AS '失业人员', " +
"CASE features.dope  WHEN dope THEN '是' ELSE '否' end  AS '吸毒人员', " +
"CASE features.foreigner  WHEN foreigner THEN '是' ELSE '否' end  AS '境外人员', " +
"CASE features.released  WHEN released THEN '是' ELSE '否' end  AS '刑满释放人员', " +
"CASE features.correction  WHEN correction THEN '是' ELSE '否' end  AS '矫正人员' , " +
" population.`name` AS na ," +
" population.card_id, " +
" population.address, " +
" CASE population.educational  WHEN '党员' THEN '是' ELSE '否' end  AS educational ," +
" population.note FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN street ON street.blockId = block.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id";



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
                    searchstr = searchstr.Replace("INNER JOIN features ON population.features = features.id WHERE population.id IS NOT NULL ", "INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE population.id IS NOT NULL AND handicapped.handicapped_type = 0"); //筛选精神残疾
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
            if (cb_jwry.Checked)
            {
                index++;
                searchstr += " AND features.foreigner IS NOT NULL"; //筛选境外人员
            }
            if (cb_dy.Checked)
            {
                searchstr += " AND population.educational = '党员'";//筛选党员
            }
            index++;
           

            

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
        private void savebox()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File To";
            saveFileDialog.ShowDialog();
            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            //StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            string str = "";
            try
            {
                //写标题
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dgv.Columns[i].HeaderText;
                }
                sw.WriteLine(str);
                //写内容
                for (int j = 0; j < dgv.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dgv.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        if (dgv.Rows[j].Cells[k].Value != null)
                        {
                            tempStr += dgv.Rows[j].Cells[k].Value.ToString();
                        }
                        else
                        {
                            tempStr += "";
                        }
                       
                    }

                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            savebox();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv.Rows[CurrentRowIndex];
            string sfz = dgv.CurrentRow.Cells["cardid"].Value.ToString();
            //根据身份证查用户
            string id = db.GetSingleObject("SELECT population.id FROM population WHERE population.card_id =" + sfz).ToString();
            CommonUse commUse = new CommonUse();
            var x = (DataGridView)sender;
            string[] str = { id };
            commUse.ShowForm(x.Tag.ToString(), this.main, str);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.Rows[CurrentRowIndex];
            string sfz = dgv.CurrentRow.Cells["cardid"].Value.ToString();
            //根据身份证查用户
           string pid = db.GetSingleObject("SELECT population.id FROM population WHERE population.card_id =" + sfz).ToString();
            var p = db.GetSingleObject("SELECT phone.id FROM population INNER JOIN phone ON phone.population = population.id WHERE population.id = " + pid);
            //查询用是否有电话
            if (p != null)
            {
                db.GetSingleObject("DELETE FROM `phone` WHERE(`id` = '" + p.ToString() + "') ");//删除电话
            }









            string strfeaturesID = db.GetSingleObject("SELECT population.features FROM population WHERE population.id = " + pid).ToString();
            //电话
          
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
                db.GetSingleObject("UPDATE `population` SET `features` = NULL WHERE(`id`='" + pid + "')");
                db.GetSingleObject("DELETE FROM `features` WHERE (`id`='" + strfeaturesID + "')");
            }

            db.GetSingleObject("DELETE FROM `population` WHERE(`id`= '" + pid + "')");




















            dgv.Rows.Remove(row);//防止滚动条滚到不是想要到的地方。
            dgv.CurrentCell = dgv[0, CurrentRowIndex];
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            var dgvv = (DataGridView)sender;
                         CurrentRowIndex = e.RowIndex;
                        CurrentColumnIndex = e.ColumnIndex;
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.Rows[CurrentRowIndex];
            string sfz = dgv.CurrentRow.Cells["cardid"].Value.ToString();
            //根据身份证查用户
            string id = db.GetSingleObject("SELECT population.id FROM population WHERE population.card_id =" + sfz).ToString();
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;
            string[] str= {id };
            commUse.ShowForm(x.Tag.ToString(), this.main,str );
        }
        private string renum (string str1)
        {
            return str1 == "" ? "0" : str1;
        }
        private string rebool(string str1, string str2)
        {
            string bools = string.Empty;
            return bools = (str1 == str2) ? "1" : "0";
        }
        private string redb(string str1)
        {
            return str1 == "" ? "NULL" : str1;
        }
        public string  openexcel()
        {
            //打开excel选择框
            OpenFileDialog frm = new OpenFileDialog();
            frm.Filter = "Excel文件(*.xls,xlsx)|*.xls;*.xlsx";
            if (frm.ShowDialog() == DialogResult.OK)
            {

                string excelName = frm.FileName;
                return excelName;
            }
            else
            {
                return "";
            }
        }
        public void Read(string FileName)
        {
            string strform = " INSERT INTO `features` (";
            string strobj = ") VALUES(";
            string sid = string.Empty;
            string strcmd = string.Empty;
            Dictionary<string, string> fid = new Dictionary<string, string>();
            List<string> l_strform = new List<string>();
            List<string> l_strobj = new List<string>();
            AppLibrary.ReadExcel.Workbook workbook = null;
            workbook = AppLibrary.ReadExcel.Workbook.getWorkbook(FileName);

            //   System.Text.StringBuilder sb = new System.Text.StringBuilder();
            List<string> l = new List<string>();
            foreach (AppLibrary.ReadExcel.Sheet sheet in workbook.Sheets)
            {
               
                for (int iRow = 2; iRow < sheet.Rows; iRow++)
                {
                    l.Clear();
                    for (int iCol = 0; iCol < sheet.Columns; iCol++)
                    {
                        AppLibrary.ReadExcel.Cell cell = sheet.getCell(iCol, iRow);
                        object val = cell.Value;

                        string cellValue = (val != null) ? val.ToString() : "";

                        l.Add(cellValue);

                      
                       
                    }
                    ////添加常住地址
                    if (db.GetSingleObject("SELECT population.id FROM population WHERE population.card_id = '"+l[4].Trim()+"'") != null)
                    {

                        continue;
                    }
                    if (l[19].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `residentaddresss` (`address`, `host`, `relationship`) VALUES ('" +
                         l[24].Trim()  + "','" + rebool(l[21].Trim(), "是") + "', '" + l[22].Trim() + "')" + ";select @@identity AS id";
                        var id = db.GetSingleObject(strcmd);
                        sid = id.ToString();
                        strcmd = "INSERT INTO `resident` (`ethnic`, `now_date`, `registration_date`, `photo`,  `resident_addresss`) VALUES ('" +
                       l[23].Trim() + "', " + redb(l[25].Trim())+ ", " + redb(l[26].Trim()) + ", '" + rebool(l[20].Trim(), "是") + "', '" +
                      sid + "')" + "; select @@identity AS id";
                      sid = db.GetSingleObject(strcmd).ToString();
                      fid.Add("resident", sid);
                    }
                    //残疾人
                    if (l[27].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `handicapped` ( `handicapped_id`, `handicapped_type`, `handicapped_level`, `guardian_name`, `guardian_relationship`) VALUES ('" 
                            + l[29].Trim() + "', '" + rebool(l[28].Trim(), "肢体") + "', '" + l[30].Trim() + "', '" + l[31].Trim() + "', '" + l[32].Trim() + "')" + "; select @@identity AS id"; 
                        sid = db.GetSingleObject(strcmd).ToString();
                        fid.Add("handicapped", sid);

                    }
                    //境外人员添加
                    if (l[33].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `foreigner` (`citizenship`, `card_id`, `card_date`, `card_type`, "
                            + "`house_belongs`, `registration_date`, `contact`, `associates`, `associates_phone`, `isforever`, `leave_date`) VALUES ('" +
                           l[34].Trim() + "', '" + l[35].Trim() + "', " + redb(l[36].Trim()) + ", '" + l[44].Trim() + "', '" +
                           l[39].Trim() + "', " + redb(l[37].Trim()) + ", '" + l[41].Trim() + "', '" + l[42].Trim() + "', '" +
                           l[43].Trim() + "', '" + rebool(l[40].Trim(), "是") + "', " + redb( l[38].Trim()) + ")" + "; select @@identity AS id";
                        sid = db.GetSingleObject(strcmd).ToString();
                        fid.Add("foreigner", sid);
                    }
                    //低保人员添加
                    if (l[45].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `poor` (`poorid`) VALUES ('" + l[46].Trim() + "')" + "; select @@identity AS id"; ;
                        sid = db.GetSingleObject(strcmd).ToString();
                        fid.Add("poor", sid);
                    }
                    //失业人员添加
                    if (l[47].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `unjob` (`insurance_id`, `first_month`, `old_factory`, `already`) VALUES (" +
                            redb(l[48].Trim()) + ", " + redb(l[49].Trim()) + ", '" + l[51].Trim() + "', '" + l[50].Trim() + "')" + "; select @@identity AS id";
                        sid = db.GetSingleObject(strcmd).ToString();
                        fid.Add("unjob", sid);
                    }
                    //刑满释放人员添加
                    if (l[52].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `released` (`criminal`, `criminal_start_date`, `criminal_end_date`, `prison_address`, `free_date`) VALUES ('" +
                            l[53].Trim() + "', '" + redb(l[54].Trim()) + "', '" + redb(l[55].Trim()) + "', '" + l[57].Trim() + "', " + redb( l[56].Trim()) + ")" + "; select @@identity AS id";
                        sid = db.GetSingleObject(strcmd).ToString();
                        fid.Add("released", sid);
                    }
                    //校正人员添加
                    if (l[58].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `correction` (`criminal`, `criminal_type`, `criminal_period`, `correction_firstdate`, `correction_enddate`, `correction_type`, `school_or_job`) VALUES ('" +
                            l[59].Trim() + "', '" + l[60].Trim() + "', '" + l[61].Trim() + "', " + redb(l[64].Trim()) + ", " + redb( l[65].Trim()) + ", '" +
                            l[62].Trim() + "', '" + l[63].Trim() + "')" + "; select @@identity AS id";
                        sid = db.GetSingleObject(strcmd).ToString();
                        fid.Add("correction", sid);
                    }
                    //吸毒人员添加
                    if (l[66].Trim() == "是")
                    {
                        strcmd = "INSERT INTO `dope` (`police_address`, `first_date`, `dope_type`, `status`) VALUES ('" + 
                            l[67].Trim() + "', " + redb( l[68].Trim()) + ", '" + l[69].Trim() + "', '" + l[70].Trim() + "')" + "; select @@identity AS id";
                        sid = db.GetSingleObject(strcmd).ToString();
                        fid.Add("dope", sid);
                    }
                    //老年人
                    if (l[15].Trim()=="是")
                    {
                        l_strform.Add("`old`");
                        l_strobj.Add("1");
                        if (l[16].Trim() == "是")
                        {
                            l_strform.Add("`old_alone`");
                            l_strobj.Add("1");
                        }
                    }
                    //藏维族
                    if (l[18].Trim() == "是")
                    {
                        l_strform.Add("`cleaner`");
                        l_strobj.Add("1");
                    }
                    //vip
                    if (l[17].Trim() == "是")
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
                    
                    string[] l_stoforms = l_strform.ToArray();
                    string[] l_stobjs = l_strobj.ToArray();
                    strform += string.Join(",", l_stoforms);
                    strobj += string.Join(",", l_stobjs);
                    strcmd = strform.TrimEnd(',') + strobj.TrimEnd(',');
                    strcmd += ")" + "; select @@identity AS id";
                    sid = db.GetSingleObject(strcmd).ToString();

                    string blockid = db.GetSingleObject("SELECT block.id FROM block WHERE block.`name` = "+"'"+l[12].Trim()+"'").ToString();
                    fid.Clear();
                     strform = " INSERT INTO `features` (";
                     strobj = ") VALUES(";
                    l_strform.Clear();
                    l_strobj.Clear();
                    if (sid == "" || sid == "0")
                    {
                        strcmd = "INSERT INTO `population` (`card_id`, `name`, `age`, `address`, `gender`, `census_address`, `block`, `note`, `educational`,`features`) VALUES('" + 
                            l[4].Trim() + "', '" + l[0].Trim() + "', '" + renum(l[2].Trim()) + "', '" + l[9].Trim() + "', '" + rebool(l[1].Trim(), "男") + "', '" + l[8].Trim() + "', '" + blockid + "', '" +l[14].Trim() + "', '" + l[3].Trim() + "','0')" + "; select @@identity AS id";
                    }
                    else
                    {
                        strcmd = "INSERT INTO `population` (`card_id`, `name`, `age`, `address`, `gender`, `census_address`, `block`, `note`, `educational`,`features`) VALUES('" +
                            l[4].Trim() + "', '" + l[0].Trim() + "', '" + renum(l[2].Trim())+ "', '" + l[9].Trim() + "', '" + rebool(l[1].Trim(), "男") + "', '" + l[8].Trim() + "', '" + blockid + "', '" + l[14].Trim() + "', '" + l[3].Trim() + "','" + sid + "')" + "; select @@identity AS id";
                    }
                    sid = db.GetSingleObject(strcmd).ToString();

                    if (l[5].Trim() != "")
                    {
                        strcmd = " INSERT INTO `phone` (`phonenumber`, `population`) VALUES('" + l[5].Trim() + "', '" + sid + "')" + "; select @@identity AS id";
                        db.GetSingleObject(strcmd).ToString();
                    }
                    if (l[6].Trim() != "")
                    {
                        strcmd = " INSERT INTO `phone` (`phonenumber`, `population`) VALUES('" + l[6].Trim() + "', '" + sid + "')" + "; select @@identity AS id";
                        db.GetSingleObject(strcmd).ToString();
                    }
                    if (l[7].Trim() != "")
                    {
                        strcmd = " INSERT INTO `phone` (`phonenumber`, `population`) VALUES('" + l[7].Trim() + "', '" + sid + "')" + "; select @@identity AS id";
                        db.GetSingleObject(strcmd).ToString();
                    }
                  //  MessageBox.Show("添加成功", "软件提示");
                    
                   // this.Close();
                }

            }
            MessageBox.Show("添加成功", "软件提示");

        }
        private void eXCEL导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Read(openexcel());
        }
    }
}
