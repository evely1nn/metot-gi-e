namespace metot_Gişe
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
            this.lblGetir1 = new System.Windows.Forms.Label();
            this.lblGetir2 = new System.Windows.Forms.Label();
            this.lblGetir3 = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.btnGetir1 = new System.Windows.Forms.Button();
            this.btnGetir2 = new System.Windows.Forms.Button();
            this.btnGetir3 = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGetir1
            // 
            this.lblGetir1.AutoSize = true;
            this.lblGetir1.Location = new System.Drawing.Point(32, 80);
            this.lblGetir1.Name = "lblGetir1";
            this.lblGetir1.Size = new System.Drawing.Size(17, 17);
            this.lblGetir1.TabIndex = 0;
            this.lblGetir1.Text = "...";
            // 
            // lblGetir2
            // 
            this.lblGetir2.AutoSize = true;
            this.lblGetir2.Location = new System.Drawing.Point(122, 80);
            this.lblGetir2.Name = "lblGetir2";
            this.lblGetir2.Size = new System.Drawing.Size(17, 17);
            this.lblGetir2.TabIndex = 1;
            this.lblGetir2.Text = "...";
            // 
            // lblGetir3
            // 
            this.lblGetir3.AutoSize = true;
            this.lblGetir3.Location = new System.Drawing.Point(214, 80);
            this.lblGetir3.Name = "lblGetir3";
            this.lblGetir3.Size = new System.Drawing.Size(17, 17);
            this.lblGetir3.TabIndex = 2;
            this.lblGetir3.Text = "...";
            // 
            // txtİsim
            // 
            this.txtİsim.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtİsim.Location = new System.Drawing.Point(29, 36);
            this.txtİsim.Multiline = true;
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(201, 31);
            this.txtİsim.TabIndex = 3;
            // 
            // btnGetir1
            // 
            this.btnGetir1.Location = new System.Drawing.Point(13, 19);
            this.btnGetir1.Name = "btnGetir1";
            this.btnGetir1.Size = new System.Drawing.Size(85, 43);
            this.btnGetir1.TabIndex = 4;
            this.btnGetir1.Text = "GİŞE 1";
            this.btnGetir1.UseVisualStyleBackColor = true;
            this.btnGetir1.Click += new System.EventHandler(this.btnGetir1_Click);
            // 
            // btnGetir2
            // 
            this.btnGetir2.Location = new System.Drawing.Point(104, 19);
            this.btnGetir2.Name = "btnGetir2";
            this.btnGetir2.Size = new System.Drawing.Size(85, 43);
            this.btnGetir2.TabIndex = 5;
            this.btnGetir2.Text = "GİŞE 2";
            this.btnGetir2.UseVisualStyleBackColor = true;
            this.btnGetir2.Click += new System.EventHandler(this.btnGetir2_Click);
            // 
            // btnGetir3
            // 
            this.btnGetir3.Location = new System.Drawing.Point(195, 19);
            this.btnGetir3.Name = "btnGetir3";
            this.btnGetir3.Size = new System.Drawing.Size(85, 43);
            this.btnGetir3.TabIndex = 6;
            this.btnGetir3.Text = "GİŞE 3";
            this.btnGetir3.UseVisualStyleBackColor = true;
            this.btnGetir3.Click += new System.EventHandler(this.btnGetir3_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(236, 36);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 31);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.lblGetir3);
            this.groupBox1.Controls.Add(this.lblGetir2);
            this.groupBox1.Controls.Add(this.lblGetir1);
            this.groupBox1.Controls.Add(this.btnGetir1);
            this.groupBox1.Controls.Add(this.btnGetir2);
            this.groupBox1.Controls.Add(this.btnGetir3);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(372, 282);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtİsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetir1;
        private System.Windows.Forms.Label lblGetir2;
        private System.Windows.Forms.Label lblGetir3;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Button btnGetir1;
        private System.Windows.Forms.Button btnGetir2;
        private System.Windows.Forms.Button btnGetir3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

