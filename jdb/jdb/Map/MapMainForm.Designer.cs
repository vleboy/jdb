namespace jdb.Map
{
    partial class MapMainForm
    {
        public Main main = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.mytm4 = new TM.mytm();
            this.mytm3 = new TM.mytm();
            this.mytm2 = new TM.mytm();
            this.mytm1 = new TM.mytm();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::jdb.Properties.Resources.gezi11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.mytm4);
            this.panel1.Controls.Add(this.mytm3);
            this.panel1.Controls.Add(this.mytm2);
            this.panel1.Controls.Add(this.mytm1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 961);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1311, 847);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mytm4
            // 
            this.mytm4.BackColor = System.Drawing.Color.Transparent;
            this.mytm4.Location = new System.Drawing.Point(254, 74);
            this.mytm4.Name = "mytm4";
            this.mytm4.Size = new System.Drawing.Size(269, 287);
            this.mytm4.TabIndex = 8;
            this.mytm4.Tag = "sxq_grid_1";
            this.mytm4.Click += new System.EventHandler(this.mytm_Click);
            // 
            // mytm3
            // 
            this.mytm3.BackColor = System.Drawing.Color.Transparent;
            this.mytm3.Location = new System.Drawing.Point(568, 225);
            this.mytm3.Name = "mytm3";
            this.mytm3.Size = new System.Drawing.Size(353, 394);
            this.mytm3.TabIndex = 8;
            this.mytm3.Tag = "qt_grid_1";
            this.mytm3.Click += new System.EventHandler(this.mytm_Click);
            // 
            // mytm2
            // 
            this.mytm2.BackColor = System.Drawing.Color.Transparent;
            this.mytm2.Location = new System.Drawing.Point(568, 649);
            this.mytm2.Name = "mytm2";
            this.mytm2.Size = new System.Drawing.Size(353, 221);
            this.mytm2.TabIndex = 8;
            this.mytm2.Tag = "fl_grid_1";
            this.mytm2.Click += new System.EventHandler(this.mytm_Click);
            // 
            // mytm1
            // 
            this.mytm1.BackColor = System.Drawing.Color.Transparent;
            this.mytm1.Location = new System.Drawing.Point(12, 379);
            this.mytm1.Name = "mytm1";
            this.mytm1.Size = new System.Drawing.Size(550, 505);
            this.mytm1.TabIndex = 7;
            this.mytm1.Tag = "ct_grid_1";
            this.mytm1.Click += new System.EventHandler(this.mytm_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1318, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 456);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1311, 880);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(526, 66);
            this.button1.TabIndex = 5;
            this.button1.Tag = "list";
            this.button1.Text = "详细信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::jdb.Properties.Resources.gezi11;
            this.pictureBox1.Image = global::jdb.Properties.Resources.map;
            this.pictureBox1.Location = new System.Drawing.Point(153, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 946);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1465, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 56);
            this.label2.TabIndex = 10;
            this.label2.Text = "草堂街道";
            // 
            // MapMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapMainForm";
            this.Load += new System.EventHandler(this.MapMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private TM.mytm mytm1;
        private TM.mytm mytm4;
        private TM.mytm mytm3;
        private TM.mytm mytm2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}