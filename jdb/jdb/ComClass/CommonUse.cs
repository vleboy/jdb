using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using jdb.dataClass;
using jdb.sundries;
using System.Threading;
using jdb.Map;
using jdb.Map._01草堂;
using jdb.Map._02琴台;
using jdb.Map._04送仙桥;
using jdb.Map._03芳邻;

namespace jdb.ComClass
{
    /// <summary>
    ///   公共的通用类，提供一些通用的方法
    /// </summary>
    /// 

    class CommonUse
    {
        private readonly DataBase db = new DataBase();

        /// <summary>
        ///   TreeView控件绑定到数据源
        /// </summary>
        /// <param name="tv"> TreeView控件 </param>
        /// <param name="imgList"> ImageList控件 </param>
        /// <param name="rootName"> 根节点的文本属性值 </param>
        /// <param name="strTable"> 要绑定的数据表 </param>
        /// <param name="strCode"> 数据表的代码列 </param>
        /// <param name="strName"> 数据表的名称列 </param>
        /// 
        public void BuildTree(TreeView tv, ImageList imgList, string rootName, string strTable, string strCode,
                              string strName)
        {
            string strSql = null;
            DataSet ds = null;
            DataTable dt = null;
            TreeNode rootNode = null;
            TreeNode childNode = null;

            strSql = "select " + strCode + " , " + strName + " from " + strTable;
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            //创建根节点
            rootNode = new TreeNode();
            rootNode.Tag = null;
            rootNode.Text = rootName;
            rootNode.ImageIndex = 1;
            rootNode.SelectedImageIndex = 0;

            try
            {
                // ds = db.GetDataSet(strSql, strTable);
                dt = ds.Tables[strTable];

                foreach (DataRow row in dt.Rows)
                {
                    //创建子节点
                    childNode = new TreeNode();
                    childNode.Tag = row[strCode];
                    childNode.Text = row[strName].ToString();
                    childNode.ImageIndex = 1;
                    childNode.SelectedImageIndex = 0;
                    rootNode.Nodes.Add(childNode);
                }

                tv.Nodes.Add(rootNode);
                tv.ExpandAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }

        public void ShowForm(string ob, Main form,string[] par)
        {
            switch (ob)
            {
                case "list"://列表
                    {
                        Districk ListDistrickEG = new Districk();
                        ListDistrickEG.MdiParent = form;
                        ListDistrickEG.StartPosition = FormStartPosition.CenterScreen;
                        ListDistrickEG.Tag = ob;
                        ListDistrickEG.WindowState = FormWindowState.Maximized;
                        ListDistrickEG.main = form;
                        ListDistrickEG.Show();
                    }
                    break;

                case "GridsCTL":
                case "GridsFLL":
                case "GridsQTL":
                case "GridsSXQ":
                    {
                        Grids ListGridsEG = new Grids();
                        ListGridsEG.MdiParent = form;
                        ListGridsEG.StartPosition = FormStartPosition.CenterScreen;
                        ListGridsEG.Tag = ob;
                        ListGridsEG.WindowState = FormWindowState.Maximized;
                        ListGridsEG.main = form;
                        ListGridsEG.district = par[0];
                        if (ob == "GridsCTL")
                        {
                            ListGridsEG.grid = "9";
                        }
                        else
                        {
                            ListGridsEG.grid = "10";
                        }
                        
                        ListGridsEG.Show();
                    }
                    break;
                case "GridNum":
                    {
                        Blocks ListBlocksEG = new Blocks();
                        ListBlocksEG.MdiParent = form;
                        ListBlocksEG.StartPosition = FormStartPosition.CenterScreen;
                        ListBlocksEG.Tag = ob;
                        ListBlocksEG.WindowState = FormWindowState.Maximized;
                        ListBlocksEG.main = form;
                        ListBlocksEG.district = par[0];
                        ListBlocksEG.grid = par[2];
                        ListBlocksEG.Show();
                    }
                    break;
                case "BlockNum":
                    {
                        Street ListStreetEG = new Street();
                        ListStreetEG.MdiParent = form;
                        ListStreetEG.StartPosition = FormStartPosition.CenterScreen;
                        ListStreetEG.Tag = ob;
                        ListStreetEG.WindowState = FormWindowState.Maximized;
                        ListStreetEG.main = form;
                        ListStreetEG.district = par[0];
                        ListStreetEG.grid = par[2];
                        ListStreetEG.block = par[4];
                       // Thread.Sleep(5000);
                        ListStreetEG.Show();
                    }
                    break;
                case "ppm":
                    {
                        ppmanager ListppmanagerEG = new ppmanager();
                        ListppmanagerEG.MdiParent = form;
                        ListppmanagerEG.StartPosition = FormStartPosition.CenterScreen;
                        ListppmanagerEG.Tag = ob;
                        ListppmanagerEG.WindowState = FormWindowState.Maximized;
                        ListppmanagerEG.main = form;
                        ListppmanagerEG.district = par[0];
                        ListppmanagerEG.grid = par[1];
                        ListppmanagerEG.block = par[2];
                        ListppmanagerEG.street = par[3];
                        ListppmanagerEG.cmd = par[4];
                        ListppmanagerEG.Show();
                    }
                    break;
                case "add"://列表
                    {
                        addusr add = new addusr();
                        add.MdiParent = form;
                        add.StartPosition = FormStartPosition.CenterScreen;
                        add.Tag = ob;
                        add.WindowState = FormWindowState.Normal;
                        add.main = form;
                        add.Show();
                    }
                break;
                case "map"://列表
                    {
                        MapMainForm MapMain = new MapMainForm();
                        MapMain.MdiParent = form;
                        MapMain.StartPosition = FormStartPosition.CenterScreen;
                        MapMain.Tag = ob;
                        MapMain.WindowState = FormWindowState.Maximized;
                        MapMain.main = form;
                        MapMain.Show();
                    }
                    break;
                case "edituser":
                    {
                        editusr edit = new editusr();
                        edit.MdiParent = form;
                        edit.StartPosition = FormStartPosition.CenterScreen;
                        edit.Tag = ob;
                        edit.WindowState = FormWindowState.Normal;
                        edit.main = form;
                        edit.pid = par[0];
                        edit.Show();
                    }
                    break;


            }
        }
        public void ShowForm(string ob, Main form)
        {
            switch (ob)
            {



                //case "manager"://列表
                //    {
                //        ppmanager appmanager = new ppmanager();
                //        appmanager.MdiParent = form;
                //        appmanager.StartPosition = FormStartPosition.CenterScreen;
                //        appmanager.Tag = ob;
                //        appmanager.WindowState = FormWindowState.Maximized;
                //        appmanager.main = form;
                //        appmanager.Show();
                //    }
                //    break;
                //case "add"://列表
                //    {
                //        addUser add = new addUser();
                //        add.MdiParent = form;
                //        add.StartPosition = FormStartPosition.CenterScreen;
                //        add.Tag = ob;
                //        add.WindowState = FormWindowState.Normal;
                //        add.main = form;
                //        add.Show();
                //    }
                //    break;
                //case "map1":
                //    {
                //        map_ct_grids map = new map_ct_grids();
                //        map.MdiParent = form;
                //        map.StartPosition = FormStartPosition.CenterScreen;
                //        map.Tag = ob;
                //        map.WindowState = FormWindowState.Normal;
                //        map.main = form;
                //        map.Show();
                //    }
                //    break;
                //case "11":
                //    {
                //        ListCtlFrom Ctl = new ListCtlFrom();
                //        Ctl.MdiParent = form;
                //        Ctl.StartPosition = FormStartPosition.CenterScreen;
                //        Ctl.Tag = ob;
                //        Ctl.WindowState = FormWindowState.Maximized;
                //        Ctl.main = form;
                //        Ctl.district = "1";
                //        Ctl.Show();


                //    }
                //    break;


                case "ct_grid_1":
                    {
                        map_ct_grids map = new map_ct_grids();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_grid_1":
                    {
                        map_qt_grids map = new map_qt_grids();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_grid_1":
                    {
                        map_fl_grids map = new map_fl_grids();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_grid_1":
                    {
                        map_sxq_grids map = new map_sxq_grids();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                //case "fl_grid_1":
                //    {
                //        map_qt_grids map = new map_qt_grids();
                //        map.MdiParent = form;
                //        map.StartPosition = FormStartPosition.CenterScreen;
                //        map.Tag = ob;
                //        map.WindowState = FormWindowState.Normal;
                //        map.main = form;
                //        map.Show();
                //    }
                //    break;
                case "ct_blocks_1":
                    {
                        map_ct_grid_1 map = new map_ct_grid_1();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_1":
                    {
                        map_qt_grid_1 map = new map_qt_grid_1();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_1":
                    {
                        map_fl_grid_1 map = new map_fl_grid_1();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_1":
                    {
                        map_sxq_grid_1 map = new map_sxq_grid_1();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_2":
                    {
                        map_ct_grid_2 map = new map_ct_grid_2();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_2":
                    {
                        map_qt_grid_2 map = new map_qt_grid_2();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_2":
                    {
                        map_fl_grid_2 map = new map_fl_grid_2();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_2":
                    {
                        map_sxq_grid_2 map = new map_sxq_grid_2();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_3":
                    {
                        map_ct_grid_3 map = new map_ct_grid_3();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_3":
                    {
                        map_qt_grid_3 map = new map_qt_grid_3();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_3":
                    {
                        map_fl_grid_3 map = new map_fl_grid_3();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_3":
                    {
                        map_sxq_grid_3 map = new map_sxq_grid_3();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_4":
                    {
                        map_ct_grid_4 map = new map_ct_grid_4();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_4":
                    {
                        map_qt_grid_4 map = new map_qt_grid_4();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_4":
                    {
                        map_fl_grid_4 map = new map_fl_grid_4();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_4":
                    {
                        map_sxq_grid_4 map = new map_sxq_grid_4();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_5":
                    {
                        map_ct_grid_5 map = new map_ct_grid_5();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_5":
                    {
                        map_qt_grid_5 map = new map_qt_grid_5();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_5":
                    {
                        map_fl_grid_5 map = new map_fl_grid_5();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_5":
                    {
                        map_sxq_grid_5 map = new map_sxq_grid_5();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_6":
                    {
                        map_ct_grid_6 map = new map_ct_grid_6();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_6":
                    {
                        map_qt_grid_6 map = new map_qt_grid_6();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_6":
                    {
                        map_fl_grid_6 map = new map_fl_grid_6();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_6":
                    {
                        map_sxq_grid_6 map = new map_sxq_grid_6();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_7":
                    {
                        map_ct_grid_7 map = new map_ct_grid_7();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_7":
                    {
                        map_qt_grid_7 map = new map_qt_grid_7();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_7":
                    {
                        map_fl_grid_7 map = new map_fl_grid_7();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_7":
                    {
                        map_sxq_grid_7 map = new map_sxq_grid_7();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_8":
                    {
                        map_ct_grid_8 map = new map_ct_grid_8();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_8":
                    {
                        map_qt_grid_8 map = new map_qt_grid_8();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_8":
                    {
                        map_fl_grid_8 map = new map_fl_grid_8();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_8":
                    {
                        map_sxq_grid_8 map = new map_sxq_grid_8();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "ct_blocks_9":
                    {
                        map_ct_grid_9 map = new map_ct_grid_9();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_9":
                    {
                        map_qt_grid_9 map = new map_qt_grid_9();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_9":
                    {
                        map_fl_grid_9 map = new map_fl_grid_9();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_9":
                    {
                        map_sxq_grid_9 map = new map_sxq_grid_9();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "qt_blocks_10":
                    {
                        map_qt_grid_10 map = new map_qt_grid_10();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "fl_blocks_10":
                    {
                        map_fl_grid_10 map = new map_fl_grid_10();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                case "sxq_blocks_10":
                    {
                        map_sxq_grid_10 map = new map_sxq_grid_10();
                        map.MdiParent = form;
                        map.StartPosition = FormStartPosition.CenterScreen;
                        map.Tag = ob;
                        map.WindowState = FormWindowState.Normal;
                        map.main = form;
                        map.Show();
                    }
                    break;
                    //case "info_grid_10":
                    //    {
                    //        ListCtlNetForm1 Ctl1 = new ListCtlNetForm1();
                    //        Ctl1.MdiParent = form;
                    //        Ctl1.StartPosition = FormStartPosition.CenterScreen;
                    //        Ctl1.Tag = ob;
                    //        Ctl1.WindowState = FormWindowState.Maximized;
                    //        Ctl1.main = form;
                    //        Ctl1.Show();
                    //    }
                    //    break;


                    //case "info_grid_2"://草堂路社区网格2

                    //    ListCtlNetForm2 Ctl2 = new ListCtlNetForm2();
                    //    Ctl2.MdiParent = form;
                    //    Ctl2.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl2.Tag = ob;
                    //    Ctl2.WindowState = FormWindowState.Maximized;
                    //    Ctl2.main = form;
                    //    Ctl2.Show();
                    //    break;
                    //case "info_grid_3"://草堂路社区网格3

                    //    ListCtlNetForm3 Ctl3 = new ListCtlNetForm3();
                    //    Ctl3.MdiParent = form;
                    //    Ctl3.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl3.Tag = ob;
                    //    Ctl3.WindowState = FormWindowState.Maximized;
                    //    Ctl3.main = form;
                    //    Ctl3.Show();
                    //    break;
                    //case "info_grid_4"://草堂路社区网格4

                    //    ListCtlNetForm4 Ctl4 = new ListCtlNetForm4();
                    //    Ctl4.MdiParent = form;
                    //    Ctl4.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl4.Tag = ob;
                    //    Ctl4.WindowState = FormWindowState.Maximized;
                    //    Ctl4.main = form;
                    //    Ctl4.Show();
                    //    break;
                    //case "info_grid_5"://草堂路社区网格5

                    //    ListCtlNetForm5 Ctl5 = new ListCtlNetForm5();
                    //    Ctl5.MdiParent = form;
                    //    Ctl5.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl5.Tag = ob;
                    //    Ctl5.WindowState = FormWindowState.Maximized;
                    //    Ctl5.main = form;
                    //    Ctl5.Show();
                    //    break;
                    //case "info_grid_6"://草堂路社区网格6

                    //    ListCtlNetForm6 Ctl6 = new ListCtlNetForm6();
                    //    Ctl6.MdiParent = form;
                    //    Ctl6.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl6.Tag = ob;
                    //    Ctl6.WindowState = FormWindowState.Maximized;
                    //    Ctl6.main = form;
                    //    Ctl6.Show();
                    //    break;
                    //case "info_grid_7"://草堂路社区网格7

                    //    ListCtlNetForm7 Ctl7 = new ListCtlNetForm7();
                    //    Ctl7.MdiParent = form;
                    //    Ctl7.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl7.Tag = ob;
                    //    Ctl7.WindowState = FormWindowState.Maximized;
                    //    Ctl7.main = form;
                    //    Ctl7.Show();
                    //    break;
                    //case "info_grid_8"://草堂路社区网格8

                    //    ListCtlNetForm8 Ctl8 = new ListCtlNetForm8();
                    //    Ctl8.MdiParent = form;
                    //    Ctl8.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl8.Tag = ob;
                    //    Ctl8.WindowState = FormWindowState.Maximized;
                    //    Ctl8.main = form;
                    //    Ctl8.Show();
                    //    break;
                    //case "info_grid_9"://草堂路社区网格9

                    //    ListCtlNetForm9 Ctl9 = new ListCtlNetForm9();
                    //    Ctl9.MdiParent = form;
                    //    Ctl9.StartPosition = FormStartPosition.CenterScreen;
                    //    Ctl9.Tag = ob;
                    //    Ctl9.WindowState = FormWindowState.Maximized;
                    //    Ctl9.main = form;
                    //    Ctl9.Show();
                    //    break;

                    //case "map2":
                    //    {
                    //        map_qt map = new map_qt();
                    //        map.MdiParent = form;
                    //        map.StartPosition = FormStartPosition.CenterScreen;
                    //        map.Tag = ob;
                    //        map.WindowState = FormWindowState.Normal;
                    //        map.main = form;
                    //        map.Show();
                    //    }
                    //    break;
                    //case "qt_grid":
                    //    {
                    //        ListQtlFrom Qtl = new ListQtlFrom();
                    //        Qtl.MdiParent = form;
                    //        Qtl.StartPosition = FormStartPosition.CenterScreen;
                    //        Qtl.Tag = ob;
                    //        Qtl.main = form;
                    //        Qtl.district = "2";
                    //        Qtl.WindowState = FormWindowState.Maximized;
                    //        Qtl.Show();


                    //    }
                    //    break;
                    //case "map3":
                    //    {
                    //        map_fl map = new map_fl();
                    //        map.MdiParent = form;
                    //        map.StartPosition = FormStartPosition.CenterScreen;
                    //        map.Tag = ob;
                    //        map.WindowState = FormWindowState.Normal;
                    //        map.main = form;
                    //        map.Show();
                    //    }
                    //    break;
                    //case "fl_grid":
                    //    {
                    //        ListFllFrom Fll = new ListFllFrom();
                    //        Fll.MdiParent = form;
                    //        Fll.StartPosition = FormStartPosition.CenterScreen;
                    //        Fll.Tag = ob;
                    //        Fll.main = form;
                    //        Fll.district = "3";
                    //        Fll.WindowState = FormWindowState.Maximized;
                    //        Fll.Show();


                    //    }
                    //    break;
                    //case "map4":
                    //    {
                    //        map_sxq map = new map_sxq();
                    //        map.MdiParent = form;
                    //        map.StartPosition = FormStartPosition.CenterScreen;
                    //        map.Tag = ob;
                    //        map.WindowState = FormWindowState.Normal;
                    //        map.main = form;
                    //        map.Show();
                    //    }
                    //    break;
                    //case "sxq_grid":
                    //    {
                    //        ListCtlNetFrom1 sxq = new ListCtlNetFrom1();
                    //        sxq.MdiParent = form;
                    //        sxq.StartPosition = FormStartPosition.CenterScreen;
                    //        sxq.Tag = ob;
                    //        sxq.WindowState = FormWindowState.Maximized;
                    //        sxq.main = form;
                    //        sxq.Show();

                    //    }
                    //    break;
            }
        }

        public void ShowForm(Label la, Form form)
        {
            //switch (la.Tag.ToString())
            //{


            //    case "1"://草堂路社区

            //        ListCtlFrom Ctl = new ListCtlFrom();
            //        Ctl.MdiParent = form;
            //        Ctl.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl.Tag = la.Tag.ToString();
            //        Ctl.WindowState = FormWindowState.Maximized;
            //        Ctl.main = form;
            //        Ctl.district = "1";
            //        Ctl.Show();
            //        break;
            //    case "11"://草堂路社区网格1

            //        ListCtlNetForm1 Ctl1 = new ListCtlNetForm1();
            //        Ctl1.MdiParent = form;
            //        Ctl1.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl1.Tag = la.Tag.ToString();
            //        Ctl1.WindowState = FormWindowState.Maximized;
            //        Ctl1.main = form;
            //        Ctl1.Show();
            //        break;
            //    case "12"://草堂路社区网格2

            //        ListCtlNetForm2 Ctl2 = new ListCtlNetForm2();
            //        Ctl2.MdiParent = form;
            //        Ctl2.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl2.Tag = la.Tag.ToString();
            //        Ctl2.WindowState = FormWindowState.Maximized;
            //        Ctl2.main = form;
            //        Ctl2.Show();
            //        break;
            //    case "13"://草堂路社区网格3

            //        ListCtlNetForm3 Ctl3 = new ListCtlNetForm3();
            //        Ctl3.MdiParent = form;
            //        Ctl3.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl3.Tag = la.Tag.ToString();
            //        Ctl3.WindowState = FormWindowState.Maximized;
            //        Ctl3.main = form;
            //        Ctl3.Show();
            //        break;
            //    case "14"://草堂路社区网格4

            //        ListCtlNetForm4 Ctl4 = new ListCtlNetForm4();
            //        Ctl4.MdiParent = form;
            //        Ctl4.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl4.Tag = la.Tag.ToString();
            //        Ctl4.WindowState = FormWindowState.Maximized;
            //        Ctl4.main = form;
            //        Ctl4.Show();
            //        break;
            //    case "15"://草堂路社区网格5

            //        ListCtlNetForm5 Ctl5 = new ListCtlNetForm5();
            //        Ctl5.MdiParent = form;
            //        Ctl5.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl5.Tag = la.Tag.ToString();
            //        Ctl5.WindowState = FormWindowState.Maximized;
            //        Ctl5.main = form;
            //        Ctl5.Show();
            //        break;
            //    case "16"://草堂路社区网格6

            //        ListCtlNetForm6 Ctl6 = new ListCtlNetForm6();
            //        Ctl6.MdiParent = form;
            //        Ctl6.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl6.Tag = la.Tag.ToString();
            //        Ctl6.WindowState = FormWindowState.Maximized;
            //        Ctl6.main = form;
            //        Ctl6.Show();
            //        break;
            //    case "17"://草堂路社区网格7

            //        ListCtlNetForm7 Ctl7 = new ListCtlNetForm7();
            //        Ctl7.MdiParent = form;
            //        Ctl7.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl7.Tag = la.Tag.ToString();
            //        Ctl7.WindowState = FormWindowState.Maximized;
            //        Ctl7.main = form;
            //        Ctl7.Show();
            //        break;
            //    case "18"://草堂路社区网格8

            //        ListCtlNetForm8 Ctl8 = new ListCtlNetForm8();
            //        Ctl8.MdiParent = form;
            //        Ctl8.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl8.Tag = la.Tag.ToString();
            //        Ctl8.WindowState = FormWindowState.Maximized;
            //        Ctl8.main = form;
            //        Ctl8.Show();
            //        break;
            //    case "19"://草堂路社区网格9

            //        ListCtlNetForm9 Ctl9 = new ListCtlNetForm9();
            //        Ctl9.MdiParent = form;
            //        Ctl9.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl9.Tag = la.Tag.ToString();
            //        Ctl9.WindowState = FormWindowState.Maximized;
            //        Ctl9.main = form;
            //        Ctl9.Show();
            //        break;
            //    case "21"://琴台路社区网格1

            //        ListQtlNetForm1 Qtl1 = new ListQtlNetForm1();
            //        Qtl1.MdiParent = form;
            //        Qtl1.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl1.Tag = la.Tag.ToString();
            //        Qtl1.WindowState = FormWindowState.Maximized;
            //        Qtl1.main = form;
            //        Qtl1.Show();
            //        break;
            //    case "22"://琴台路社区网格2

            //        ListQtlNetForm2 Qtl2 = new ListQtlNetForm2();
            //        Qtl2.MdiParent = form;
            //        Qtl2.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl2.Tag = la.Tag.ToString();
            //        Qtl2.WindowState = FormWindowState.Maximized;
            //        Qtl2.main = form;
            //        Qtl2.Show();
            //        break;
            //    case "23"://琴台路社区网格3

            //        ListQtlNetForm3 Qtl3 = new ListQtlNetForm3();
            //        Qtl3.MdiParent = form;
            //        Qtl3.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl3.Tag = la.Tag.ToString();
            //        Qtl3.WindowState = FormWindowState.Maximized;
            //        Qtl3.main = form;
            //        Qtl3.Show();
            //        break;
            //    case "24"://琴台路社区网格4

            //        ListQtlNetForm4 Qtl4 = new ListQtlNetForm4();
            //        Qtl4.MdiParent = form;
            //        Qtl4.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl4.Tag = la.Tag.ToString();
            //        Qtl4.WindowState = FormWindowState.Maximized;
            //        Qtl4.main = form;
            //        Qtl4.Show();
            //        break;
            //    case "25"://琴台路社区网格5

            //        ListQtlNetForm5 Qtl5 = new ListQtlNetForm5();
            //        Qtl5.MdiParent = form;
            //        Qtl5.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl5.Tag = la.Tag.ToString();
            //        Qtl5.WindowState = FormWindowState.Maximized;
            //        Qtl5.main = form;
            //        Qtl5.Show();
            //        break;
            //    case "26"://琴台路社区网格6

            //        ListQtlNetForm6 Qtl6 = new ListQtlNetForm6();
            //        Qtl6.MdiParent = form;
            //        Qtl6.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl6.Tag = la.Tag.ToString();
            //        Qtl6.WindowState = FormWindowState.Maximized;
            //        Qtl6.main = form;
            //        Qtl6.Show();
            //        break;
            //    case "27"://琴台路社区网格7

            //        ListQtlNetForm7 Qtl7 = new ListQtlNetForm7();
            //        Qtl7.MdiParent = form;
            //        Qtl7.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl7.Tag = la.Tag.ToString();
            //        Qtl7.WindowState = FormWindowState.Maximized;
            //        Qtl7.main = form;
            //        Qtl7.Show();
            //        break;
            //    case "28"://琴台路社区网格8

            //        ListQtlNetForm8 Qtl8 = new ListQtlNetForm8();
            //        Qtl8.MdiParent = form;
            //        Qtl8.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl8.Tag = la.Tag.ToString();
            //        Qtl8.WindowState = FormWindowState.Maximized;
            //        Qtl8.main = form;
            //        Qtl8.Show();
            //        break;
            //    case "29"://琴台路社区网格9

            //        ListQtlNetForm9 Qtl9 = new ListQtlNetForm9();
            //        Qtl9.MdiParent = form;
            //        Qtl9.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl9.Tag = la.Tag.ToString();
            //        Qtl9.WindowState = FormWindowState.Maximized;
            //        Qtl9.main = form;
            //        Qtl9.Show();
            //        break;
            //    case "31"://芳邻街社区网格1

            //        ListFllNetForm1 Fll1 = new ListFllNetForm1();
            //        Fll1.MdiParent = form;
            //        Fll1.StartPosition = FormStartPosition.CenterScreen;
            //        Fll1.Tag = la.Tag.ToString();
            //        Fll1.WindowState = FormWindowState.Maximized;
            //        Fll1.main = form;
            //        Fll1.Show();
            //        break;
            //    case "32"://芳邻街社区网格2

            //        ListFllNetForm2 Fll2 = new ListFllNetForm2();
            //        Fll2.MdiParent = form;
            //        Fll2.StartPosition = FormStartPosition.CenterScreen;
            //        Fll2.Tag = la.Tag.ToString();
            //        Fll2.WindowState = FormWindowState.Maximized;
            //        Fll2.main = form;
            //        Fll2.Show();
            //        break;
            //    case "33"://芳邻街社区网格3

            //        ListFllNetForm3 Fll3 = new ListFllNetForm3();
            //        Fll3.MdiParent = form;
            //        Fll3.StartPosition = FormStartPosition.CenterScreen;
            //        Fll3.Tag = la.Tag.ToString();
            //        Fll3.WindowState = FormWindowState.Maximized;
            //        Fll3.main = form;
            //        Fll3.Show();
            //        break;
            //    case "34"://芳邻街社区网格4

            //        ListFllNetForm4 Fll4 = new ListFllNetForm4();
            //        Fll4.MdiParent = form;
            //        Fll4.StartPosition = FormStartPosition.CenterScreen;
            //        Fll4.Tag = la.Tag.ToString();
            //        Fll4.WindowState = FormWindowState.Maximized;
            //        Fll4.main = form;
            //        Fll4.Show();
            //        break;
            //    case "35"://芳邻街社区网格5

            //        ListFllNetForm5 Fll5 = new ListFllNetForm5();
            //        Fll5.MdiParent = form;
            //        Fll5.StartPosition = FormStartPosition.CenterScreen;
            //        Fll5.Tag = la.Tag.ToString();
            //        Fll5.WindowState = FormWindowState.Maximized;
            //        Fll5.main = form;
            //        Fll5.Show();
            //        break;
            //    case "36"://芳邻街社区网格6

            //        ListFllNetForm6 Fll6 = new ListFllNetForm6();
            //        Fll6.MdiParent = form;
            //        Fll6.StartPosition = FormStartPosition.CenterScreen;
            //        Fll6.Tag = la.Tag.ToString();
            //        Fll6.WindowState = FormWindowState.Maximized;
            //        Fll6.main = form;
            //        Fll6.Show();
            //        break;
            //    case "37"://芳邻街社区网格7

            //        ListFllNetForm7 Fll7 = new ListFllNetForm7();
            //        Fll7.MdiParent = form;
            //        Fll7.StartPosition = FormStartPosition.CenterScreen;
            //        Fll7.Tag = la.Tag.ToString();
            //        Fll7.WindowState = FormWindowState.Maximized;
            //        Fll7.main = form;
            //        Fll7.Show();
            //        break;
            //    case "38"://芳邻街社区网格8

            //        ListFllNetForm8 Fll8 = new ListFllNetForm8();
            //        Fll8.MdiParent = form;
            //        Fll8.StartPosition = FormStartPosition.CenterScreen;
            //        Fll8.Tag = la.Tag.ToString();
            //        Fll8.WindowState = FormWindowState.Maximized;
            //        Fll8.main = form;
            //        Fll8.Show();
            //        break;
            //    case "39"://芳邻街社区网格9

            //        ListFllNetForm9 Fll9 = new ListFllNetForm9();
            //        Fll9.MdiParent = form;
            //        Fll9.StartPosition = FormStartPosition.CenterScreen;
            //        Fll9.Tag = la.Tag.ToString();
            //        Fll9.WindowState = FormWindowState.Maximized;
            //        Fll9.main = form;
            //        Fll9.Show();
            //        break;
            //    case "41"://送仙桥社区网格1

            //        ListSxqNetForm1 Sxq1 = new ListSxqNetForm1();
            //        Sxq1.MdiParent = form;
            //        Sxq1.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq1.Tag = la.Tag.ToString();
            //        Sxq1.WindowState = FormWindowState.Maximized;
            //        Sxq1.main = form;
            //        Sxq1.Show();
            //        break;
            //    case "42"://送仙桥社区网格2

            //        ListSxqNetForm2 Sxq2 = new ListSxqNetForm2();
            //        Sxq2.MdiParent = form;
            //        Sxq2.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq2.Tag = la.Tag.ToString();
            //        Sxq2.WindowState = FormWindowState.Maximized;
            //        Sxq2.main = form;
            //        Sxq2.Show();
            //        break;
            //    case "43"://送仙桥社区网格3

            //        ListSxqNetForm3 Sxq3 = new ListSxqNetForm3();
            //        Sxq3.MdiParent = form;
            //        Sxq3.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq3.Tag = la.Tag.ToString();
            //        Sxq3.WindowState = FormWindowState.Maximized;
            //        Sxq3.main = form;
            //        Sxq3.Show();
            //        break;
            //    case "44"://送仙桥社区网格4

            //        ListSxqNetForm4 Sxq4 = new ListSxqNetForm4();
            //        Sxq4.MdiParent = form;
            //        Sxq4.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq4.Tag = la.Tag.ToString();
            //        Sxq4.WindowState = FormWindowState.Maximized;
            //        Sxq4.main = form;
            //        Sxq4.Show();
            //        break;
            //    case "45"://送仙桥社区网格5

            //        ListSxqNetForm5 Sxq5 = new ListSxqNetForm5();
            //        Sxq5.MdiParent = form;
            //        Sxq5.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq5.Tag = la.Tag.ToString();
            //        Sxq5.WindowState = FormWindowState.Maximized;
            //        Sxq5.main = form;
            //        Sxq5.Show();
            //        break;
            //    case "46"://送仙桥社区网格6

            //        ListSxqNetForm6 Sxq6 = new ListSxqNetForm6();
            //        Sxq6.MdiParent = form;
            //        Sxq6.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq6.Tag = la.Tag.ToString();
            //        Sxq6.WindowState = FormWindowState.Maximized;
            //        Sxq6.main = form;
            //        Sxq6.Show();
            //        break;
            //    case "47"://送仙桥社区网格7

            //        ListSxqNetForm7 Sxq7 = new ListSxqNetForm7();
            //        Sxq7.MdiParent = form;
            //        Sxq7.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq7.Tag = la.Tag.ToString();
            //        Sxq7.WindowState = FormWindowState.Maximized;
            //        Sxq7.main = form;
            //        Sxq7.Show();
            //        break;
            //    case "48"://送仙桥社区网格8

            //        ListSxqNetForm8 Sxq8 = new ListSxqNetForm8();
            //        Sxq8.MdiParent = form;
            //        Sxq8.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq8.Tag = la.Tag.ToString();
            //        Sxq8.WindowState = FormWindowState.Maximized;
            //        Sxq8.main = form;
            //        Sxq8.Show();
            //        break;
            //    case "49"://送仙桥社区网格9

            //        ListSxqNetForm9 Sxq9 = new ListSxqNetForm9();
            //        Sxq9.MdiParent = form;
            //        Sxq9.StartPosition = FormStartPosition.CenterScreen;
            //        Sxq9.Tag = la.Tag.ToString();
            //        Sxq9.WindowState = FormWindowState.Maximized;
            //        Sxq9.main = form;
            //        Sxq9.Show();
            //        break;


            //    case "111":
            //    case "112":
            //    case "113":
            //    case "114":
            //    case "121":
            //    case "131":
            //    case "132":
            //    case "133":
            //    case "134":
            //    case "135":
            //    case "136":
            //    case "141":
            //    case "142":
            //    case "143":
            //    case "151":
            //    case "152":
            //    case "153":
            //    case "161":
            //    case "171":
            //    case "172":
            //    case "181":
            //    case "182":
            //    case "191":
            //    case "192":
            //    case "193":
            //    case "211":
            //    case "212":
            //    case "213":
            //    case "214":
            //    case "221":
            //    case "222":
            //    case "223":
            //    case "224":
            //    case "231":
            //    case "232":
            //    case "233":
            //    case "234":
            //    case "241":
            //    case "242":
            //    case "243":
            //    case "244":
            //    case "245":
            //    case "251":
            //    case "252":
            //    case "253":
            //    case "254":
            //    case "261":
            //    case "262":
            //    case "263":
            //    case "264":
            //    case "271":
            //    case "272":
            //    case "273":
            //    case "274":
            //    case "275":
            //    case "276":
            //    case "281":
            //    case "282":
            //    case "283":
            //    case "284":
            //    case "285":
            //    case "291":
            //    case "292":
            //    case "293":
            //    case "294":
            //    case "295":
            //    case "311":
            //    case "312":
            //    case "313":
            //    case "314":
            //    case "315":
            //    case "321":
            //    case "331":
            //    case "332":
            //    case "333":
            //    case "334":
            //    case "335":
            //    case "341":
            //    case "342":
            //    case "343":
            //    case "344":
            //    case "345":
            //    case "346":
            //    case "347":
            //    case "348":
            //    case "351":
            //    case "352":
            //    case "353":
            //    case "361":
            //    case "362":
            //    case "363":
            //    case "371":
            //    case "372":
            //    case "373":
            //    case "374":
            //    case "375":
            //    case "376":
            //    case "381":
            //    case "391":
            //    case "392":
            //    case "393":
            //    case "394":
            //    case "411":
            //    case "412":
            //    case "413":
            //    case "414":
            //    case "421":
            //    case "422":
            //    case "423":
            //    case "424":
            //    case "425":
            //    case "426":
            //    case "431":
            //    case "432":
            //    case "433":
            //    case "441":
            //    case "442":
            //    case "443":
            //    case "451":
            //    case "452":
            //    case "453":
            //    case "461":
            //    case "462":
            //    case "463":
            //    case "464":
            //    case "471":
            //    case "472":
            //    case "473":
            //    case "481":
            //    case "482":
            //    case "483":
            //    case "491":
            //    case "492":
            //        ListCtlNetBlockPersonForm Ctl11 = new ListCtlNetBlockPersonForm();
            //        Ctl11.MdiParent = form;
            //        Ctl11.StartPosition = FormStartPosition.CenterScreen;
            //        Ctl11.Tag = la.Tag.ToString();
            //        Ctl11.WindowState = FormWindowState.Maximized;
            //        Ctl11.main = form;
            //        Ctl11.resident = Convert.ToInt16(la.Tag.ToString()[0].ToString());
            //        Ctl11.grid = Convert.ToInt16(la.Tag.ToString()[1].ToString());
            //        Ctl11.block = Convert.ToInt16(la.Tag.ToString()[2].ToString());
            //        Ctl11.Show();
            //        break;





            //    case "2"://列表

            //        ListQtlFrom Qtl = new ListQtlFrom();
            //        Qtl.MdiParent = form;
            //        Qtl.StartPosition = FormStartPosition.CenterScreen;
            //        Qtl.Tag = la.Tag.ToString();
            //        Qtl.main = form;
            //        Qtl.district = "2";
            //        Qtl.WindowState = FormWindowState.Maximized;
            //        Qtl.Show();
            //        break;




            //    case "3"://列表

            //        ListFllFrom Fll = new ListFllFrom();
            //        Fll.MdiParent = form;
            //        Fll.StartPosition = FormStartPosition.CenterScreen;
            //        Fll.Tag = la.Tag.ToString();
            //        Fll.main = form;
            //        Fll.district = "3";
            //        Fll.WindowState = FormWindowState.Maximized;
            //        Fll.Show();
            //        break;
            //    case "4"://列表

            //        ListCtlNetFrom1 sxq = new ListCtlNetFrom1();
            //        sxq.MdiParent = form;
            //        sxq.StartPosition = FormStartPosition.CenterScreen;
            //        sxq.Tag = la.Tag.ToString();
            //        sxq.WindowState = FormWindowState.Maximized;
            //        sxq.main = form;
            //        sxq.Show();

            //        break;
            //    case "m1":
            //    case "m2":
            //    case "m3":
            //    case "m4":
            //    case "m5":
            //    case "m6":
            //    case "m7":
            //    case "m8":
            //    case "m9":
            //    case "m10":
            //    case "m11":
            //    case "m12":
            //    case "m13":
            //    case "m14":
            //    case "m15":
            //    case "m101":
            //    case "m102":
            //    case "m103":
            //    case "m104":
            //    case "m105":
            //    case "m106":
            //    case "m107":
            //    case "m108":
            //    case "m109":
            //    case "m110":
            //    case "m111":
            //    case "m112":
            //    case "m113":
            //    case "m114":
            //    case "m115":


            //    case "m201":
            //    case "m202":
            //    case "m203":
            //    case "m204":
            //    case "m205":
            //    case "m206":
            //    case "m207":
            //    case "m208":
            //    case "m209":
            //    case "m210":
            //    case "m211":
            //    case "m212":
            //    case "m213":
            //    case "m214":
            //    case "m215":

            //    case "m301":
            //    case "m302":
            //    case "m303":
            //    case "m304":
            //    case "m305":
            //    case "m306":
            //    case "m307":
            //    case "m308":
            //    case "m309":
            //    case "m310":
            //    case "m311":
            //    case "m312":
            //    case "m313":
            //    case "m314":
            //    case "m315":

            //    case "m401":
            //    case "m402":
            //    case "m403":
            //    case "m404":
            //    case "m405":
            //    case "m406":
            //    case "m407":
            //    case "m408":
            //    case "m409":
            //    case "m410":
            //    case "m411":
            //    case "m412":
            //    case "m413":
            //    case "m414":
            //    case "m415":

            //    case "m10101":
            //    case "m10102":
            //    case "m10103":
            //    case "m10104":
            //    case "m10105":
            //    case "m10106":
            //    case "m10107":
            //    case "m10108":
            //    case "m10109":
            //    case "m10110":
            //    case "m10111":
            //    case "m10112":
            //    case "m10113":
            //    case "m10114":
            //    case "m10115":

            //    case "m10201":
            //    case "m10202":
            //    case "m10203":
            //    case "m10204":
            //    case "m10205":
            //    case "m10206":
            //    case "m10207":
            //    case "m10208":
            //    case "m10209":
            //    case "m10210":
            //    case "m10211":
            //    case "m10212":
            //    case "m10213":
            //    case "m10214":
            //    case "m10215":

            //    case "m10301":
            //    case "m10302":
            //    case "m10303":
            //    case "m10304":
            //    case "m10305":
            //    case "m10306":
            //    case "m10307":
            //    case "m10308":
            //    case "m10309":
            //    case "m10310":
            //    case "m10311":
            //    case "m10312":
            //    case "m10313":
            //    case "m10314":
            //    case "m10315":

            //    case "m10401":
            //    case "m10402":
            //    case "m10403":
            //    case "m10404":
            //    case "m10405":
            //    case "m10406":
            //    case "m10407":
            //    case "m10408":
            //    case "m10409":
            //    case "m10410":
            //    case "m10411":
            //    case "m10412":
            //    case "m10413":
            //    case "m10414":
            //    case "m10415":

            //    case "m10501":
            //    case "m10502":
            //    case "m10503":
            //    case "m10504":
            //    case "m10505":
            //    case "m10506":
            //    case "m10507":
            //    case "m10508":
            //    case "m10509":
            //    case "m10510":
            //    case "m10511":
            //    case "m10512":
            //    case "m10513":
            //    case "m10514":
            //    case "m10515":

            //    case "m10601":
            //    case "m10602":
            //    case "m10603":
            //    case "m10604":
            //    case "m10605":
            //    case "m10606":
            //    case "m10607":
            //    case "m10608":
            //    case "m10609":
            //    case "m10610":
            //    case "m10611":
            //    case "m10612":
            //    case "m10613":
            //    case "m10614":
            //    case "m10615":

            //    case "m10701":
            //    case "m10702":
            //    case "m10703":
            //    case "m10704":
            //    case "m10705":
            //    case "m10706":
            //    case "m10707":
            //    case "m10708":
            //    case "m10709":
            //    case "m10710":
            //    case "m10711":
            //    case "m10712":
            //    case "m10713":
            //    case "m10714":
            //    case "m10715":

            //    case "m10801":
            //    case "m10802":
            //    case "m10803":
            //    case "m10804":
            //    case "m10805":
            //    case "m10806":
            //    case "m10807":
            //    case "m10808":
            //    case "m10809":
            //    case "m10810":
            //    case "m10811":
            //    case "m10812":
            //    case "m10813":
            //    case "m10814":
            //    case "m10815":

            //    case "m10901":
            //    case "m10902":
            //    case "m10903":
            //    case "m10904":
            //    case "m10905":
            //    case "m10906":
            //    case "m10907":
            //    case "m10908":
            //    case "m10909":
            //    case "m10910":
            //    case "m10911":
            //    case "m10912":
            //    case "m10913":
            //    case "m10914":
            //    case "m10915":
            //    case "m20101":
            //    case "m20102":
            //    case "m20103":
            //    case "m20104":
            //    case "m20105":
            //    case "m20106":
            //    case "m20107":
            //    case "m20108":
            //    case "m20109":
            //    case "m20110":
            //    case "m20111":
            //    case "m20112":
            //    case "m20113":
            //    case "m20114":
            //    case "m20115":

            //    case "m20201":
            //    case "m20202":
            //    case "m20203":
            //    case "m20204":
            //    case "m20205":
            //    case "m20206":
            //    case "m20207":
            //    case "m20208":
            //    case "m20209":
            //    case "m20210":
            //    case "m20211":
            //    case "m20212":
            //    case "m20213":
            //    case "m20214":
            //    case "m20215":

            //    case "m20301":
            //    case "m20302":
            //    case "m20303":
            //    case "m20304":
            //    case "m20305":
            //    case "m20306":
            //    case "m20307":
            //    case "m20308":
            //    case "m20309":
            //    case "m20310":
            //    case "m20311":
            //    case "m20312":
            //    case "m20313":
            //    case "m20314":
            //    case "m20315":

            //    case "m20401":
            //    case "m20402":
            //    case "m20403":
            //    case "m20404":
            //    case "m20405":
            //    case "m20406":
            //    case "m20407":
            //    case "m20408":
            //    case "m20409":
            //    case "m20410":
            //    case "m20411":
            //    case "m20412":
            //    case "m20413":
            //    case "m20414":
            //    case "m20415":

            //    case "m20501":
            //    case "m20502":
            //    case "m20503":
            //    case "m20504":
            //    case "m20505":
            //    case "m20506":
            //    case "m20507":
            //    case "m20508":
            //    case "m20509":
            //    case "m20510":
            //    case "m20511":
            //    case "m20512":
            //    case "m20513":
            //    case "m20514":
            //    case "m20515":

            //    case "m20601":
            //    case "m20602":
            //    case "m20603":
            //    case "m20604":
            //    case "m20605":
            //    case "m20606":
            //    case "m20607":
            //    case "m20608":
            //    case "m20609":
            //    case "m20610":
            //    case "m20611":
            //    case "m20612":
            //    case "m20613":
            //    case "m20614":
            //    case "m20615":

            //    case "m20701":
            //    case "m20702":
            //    case "m20703":
            //    case "m20704":
            //    case "m20705":
            //    case "m20706":
            //    case "m20707":
            //    case "m20708":
            //    case "m20709":
            //    case "m20710":
            //    case "m20711":
            //    case "m20712":
            //    case "m20713":
            //    case "m20714":
            //    case "m20715":

            //    case "m20801":
            //    case "m20802":
            //    case "m20803":
            //    case "m20804":
            //    case "m20805":
            //    case "m20806":
            //    case "m20807":
            //    case "m20808":
            //    case "m20809":
            //    case "m20810":
            //    case "m20811":
            //    case "m20812":
            //    case "m20813":
            //    case "m20814":
            //    case "m20815":

            //    case "m20901":
            //    case "m20902":
            //    case "m20903":
            //    case "m20904":
            //    case "m20905":
            //    case "m20906":
            //    case "m20907":
            //    case "m20908":
            //    case "m20909":
            //    case "m20910":
            //    case "m20911":
            //    case "m20912":
            //    case "m20913":
            //    case "m20914":
            //    case "m20915":

            //    case "m20001":
            //    case "m20002":
            //    case "m20003":
            //    case "m20004":
            //    case "m20005":
            //    case "m20006":
            //    case "m20007":
            //    case "m20008":
            //    case "m20009":
            //    case "m20010":
            //    case "m20011":
            //    case "m20012":
            //    case "m20013":
            //    case "m20014":
            //    case "m20015":

            //    case "m30101":
            //    case "m30102":
            //    case "m30103":
            //    case "m30104":
            //    case "m30105":
            //    case "m30106":
            //    case "m30107":
            //    case "m30108":
            //    case "m30109":
            //    case "m30110":
            //    case "m30111":
            //    case "m30112":
            //    case "m30113":
            //    case "m30114":
            //    case "m30115":

            //    case "m30201":
            //    case "m30202":
            //    case "m30203":
            //    case "m30204":
            //    case "m30205":
            //    case "m30206":
            //    case "m30207":
            //    case "m30208":
            //    case "m30209":
            //    case "m30210":
            //    case "m30211":
            //    case "m30212":
            //    case "m30213":
            //    case "m30214":
            //    case "m30215":

            //    case "m30301":
            //    case "m30302":
            //    case "m30303":
            //    case "m30304":
            //    case "m30305":
            //    case "m30306":
            //    case "m30307":
            //    case "m30308":
            //    case "m30309":
            //    case "m30310":
            //    case "m30311":
            //    case "m30312":
            //    case "m30313":
            //    case "m30314":
            //    case "m30315":

            //    case "m30401":
            //    case "m30402":
            //    case "m30403":
            //    case "m30404":
            //    case "m30405":
            //    case "m30406":
            //    case "m30407":
            //    case "m30408":
            //    case "m30409":
            //    case "m30410":
            //    case "m30411":
            //    case "m30412":
            //    case "m30413":
            //    case "m30414":
            //    case "m30415":

            //    case "m30501":
            //    case "m30502":
            //    case "m30503":
            //    case "m30504":
            //    case "m30505":
            //    case "m30506":
            //    case "m30507":
            //    case "m30508":
            //    case "m30509":
            //    case "m30510":
            //    case "m30511":
            //    case "m30512":
            //    case "m30513":
            //    case "m30514":
            //    case "m30515":

            //    case "m30601":
            //    case "m30602":
            //    case "m30603":
            //    case "m30604":
            //    case "m30605":
            //    case "m30606":
            //    case "m30607":
            //    case "m30608":
            //    case "m30609":
            //    case "m30610":
            //    case "m30611":
            //    case "m30612":
            //    case "m30613":
            //    case "m30614":
            //    case "m30615":

            //    case "m30701":
            //    case "m30702":
            //    case "m30703":
            //    case "m30704":
            //    case "m30705":
            //    case "m30706":
            //    case "m30707":
            //    case "m30708":
            //    case "m30709":
            //    case "m30710":
            //    case "m30711":
            //    case "m30712":
            //    case "m30713":
            //    case "m30714":
            //    case "m30715":

            //    case "m30801":
            //    case "m30802":
            //    case "m30803":
            //    case "m30804":
            //    case "m30805":
            //    case "m30806":
            //    case "m30807":
            //    case "m30808":
            //    case "m30809":
            //    case "m30810":
            //    case "m30811":
            //    case "m30812":
            //    case "m30813":
            //    case "m30814":
            //    case "m30815":

            //    case "m30901":
            //    case "m30902":
            //    case "m30903":
            //    case "m30904":
            //    case "m30905":
            //    case "m30906":
            //    case "m30907":
            //    case "m30908":
            //    case "m30909":
            //    case "m30910":
            //    case "m30911":
            //    case "m30912":
            //    case "m30913":
            //    case "m30914":
            //    case "m30915":

            //    case "m30001":
            //    case "m3002":
            //    case "m30003":
            //    case "m30004":
            //    case "m30005":
            //    case "m30006":
            //    case "m30007":
            //    case "m30008":
            //    case "m30009":
            //    case "m30010":
            //    case "m30011":
            //    case "m30012":
            //    case "m30013":
            //    case "m30014":
            //    case "m30015":

            //    case "m40101":
            //    case "m40102":
            //    case "m40103":
            //    case "m40104":
            //    case "m40105":
            //    case "m40106":
            //    case "m40107":
            //    case "m40108":
            //    case "m40109":
            //    case "m40110":
            //    case "m40111":
            //    case "m40112":
            //    case "m40113":
            //    case "m40114":
            //    case "m40115":

            //    case "m40201":
            //    case "m40202":
            //    case "m40203":
            //    case "m40204":
            //    case "m40205":
            //    case "m40206":
            //    case "m40207":
            //    case "m40208":
            //    case "m40209":
            //    case "m40210":
            //    case "m40211":
            //    case "m40212":
            //    case "m40213":
            //    case "m40214":
            //    case "m40215":

            //    case "m40301":
            //    case "m40302":
            //    case "m40303":
            //    case "m40304":
            //    case "m40305":
            //    case "m40306":
            //    case "m40307":
            //    case "m40308":
            //    case "m40309":
            //    case "m40310":
            //    case "m40311":
            //    case "m40312":
            //    case "m40313":
            //    case "m40314":
            //    case "m40315":

            //    case "m40401":
            //    case "m40402":
            //    case "m40403":
            //    case "m40404":
            //    case "m40405":
            //    case "m40406":
            //    case "m40407":
            //    case "m40408":
            //    case "m40409":
            //    case "m40410":
            //    case "m40411":
            //    case "m40412":
            //    case "m40413":
            //    case "m40414":
            //    case "m40415":

            //    case "m40501":
            //    case "m40502":
            //    case "m40503":
            //    case "m40504":
            //    case "m40505":
            //    case "m40506":
            //    case "m40507":
            //    case "m40508":
            //    case "m40509":
            //    case "m40510":
            //    case "m40511":
            //    case "m40512":
            //    case "m40513":
            //    case "m40514":
            //    case "m40515":

            //    case "m40601":
            //    case "m40602":
            //    case "m40603":
            //    case "m40604":
            //    case "m40605":
            //    case "m40606":
            //    case "m40607":
            //    case "m40608":
            //    case "m40609":
            //    case "m40610":
            //    case "m40611":
            //    case "m40612":
            //    case "m40613":
            //    case "m40614":
            //    case "m40615":

            //    case "m40701":
            //    case "m40702":
            //    case "m40703":
            //    case "m40704":
            //    case "m40705":
            //    case "m40706":
            //    case "m40707":
            //    case "m40708":
            //    case "m40709":
            //    case "m40710":
            //    case "m40711":
            //    case "m40712":
            //    case "m40713":
            //    case "m40714":
            //    case "m40715":

            //    case "m40801":
            //    case "m40802":
            //    case "m40803":
            //    case "m40804":
            //    case "m40805":
            //    case "m40806":
            //    case "m40807":
            //    case "m40808":
            //    case "m40809":
            //    case "m40810":
            //    case "m40811":
            //    case "m40812":
            //    case "m40813":
            //    case "m40814":
            //    case "m40815":

            //    case "m40901":
            //    case "m40902":
            //    case "m40903":
            //    case "m40904":
            //    case "m40905":
            //    case "m40906":
            //    case "m40907":
            //    case "m40908":
            //    case "m40909":
            //    case "m40910":
            //    case "m40911":
            //    case "m40912":
            //    case "m40913":
            //    case "m40914":
            //    case "m40915":

            //    case "m40001":
            //    case "m40002":
            //    case "m40003":
            //    case "m40004":
            //    case "m40005":
            //    case "m40006":
            //    case "m40007":
            //    case "m40008":
            //    case "m40009":
            //    case "m40010":
            //    case "m40011":
            //    case "m40012":
            //    case "m40013":
            //    case "m40014":
            //    case "m40015":
            //        ppmanager m1 = new ppmanager();

            //        m1.MdiParent = form;
            //        m1.StartPosition = FormStartPosition.CenterScreen;
            //        m1.Tag = la.Tag.ToString();
            //        m1.WindowState = FormWindowState.Maximized;
            //        m1.Show();
            //        break;


            //}
        }

        public void district_gird_block(ComboBox cb1, ComboBox cb2, string from1, string from2)
        {

            //string index = null;
            //    List<item> items = new List<item>();
            //    MySqlDataReader sdr;
            //    item it = (item)cb_grid.SelectedItem;
            //    index = it.Value;
            //    sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = " + index);
            //    while (sdr.Read())
            //    {
            //        item its = new item(sdr[0].ToString(), sdr[1].ToString());
            //        items.Add(its);
            //    }
            //     sdr.Close();
            //     cb_block.DataSource = items;

            string sqlcmd = "SELECT grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = ";
            sqlcmd = sqlcmd.Replace("grid", from2);
            sqlcmd = sqlcmd.Replace("district", from1);

            string index = null;
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            if (cb1.SelectedItem != null)
            {
                item it = (item)cb1.SelectedItem;
                index = it.Value;

                // sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = " + index);
                sdr = db.GetDataReader(sqlcmd + index);
                while (sdr.Read())
                {
                    item its = new item(sdr[0].ToString(), sdr[1].ToString());
                    items.Add(its);
                }
                sdr.Close();
                cb2.DataSource = items;
            }
            
        }

        public void load_district(ComboBox district, ComboBox grid, ComboBox block)
        {
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            sdr = db.GetDataReader("SELECT district.`name`,district.`id` FROM district");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            district.DataSource = items;
            //   items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            grid.DataSource = items;
            //  items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            block.DataSource = items;
            //  items.Clear();
            sdr.Close();
        }
    }
}
