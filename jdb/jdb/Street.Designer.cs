using System.Windows.Forms;

namespace jdb.ComClass
{
    partial class Street
    {
        public Main main = null;
        public string grid = null;
        public string district = null;
        public string block = null;
        /// <summary>
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
            this.black = new System.Windows.Forms.Panel();
            this.shujiValue = new System.Windows.Forms.Label();
            this.dangValue = new System.Windows.Forms.Label();
            this.laCommunityPopulationValue = new System.Windows.Forms.Label();
            this.laReleaseValue = new System.Windows.Forms.Label();
            this.laReleaseTitle = new System.Windows.Forms.Label();
            this.laCorrectValue = new System.Windows.Forms.Label();
            this.laCorrectTitle = new System.Windows.Forms.Label();
            this.laDopeValue = new System.Windows.Forms.Label();
            this.laDopeTitle = new System.Windows.Forms.Label();
            this.laUnemploymentValue = new System.Windows.Forms.Label();
            this.laUnemploymentTitle = new System.Windows.Forms.Label();
            this.laEmphasisValue = new System.Windows.Forms.Label();
            this.laEmphasisTitle = new System.Windows.Forms.Label();
            this.laCleanerValue = new System.Windows.Forms.Label();
            this.laCleanerTitle = new System.Windows.Forms.Label();
            this.laLowestPeopleValue = new System.Windows.Forms.Label();
            this.laLowestPeopleTitle = new System.Windows.Forms.Label();
            this.laLowestFmailyValue = new System.Windows.Forms.Label();
            this.laLowestFmailyTitle = new System.Windows.Forms.Label();
            this.laForeignerValue = new System.Windows.Forms.Label();
            this.laForeignerTitle = new System.Windows.Forms.Label();
            this.laPriorityValue = new System.Windows.Forms.Label();
            this.laPriorityTitle = new System.Windows.Forms.Label();
            this.laMentalValue = new System.Windows.Forms.Label();
            this.laHandicappedValue = new System.Windows.Forms.Label();
            this.laMentalTitle = new System.Windows.Forms.Label();
            this.laHandicappedTitle = new System.Windows.Forms.Label();
            this.laAloneOlderValue = new System.Windows.Forms.Label();
            this.laAloneOlderTitle = new System.Windows.Forms.Label();
            this.laOlderValue = new System.Windows.Forms.Label();
            this.laOlderTitle = new System.Windows.Forms.Label();
            this.laCommunistValue = new System.Windows.Forms.Label();
            this.laCommunistTitle = new System.Windows.Forms.Label();
            this.laMobilePopulationValue = new System.Windows.Forms.Label();
            this.laMobilePopulationTtile = new System.Windows.Forms.Label();
            this.laFamilyPopulationValue = new System.Windows.Forms.Label();
            this.laFamilyPopulationTtile = new System.Windows.Forms.Label();
            this.laCommunityPopulationTitle = new System.Windows.Forms.Label();
            this.laFamilyValue = new System.Windows.Forms.Label();
            this.laFamilyTitle = new System.Windows.Forms.Label();
            this.laYardValue = new System.Windows.Forms.Label();
            this.laYardTitle = new System.Windows.Forms.Label();
            this.laUnitValue = new System.Windows.Forms.Label();
            this.laHouseValue = new System.Windows.Forms.Label();
            this.laUnitTitle = new System.Windows.Forms.Label();
            this.laHouseTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.jmxz = new System.Windows.Forms.Label();
            this.laTitle = new System.Windows.Forms.Label();
            this.black.SuspendLayout();
            this.SuspendLayout();
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.White;
            this.black.BackgroundImage = global::jdb.Properties.Resources.biaozi_2;
            this.black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.black.Controls.Add(this.shujiValue);
            this.black.Controls.Add(this.dangValue);
            this.black.Controls.Add(this.laCommunityPopulationValue);
            this.black.Controls.Add(this.laReleaseValue);
            this.black.Controls.Add(this.laReleaseTitle);
            this.black.Controls.Add(this.laCorrectValue);
            this.black.Controls.Add(this.laCorrectTitle);
            this.black.Controls.Add(this.laDopeValue);
            this.black.Controls.Add(this.laDopeTitle);
            this.black.Controls.Add(this.laUnemploymentValue);
            this.black.Controls.Add(this.laUnemploymentTitle);
            this.black.Controls.Add(this.laEmphasisValue);
            this.black.Controls.Add(this.laEmphasisTitle);
            this.black.Controls.Add(this.laCleanerValue);
            this.black.Controls.Add(this.laCleanerTitle);
            this.black.Controls.Add(this.laLowestPeopleValue);
            this.black.Controls.Add(this.laLowestPeopleTitle);
            this.black.Controls.Add(this.laLowestFmailyValue);
            this.black.Controls.Add(this.laLowestFmailyTitle);
            this.black.Controls.Add(this.laForeignerValue);
            this.black.Controls.Add(this.laForeignerTitle);
            this.black.Controls.Add(this.laPriorityValue);
            this.black.Controls.Add(this.laPriorityTitle);
            this.black.Controls.Add(this.laMentalValue);
            this.black.Controls.Add(this.laHandicappedValue);
            this.black.Controls.Add(this.laMentalTitle);
            this.black.Controls.Add(this.laHandicappedTitle);
            this.black.Controls.Add(this.laAloneOlderValue);
            this.black.Controls.Add(this.laAloneOlderTitle);
            this.black.Controls.Add(this.laOlderValue);
            this.black.Controls.Add(this.laOlderTitle);
            this.black.Controls.Add(this.laCommunistValue);
            this.black.Controls.Add(this.laCommunistTitle);
            this.black.Controls.Add(this.laMobilePopulationValue);
            this.black.Controls.Add(this.laMobilePopulationTtile);
            this.black.Controls.Add(this.laFamilyPopulationValue);
            this.black.Controls.Add(this.laFamilyPopulationTtile);
            this.black.Controls.Add(this.laCommunityPopulationTitle);
            this.black.Controls.Add(this.laFamilyValue);
            this.black.Controls.Add(this.laFamilyTitle);
            this.black.Controls.Add(this.laYardValue);
            this.black.Controls.Add(this.laYardTitle);
            this.black.Controls.Add(this.laUnitValue);
            this.black.Controls.Add(this.laHouseValue);
            this.black.Controls.Add(this.laUnitTitle);
            this.black.Controls.Add(this.laHouseTitle);
            this.black.Controls.Add(this.button1);
            this.black.Controls.Add(this.label3);
            this.black.Controls.Add(this.jmxz);
            this.black.Controls.Add(this.laTitle);
            this.black.Dock = System.Windows.Forms.DockStyle.Fill;
            this.black.Location = new System.Drawing.Point(0, 0);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(1904, 1041);
            this.black.TabIndex = 0;
            this.black.Tag = "1";
            // 
            // shujiValue
            // 
            this.shujiValue.AutoSize = true;
            this.shujiValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shujiValue.Location = new System.Drawing.Point(556, 372);
            this.shujiValue.Name = "shujiValue";
            this.shujiValue.Size = new System.Drawing.Size(46, 38);
            this.shujiValue.TabIndex = 286;
            this.shujiValue.Text = "无";
            // 
            // dangValue
            // 
            this.dangValue.AutoSize = true;
            this.dangValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dangValue.Location = new System.Drawing.Point(556, 299);
            this.dangValue.Name = "dangValue";
            this.dangValue.Size = new System.Drawing.Size(46, 38);
            this.dangValue.TabIndex = 285;
            this.dangValue.Text = "无";
            // 
            // laCommunityPopulationValue
            // 
            this.laCommunityPopulationValue.AutoSize = true;
            this.laCommunityPopulationValue.BackColor = System.Drawing.Color.White;
            this.laCommunityPopulationValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunityPopulationValue.Location = new System.Drawing.Point(518, 520);
            this.laCommunityPopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunityPopulationValue.Name = "laCommunityPopulationValue";
            this.laCommunityPopulationValue.Size = new System.Drawing.Size(84, 31);
            this.laCommunityPopulationValue.TabIndex = 284;
            this.laCommunityPopulationValue.Text = "00000";
            // 
            // laReleaseValue
            // 
            this.laReleaseValue.AutoSize = true;
            this.laReleaseValue.BackColor = System.Drawing.Color.White;
            this.laReleaseValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laReleaseValue.Location = new System.Drawing.Point(1528, 596);
            this.laReleaseValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laReleaseValue.Name = "laReleaseValue";
            this.laReleaseValue.Size = new System.Drawing.Size(68, 38);
            this.laReleaseValue.TabIndex = 283;
            this.laReleaseValue.Text = "000";
            // 
            // laReleaseTitle
            // 
            this.laReleaseTitle.AutoSize = true;
            this.laReleaseTitle.BackColor = System.Drawing.Color.White;
            this.laReleaseTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laReleaseTitle.Location = new System.Drawing.Point(1329, 596);
            this.laReleaseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laReleaseTitle.Name = "laReleaseTitle";
            this.laReleaseTitle.Size = new System.Drawing.Size(162, 38);
            this.laReleaseTitle.TabIndex = 282;
            this.laReleaseTitle.Tag = "5";
            this.laReleaseTitle.Text = "刑释人员：";
            this.laReleaseTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laCorrectValue
            // 
            this.laCorrectValue.AutoSize = true;
            this.laCorrectValue.BackColor = System.Drawing.Color.White;
            this.laCorrectValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCorrectValue.Location = new System.Drawing.Point(1188, 596);
            this.laCorrectValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCorrectValue.Name = "laCorrectValue";
            this.laCorrectValue.Size = new System.Drawing.Size(68, 38);
            this.laCorrectValue.TabIndex = 281;
            this.laCorrectValue.Text = "000";
            // 
            // laCorrectTitle
            // 
            this.laCorrectTitle.AutoSize = true;
            this.laCorrectTitle.BackColor = System.Drawing.Color.White;
            this.laCorrectTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCorrectTitle.Location = new System.Drawing.Point(985, 596);
            this.laCorrectTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCorrectTitle.Name = "laCorrectTitle";
            this.laCorrectTitle.Size = new System.Drawing.Size(162, 38);
            this.laCorrectTitle.TabIndex = 280;
            this.laCorrectTitle.Tag = "4";
            this.laCorrectTitle.Text = "矫正人员：";
            this.laCorrectTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laDopeValue
            // 
            this.laDopeValue.AutoSize = true;
            this.laDopeValue.BackColor = System.Drawing.Color.White;
            this.laDopeValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDopeValue.Location = new System.Drawing.Point(517, 667);
            this.laDopeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDopeValue.Name = "laDopeValue";
            this.laDopeValue.Size = new System.Drawing.Size(68, 38);
            this.laDopeValue.TabIndex = 279;
            this.laDopeValue.Text = "000";
            // 
            // laDopeTitle
            // 
            this.laDopeTitle.AutoSize = true;
            this.laDopeTitle.BackColor = System.Drawing.Color.White;
            this.laDopeTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDopeTitle.Location = new System.Drawing.Point(302, 667);
            this.laDopeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDopeTitle.Name = "laDopeTitle";
            this.laDopeTitle.Size = new System.Drawing.Size(162, 38);
            this.laDopeTitle.TabIndex = 278;
            this.laDopeTitle.Tag = "6";
            this.laDopeTitle.Text = "吸毒人员：";
            this.laDopeTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laUnemploymentValue
            // 
            this.laUnemploymentValue.AutoSize = true;
            this.laUnemploymentValue.BackColor = System.Drawing.Color.White;
            this.laUnemploymentValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnemploymentValue.Location = new System.Drawing.Point(1188, 667);
            this.laUnemploymentValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnemploymentValue.Name = "laUnemploymentValue";
            this.laUnemploymentValue.Size = new System.Drawing.Size(68, 38);
            this.laUnemploymentValue.TabIndex = 277;
            this.laUnemploymentValue.Text = "000";
            // 
            // laUnemploymentTitle
            // 
            this.laUnemploymentTitle.AutoSize = true;
            this.laUnemploymentTitle.BackColor = System.Drawing.Color.White;
            this.laUnemploymentTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnemploymentTitle.Location = new System.Drawing.Point(985, 667);
            this.laUnemploymentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnemploymentTitle.Name = "laUnemploymentTitle";
            this.laUnemploymentTitle.Size = new System.Drawing.Size(162, 38);
            this.laUnemploymentTitle.TabIndex = 276;
            this.laUnemploymentTitle.Tag = "8";
            this.laUnemploymentTitle.Text = "失业人员：";
            this.laUnemploymentTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laEmphasisValue
            // 
            this.laEmphasisValue.AutoSize = true;
            this.laEmphasisValue.BackColor = System.Drawing.Color.White;
            this.laEmphasisValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEmphasisValue.Location = new System.Drawing.Point(853, 596);
            this.laEmphasisValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laEmphasisValue.Name = "laEmphasisValue";
            this.laEmphasisValue.Size = new System.Drawing.Size(68, 38);
            this.laEmphasisValue.TabIndex = 275;
            this.laEmphasisValue.Text = "000";
            // 
            // laEmphasisTitle
            // 
            this.laEmphasisTitle.AutoSize = true;
            this.laEmphasisTitle.BackColor = System.Drawing.Color.White;
            this.laEmphasisTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEmphasisTitle.Location = new System.Drawing.Point(643, 596);
            this.laEmphasisTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laEmphasisTitle.Name = "laEmphasisTitle";
            this.laEmphasisTitle.Size = new System.Drawing.Size(162, 38);
            this.laEmphasisTitle.TabIndex = 274;
            this.laEmphasisTitle.Tag = "3";
            this.laEmphasisTitle.Text = "重点人员：";
            this.laEmphasisTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laCleanerValue
            // 
            this.laCleanerValue.AutoSize = true;
            this.laCleanerValue.BackColor = System.Drawing.Color.White;
            this.laCleanerValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCleanerValue.Location = new System.Drawing.Point(517, 596);
            this.laCleanerValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCleanerValue.Name = "laCleanerValue";
            this.laCleanerValue.Size = new System.Drawing.Size(68, 38);
            this.laCleanerValue.TabIndex = 273;
            this.laCleanerValue.Text = "000";
            // 
            // laCleanerTitle
            // 
            this.laCleanerTitle.AutoSize = true;
            this.laCleanerTitle.BackColor = System.Drawing.Color.White;
            this.laCleanerTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCleanerTitle.Location = new System.Drawing.Point(302, 596);
            this.laCleanerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCleanerTitle.Name = "laCleanerTitle";
            this.laCleanerTitle.Size = new System.Drawing.Size(191, 38);
            this.laCleanerTitle.TabIndex = 272;
            this.laCleanerTitle.Tag = "2";
            this.laCleanerTitle.Text = "藏维族人员：";
            this.laCleanerTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laLowestPeopleValue
            // 
            this.laLowestPeopleValue.AutoSize = true;
            this.laLowestPeopleValue.BackColor = System.Drawing.Color.White;
            this.laLowestPeopleValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestPeopleValue.Location = new System.Drawing.Point(853, 811);
            this.laLowestPeopleValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestPeopleValue.Name = "laLowestPeopleValue";
            this.laLowestPeopleValue.Size = new System.Drawing.Size(68, 38);
            this.laLowestPeopleValue.TabIndex = 271;
            this.laLowestPeopleValue.Text = "000";
            // 
            // laLowestPeopleTitle
            // 
            this.laLowestPeopleTitle.AutoSize = true;
            this.laLowestPeopleTitle.BackColor = System.Drawing.Color.White;
            this.laLowestPeopleTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestPeopleTitle.Location = new System.Drawing.Point(643, 811);
            this.laLowestPeopleTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestPeopleTitle.Name = "laLowestPeopleTitle";
            this.laLowestPeopleTitle.Size = new System.Drawing.Size(162, 38);
            this.laLowestPeopleTitle.TabIndex = 270;
            this.laLowestPeopleTitle.Tag = "15";
            this.laLowestPeopleTitle.Text = "低保人员：";
            this.laLowestPeopleTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laLowestFmailyValue
            // 
            this.laLowestFmailyValue.AutoSize = true;
            this.laLowestFmailyValue.BackColor = System.Drawing.Color.White;
            this.laLowestFmailyValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestFmailyValue.Location = new System.Drawing.Point(517, 811);
            this.laLowestFmailyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestFmailyValue.Name = "laLowestFmailyValue";
            this.laLowestFmailyValue.Size = new System.Drawing.Size(68, 38);
            this.laLowestFmailyValue.TabIndex = 269;
            this.laLowestFmailyValue.Text = "000";
            // 
            // laLowestFmailyTitle
            // 
            this.laLowestFmailyTitle.AutoSize = true;
            this.laLowestFmailyTitle.BackColor = System.Drawing.Color.White;
            this.laLowestFmailyTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestFmailyTitle.Location = new System.Drawing.Point(302, 811);
            this.laLowestFmailyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestFmailyTitle.Name = "laLowestFmailyTitle";
            this.laLowestFmailyTitle.Size = new System.Drawing.Size(162, 38);
            this.laLowestFmailyTitle.TabIndex = 268;
            this.laLowestFmailyTitle.Tag = "14";
            this.laLowestFmailyTitle.Text = "低保户数：";
            this.laLowestFmailyTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laForeignerValue
            // 
            this.laForeignerValue.AutoSize = true;
            this.laForeignerValue.BackColor = System.Drawing.Color.White;
            this.laForeignerValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laForeignerValue.Location = new System.Drawing.Point(853, 667);
            this.laForeignerValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laForeignerValue.Name = "laForeignerValue";
            this.laForeignerValue.Size = new System.Drawing.Size(68, 38);
            this.laForeignerValue.TabIndex = 267;
            this.laForeignerValue.Text = "000";
            // 
            // laForeignerTitle
            // 
            this.laForeignerTitle.AutoSize = true;
            this.laForeignerTitle.BackColor = System.Drawing.Color.White;
            this.laForeignerTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laForeignerTitle.Location = new System.Drawing.Point(643, 667);
            this.laForeignerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laForeignerTitle.Name = "laForeignerTitle";
            this.laForeignerTitle.Size = new System.Drawing.Size(162, 38);
            this.laForeignerTitle.TabIndex = 266;
            this.laForeignerTitle.Tag = "7";
            this.laForeignerTitle.Text = "境外人员：";
            this.laForeignerTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laPriorityValue
            // 
            this.laPriorityValue.AutoSize = true;
            this.laPriorityValue.BackColor = System.Drawing.Color.White;
            this.laPriorityValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laPriorityValue.Location = new System.Drawing.Point(1528, 667);
            this.laPriorityValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laPriorityValue.Name = "laPriorityValue";
            this.laPriorityValue.Size = new System.Drawing.Size(68, 38);
            this.laPriorityValue.TabIndex = 265;
            this.laPriorityValue.Text = "000";
            // 
            // laPriorityTitle
            // 
            this.laPriorityTitle.AutoSize = true;
            this.laPriorityTitle.BackColor = System.Drawing.Color.White;
            this.laPriorityTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laPriorityTitle.Location = new System.Drawing.Point(1329, 667);
            this.laPriorityTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laPriorityTitle.Name = "laPriorityTitle";
            this.laPriorityTitle.Size = new System.Drawing.Size(162, 38);
            this.laPriorityTitle.TabIndex = 264;
            this.laPriorityTitle.Tag = "9";
            this.laPriorityTitle.Text = "优抚人员：";
            this.laPriorityTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laMentalValue
            // 
            this.laMentalValue.AutoSize = true;
            this.laMentalValue.BackColor = System.Drawing.Color.White;
            this.laMentalValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMentalValue.Location = new System.Drawing.Point(853, 740);
            this.laMentalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMentalValue.Name = "laMentalValue";
            this.laMentalValue.Size = new System.Drawing.Size(68, 38);
            this.laMentalValue.TabIndex = 263;
            this.laMentalValue.Text = "000";
            // 
            // laHandicappedValue
            // 
            this.laHandicappedValue.AutoSize = true;
            this.laHandicappedValue.BackColor = System.Drawing.Color.White;
            this.laHandicappedValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHandicappedValue.Location = new System.Drawing.Point(517, 740);
            this.laHandicappedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHandicappedValue.Name = "laHandicappedValue";
            this.laHandicappedValue.Size = new System.Drawing.Size(68, 38);
            this.laHandicappedValue.TabIndex = 262;
            this.laHandicappedValue.Text = "000";
            // 
            // laMentalTitle
            // 
            this.laMentalTitle.AutoSize = true;
            this.laMentalTitle.BackColor = System.Drawing.Color.White;
            this.laMentalTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMentalTitle.Location = new System.Drawing.Point(643, 740);
            this.laMentalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMentalTitle.Name = "laMentalTitle";
            this.laMentalTitle.Size = new System.Drawing.Size(162, 38);
            this.laMentalTitle.TabIndex = 261;
            this.laMentalTitle.Tag = "11";
            this.laMentalTitle.Text = "精神残疾：";
            this.laMentalTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laHandicappedTitle
            // 
            this.laHandicappedTitle.AutoSize = true;
            this.laHandicappedTitle.BackColor = System.Drawing.Color.White;
            this.laHandicappedTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHandicappedTitle.Location = new System.Drawing.Point(302, 740);
            this.laHandicappedTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHandicappedTitle.Name = "laHandicappedTitle";
            this.laHandicappedTitle.Size = new System.Drawing.Size(133, 38);
            this.laHandicappedTitle.TabIndex = 260;
            this.laHandicappedTitle.Tag = "10";
            this.laHandicappedTitle.Text = "残疾人：";
            this.laHandicappedTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laAloneOlderValue
            // 
            this.laAloneOlderValue.AutoSize = true;
            this.laAloneOlderValue.BackColor = System.Drawing.Color.White;
            this.laAloneOlderValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laAloneOlderValue.Location = new System.Drawing.Point(1528, 740);
            this.laAloneOlderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laAloneOlderValue.Name = "laAloneOlderValue";
            this.laAloneOlderValue.Size = new System.Drawing.Size(68, 38);
            this.laAloneOlderValue.TabIndex = 259;
            this.laAloneOlderValue.Text = "000";
            // 
            // laAloneOlderTitle
            // 
            this.laAloneOlderTitle.AutoSize = true;
            this.laAloneOlderTitle.BackColor = System.Drawing.Color.White;
            this.laAloneOlderTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laAloneOlderTitle.Location = new System.Drawing.Point(1329, 740);
            this.laAloneOlderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laAloneOlderTitle.Name = "laAloneOlderTitle";
            this.laAloneOlderTitle.Size = new System.Drawing.Size(162, 38);
            this.laAloneOlderTitle.TabIndex = 258;
            this.laAloneOlderTitle.Tag = "13";
            this.laAloneOlderTitle.Text = "空巢老人：";
            this.laAloneOlderTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laOlderValue
            // 
            this.laOlderValue.AutoSize = true;
            this.laOlderValue.BackColor = System.Drawing.Color.White;
            this.laOlderValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laOlderValue.Location = new System.Drawing.Point(1188, 740);
            this.laOlderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laOlderValue.Name = "laOlderValue";
            this.laOlderValue.Size = new System.Drawing.Size(85, 38);
            this.laOlderValue.TabIndex = 257;
            this.laOlderValue.Text = "0000";
            // 
            // laOlderTitle
            // 
            this.laOlderTitle.AutoSize = true;
            this.laOlderTitle.BackColor = System.Drawing.Color.White;
            this.laOlderTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laOlderTitle.Location = new System.Drawing.Point(985, 740);
            this.laOlderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laOlderTitle.Name = "laOlderTitle";
            this.laOlderTitle.Size = new System.Drawing.Size(133, 38);
            this.laOlderTitle.TabIndex = 256;
            this.laOlderTitle.Tag = "12";
            this.laOlderTitle.Text = "老年人：";
            this.laOlderTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laCommunistValue
            // 
            this.laCommunistValue.AutoSize = true;
            this.laCommunistValue.BackColor = System.Drawing.Color.White;
            this.laCommunistValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunistValue.Location = new System.Drawing.Point(1528, 519);
            this.laCommunistValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunistValue.Name = "laCommunistValue";
            this.laCommunistValue.Size = new System.Drawing.Size(68, 38);
            this.laCommunistValue.TabIndex = 255;
            this.laCommunistValue.Text = "000";
            // 
            // laCommunistTitle
            // 
            this.laCommunistTitle.AutoSize = true;
            this.laCommunistTitle.BackColor = System.Drawing.Color.White;
            this.laCommunistTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunistTitle.Location = new System.Drawing.Point(1329, 519);
            this.laCommunistTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunistTitle.Name = "laCommunistTitle";
            this.laCommunistTitle.Size = new System.Drawing.Size(104, 38);
            this.laCommunistTitle.TabIndex = 254;
            this.laCommunistTitle.Tag = "1";
            this.laCommunistTitle.Text = "党员：";
            this.laCommunistTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laMobilePopulationValue
            // 
            this.laMobilePopulationValue.AutoSize = true;
            this.laMobilePopulationValue.BackColor = System.Drawing.Color.White;
            this.laMobilePopulationValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMobilePopulationValue.Location = new System.Drawing.Point(1189, 522);
            this.laMobilePopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMobilePopulationValue.Name = "laMobilePopulationValue";
            this.laMobilePopulationValue.Size = new System.Drawing.Size(84, 31);
            this.laMobilePopulationValue.TabIndex = 253;
            this.laMobilePopulationValue.Text = "00000";
            // 
            // laMobilePopulationTtile
            // 
            this.laMobilePopulationTtile.AutoSize = true;
            this.laMobilePopulationTtile.BackColor = System.Drawing.Color.White;
            this.laMobilePopulationTtile.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMobilePopulationTtile.Location = new System.Drawing.Point(985, 519);
            this.laMobilePopulationTtile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMobilePopulationTtile.Name = "laMobilePopulationTtile";
            this.laMobilePopulationTtile.Size = new System.Drawing.Size(162, 38);
            this.laMobilePopulationTtile.TabIndex = 252;
            this.laMobilePopulationTtile.Text = "流动人口：";
            // 
            // laFamilyPopulationValue
            // 
            this.laFamilyPopulationValue.AutoSize = true;
            this.laFamilyPopulationValue.BackColor = System.Drawing.Color.White;
            this.laFamilyPopulationValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyPopulationValue.Location = new System.Drawing.Point(854, 522);
            this.laFamilyPopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyPopulationValue.Name = "laFamilyPopulationValue";
            this.laFamilyPopulationValue.Size = new System.Drawing.Size(84, 31);
            this.laFamilyPopulationValue.TabIndex = 251;
            this.laFamilyPopulationValue.Text = "00000";
            // 
            // laFamilyPopulationTtile
            // 
            this.laFamilyPopulationTtile.AutoSize = true;
            this.laFamilyPopulationTtile.BackColor = System.Drawing.Color.White;
            this.laFamilyPopulationTtile.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyPopulationTtile.Location = new System.Drawing.Point(643, 517);
            this.laFamilyPopulationTtile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyPopulationTtile.Name = "laFamilyPopulationTtile";
            this.laFamilyPopulationTtile.Size = new System.Drawing.Size(162, 38);
            this.laFamilyPopulationTtile.TabIndex = 250;
            this.laFamilyPopulationTtile.Text = "户籍人口：";
            // 
            // laCommunityPopulationTitle
            // 
            this.laCommunityPopulationTitle.AutoSize = true;
            this.laCommunityPopulationTitle.BackColor = System.Drawing.Color.White;
            this.laCommunityPopulationTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunityPopulationTitle.Location = new System.Drawing.Point(302, 517);
            this.laCommunityPopulationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunityPopulationTitle.Name = "laCommunityPopulationTitle";
            this.laCommunityPopulationTitle.Size = new System.Drawing.Size(162, 38);
            this.laCommunityPopulationTitle.TabIndex = 249;
            this.laCommunityPopulationTitle.Text = "常住人口：";
            // 
            // laFamilyValue
            // 
            this.laFamilyValue.AutoSize = true;
            this.laFamilyValue.BackColor = System.Drawing.Color.White;
            this.laFamilyValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyValue.Location = new System.Drawing.Point(854, 449);
            this.laFamilyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyValue.Name = "laFamilyValue";
            this.laFamilyValue.Size = new System.Drawing.Size(84, 31);
            this.laFamilyValue.TabIndex = 248;
            this.laFamilyValue.Text = "00000";
            // 
            // laFamilyTitle
            // 
            this.laFamilyTitle.AutoSize = true;
            this.laFamilyTitle.BackColor = System.Drawing.Color.White;
            this.laFamilyTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyTitle.Location = new System.Drawing.Point(643, 446);
            this.laFamilyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyTitle.Name = "laFamilyTitle";
            this.laFamilyTitle.Size = new System.Drawing.Size(104, 38);
            this.laFamilyTitle.TabIndex = 247;
            this.laFamilyTitle.Text = "户数：";
            // 
            // laYardValue
            // 
            this.laYardValue.AutoSize = true;
            this.laYardValue.BackColor = System.Drawing.Color.White;
            this.laYardValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laYardValue.Location = new System.Drawing.Point(517, 446);
            this.laYardValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laYardValue.Name = "laYardValue";
            this.laYardValue.Size = new System.Drawing.Size(34, 38);
            this.laYardValue.TabIndex = 246;
            this.laYardValue.Text = "1";
            // 
            // laYardTitle
            // 
            this.laYardTitle.AutoSize = true;
            this.laYardTitle.BackColor = System.Drawing.Color.White;
            this.laYardTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laYardTitle.Location = new System.Drawing.Point(302, 446);
            this.laYardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laYardTitle.Name = "laYardTitle";
            this.laYardTitle.Size = new System.Drawing.Size(133, 38);
            this.laYardTitle.TabIndex = 245;
            this.laYardTitle.Text = "院落数：";
            // 
            // laUnitValue
            // 
            this.laUnitValue.AutoSize = true;
            this.laUnitValue.BackColor = System.Drawing.Color.White;
            this.laUnitValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnitValue.Location = new System.Drawing.Point(1535, 446);
            this.laUnitValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnitValue.Name = "laUnitValue";
            this.laUnitValue.Size = new System.Drawing.Size(68, 38);
            this.laUnitValue.TabIndex = 244;
            this.laUnitValue.Text = "321";
            // 
            // laHouseValue
            // 
            this.laHouseValue.AutoSize = true;
            this.laHouseValue.BackColor = System.Drawing.Color.White;
            this.laHouseValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHouseValue.Location = new System.Drawing.Point(1196, 446);
            this.laHouseValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHouseValue.Name = "laHouseValue";
            this.laHouseValue.Size = new System.Drawing.Size(68, 38);
            this.laHouseValue.TabIndex = 243;
            this.laHouseValue.Text = "140";
            // 
            // laUnitTitle
            // 
            this.laUnitTitle.AutoSize = true;
            this.laUnitTitle.BackColor = System.Drawing.Color.White;
            this.laUnitTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnitTitle.Location = new System.Drawing.Point(1329, 444);
            this.laUnitTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnitTitle.Name = "laUnitTitle";
            this.laUnitTitle.Size = new System.Drawing.Size(133, 38);
            this.laUnitTitle.TabIndex = 242;
            this.laUnitTitle.Text = "单元数：";
            // 
            // laHouseTitle
            // 
            this.laHouseTitle.AutoSize = true;
            this.laHouseTitle.BackColor = System.Drawing.Color.White;
            this.laHouseTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHouseTitle.Location = new System.Drawing.Point(985, 444);
            this.laHouseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHouseTitle.Name = "laHouseTitle";
            this.laHouseTitle.Size = new System.Drawing.Size(104, 38);
            this.laHouseTitle.TabIndex = 241;
            this.laHouseTitle.Text = "栋数：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 240;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(331, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "党支部书记：";
            // 
            // jmxz
            // 
            this.jmxz.AutoSize = true;
            this.jmxz.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jmxz.Location = new System.Drawing.Point(331, 372);
            this.jmxz.Name = "jmxz";
            this.jmxz.Size = new System.Drawing.Size(191, 38);
            this.jmxz.TabIndex = 1;
            this.jmxz.Text = "居民小组长：";
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laTitle.Location = new System.Drawing.Point(828, 208);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(160, 46);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "院落名称";
            // 
            // Street
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.black);
            this.Name = "Street";
            this.Load += new System.EventHandler(this.Street_Load);
            this.black.ResumeLayout(false);
            this.black.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel black;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label jmxz;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label laCommunityPopulationValue;
        private System.Windows.Forms.Label laReleaseValue;
        private System.Windows.Forms.Label laReleaseTitle;
        private System.Windows.Forms.Label laCorrectValue;
        private System.Windows.Forms.Label laCorrectTitle;
        private System.Windows.Forms.Label laDopeValue;
        private System.Windows.Forms.Label laDopeTitle;
        private System.Windows.Forms.Label laUnemploymentValue;
        private System.Windows.Forms.Label laUnemploymentTitle;
        private System.Windows.Forms.Label laEmphasisValue;
        private System.Windows.Forms.Label laEmphasisTitle;
        private System.Windows.Forms.Label laCleanerValue;
        private System.Windows.Forms.Label laCleanerTitle;
        private System.Windows.Forms.Label laLowestPeopleValue;
        private System.Windows.Forms.Label laLowestPeopleTitle;
        private System.Windows.Forms.Label laLowestFmailyValue;
        private System.Windows.Forms.Label laLowestFmailyTitle;
        private System.Windows.Forms.Label laForeignerValue;
        private System.Windows.Forms.Label laForeignerTitle;
        private System.Windows.Forms.Label laPriorityValue;
        private System.Windows.Forms.Label laPriorityTitle;
        private System.Windows.Forms.Label laMentalValue;
        private System.Windows.Forms.Label laHandicappedValue;
        private System.Windows.Forms.Label laMentalTitle;
        private System.Windows.Forms.Label laHandicappedTitle;
        private System.Windows.Forms.Label laAloneOlderValue;
        private System.Windows.Forms.Label laAloneOlderTitle;
        private System.Windows.Forms.Label laOlderValue;
        private System.Windows.Forms.Label laOlderTitle;
        private System.Windows.Forms.Label laCommunistValue;
        private System.Windows.Forms.Label laCommunistTitle;
        private System.Windows.Forms.Label laMobilePopulationValue;
        private System.Windows.Forms.Label laMobilePopulationTtile;
        private System.Windows.Forms.Label laFamilyPopulationValue;
        private System.Windows.Forms.Label laFamilyPopulationTtile;
        private System.Windows.Forms.Label laCommunityPopulationTitle;
        private System.Windows.Forms.Label laFamilyValue;
        private System.Windows.Forms.Label laFamilyTitle;
        private System.Windows.Forms.Label laYardValue;
        private System.Windows.Forms.Label laYardTitle;
        private System.Windows.Forms.Label laUnitValue;
        private System.Windows.Forms.Label laHouseValue;
        private System.Windows.Forms.Label laUnitTitle;
        private System.Windows.Forms.Label laHouseTitle;
        private System.Windows.Forms.Label shujiValue;
        private System.Windows.Forms.Label dangValue;
    }
}