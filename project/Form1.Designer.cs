namespace project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.form1_upcolor = new System.Windows.Forms.PictureBox();
            this.pictureBox_earth = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Blegger = new System.Windows.Forms.Button();
            this.reader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.About = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1_upcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // form1_upcolor
            // 
            this.form1_upcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.form1_upcolor.Location = new System.Drawing.Point(-1, 64);
            this.form1_upcolor.Name = "form1_upcolor";
            this.form1_upcolor.Size = new System.Drawing.Size(743, 94);
            this.form1_upcolor.TabIndex = 0;
            this.form1_upcolor.TabStop = false;
            // 
            // pictureBox_earth
            // 
            this.pictureBox_earth.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_earth.Image")));
            this.pictureBox_earth.Location = new System.Drawing.Point(-1, 156);
            this.pictureBox_earth.Name = "pictureBox_earth";
            this.pictureBox_earth.Size = new System.Drawing.Size(810, 379);
            this.pictureBox_earth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_earth.TabIndex = 1;
            this.pictureBox_earth.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-1, 64);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(145, 77);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.MouseEnter += new System.EventHandler(this.logo_MouseEnter);
            this.logo.MouseLeave += new System.EventHandler(this.logo_MouseLeave);
            // 
            // Blegger
            // 
            this.Blegger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Blegger.Image = ((System.Drawing.Image)(resources.GetObject("Blegger.Image")));
            this.Blegger.Location = new System.Drawing.Point(285, 77);
            this.Blegger.Name = "Blegger";
            this.Blegger.Size = new System.Drawing.Size(98, 73);
            this.Blegger.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Blegger, "Member");
            this.Blegger.UseVisualStyleBackColor = true;
            this.Blegger.Click += new System.EventHandler(this.Blegger_Click);
            // 
            // reader
            // 
            this.reader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reader.Image = ((System.Drawing.Image)(resources.GetObject("reader.Image")));
            this.reader.Location = new System.Drawing.Point(410, 77);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(104, 73);
            this.reader.TabIndex = 4;
            this.toolTip1.SetToolTip(this.reader, "Blegger");
            this.reader.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(389, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "J";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(388, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "O";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(388, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "U";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(388, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "N";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // About
            // 
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.Location = new System.Drawing.Point(650, 449);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(69, 66);
            this.About.TabIndex = 9;
            this.toolTip1.SetToolTip(this.About, "About Us");
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2500;
            this.toolTip1.InitialDelay = 260;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 527);
            this.Controls.Add(this.About);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.Blegger);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox_earth);
            this.Controls.Add(this.form1_upcolor);
            this.Name = "Form1";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1_upcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox form1_upcolor;
        private System.Windows.Forms.PictureBox pictureBox_earth;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button Blegger;
        private System.Windows.Forms.Button reader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

