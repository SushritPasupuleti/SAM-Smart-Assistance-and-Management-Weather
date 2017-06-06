namespace SAM_Weather
{
    partial class Weather
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WI = new System.Windows.Forms.PictureBox();
            this.WT = new System.Windows.Forms.TextBox();
            this.Temp = new System.Windows.Forms.Label();
            this.WSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HMDY = new System.Windows.Forms.Label();
            this.CNDN = new System.Windows.Forms.Label();
            this.TWN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sr = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.Dt = new System.Windows.Forms.Label();
            this.WRefresh = new System.Windows.Forms.PictureBox();
            this.Closethis = new System.Windows.Forms.PictureBox();
            this.WeatherBox2 = new System.Windows.Forms.Panel();
            this.BckScrn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).BeginInit();
            this.WeatherBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BckScrn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SAM_Weather.Properties.Resources.Sunrise;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(375, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 72);
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // WI
            // 
            this.WI.BackColor = System.Drawing.Color.Transparent;
            this.WI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WI.Location = new System.Drawing.Point(13, 8);
            this.WI.Name = "WI";
            this.WI.Size = new System.Drawing.Size(70, 70);
            this.WI.TabIndex = 103;
            this.WI.TabStop = false;
            this.WI.Click += new System.EventHandler(this.WI_Click);
            this.WI.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WI_MouseDoubleClick);
            // 
            // WT
            // 
            this.WT.Location = new System.Drawing.Point(200, 235);
            this.WT.Name = "WT";
            this.WT.Size = new System.Drawing.Size(100, 20);
            this.WT.TabIndex = 130;
            this.WT.Visible = false;
            this.WT.TextChanged += new System.EventHandler(this.WT_TextChanged);
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.BackColor = System.Drawing.Color.Transparent;
            this.Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Temp.Location = new System.Drawing.Point(59, 53);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(85, 39);
            this.Temp.TabIndex = 131;
            this.Temp.Text = "96 F";
            // 
            // WSP
            // 
            this.WSP.AutoSize = true;
            this.WSP.BackColor = System.Drawing.Color.Transparent;
            this.WSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WSP.ForeColor = System.Drawing.SystemColors.Control;
            this.WSP.Location = new System.Drawing.Point(127, 143);
            this.WSP.Name = "WSP";
            this.WSP.Size = new System.Drawing.Size(143, 25);
            this.WSP.TabIndex = 132;
            this.WSP.Text = "3 mile(s)/hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 133;
            this.label1.Text = "Wind Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(35, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 134;
            this.label2.Text = "Humidity";
            // 
            // HMDY
            // 
            this.HMDY.AutoSize = true;
            this.HMDY.BackColor = System.Drawing.Color.Transparent;
            this.HMDY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HMDY.ForeColor = System.Drawing.SystemColors.Control;
            this.HMDY.Location = new System.Drawing.Point(127, 170);
            this.HMDY.Name = "HMDY";
            this.HMDY.Size = new System.Drawing.Size(55, 25);
            this.HMDY.TabIndex = 135;
            this.HMDY.Text = "34%";
            // 
            // CNDN
            // 
            this.CNDN.AutoSize = true;
            this.CNDN.BackColor = System.Drawing.Color.Transparent;
            this.CNDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNDN.ForeColor = System.Drawing.Color.Cornsilk;
            this.CNDN.Location = new System.Drawing.Point(66, 8);
            this.CNDN.Name = "CNDN";
            this.CNDN.Size = new System.Drawing.Size(78, 25);
            this.CNDN.TabIndex = 136;
            this.CNDN.Text = "Sunny";
            // 
            // TWN
            // 
            this.TWN.AutoSize = true;
            this.TWN.BackColor = System.Drawing.Color.Transparent;
            this.TWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWN.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.TWN.Location = new System.Drawing.Point(219, 235);
            this.TWN.Name = "TWN";
            this.TWN.Size = new System.Drawing.Size(152, 25);
            this.TWN.TabIndex = 137;
            this.TWN.Text = "Internet issues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(284, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Sunrise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(289, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 139;
            this.label4.Text = "Sunset";
            // 
            // sr
            // 
            this.sr.AutoSize = true;
            this.sr.BackColor = System.Drawing.Color.Transparent;
            this.sr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sr.Location = new System.Drawing.Point(360, 53);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(92, 25);
            this.sr.TabIndex = 140;
            this.sr.Text = "5:33 AM";
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.BackColor = System.Drawing.Color.Transparent;
            this.ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss.ForeColor = System.Drawing.Color.White;
            this.ss.Location = new System.Drawing.Point(360, 86);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(92, 25);
            this.ss.TabIndex = 141;
            this.ss.Text = "6:45 PM";
            // 
            // Dt
            // 
            this.Dt.AutoSize = true;
            this.Dt.BackColor = System.Drawing.Color.Transparent;
            this.Dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt.ForeColor = System.Drawing.Color.White;
            this.Dt.Location = new System.Drawing.Point(97, 207);
            this.Dt.Name = "Dt";
            this.Dt.Size = new System.Drawing.Size(306, 25);
            this.Dt.TabIndex = 144;
            this.Dt.Text = "Sat, 18 Apr 2015 11:30 am IST";
            // 
            // WRefresh
            // 
            this.WRefresh.BackColor = System.Drawing.Color.Transparent;
            this.WRefresh.BackgroundImage = global::SAM_Weather.Properties.Resources.Refresh_iconC;
            this.WRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WRefresh.Location = new System.Drawing.Point(429, 227);
            this.WRefresh.Name = "WRefresh";
            this.WRefresh.Size = new System.Drawing.Size(35, 35);
            this.WRefresh.TabIndex = 146;
            this.WRefresh.TabStop = false;
            this.WRefresh.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Closethis
            // 
            this.Closethis.BackColor = System.Drawing.Color.Transparent;
            this.Closethis.BackgroundImage = global::SAM_Weather.Properties.Resources.close_icon;
            this.Closethis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closethis.Location = new System.Drawing.Point(544, 45);
            this.Closethis.Name = "Closethis";
            this.Closethis.Size = new System.Drawing.Size(26, 25);
            this.Closethis.TabIndex = 171;
            this.Closethis.TabStop = false;
            this.Closethis.Click += new System.EventHandler(this.Closethis_Click);
            // 
            // WeatherBox2
            // 
            this.WeatherBox2.BackColor = System.Drawing.Color.Black;
            this.WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Rainy;
            this.WeatherBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WeatherBox2.Controls.Add(this.CNDN);
            this.WeatherBox2.Controls.Add(this.Temp);
            this.WeatherBox2.Controls.Add(this.WI);
            this.WeatherBox2.Controls.Add(this.sr);
            this.WeatherBox2.Controls.Add(this.WRefresh);
            this.WeatherBox2.Controls.Add(this.pictureBox1);
            this.WeatherBox2.Controls.Add(this.Dt);
            this.WeatherBox2.Controls.Add(this.ss);
            this.WeatherBox2.Controls.Add(this.WT);
            this.WeatherBox2.Controls.Add(this.label4);
            this.WeatherBox2.Controls.Add(this.WSP);
            this.WeatherBox2.Controls.Add(this.label3);
            this.WeatherBox2.Controls.Add(this.label1);
            this.WeatherBox2.Controls.Add(this.TWN);
            this.WeatherBox2.Controls.Add(this.label2);
            this.WeatherBox2.Controls.Add(this.HMDY);
            this.WeatherBox2.Location = new System.Drawing.Point(75, 87);
            this.WeatherBox2.Name = "WeatherBox2";
            this.WeatherBox2.Size = new System.Drawing.Size(495, 278);
            this.WeatherBox2.TabIndex = 173;
            // 
            // BckScrn
            // 
            this.BckScrn.BackColor = System.Drawing.Color.Transparent;
            this.BckScrn.BackgroundImage = global::SAM_Weather.Properties.Resources.GreyScrn;
            this.BckScrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BckScrn.Location = new System.Drawing.Point(164, 147);
            this.BckScrn.Name = "BckScrn";
            this.BckScrn.Size = new System.Drawing.Size(495, 278);
            this.BckScrn.TabIndex = 147;
            this.BckScrn.TabStop = false;
            this.BckScrn.Visible = false;
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SAM_Weather.Properties.Resources.WeatherWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 413);
            this.Controls.Add(this.WeatherBox2);
            this.Controls.Add(this.Closethis);
            this.Controls.Add(this.BckScrn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Weather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).EndInit();
            this.WeatherBox2.ResumeLayout(false);
            this.WeatherBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BckScrn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox WI;
        private System.Windows.Forms.TextBox WT;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label WSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HMDY;
        private System.Windows.Forms.Label CNDN;
        private System.Windows.Forms.Label TWN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sr;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label Dt;
        private System.Windows.Forms.PictureBox WRefresh;
        private System.Windows.Forms.PictureBox Closethis;
        private System.Windows.Forms.Panel WeatherBox2;
        private System.Windows.Forms.PictureBox BckScrn;

    }
}