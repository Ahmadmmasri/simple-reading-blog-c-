namespace project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.psychology = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.artificial_intelligence = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Arts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // psychology
            // 
            this.psychology.BackColor = System.Drawing.Color.Gainsboro;
            this.psychology.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.psychology.Image = ((System.Drawing.Image)(resources.GetObject("psychology.Image")));
            this.psychology.Location = new System.Drawing.Point(12, 111);
            this.psychology.Name = "psychology";
            this.psychology.Size = new System.Drawing.Size(158, 108);
            this.psychology.TabIndex = 1;
            this.psychology.UseVisualStyleBackColor = false;
            this.psychology.Click += new System.EventHandler(this.psychology_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Psychology";
            // 
            // artificial_intelligence
            // 
            this.artificial_intelligence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.artificial_intelligence.Image = ((System.Drawing.Image)(resources.GetObject("artificial_intelligence.Image")));
            this.artificial_intelligence.Location = new System.Drawing.Point(12, 293);
            this.artificial_intelligence.Name = "artificial_intelligence";
            this.artificial_intelligence.Size = new System.Drawing.Size(158, 108);
            this.artificial_intelligence.TabIndex = 3;
            this.artificial_intelligence.UseVisualStyleBackColor = true;
            this.artificial_intelligence.Click += new System.EventHandler(this.artificial_intelligence_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(176, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Artificial Intelligence";
            // 
            // Arts
            // 
            this.Arts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Arts.Image = ((System.Drawing.Image)(resources.GetObject("Arts.Image")));
            this.Arts.Location = new System.Drawing.Point(502, 249);
            this.Arts.Name = "Arts";
            this.Arts.Size = new System.Drawing.Size(134, 94);
            this.Arts.TabIndex = 5;
            this.Arts.UseVisualStyleBackColor = true;
            this.Arts.Click += new System.EventHandler(this.Arts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(642, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arts";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Control;
            this.Back.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(48, 492);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(122, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back to main page";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 527);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Arts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artificial_intelligence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.psychology);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reader page";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button psychology;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button artificial_intelligence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Arts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back;
    }
}