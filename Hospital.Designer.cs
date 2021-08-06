
namespace BDMS.Forms
{
    partial class Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtReqUnits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bloodtype = new System.Windows.Forms.ComboBox();
            this.btnRequest = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconLogout = new FontAwesome.Sharp.IconButton();
            this.btnclose = new FontAwesome.Sharp.IconButton();
            this.btnminimiz = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(653, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Request";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(605, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 2);
            this.panel4.TabIndex = 56;
            // 
            // txtReqUnits
            // 
            this.txtReqUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtReqUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReqUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReqUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReqUnits.Location = new System.Drawing.Point(603, 373);
            this.txtReqUnits.Name = "txtReqUnits";
            this.txtReqUnits.Size = new System.Drawing.Size(150, 23);
            this.txtReqUnits.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(222, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 31);
            this.label2.TabIndex = 49;
            this.label2.Text = "Requested Units (ml)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(219, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Blood Type";
            // 
            // bloodtype
            // 
            this.bloodtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bloodtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bloodtype.FormattingEnabled = true;
            this.bloodtype.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodtype.Location = new System.Drawing.Point(605, 240);
            this.bloodtype.Name = "bloodtype";
            this.bloodtype.Size = new System.Drawing.Size(148, 37);
            this.bloodtype.TabIndex = 57;
            // 
            // btnRequest
            // 
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRequest.ForeColor = System.Drawing.Color.Red;
            this.btnRequest.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.btnRequest.IconColor = System.Drawing.Color.Red;
            this.btnRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.Location = new System.Drawing.Point(1207, 526);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(213, 72);
            this.btnRequest.TabIndex = 58;
            this.btnRequest.Text = "Requested";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1021, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconLogout
            // 
            this.iconLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconLogout.FlatAppearance.BorderSize = 0;
            this.iconLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogout.IconSize = 32;
            this.iconLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogout.Location = new System.Drawing.Point(50, 864);
            this.iconLogout.Name = "iconLogout";
            this.iconLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconLogout.Size = new System.Drawing.Size(200, 50);
            this.iconLogout.TabIndex = 60;
            this.iconLogout.Text = "Log out";
            this.iconLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLogout.UseVisualStyleBackColor = true;
            this.iconLogout.Click += new System.EventHandler(this.iconLogout_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnclose.IconColor = System.Drawing.Color.DarkRed;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.IconSize = 15;
            this.btnclose.Location = new System.Drawing.Point(1658, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(20, 20);
            this.btnclose.TabIndex = 62;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnminimiz
            // 
            this.btnminimiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimiz.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnminimiz.IconColor = System.Drawing.Color.DarkRed;
            this.btnminimiz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnminimiz.IconSize = 15;
            this.btnminimiz.Location = new System.Drawing.Point(1632, 12);
            this.btnminimiz.Name = "btnminimiz";
            this.btnminimiz.Size = new System.Drawing.Size(20, 20);
            this.btnminimiz.TabIndex = 61;
            this.btnminimiz.UseVisualStyleBackColor = true;
            this.btnminimiz.Click += new System.EventHandler(this.btnminimiz_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1702, 971);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnminimiz);
            this.Controls.Add(this.iconLogout);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bloodtype);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtReqUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReqUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bloodtype;
        private FontAwesome.Sharp.IconButton btnRequest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconLogout;
        private FontAwesome.Sharp.IconButton btnclose;
        private FontAwesome.Sharp.IconButton btnminimiz;
    }
}