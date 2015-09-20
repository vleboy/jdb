using System.Windows.Forms;

namespace jdb
{
    partial class ppmanager
    {
        public Main main = null;
        public string grid = null;
        public string district = null;
        public string block = null;
        public string street = null;
        public string cmd = null;
        ///// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sssq_cb = new System.Windows.Forms.ComboBox();
            this.sswg_cb = new System.Windows.Forms.ComboBox();
            this.ssyl_cb = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.cbox_sssq = new System.Windows.Forms.CheckBox();
            this.cbox_grid = new System.Windows.Forms.CheckBox();
            this.cb_block = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.released = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jwry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.old_alone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.old = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handicapped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ylmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.griddgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.back.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回ToolStripMenuItem,
            this.添加人员ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1904, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.返回ToolStripMenuItem.Tag = "";
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // 添加人员ToolStripMenuItem
            // 
            this.添加人员ToolStripMenuItem.Name = "添加人员ToolStripMenuItem";
            this.添加人员ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加人员ToolStripMenuItem.Tag = "add";
            this.添加人员ToolStripMenuItem.Text = "添加人员";
            this.添加人员ToolStripMenuItem.Visible = false;
            this.添加人员ToolStripMenuItem.Click += new System.EventHandler(this.添加人员ToolStripMenuItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_block);
            this.groupBox1.Controls.Add(this.cbox_grid);
            this.groupBox1.Controls.Add(this.cbox_sssq);
            this.groupBox1.Controls.Add(this.checkBox15);
            this.groupBox1.Controls.Add(this.checkBox14);
            this.groupBox1.Controls.Add(this.checkBox13);
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.ssyl_cb);
            this.groupBox1.Controls.Add(this.sswg_cb);
            this.groupBox1.Controls.Add(this.sssq_cb);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1891, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员管理";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份证";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // sssq_cb
            // 
            this.sssq_cb.Enabled = false;
            this.sssq_cb.FormattingEnabled = true;
            this.sssq_cb.Location = new System.Drawing.Point(290, 22);
            this.sssq_cb.Name = "sssq_cb";
            this.sssq_cb.Size = new System.Drawing.Size(121, 20);
            this.sssq_cb.TabIndex = 6;
            this.sssq_cb.SelectionChangeCommitted += new System.EventHandler(this.sssq_cb_SelectionChangeCommitted);
            // 
            // sswg_cb
            // 
            this.sswg_cb.Enabled = false;
            this.sswg_cb.FormattingEnabled = true;
            this.sswg_cb.Location = new System.Drawing.Point(290, 60);
            this.sswg_cb.Name = "sswg_cb";
            this.sswg_cb.Size = new System.Drawing.Size(121, 20);
            this.sswg_cb.TabIndex = 7;
            this.sswg_cb.SelectionChangeCommitted += new System.EventHandler(this.sswg_cb_SelectionChangeCommitted);
            // 
            // ssyl_cb
            // 
            this.ssyl_cb.Enabled = false;
            this.ssyl_cb.FormattingEnabled = true;
            this.ssyl_cb.Location = new System.Drawing.Point(290, 95);
            this.ssyl_cb.Name = "ssyl_cb";
            this.ssyl_cb.Size = new System.Drawing.Size(121, 20);
            this.ssyl_cb.TabIndex = 9;
            this.ssyl_cb.SelectedIndexChanged += new System.EventHandler(this.ssyl_cb_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(434, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "流动人员";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(434, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "常住人员";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(434, 64);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 16);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "残疾人";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(434, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 16);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "老年人";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(596, 65);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 16);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "低保人员";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(596, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(72, 16);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.Text = "矫正人员";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(596, 42);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 16);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = "刑满人员";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(434, 108);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(72, 16);
            this.checkBox8.TabIndex = 17;
            this.checkBox8.Text = "境外人员";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(596, 87);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(72, 16);
            this.checkBox9.TabIndex = 18;
            this.checkBox9.Text = "吸毒人员";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Enabled = false;
            this.checkBox10.Location = new System.Drawing.Point(500, 64);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(48, 16);
            this.checkBox10.TabIndex = 19;
            this.checkBox10.Text = "精神";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Enabled = false;
            this.checkBox11.Location = new System.Drawing.Point(500, 86);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(48, 16);
            this.checkBox11.TabIndex = 20;
            this.checkBox11.Text = "空巢";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(819, 112);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 21;
            this.search.Text = "筛选";
            this.search.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(698, 20);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(84, 16);
            this.checkBox12.TabIndex = 23;
            this.checkBox12.Text = "藏维族人员";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(698, 42);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(72, 16);
            this.checkBox13.TabIndex = 24;
            this.checkBox13.Text = "失业人员";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(698, 65);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(72, 16);
            this.checkBox14.TabIndex = 25;
            this.checkBox14.Text = "重要人员";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(698, 87);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(48, 16);
            this.checkBox15.TabIndex = 26;
            this.checkBox15.Text = "党员";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // cbox_sssq
            // 
            this.cbox_sssq.AutoSize = true;
            this.cbox_sssq.Location = new System.Drawing.Point(212, 24);
            this.cbox_sssq.Name = "cbox_sssq";
            this.cbox_sssq.Size = new System.Drawing.Size(72, 16);
            this.cbox_sssq.TabIndex = 27;
            this.cbox_sssq.Text = "所属社区";
            this.cbox_sssq.UseVisualStyleBackColor = true;
            this.cbox_sssq.CheckedChanged += new System.EventHandler(this.cbox_sssq_CheckedChanged);
            // 
            // cbox_grid
            // 
            this.cbox_grid.AutoSize = true;
            this.cbox_grid.Location = new System.Drawing.Point(212, 63);
            this.cbox_grid.Name = "cbox_grid";
            this.cbox_grid.Size = new System.Drawing.Size(72, 16);
            this.cbox_grid.TabIndex = 28;
            this.cbox_grid.Text = "所属网格";
            this.cbox_grid.UseVisualStyleBackColor = true;
            this.cbox_grid.CheckedChanged += new System.EventHandler(this.cbox_grid_CheckedChanged);
            // 
            // cb_block
            // 
            this.cb_block.AutoSize = true;
            this.cb_block.Location = new System.Drawing.Point(212, 99);
            this.cb_block.Name = "cb_block";
            this.cb_block.Size = new System.Drawing.Size(72, 16);
            this.cb_block.TabIndex = 29;
            this.cb_block.Text = "所属院落";
            this.cb_block.UseVisualStyleBackColor = true;
            this.cb_block.CheckedChanged += new System.EventHandler(this.cb_block_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(0, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1894, 671);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.districtdgv,
            this.griddgv,
            this.blockdgv,
            this.ylmc,
            this.cardid,
            this.ad,
            this.member,
            this.resident,
            this.handicapped,
            this.old,
            this.old_alone,
            this.jwry,
            this.syry,
            this.vip,
            this.cleaner,
            this.correction,
            this.released,
            this.poor,
            this.dope,
            this.note});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1888, 651);
            this.dgv.TabIndex = 0;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "备注";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // dope
            // 
            this.dope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dope.DataPropertyName = "dope";
            this.dope.HeaderText = "吸毒人员";
            this.dope.Name = "dope";
            this.dope.ReadOnly = true;
            this.dope.Width = 78;
            // 
            // poor
            // 
            this.poor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.poor.DataPropertyName = "poor";
            this.poor.HeaderText = "低保人员";
            this.poor.Name = "poor";
            this.poor.ReadOnly = true;
            this.poor.Width = 78;
            // 
            // released
            // 
            this.released.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.released.DataPropertyName = "released";
            this.released.HeaderText = "刑满人员";
            this.released.Name = "released";
            this.released.ReadOnly = true;
            this.released.Width = 78;
            // 
            // correction
            // 
            this.correction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correction.DataPropertyName = "correction";
            this.correction.HeaderText = "矫正人员";
            this.correction.Name = "correction";
            this.correction.ReadOnly = true;
            this.correction.Width = 78;
            // 
            // cleaner
            // 
            this.cleaner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cleaner.DataPropertyName = "cleaner";
            this.cleaner.HeaderText = "藏维族人员";
            this.cleaner.Name = "cleaner";
            this.cleaner.ReadOnly = true;
            this.cleaner.Width = 90;
            // 
            // vip
            // 
            this.vip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vip.DataPropertyName = "vip";
            this.vip.HeaderText = "重要人员";
            this.vip.Name = "vip";
            this.vip.ReadOnly = true;
            this.vip.Width = 78;
            // 
            // syry
            // 
            this.syry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.syry.DataPropertyName = "unjob";
            this.syry.HeaderText = "失业人员";
            this.syry.Name = "syry";
            this.syry.ReadOnly = true;
            this.syry.Width = 78;
            // 
            // jwry
            // 
            this.jwry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jwry.DataPropertyName = "foreigner";
            this.jwry.HeaderText = "境外人员";
            this.jwry.Name = "jwry";
            this.jwry.ReadOnly = true;
            this.jwry.Width = 78;
            // 
            // old_alone
            // 
            this.old_alone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.old_alone.DataPropertyName = "old_alone";
            this.old_alone.HeaderText = "空巢老人";
            this.old_alone.Name = "old_alone";
            this.old_alone.ReadOnly = true;
            this.old_alone.Width = 78;
            // 
            // old
            // 
            this.old.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.old.DataPropertyName = "old";
            this.old.HeaderText = "老年人";
            this.old.Name = "old";
            this.old.ReadOnly = true;
            this.old.Width = 66;
            // 
            // handicapped
            // 
            this.handicapped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.handicapped.DataPropertyName = "handicapped";
            this.handicapped.HeaderText = "残疾人";
            this.handicapped.Name = "handicapped";
            this.handicapped.ReadOnly = true;
            this.handicapped.Width = 66;
            // 
            // resident
            // 
            this.resident.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.resident.DataPropertyName = "resident";
            this.resident.HeaderText = "常住人员";
            this.resident.Name = "resident";
            this.resident.ReadOnly = true;
            this.resident.Width = 78;
            // 
            // member
            // 
            this.member.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.member.DataPropertyName = "educational";
            this.member.HeaderText = "党员";
            this.member.Name = "member";
            this.member.ReadOnly = true;
            this.member.Width = 54;
            // 
            // ad
            // 
            this.ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ad.DataPropertyName = "address";
            this.ad.HeaderText = "居住地址";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            this.ad.Width = 78;
            // 
            // cardid
            // 
            this.cardid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cardid.DataPropertyName = "card_id";
            this.cardid.HeaderText = "身份证";
            this.cardid.Name = "cardid";
            this.cardid.ReadOnly = true;
            this.cardid.Width = 66;
            // 
            // ylmc
            // 
            this.ylmc.DataPropertyName = "ns";
            this.ylmc.HeaderText = "院落名称";
            this.ylmc.Name = "ylmc";
            this.ylmc.ReadOnly = true;
            // 
            // blockdgv
            // 
            this.blockdgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.blockdgv.DataPropertyName = "nb";
            this.blockdgv.HeaderText = "所属院落";
            this.blockdgv.Name = "blockdgv";
            this.blockdgv.ReadOnly = true;
            this.blockdgv.Width = 78;
            // 
            // griddgv
            // 
            this.griddgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.griddgv.DataPropertyName = "ng";
            this.griddgv.HeaderText = "所属网格";
            this.griddgv.Name = "griddgv";
            this.griddgv.ReadOnly = true;
            this.griddgv.Width = 78;
            // 
            // districtdgv
            // 
            this.districtdgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.districtdgv.DataPropertyName = "nd";
            this.districtdgv.HeaderText = "所属社区";
            this.districtdgv.Name = "districtdgv";
            this.districtdgv.ReadOnly = true;
            this.districtdgv.Width = 78;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "na";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 54;
            // 
            // back
            // 
            this.back.Controls.Add(this.groupBox2);
            this.back.Controls.Add(this.groupBox1);
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(1904, 853);
            this.back.TabIndex = 0;
            // 
            // ppmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 853);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.back);
            this.Name = "ppmanager";
            this.Text = "ppmanager";
            this.Load += new System.EventHandler(this.ppmanager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.back.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private ToolStripMenuItem 添加人员ToolStripMenuItem;
        private GroupBox groupBox1;
        private CheckBox cb_block;
        private CheckBox cbox_grid;
        private CheckBox cbox_sssq;
        private CheckBox checkBox15;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox12;
        private Button button1;
        private Button search;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox ssyl_cb;
        private ComboBox sswg_cb;
        private ComboBox sssq_cb;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn districtdgv;
        private DataGridViewTextBoxColumn griddgv;
        private DataGridViewTextBoxColumn blockdgv;
        private DataGridViewTextBoxColumn ylmc;
        private DataGridViewTextBoxColumn cardid;
        private DataGridViewTextBoxColumn ad;
        private DataGridViewTextBoxColumn member;
        private DataGridViewTextBoxColumn resident;
        private DataGridViewTextBoxColumn handicapped;
        private DataGridViewTextBoxColumn old;
        private DataGridViewTextBoxColumn old_alone;
        private DataGridViewTextBoxColumn jwry;
        private DataGridViewTextBoxColumn syry;
        private DataGridViewTextBoxColumn vip;
        private DataGridViewTextBoxColumn cleaner;
        private DataGridViewTextBoxColumn correction;
        private DataGridViewTextBoxColumn released;
        private DataGridViewTextBoxColumn poor;
        private DataGridViewTextBoxColumn dope;
        private DataGridViewTextBoxColumn note;
        private Panel back;
    }
}