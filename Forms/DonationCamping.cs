using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS.Forms
{
    public partial class DonationCamping : Form
    {
        public DonationCamping()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(bloodunit.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                bloodunit.Text = bloodunit.Text.Remove(bloodunit.Text.Length - 1);
            }
        }

        private void AddDonor_Click(object sender, EventArgs e)
        {
            DropDownBlood.SelectedItem = null;
            bloodunit.Text = "";
           
           
        }
        
        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void keyPressName(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void keyPressCity(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void DonationCamping_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void texNIC_TextChanged(object sender, EventArgs e)
        {
            String nic = txtNIC.Text;

            if (nic.Length == 10 ^ nic.Length == 12)
            {
                if (nic.Length == 10)
                {
                    String a = nic.Substring(9);
                    if (a == "v" || a == "V")
                    {
                        labelmsg.Text = "";
                    }
                    else
                    {
                        labelmsg.Text = "Wrong NIC";
                    }
                }
                else
                {
                    labelmsg.Text = "";
                }
            }
            else
            {
                labelmsg.Text = "Wrong NIC";
            }
        }

        private void llblFname_Click(object sender, EventArgs e)
        {

        }

        private void btnDonate_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bloodtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

