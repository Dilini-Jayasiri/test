using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS.Forms
{
    public partial class Donations : Form
    {
        public Donations()
        {
            InitializeComponent();
        }

        private void Donations_Load(object sender, EventArgs e)
        {

        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btnDonate.Enabled = true;
            }
            else
            {
                btnDonate.Enabled = false;

            }

            texNIC.Text = "";
            textname.Text = "";
            textbloodtype.Text = "";
            bloodUnit.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(bloodUnit.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                bloodUnit.Text = bloodUnit.Text.Remove(bloodUnit.Text.Length - 1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
                        lblmsg.Text = "";
                    }
                    else
                    {
                        lblmsg.Text = "Wrong NIC";
                    }
                }
                else
                {
                    lblmsg.Text = "";
                }
            }
            else
            {
                lblmsg.Text = "Wrong NIC";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

