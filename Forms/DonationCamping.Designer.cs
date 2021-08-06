
namespace BDMS.Forms
{
    partial class DonationCamping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationCamping));
            this.label1 = new System.Windows.Forms.Label();
            this.maskTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.llblFname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.labelmsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDonate = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bloodunit = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DropDownBlood = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(456, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donation Campaign Details";
            // 
            // maskTel
            // 
            this.maskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.maskTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskTel.Location = new System.Drawing.Point(375, 245);
            this.maskTel.Mask = "(999) 000-0000";
            this.maskTel.Name = "maskTel";
            this.maskTel.Size = new System.Drawing.Size(227, 23);
            this.maskTel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(120, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Contact No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(129, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "City";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(827, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = " NIC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtname.Location = new System.Drawing.Point(375, 137);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(227, 23);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressName);
            // 
            // llblFname
            // 
            this.llblFname.AutoSize = true;
            this.llblFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.llblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llblFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.llblFname.Location = new System.Drawing.Point(120, 136);
            this.llblFname.Name = "llblFname";
            this.llblFname.Size = new System.Drawing.Size(98, 31);
            this.llblFname.TabIndex = 22;
            this.llblFname.Text = "Name ";
            this.llblFname.Click += new System.EventHandler(this.llblFname_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(129, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // date
            // 
            this.date.CalendarForeColor = System.Drawing.Color.Black;
            this.date.CalendarMonthBackground = System.Drawing.Color.Black;
            this.date.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.date.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.date.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(375, 440);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(227, 38);
            this.date.TabIndex = 7;
            this.date.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(827, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 31);
            this.label6.TabIndex = 35;
            this.label6.Text = "Blood Group";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(1830, 34);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 16);
            this.lblmsg.TabIndex = 40;
            // 
            // labelmsg
            // 
            this.labelmsg.AutoSize = true;
            this.labelmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.labelmsg.Location = new System.Drawing.Point(1837, 20);
            this.labelmsg.Name = "labelmsg";
            this.labelmsg.Size = new System.Drawing.Size(0, 16);
            this.labelmsg.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(375, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 2);
            this.panel1.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(375, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 2);
            this.panel3.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(375, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 2);
            this.panel4.TabIndex = 44;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(1096, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 2);
            this.panel5.TabIndex = 44;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCity.Location = new System.Drawing.Point(375, 343);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(227, 23);
            this.txtCity.TabIndex = 5;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressCity);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(827, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Blood Units(ml)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDonate.ForeColor = System.Drawing.Color.Red;
            this.btnDonate.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.btnDonate.IconColor = System.Drawing.Color.Red;
            this.btnDonate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonate.Location = new System.Drawing.Point(1145, 549);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(198, 64);
            this.btnDonate.TabIndex = 8;
            this.btnDonate.Text = "Add to Stock";
            this.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1096, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 2);
            this.panel2.TabIndex = 46;
            // 
            // bloodunit
            // 
            this.bloodunit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bloodunit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bloodunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodunit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bloodunit.Location = new System.Drawing.Point(1096, 343);
            this.bloodunit.Name = "bloodunit";
            this.bloodunit.Size = new System.Drawing.Size(227, 23);
            this.bloodunit.TabIndex = 45;
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNIC.Location = new System.Drawing.Point(1096, 137);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(227, 23);
            this.txtNIC.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(970, 549);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 302);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // DropDownBlood
            // 
            this.DropDownBlood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DropDownBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DropDownBlood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DropDownBlood.FormattingEnabled = true;
            this.DropDownBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.DropDownBlood.Location = new System.Drawing.Point(1096, 231);
            this.DropDownBlood.Name = "DropDownBlood";
            this.DropDownBlood.Size = new System.Drawing.Size(227, 37);
            this.DropDownBlood.TabIndex = 50;
            this.DropDownBlood.SelectedIndexChanged += new System.EventHandler(this.bloodtype_SelectedIndexChanged);
            // 
            // DonationCamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1720, 1018);
            this.Controls.Add(this.DropDownBlood);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bloodunit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.labelmsg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.llblFname);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonationCamping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donation Camping";
            this.Load += new System.EventHandler(this.DonationCamping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label llblFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label labelmsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnDonate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox bloodunit;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox DropDownBlood;
    }
}