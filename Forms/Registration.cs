using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void llblFname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Boolean allDone()
        {

            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked = true) && (txtFname.Text != "") && (textLname.Text != "") && (texNIC.Text != " ")
                 && (radiomale.Checked || radiofeamle.Checked) && (maskedTextBox2.Text != "(___) ___-____") && (textBox1.Text != " ") && DropDownBlood.SelectedItem != null)
            {
                AddDonor.Enabled = true;
            }
            else
            {
                AddDonor.Enabled = false;

            }
        }

        private void AddDonor_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            txtFname.Text = "";
            textLname.Text = "";
            texNIC.Text = " ";
            radiomale.Checked = false;
            radiofeamle.Checked = false;
            maskedTextBox2.Text = "(___) ___-____";
            textBox1.Text = " ";
            DropDownBlood.SelectedItem = null;
            lblmsge.Text = "";
            AddressLine1.Text = "";
            AddressLine2.Text = "";
            Addressline3.Text = "";
            City.Text = "";
             


        }

        private void AddDonor_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void keyPressFullName(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void keyPressLastName(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan tSpan = (to - from);
            double days = tSpan.TotalDays;
            int intAge = Convert.ToInt32(days / 365);

            if (intAge < 18 || intAge > 60)
            {
                ErrorMessageAge era = new ErrorMessageAge();
                era.Show();
                textBox1.Text = "";

            }
            else
            {
                textBox1.Text = intAge.ToString("0");

            }












        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void texNIC_TextChanged(object sender, EventArgs e)
        {
            String nic = texNIC.Text;

            if (nic.Length == 10 ^ nic.Length == 12)
            {
                if (nic.Length == 10)
                {
                    String a = nic.Substring(9);
                    if (a == "v" || a == "V")
                    {
                        lblmsge.Text = "";
                    }
                    else
                    {
                        lblmsge.Text = "Wrong NIC";
                    }
                }
                else
                {
                    lblmsge.Text = "";
                }
            }
            else
            {
                lblmsge.Text = "Wrong NIC";
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            {
                DateTime from = dateTimePicker1.Value;
                DateTime to = DateTime.Now;
                TimeSpan tSpan = (to - from);
                double days = tSpan.TotalDays;
                int intAge = Convert.ToInt32(days / 365);

                if (intAge < 18 || intAge > 60)
                {
                    ErrorMessageAge era = new ErrorMessageAge();
                    era.Show();
                    textBox1.Text = "";

                }
                else
                {
                    textBox1.Text = intAge.ToString("0");

                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}