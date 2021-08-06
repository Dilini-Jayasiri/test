using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS
{
    public partial class changePW : Form
    {
        public changePW()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void picuser_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void changePW_Load(object sender, EventArgs e)
        {

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if ( staffID.Text == "" || password.Text == "" || confPass.Text == "" || password.Text != confPass.Text || nic.Text == "")
            {
                incorrectLogin inl = new incorrectLogin();
                inl.Show();
            }
            else
            {
                reigisterSuccess rg = new reigisterSuccess();
                rg.Show();

                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            if (password.Text != confPass.Text)
            {
                password.Text = "";
                confPass.Text = "";
            }
        }
      

        private void password_TextChanged(object sender, EventArgs e)
        {
            int n = password.Text.Length;
            if(n>0 && n < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label2.Text = "Weak";
                label2.ForeColor = Color.Red;

            }
            else if(n>=4 && n < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label2.Text = "Medium";
                label2.ForeColor = Color.Yellow;
            }else if (n >= 8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label2.Text = "Strong";
                label2.ForeColor = Color.Green;
            }
            else
            {
                progressBar1.Value = 0;
            }

        }

        private void confPass_TextChanged(object sender, EventArgs e)
        {
            if (confPass.Text == " ")
            {
                msgbox.Text.Equals("......");
            }
            else
            {
                if (password.Text == confPass.Text)
                {
                    msgbox.Text = "Matched";
                    msgbox.ForeColor = Color.White;
                }
                else
                {
                    msgbox.Text = "Unmached";
                    msgbox.ForeColor = Color.Red;
                }

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear() {
            {
               
                staffID.Text = "";
                password.Text = "";
                confPass.Text = "";
                nic.Text = "";
                msgbox.Text = "";
                label2.Text = "";
            }
        }

        private void nic_TextChanged(object sender, EventArgs e)
        {
            if (staffID.Text == "BH/1234/56" && nic.Text == ("123456789v") || nic.Text== ("123456789V"))
            {
                password.Enabled = true;
                confPass.Enabled = true;
                regBtn.Enabled = true;
            }
            else
            {
                password.Enabled =false;
                confPass.Enabled =false;
                regBtn.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void keyPressUser(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void msgbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

