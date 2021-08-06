
namespace BDMS.Forms
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApprove = new FontAwesome.Sharp.IconButton();
            this.btnContact = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtReqUnits = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAviUnits = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1720, 95);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(534, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(392, 51);
            this.label7.TabIndex = 0;
            this.label7.Text = "Blood Requests";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(991, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Blood Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(994, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "Available Units (ml)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(773, 686);
            this.dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(994, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Requested Units (ml)";
            // 
            // btnApprove
            // 
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApprove.ForeColor = System.Drawing.Color.Red;
            this.btnApprove.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btnApprove.IconColor = System.Drawing.Color.Red;
            this.btnApprove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApprove.IconSize = 30;
            this.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.Location = new System.Drawing.Point(1206, 502);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(229, 46);
            this.btnApprove.TabIndex = 30;
            this.btnApprove.Text = "Approve";
            this.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContact.ForeColor = System.Drawing.Color.Red;
            this.btnContact.IconChar = FontAwesome.Sharp.IconChar.PhoneSquare;
            this.btnContact.IconColor = System.Drawing.Color.Red;
            this.btnContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContact.IconSize = 30;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(1189, 502);
            this.btnContact.Name = "btnContact";
            this.btnContact.Rotation = 90D;
            this.btnContact.Size = new System.Drawing.Size(246, 55);
            this.btnContact.TabIndex = 34;
            this.btnContact.Text = "Contact a Donor";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Visible = false;
            this.btnContact.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox1.Location = new System.Drawing.Point(1289, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 31;
            // 
            // txtReqUnits
            // 
            this.txtReqUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtReqUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReqUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReqUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReqUnits.Location = new System.Drawing.Point(1287, 278);
            this.txtReqUnits.Name = "txtReqUnits";
            this.txtReqUnits.Size = new System.Drawing.Size(150, 23);
            this.txtReqUnits.TabIndex = 33;
            this.txtReqUnits.TextChanged += new System.EventHandler(this.txtReqUnits_TextChanged);
            // 
            // txtAvailable
            // 
            this.txtAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtAvailable.Location = new System.Drawing.Point(1324, 212);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(101, 23);
            this.txtAvailable.TabIndex = 32;
            this.txtAvailable.TextChanged += new System.EventHandler(this.txtAvailable_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(1287, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 2);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(1287, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(1289, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 2);
            this.panel4.TabIndex = 46;
            // 
            // txtAviUnits
            // 
            this.txtAviUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAviUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAviUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAviUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAviUnits.Location = new System.Drawing.Point(1287, 204);
            this.txtAviUnits.Name = "txtAviUnits";
            this.txtAviUnits.Size = new System.Drawing.Size(148, 23);
            this.txtAviUnits.TabIndex = 32;
            this.txtAviUnits.TextChanged += new System.EventHandler(this.txtAvailable_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1062, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1720, 1018);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.txtReqUnits);
            this.Controls.Add(this.txtAviUnits);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending Requests";
            this.Load += new System.EventHandler(this.Requests_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnApprove;
        private FontAwesome.Sharp.IconButton btnContact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtReqUnits;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAviUnits;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}