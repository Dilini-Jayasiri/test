
namespace BDMS.Forms
{
    partial class Donations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donations));
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDonate = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textbloodtype = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bloodUnit = new System.Windows.Forms.TextBox();
            this.texNIC = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(353, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 51);
            this.label7.TabIndex = 0;
            this.label7.Text = "Blood Donation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(227, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 99);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(168, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Donor NIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(913, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Donated Date";
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
            this.btnDonate.Location = new System.Drawing.Point(1099, 572);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(191, 72);
            this.btnDonate.TabIndex = 7;
            this.btnDonate.Text = "Add to Stock";
            this.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(168, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(168, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Blood Type";
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textname.Location = new System.Drawing.Point(439, 248);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(226, 23);
            this.textname.TabIndex = 3;
            this.textname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbloodtype
            // 
            this.textbloodtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbloodtype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbloodtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textbloodtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textbloodtype.Location = new System.Drawing.Point(439, 345);
            this.textbloodtype.Name = "textbloodtype";
            this.textbloodtype.Size = new System.Drawing.Size(226, 23);
            this.textbloodtype.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.checkBox1.Location = new System.Drawing.Point(158, 718);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(432, 33);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Donor has no any recent Diseases";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(913, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Units (ml)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bloodUnit
            // 
            this.bloodUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bloodUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bloodUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bloodUnit.Location = new System.Drawing.Point(1215, 248);
            this.bloodUnit.Name = "bloodUnit";
            this.bloodUnit.Size = new System.Drawing.Size(189, 23);
            this.bloodUnit.TabIndex = 4;
            this.bloodUnit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // texNIC
            // 
            this.texNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.texNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.texNIC.Location = new System.Drawing.Point(439, 145);
            this.texNIC.Name = "texNIC";
            this.texNIC.Size = new System.Drawing.Size(226, 23);
            this.texNIC.TabIndex = 1;
            this.texNIC.TextChanged += new System.EventHandler(this.texNIC_TextChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblmsg.Location = new System.Drawing.Point(685, 147);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 32);
            this.lblmsg.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(439, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 2);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(439, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 2);
            this.panel3.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(439, 374);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 2);
            this.panel4.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(939, 572);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(1204, 277);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 2);
            this.panel5.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1193, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 38);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
            // 
            // Donations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1720, 1018);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.texNIC);
            this.Controls.Add(this.bloodUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textbloodtype);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donations";
            this.Load += new System.EventHandler(this.Donations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnDonate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textbloodtype;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bloodUnit;
        private System.Windows.Forms.TextBox texNIC;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}