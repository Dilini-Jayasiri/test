
namespace BDMS.Forms
{
    partial class Registration
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
            System.Windows.Forms.Label llblFname;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label lblmsg;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.radiomale = new System.Windows.Forms.RadioButton();
            this.radiofeamle = new System.Windows.Forms.RadioButton();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.AddressLine1 = new System.Windows.Forms.TextBox();
            this.AddressLine2 = new System.Windows.Forms.TextBox();
            this.Addressline3 = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.texNIC = new System.Windows.Forms.TextBox();
            this.AddDonor = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblmsge = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DropDownBlood = new System.Windows.Forms.ComboBox();
            llblFname = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblmsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // llblFname
            // 
            llblFname.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            llblFname.AutoSize = true;
            llblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            llblFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            llblFname.Location = new System.Drawing.Point(251, 120);
            llblFname.Name = "llblFname";
            llblFname.Size = new System.Drawing.Size(165, 31);
            llblFname.TabIndex = 0;
            llblFname.Text = "First Name ";
            llblFname.Click += new System.EventHandler(this.llblFname_Click);
            // 
            // label1
            // 
            label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label1.Location = new System.Drawing.Point(819, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 31);
            label1.TabIndex = 2;
            label1.Text = "Last Name ";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label2.Location = new System.Drawing.Point(251, 245);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(152, 31);
            label2.TabIndex = 4;
            label2.Text = "Donor NIC";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label3.Location = new System.Drawing.Point(819, 260);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 31);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label4.Location = new System.Drawing.Point(815, 614);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(176, 31);
            label4.TabIndex = 6;
            label4.Text = "Blood Group";
            // 
            // label5
            // 
            label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label5.Location = new System.Drawing.Point(822, 383);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 31);
            label5.TabIndex = 7;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label6.Location = new System.Drawing.Point(258, 507);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 31);
            label6.TabIndex = 16;
            label6.Text = "DOB";
            // 
            // label8
            // 
            label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label8.Location = new System.Drawing.Point(251, 383);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(161, 31);
            label8.TabIndex = 21;
            label8.Text = "Contact No";
            // 
            // label9
            // 
            label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            label9.Location = new System.Drawing.Point(258, 624);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(65, 31);
            label9.TabIndex = 23;
            label9.Text = "Age";
            // 
            // lblmsg
            // 
            lblmsg.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            lblmsg.AutoSize = true;
            lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblmsg.ForeColor = System.Drawing.Color.Red;
            lblmsg.Location = new System.Drawing.Point(458, 262);
            lblmsg.Name = "lblmsg";
            lblmsg.Size = new System.Drawing.Size(0, 22);
            lblmsg.TabIndex = 25;
            // 
            // radiomale
            // 
            this.radiomale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radiomale.AutoSize = true;
            this.radiomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiomale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.radiomale.Location = new System.Drawing.Point(822, 303);
            this.radiomale.Name = "radiomale";
            this.radiomale.Size = new System.Drawing.Size(80, 29);
            this.radiomale.TabIndex = 4;
            this.radiomale.Text = "Male";
            this.radiomale.UseVisualStyleBackColor = true;
            // 
            // radiofeamle
            // 
            this.radiofeamle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radiofeamle.AutoSize = true;
            this.radiofeamle.Checked = true;
            this.radiofeamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiofeamle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.radiofeamle.Location = new System.Drawing.Point(938, 303);
            this.radiofeamle.Name = "radiofeamle";
            this.radiofeamle.Size = new System.Drawing.Size(104, 29);
            this.radiofeamle.TabIndex = 5;
            this.radiofeamle.TabStop = true;
            this.radiofeamle.Text = "Female";
            this.radiofeamle.UseVisualStyleBackColor = true;
            this.radiofeamle.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtFname
            // 
            this.txtFname.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFname.Location = new System.Drawing.Point(251, 160);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(226, 23);
            this.txtFname.TabIndex = 1;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressFullName);
            // 
            // textLname
            // 
            this.textLname.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLname.Location = new System.Drawing.Point(819, 160);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(234, 23);
            this.textLname.TabIndex = 2;
            this.textLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressLastName);
            // 
            // AddressLine1
            // 
            this.AddressLine1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddressLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddressLine1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddressLine1.Location = new System.Drawing.Point(822, 419);
            this.AddressLine1.Name = "AddressLine1";
            this.AddressLine1.PlaceholderText = "Address Line 1";
            this.AddressLine1.Size = new System.Drawing.Size(231, 23);
            this.AddressLine1.TabIndex = 7;
            // 
            // AddressLine2
            // 
            this.AddressLine2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddressLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddressLine2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddressLine2.Location = new System.Drawing.Point(822, 456);
            this.AddressLine2.Name = "AddressLine2";
            this.AddressLine2.PlaceholderText = "Address Line 2";
            this.AddressLine2.Size = new System.Drawing.Size(231, 23);
            this.AddressLine2.TabIndex = 8;
            // 
            // Addressline3
            // 
            this.Addressline3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Addressline3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Addressline3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Addressline3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addressline3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Addressline3.Location = new System.Drawing.Point(822, 493);
            this.Addressline3.Name = "Addressline3";
            this.Addressline3.PlaceholderText = "Street";
            this.Addressline3.Size = new System.Drawing.Size(231, 23);
            this.Addressline3.TabIndex = 9;
            // 
            // City
            // 
            this.City.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.City.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.City.Location = new System.Drawing.Point(822, 530);
            this.City.Name = "City";
            this.City.PlaceholderText = "City";
            this.City.Size = new System.Drawing.Size(231, 23);
            this.City.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskedTextBox2.Location = new System.Drawing.Point(258, 417);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(207, 23);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(258, 658);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texNIC
            // 
            this.texNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.texNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.texNIC.Location = new System.Drawing.Point(251, 286);
            this.texNIC.Name = "texNIC";
            this.texNIC.Size = new System.Drawing.Size(207, 23);
            this.texNIC.TabIndex = 3;
            this.texNIC.TextChanged += new System.EventHandler(this.texNIC_TextChanged);
            // 
            // AddDonor
            // 
            this.AddDonor.AutoSize = true;
            this.AddDonor.BackColor = System.Drawing.Color.Transparent;
            this.AddDonor.Enabled = false;
            this.AddDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddDonor.ForeColor = System.Drawing.Color.Red;
            this.AddDonor.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.AddDonor.IconColor = System.Drawing.Color.Red;
            this.AddDonor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddDonor.IconSize = 35;
            this.AddDonor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDonor.Location = new System.Drawing.Point(1157, 663);
            this.AddDonor.Name = "AddDonor";
            this.AddDonor.Size = new System.Drawing.Size(223, 54);
            this.AddDonor.TabIndex = 15;
            this.AddDonor.Text = "Add Donor";
            this.AddDonor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddDonor.UseVisualStyleBackColor = false;
            this.AddDonor.EnabledChanged += new System.EventHandler(this.AddDonor_EnabledChanged);
            this.AddDonor.Click += new System.EventHandler(this.AddDonor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1720, 87);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(531, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(497, 51);
            this.label7.TabIndex = 0;
            this.label7.Text = "Donor Registration";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.checkBox1.Location = new System.Drawing.Point(251, 882);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(478, 33);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Donor has fulfilled all the requirments ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblmsge
            // 
            this.lblmsge.AutoSize = true;
            this.lblmsge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmsge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblmsge.Location = new System.Drawing.Point(531, 260);
            this.lblmsge.Name = "lblmsge";
            this.lblmsge.Size = new System.Drawing.Size(0, 16);
            this.lblmsge.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(251, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 2);
            this.panel2.TabIndex = 45;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(251, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 2);
            this.panel3.TabIndex = 46;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(258, 438);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 2);
            this.panel4.TabIndex = 47;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(258, 682);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 2);
            this.panel5.TabIndex = 48;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel6.Location = new System.Drawing.Point(815, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 2);
            this.panel6.TabIndex = 49;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(822, 485);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 2);
            this.panel7.TabIndex = 50;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel8.Location = new System.Drawing.Point(827, 559);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(226, 2);
            this.panel8.TabIndex = 45;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(822, 522);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(226, 2);
            this.panel9.TabIndex = 45;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(819, 448);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(226, 2);
            this.panel10.TabIndex = 45;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 559);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 38);
            this.dateTimePicker1.TabIndex = 51;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1048, 663);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
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
            this.DropDownBlood.Location = new System.Drawing.Point(815, 663);
            this.DropDownBlood.Name = "DropDownBlood";
            this.DropDownBlood.Size = new System.Drawing.Size(136, 37);
            this.DropDownBlood.TabIndex = 53;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1720, 1018);
            this.Controls.Add(this.DropDownBlood);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblmsge);
            this.Controls.Add(this.texNIC);
            this.Controls.Add(lblmsg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label9);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddDonor);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(label6);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Addressline3);
            this.Controls.Add(this.AddressLine2);
            this.Controls.Add(this.AddressLine1);
            this.Controls.Add(this.radiofeamle);
            this.Controls.Add(this.radiomale);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textLname);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(llblFname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llblFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radiomale;
        private System.Windows.Forms.RadioButton radiofeamle;
        private System.Windows.Forms.TextBox AddressLine1;
        private System.Windows.Forms.TextBox AddressLine2;
        private System.Windows.Forms.TextBox Addressline3;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton AddDonor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox texNIC;
        private System.Windows.Forms.Label lblmsge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox DropDownBlood;
    }
}