using System.Windows.Forms;

namespace jdb
{
    partial class Districk
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
            this.laUnitValue = new System.Windows.Forms.Label();
            this.laUnitTitle = new System.Windows.Forms.Label();
            this.laHouseValue = new System.Windows.Forms.Label();
            this.laHouseTitle = new System.Windows.Forms.Label();
            this.laFamilyValue = new System.Windows.Forms.Label();
            this.laFamilyTitle = new System.Windows.Forms.Label();
            this.laYardValue = new System.Windows.Forms.Label();
            this.laYardTitle = new System.Windows.Forms.Label();
            this.laFLL = new System.Windows.Forms.Label();
            this.laQTL = new System.Windows.Forms.Label();
            this.laCTL = new System.Windows.Forms.Label();
            this.laSXQ = new System.Windows.Forms.Label();
            this.laNetRange = new System.Windows.Forms.Label();
            this.laBgszrName = new System.Windows.Forms.Label();
            this.laBgszrTitle = new System.Windows.Forms.Label();
            this.laDgwsjName = new System.Windows.Forms.Label();
            this.laDgwsjTitle = new System.Windows.Forms.Label();
            this.laTitle1 = new System.Windows.Forms.Label();
            this.black.SuspendLayout();
            this.SuspendLayout();
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.White;
            this.black.BackgroundImage = global::jdb.Properties.Resources.biaozi_1;
            this.black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.black.Controls.Add(this.laUnitValue);
            this.black.Controls.Add(this.laUnitTitle);
            this.black.Controls.Add(this.laHouseValue);
            this.black.Controls.Add(this.laHouseTitle);
            this.black.Controls.Add(this.laFamilyValue);
            this.black.Controls.Add(this.laFamilyTitle);
            this.black.Controls.Add(this.laYardValue);
            this.black.Controls.Add(this.laYardTitle);
            this.black.Controls.Add(this.laFLL);
            this.black.Controls.Add(this.laQTL);
            this.black.Controls.Add(this.laCTL);
            this.black.Controls.Add(this.laSXQ);
            this.black.Controls.Add(this.laNetRange);
            this.black.Controls.Add(this.laBgszrName);
            this.black.Controls.Add(this.laBgszrTitle);
            this.black.Controls.Add(this.laDgwsjName);
            this.black.Controls.Add(this.laDgwsjTitle);
            this.black.Controls.Add(this.laTitle1);
            this.black.Dock = System.Windows.Forms.DockStyle.Fill;
            this.black.Location = new System.Drawing.Point(0, 0);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(1904, 1041);
            this.black.TabIndex = 0;
            // 
            // laCommunityPopulationValue
            // 
            this.laCommunityPopulationValue.AutoSize = true;
            this.laCommunityPopulationValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunityPopulationValue.Location = new System.Drawing.Point(519, 523);
            this.laCommunityPopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunityPopulationValue.Name = "laCommunityPopulationValue";
            this.laCommunityPopulationValue.Size = new System.Drawing.Size(84, 31);
            this.laCommunityPopulationValue.TabIndex = 97;
            this.laCommunityPopulationValue.Text = "00000";
            // 
            // laReleaseValue
            // 
            this.laReleaseValue.AutoSize = true;
            this.laReleaseValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laReleaseValue.Location = new System.Drawing.Point(1529, 599);
            this.laReleaseValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laReleaseValue.Name = "laReleaseValue";
            this.laReleaseValue.Size = new System.Drawing.Size(68, 38);
            this.laReleaseValue.TabIndex = 96;
            this.laReleaseValue.Text = "000";
            // 
            // laReleaseTitle
            // 
            this.laReleaseTitle.AutoSize = true;
            this.laReleaseTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laReleaseTitle.Location = new System.Drawing.Point(1330, 599);
            this.laReleaseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laReleaseTitle.Name = "laReleaseTitle";
            this.laReleaseTitle.Size = new System.Drawing.Size(162, 38);
            this.laReleaseTitle.TabIndex = 95;
            this.laReleaseTitle.Tag = "5";
            this.laReleaseTitle.Text = "刑释人员：";
            this.laReleaseTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laCorrectValue
            // 
            this.laCorrectValue.AutoSize = true;
            this.laCorrectValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCorrectValue.Location = new System.Drawing.Point(1189, 599);
            this.laCorrectValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCorrectValue.Name = "laCorrectValue";
            this.laCorrectValue.Size = new System.Drawing.Size(68, 38);
            this.laCorrectValue.TabIndex = 94;
            this.laCorrectValue.Text = "000";
            // 
            // laCorrectTitle
            // 
            this.laCorrectTitle.AutoSize = true;
            this.laCorrectTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCorrectTitle.Location = new System.Drawing.Point(986, 599);
            this.laCorrectTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCorrectTitle.Name = "laCorrectTitle";
            this.laCorrectTitle.Size = new System.Drawing.Size(162, 38);
            this.laCorrectTitle.TabIndex = 93;
            this.laCorrectTitle.Tag = "4";
            this.laCorrectTitle.Text = "矫正人员：";
            this.laCorrectTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laDopeValue
            // 
            this.laDopeValue.AutoSize = true;
            this.laDopeValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDopeValue.Location = new System.Drawing.Point(518, 670);
            this.laDopeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDopeValue.Name = "laDopeValue";
            this.laDopeValue.Size = new System.Drawing.Size(68, 38);
            this.laDopeValue.TabIndex = 92;
            this.laDopeValue.Text = "000";
            // 
            // laDopeTitle
            // 
            this.laDopeTitle.AutoSize = true;
            this.laDopeTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDopeTitle.Location = new System.Drawing.Point(303, 670);
            this.laDopeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDopeTitle.Name = "laDopeTitle";
            this.laDopeTitle.Size = new System.Drawing.Size(162, 38);
            this.laDopeTitle.TabIndex = 91;
            this.laDopeTitle.Tag = "6";
            this.laDopeTitle.Text = "吸毒人员：";
            this.laDopeTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laUnemploymentValue
            // 
            this.laUnemploymentValue.AutoSize = true;
            this.laUnemploymentValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnemploymentValue.Location = new System.Drawing.Point(1189, 670);
            this.laUnemploymentValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnemploymentValue.Name = "laUnemploymentValue";
            this.laUnemploymentValue.Size = new System.Drawing.Size(68, 38);
            this.laUnemploymentValue.TabIndex = 90;
            this.laUnemploymentValue.Text = "000";
            // 
            // laUnemploymentTitle
            // 
            this.laUnemploymentTitle.AutoSize = true;
            this.laUnemploymentTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnemploymentTitle.Location = new System.Drawing.Point(986, 670);
            this.laUnemploymentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnemploymentTitle.Name = "laUnemploymentTitle";
            this.laUnemploymentTitle.Size = new System.Drawing.Size(162, 38);
            this.laUnemploymentTitle.TabIndex = 89;
            this.laUnemploymentTitle.Tag = "8";
            this.laUnemploymentTitle.Text = "失业人员：";
            this.laUnemploymentTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laEmphasisValue
            // 
            this.laEmphasisValue.AutoSize = true;
            this.laEmphasisValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEmphasisValue.Location = new System.Drawing.Point(854, 599);
            this.laEmphasisValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laEmphasisValue.Name = "laEmphasisValue";
            this.laEmphasisValue.Size = new System.Drawing.Size(68, 38);
            this.laEmphasisValue.TabIndex = 88;
            this.laEmphasisValue.Text = "000";
            // 
            // laEmphasisTitle
            // 
            this.laEmphasisTitle.AutoSize = true;
            this.laEmphasisTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEmphasisTitle.Location = new System.Drawing.Point(644, 599);
            this.laEmphasisTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laEmphasisTitle.Name = "laEmphasisTitle";
            this.laEmphasisTitle.Size = new System.Drawing.Size(162, 38);
            this.laEmphasisTitle.TabIndex = 87;
            this.laEmphasisTitle.Tag = "3";
            this.laEmphasisTitle.Text = "重点人员：";
            this.laEmphasisTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laCleanerValue
            // 
            this.laCleanerValue.AutoSize = true;
            this.laCleanerValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCleanerValue.Location = new System.Drawing.Point(518, 599);
            this.laCleanerValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCleanerValue.Name = "laCleanerValue";
            this.laCleanerValue.Size = new System.Drawing.Size(68, 38);
            this.laCleanerValue.TabIndex = 86;
            this.laCleanerValue.Text = "000";
            // 
            // laCleanerTitle
            // 
            this.laCleanerTitle.AutoSize = true;
            this.laCleanerTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCleanerTitle.Location = new System.Drawing.Point(303, 599);
            this.laCleanerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCleanerTitle.Name = "laCleanerTitle";
            this.laCleanerTitle.Size = new System.Drawing.Size(191, 38);
            this.laCleanerTitle.TabIndex = 85;
            this.laCleanerTitle.Tag = "2";
            this.laCleanerTitle.Text = "藏维族人员：";
            this.laCleanerTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laLowestPeopleValue
            // 
            this.laLowestPeopleValue.AutoSize = true;
            this.laLowestPeopleValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestPeopleValue.Location = new System.Drawing.Point(854, 814);
            this.laLowestPeopleValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestPeopleValue.Name = "laLowestPeopleValue";
            this.laLowestPeopleValue.Size = new System.Drawing.Size(68, 38);
            this.laLowestPeopleValue.TabIndex = 84;
            this.laLowestPeopleValue.Text = "000";
            // 
            // laLowestPeopleTitle
            // 
            this.laLowestPeopleTitle.AutoSize = true;
            this.laLowestPeopleTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestPeopleTitle.Location = new System.Drawing.Point(644, 814);
            this.laLowestPeopleTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestPeopleTitle.Name = "laLowestPeopleTitle";
            this.laLowestPeopleTitle.Size = new System.Drawing.Size(162, 38);
            this.laLowestPeopleTitle.TabIndex = 83;
            this.laLowestPeopleTitle.Tag = "15";
            this.laLowestPeopleTitle.Text = "低保人员：";
            this.laLowestPeopleTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laLowestFmailyValue
            // 
            this.laLowestFmailyValue.AutoSize = true;
            this.laLowestFmailyValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestFmailyValue.Location = new System.Drawing.Point(518, 814);
            this.laLowestFmailyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestFmailyValue.Name = "laLowestFmailyValue";
            this.laLowestFmailyValue.Size = new System.Drawing.Size(68, 38);
            this.laLowestFmailyValue.TabIndex = 82;
            this.laLowestFmailyValue.Text = "000";
            // 
            // laLowestFmailyTitle
            // 
            this.laLowestFmailyTitle.AutoSize = true;
            this.laLowestFmailyTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestFmailyTitle.Location = new System.Drawing.Point(303, 814);
            this.laLowestFmailyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestFmailyTitle.Name = "laLowestFmailyTitle";
            this.laLowestFmailyTitle.Size = new System.Drawing.Size(162, 38);
            this.laLowestFmailyTitle.TabIndex = 81;
            this.laLowestFmailyTitle.Tag = "14";
            this.laLowestFmailyTitle.Text = "低保户数：";
            this.laLowestFmailyTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laForeignerValue
            // 
            this.laForeignerValue.AutoSize = true;
            this.laForeignerValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laForeignerValue.Location = new System.Drawing.Point(854, 670);
            this.laForeignerValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laForeignerValue.Name = "laForeignerValue";
            this.laForeignerValue.Size = new System.Drawing.Size(68, 38);
            this.laForeignerValue.TabIndex = 80;
            this.laForeignerValue.Text = "000";
            // 
            // laForeignerTitle
            // 
            this.laForeignerTitle.AutoSize = true;
            this.laForeignerTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laForeignerTitle.Location = new System.Drawing.Point(644, 670);
            this.laForeignerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laForeignerTitle.Name = "laForeignerTitle";
            this.laForeignerTitle.Size = new System.Drawing.Size(162, 38);
            this.laForeignerTitle.TabIndex = 79;
            this.laForeignerTitle.Tag = "7";
            this.laForeignerTitle.Text = "境外人员：";
            this.laForeignerTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laPriorityValue
            // 
            this.laPriorityValue.AutoSize = true;
            this.laPriorityValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laPriorityValue.Location = new System.Drawing.Point(1529, 670);
            this.laPriorityValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laPriorityValue.Name = "laPriorityValue";
            this.laPriorityValue.Size = new System.Drawing.Size(68, 38);
            this.laPriorityValue.TabIndex = 78;
            this.laPriorityValue.Text = "000";
            // 
            // laPriorityTitle
            // 
            this.laPriorityTitle.AutoSize = true;
            this.laPriorityTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laPriorityTitle.Location = new System.Drawing.Point(1330, 670);
            this.laPriorityTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laPriorityTitle.Name = "laPriorityTitle";
            this.laPriorityTitle.Size = new System.Drawing.Size(162, 38);
            this.laPriorityTitle.TabIndex = 77;
            this.laPriorityTitle.Tag = "9";
            this.laPriorityTitle.Text = "优抚人员：";
            this.laPriorityTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laMentalValue
            // 
            this.laMentalValue.AutoSize = true;
            this.laMentalValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMentalValue.Location = new System.Drawing.Point(854, 743);
            this.laMentalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMentalValue.Name = "laMentalValue";
            this.laMentalValue.Size = new System.Drawing.Size(68, 38);
            this.laMentalValue.TabIndex = 76;
            this.laMentalValue.Text = "000";
            // 
            // laHandicappedValue
            // 
            this.laHandicappedValue.AutoSize = true;
            this.laHandicappedValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHandicappedValue.Location = new System.Drawing.Point(518, 743);
            this.laHandicappedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHandicappedValue.Name = "laHandicappedValue";
            this.laHandicappedValue.Size = new System.Drawing.Size(68, 38);
            this.laHandicappedValue.TabIndex = 75;
            this.laHandicappedValue.Text = "000";
            // 
            // laMentalTitle
            // 
            this.laMentalTitle.AutoSize = true;
            this.laMentalTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMentalTitle.Location = new System.Drawing.Point(644, 743);
            this.laMentalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMentalTitle.Name = "laMentalTitle";
            this.laMentalTitle.Size = new System.Drawing.Size(162, 38);
            this.laMentalTitle.TabIndex = 74;
            this.laMentalTitle.Tag = "11";
            this.laMentalTitle.Text = "精神残疾：";
            this.laMentalTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laHandicappedTitle
            // 
            this.laHandicappedTitle.AutoSize = true;
            this.laHandicappedTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHandicappedTitle.Location = new System.Drawing.Point(303, 743);
            this.laHandicappedTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHandicappedTitle.Name = "laHandicappedTitle";
            this.laHandicappedTitle.Size = new System.Drawing.Size(133, 38);
            this.laHandicappedTitle.TabIndex = 73;
            this.laHandicappedTitle.Tag = "10";
            this.laHandicappedTitle.Text = "残疾人：";
            this.laHandicappedTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laAloneOlderValue
            // 
            this.laAloneOlderValue.AutoSize = true;
            this.laAloneOlderValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laAloneOlderValue.Location = new System.Drawing.Point(1529, 743);
            this.laAloneOlderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laAloneOlderValue.Name = "laAloneOlderValue";
            this.laAloneOlderValue.Size = new System.Drawing.Size(68, 38);
            this.laAloneOlderValue.TabIndex = 72;
            this.laAloneOlderValue.Text = "000";
            // 
            // laAloneOlderTitle
            // 
            this.laAloneOlderTitle.AutoSize = true;
            this.laAloneOlderTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laAloneOlderTitle.Location = new System.Drawing.Point(1330, 743);
            this.laAloneOlderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laAloneOlderTitle.Name = "laAloneOlderTitle";
            this.laAloneOlderTitle.Size = new System.Drawing.Size(162, 38);
            this.laAloneOlderTitle.TabIndex = 71;
            this.laAloneOlderTitle.Tag = "13";
            this.laAloneOlderTitle.Text = "空巢老人：";
            this.laAloneOlderTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laOlderValue
            // 
            this.laOlderValue.AutoSize = true;
            this.laOlderValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laOlderValue.Location = new System.Drawing.Point(1189, 743);
            this.laOlderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laOlderValue.Name = "laOlderValue";
            this.laOlderValue.Size = new System.Drawing.Size(85, 38);
            this.laOlderValue.TabIndex = 70;
            this.laOlderValue.Text = "0000";
            // 
            // laOlderTitle
            // 
            this.laOlderTitle.AutoSize = true;
            this.laOlderTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laOlderTitle.Location = new System.Drawing.Point(986, 743);
            this.laOlderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laOlderTitle.Name = "laOlderTitle";
            this.laOlderTitle.Size = new System.Drawing.Size(133, 38);
            this.laOlderTitle.TabIndex = 69;
            this.laOlderTitle.Tag = "12";
            this.laOlderTitle.Text = "老年人：";
            this.laOlderTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laCommunistValue
            // 
            this.laCommunistValue.AutoSize = true;
            this.laCommunistValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunistValue.Location = new System.Drawing.Point(1529, 522);
            this.laCommunistValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunistValue.Name = "laCommunistValue";
            this.laCommunistValue.Size = new System.Drawing.Size(68, 38);
            this.laCommunistValue.TabIndex = 68;
            this.laCommunistValue.Text = "000";
            // 
            // laCommunistTitle
            // 
            this.laCommunistTitle.AutoSize = true;
            this.laCommunistTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunistTitle.Location = new System.Drawing.Point(1330, 522);
            this.laCommunistTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunistTitle.Name = "laCommunistTitle";
            this.laCommunistTitle.Size = new System.Drawing.Size(104, 38);
            this.laCommunistTitle.TabIndex = 67;
            this.laCommunistTitle.Tag = "1";
            this.laCommunistTitle.Text = "党员：";
            this.laCommunistTitle.Click += new System.EventHandler(this.laClick_Click);
            // 
            // laMobilePopulationValue
            // 
            this.laMobilePopulationValue.AutoSize = true;
            this.laMobilePopulationValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMobilePopulationValue.Location = new System.Drawing.Point(1190, 525);
            this.laMobilePopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMobilePopulationValue.Name = "laMobilePopulationValue";
            this.laMobilePopulationValue.Size = new System.Drawing.Size(84, 31);
            this.laMobilePopulationValue.TabIndex = 66;
            this.laMobilePopulationValue.Text = "00000";
            // 
            // laMobilePopulationTtile
            // 
            this.laMobilePopulationTtile.AutoSize = true;
            this.laMobilePopulationTtile.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMobilePopulationTtile.Location = new System.Drawing.Point(986, 522);
            this.laMobilePopulationTtile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMobilePopulationTtile.Name = "laMobilePopulationTtile";
            this.laMobilePopulationTtile.Size = new System.Drawing.Size(162, 38);
            this.laMobilePopulationTtile.TabIndex = 65;
            this.laMobilePopulationTtile.Text = "流动人口：";
            // 
            // laFamilyPopulationValue
            // 
            this.laFamilyPopulationValue.AutoSize = true;
            this.laFamilyPopulationValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyPopulationValue.Location = new System.Drawing.Point(855, 525);
            this.laFamilyPopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyPopulationValue.Name = "laFamilyPopulationValue";
            this.laFamilyPopulationValue.Size = new System.Drawing.Size(84, 31);
            this.laFamilyPopulationValue.TabIndex = 64;
            this.laFamilyPopulationValue.Text = "00000";
            // 
            // laFamilyPopulationTtile
            // 
            this.laFamilyPopulationTtile.AutoSize = true;
            this.laFamilyPopulationTtile.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyPopulationTtile.Location = new System.Drawing.Point(644, 520);
            this.laFamilyPopulationTtile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyPopulationTtile.Name = "laFamilyPopulationTtile";
            this.laFamilyPopulationTtile.Size = new System.Drawing.Size(162, 38);
            this.laFamilyPopulationTtile.TabIndex = 63;
            this.laFamilyPopulationTtile.Text = "户籍人口：";
            // 
            // laCommunityPopulationTitle
            // 
            this.laCommunityPopulationTitle.AutoSize = true;
            this.laCommunityPopulationTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunityPopulationTitle.Location = new System.Drawing.Point(303, 520);
            this.laCommunityPopulationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunityPopulationTitle.Name = "laCommunityPopulationTitle";
            this.laCommunityPopulationTitle.Size = new System.Drawing.Size(162, 38);
            this.laCommunityPopulationTitle.TabIndex = 62;
            this.laCommunityPopulationTitle.Text = "常住人口：";
            this.laCommunityPopulationTitle.Click += new System.EventHandler(this.laCommunityPopulationTitle_Click);
            // 
            // laUnitValue
            // 
            this.laUnitValue.AutoSize = true;
            this.laUnitValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnitValue.Location = new System.Drawing.Point(1530, 449);
            this.laUnitValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnitValue.Name = "laUnitValue";
            this.laUnitValue.Size = new System.Drawing.Size(70, 31);
            this.laUnitValue.TabIndex = 61;
            this.laUnitValue.Text = "1554";
            // 
            // laUnitTitle
            // 
            this.laUnitTitle.AutoSize = true;
            this.laUnitTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnitTitle.Location = new System.Drawing.Point(1330, 449);
            this.laUnitTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnitTitle.Name = "laUnitTitle";
            this.laUnitTitle.Size = new System.Drawing.Size(133, 38);
            this.laUnitTitle.TabIndex = 60;
            this.laUnitTitle.Text = "单元数：";
            // 
            // laHouseValue
            // 
            this.laHouseValue.AutoSize = true;
            this.laHouseValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHouseValue.Location = new System.Drawing.Point(1189, 449);
            this.laHouseValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHouseValue.Name = "laHouseValue";
            this.laHouseValue.Size = new System.Drawing.Size(68, 38);
            this.laHouseValue.TabIndex = 59;
            this.laHouseValue.Text = "620";
            // 
            // laHouseTitle
            // 
            this.laHouseTitle.AutoSize = true;
            this.laHouseTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHouseTitle.Location = new System.Drawing.Point(986, 449);
            this.laHouseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHouseTitle.Name = "laHouseTitle";
            this.laHouseTitle.Size = new System.Drawing.Size(104, 38);
            this.laHouseTitle.TabIndex = 58;
            this.laHouseTitle.Text = "栋数：";
            // 
            // laFamilyValue
            // 
            this.laFamilyValue.AutoSize = true;
            this.laFamilyValue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyValue.Location = new System.Drawing.Point(855, 452);
            this.laFamilyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyValue.Name = "laFamilyValue";
            this.laFamilyValue.Size = new System.Drawing.Size(84, 31);
            this.laFamilyValue.TabIndex = 57;
            this.laFamilyValue.Text = "00000";
            // 
            // laFamilyTitle
            // 
            this.laFamilyTitle.AutoSize = true;
            this.laFamilyTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyTitle.Location = new System.Drawing.Point(644, 449);
            this.laFamilyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyTitle.Name = "laFamilyTitle";
            this.laFamilyTitle.Size = new System.Drawing.Size(104, 38);
            this.laFamilyTitle.TabIndex = 56;
            this.laFamilyTitle.Text = "户数：";
            // 
            // laYardValue
            // 
            this.laYardValue.AutoSize = true;
            this.laYardValue.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laYardValue.Location = new System.Drawing.Point(518, 449);
            this.laYardValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laYardValue.Name = "laYardValue";
            this.laYardValue.Size = new System.Drawing.Size(85, 38);
            this.laYardValue.TabIndex = 55;
            this.laYardValue.Text = "0000";
            // 
            // laYardTitle
            // 
            this.laYardTitle.AutoSize = true;
            this.laYardTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laYardTitle.Location = new System.Drawing.Point(303, 449);
            this.laYardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laYardTitle.Name = "laYardTitle";
            this.laYardTitle.Size = new System.Drawing.Size(133, 38);
            this.laYardTitle.TabIndex = 54;
            this.laYardTitle.Text = "院落数：";
            // 
            // laFLL
            // 
            this.laFLL.AutoSize = true;
            this.laFLL.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFLL.Location = new System.Drawing.Point(1133, 371);
            this.laFLL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFLL.Name = "laFLL";
            this.laFLL.Size = new System.Drawing.Size(162, 38);
            this.laFLL.TabIndex = 18;
            this.laFLL.Tag = "GridsFLL";
            this.laFLL.Text = "芳邻路社区";
            this.laFLL.Click += new System.EventHandler(this.laFLL_Click);
            // 
            // laQTL
            // 
            this.laQTL.AutoSize = true;
            this.laQTL.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laQTL.Location = new System.Drawing.Point(862, 371);
            this.laQTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laQTL.Name = "laQTL";
            this.laQTL.Size = new System.Drawing.Size(162, 38);
            this.laQTL.TabIndex = 17;
            this.laQTL.Tag = "GridsQTL";
            this.laQTL.Text = "琴台路社区";
            this.laQTL.Click += new System.EventHandler(this.laQTL_Click);
            // 
            // laCTL
            // 
            this.laCTL.AutoSize = true;
            this.laCTL.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCTL.Location = new System.Drawing.Point(591, 371);
            this.laCTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCTL.Name = "laCTL";
            this.laCTL.Size = new System.Drawing.Size(162, 38);
            this.laCTL.TabIndex = 16;
            this.laCTL.Tag = "GridsCTL";
            this.laCTL.Text = "草堂路社区";
            this.laCTL.Click += new System.EventHandler(this.laCTL_Click);
            // 
            // laSXQ
            // 
            this.laSXQ.AutoSize = true;
            this.laSXQ.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laSXQ.Location = new System.Drawing.Point(1404, 371);
            this.laSXQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laSXQ.Name = "laSXQ";
            this.laSXQ.Size = new System.Drawing.Size(162, 38);
            this.laSXQ.TabIndex = 15;
            this.laSXQ.Tag = "GridsSXQ";
            this.laSXQ.Text = "送仙桥社区";
            this.laSXQ.Click += new System.EventHandler(this.laSXQ_Click);
            // 
            // laNetRange
            // 
            this.laNetRange.AutoSize = true;
            this.laNetRange.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laNetRange.Location = new System.Drawing.Point(332, 371);
            this.laNetRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laNetRange.Name = "laNetRange";
            this.laNetRange.Size = new System.Drawing.Size(162, 38);
            this.laNetRange.TabIndex = 14;
            this.laNetRange.Text = "网络范围：";
            // 
            // laBgszrName
            // 
            this.laBgszrName.AutoSize = true;
            this.laBgszrName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laBgszrName.Location = new System.Drawing.Point(1404, 291);
            this.laBgszrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laBgszrName.Name = "laBgszrName";
            this.laBgszrName.Size = new System.Drawing.Size(75, 38);
            this.laBgszrName.TabIndex = 13;
            this.laBgszrName.Text = "彭伟";
            // 
            // laBgszrTitle
            // 
            this.laBgszrTitle.AutoSize = true;
            this.laBgszrTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laBgszrTitle.Location = new System.Drawing.Point(1133, 291);
            this.laBgszrTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laBgszrTitle.Name = "laBgszrTitle";
            this.laBgszrTitle.Size = new System.Drawing.Size(191, 38);
            this.laBgszrTitle.TabIndex = 12;
            this.laBgszrTitle.Text = "办事处主任：";
            // 
            // laDgwsjName
            // 
            this.laDgwsjName.AutoSize = true;
            this.laDgwsjName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDgwsjName.Location = new System.Drawing.Point(591, 291);
            this.laDgwsjName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDgwsjName.Name = "laDgwsjName";
            this.laDgwsjName.Size = new System.Drawing.Size(104, 38);
            this.laDgwsjName.TabIndex = 11;
            this.laDgwsjName.Text = "贾定邦";
            // 
            // laDgwsjTitle
            // 
            this.laDgwsjTitle.AutoSize = true;
            this.laDgwsjTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDgwsjTitle.Location = new System.Drawing.Point(332, 291);
            this.laDgwsjTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDgwsjTitle.Name = "laDgwsjTitle";
            this.laDgwsjTitle.Size = new System.Drawing.Size(191, 38);
            this.laDgwsjTitle.TabIndex = 10;
            this.laDgwsjTitle.Text = "党工委书记：";
            // 
            // laTitle1
            // 
            this.laTitle1.AutoSize = true;
            this.laTitle1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laTitle1.Location = new System.Drawing.Point(585, 188);
            this.laTitle1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laTitle1.Name = "laTitle1";
            this.laTitle1.Size = new System.Drawing.Size(704, 75);
            this.laTitle1.TabIndex = 1;
            this.laTitle1.Text = "草堂办事处基础网格汇总表";
            // 
            // Districk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.black);
            this.Name = "Districk";
            this.Text = "Districk";
            this.Load += new System.EventHandler(this.Districk_Load);
            this.black.ResumeLayout(false);
            this.black.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel black;
        private Label laFLL;
        private Label laQTL;
        private Label laCTL;
        private Label laSXQ;
        private Label laNetRange;
        private Label laBgszrName;
        private Label laBgszrTitle;
        private Label laDgwsjName;
        private Label laDgwsjTitle;
        private Label laTitle1;
        private Label laCommunityPopulationValue;
        private Label laReleaseValue;
        private Label laReleaseTitle;
        private Label laCorrectValue;
        private Label laCorrectTitle;
        private Label laDopeValue;
        private Label laDopeTitle;
        private Label laUnemploymentValue;
        private Label laUnemploymentTitle;
        private Label laEmphasisValue;
        private Label laEmphasisTitle;
        private Label laCleanerValue;
        private Label laCleanerTitle;
        private Label laLowestPeopleValue;
        private Label laLowestPeopleTitle;
        private Label laLowestFmailyValue;
        private Label laLowestFmailyTitle;
        private Label laForeignerValue;
        private Label laForeignerTitle;
        private Label laPriorityValue;
        private Label laPriorityTitle;
        private Label laMentalValue;
        private Label laHandicappedValue;
        private Label laMentalTitle;
        private Label laHandicappedTitle;
        private Label laAloneOlderValue;
        private Label laAloneOlderTitle;
        private Label laOlderValue;
        private Label laOlderTitle;
        private Label laCommunistValue;
        private Label laCommunistTitle;
        private Label laMobilePopulationValue;
        private Label laMobilePopulationTtile;
        private Label laFamilyPopulationValue;
        private Label laFamilyPopulationTtile;
        private Label laCommunityPopulationTitle;
        private Label laUnitValue;
        private Label laUnitTitle;
        private Label laHouseValue;
        private Label laHouseTitle;
        private Label laFamilyValue;
        private Label laFamilyTitle;
        private Label laYardValue;
        private Label laYardTitle;
    }
}