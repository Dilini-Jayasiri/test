using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
           
        }

        private void txtuser_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

            int n = password.Text.Length;
            if (n > 0 && n < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label2.Text = "Weak";
                label2.ForeColor = Color.Red;



            }
            else if (n >= 4 && n < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label2.Text = "Medium";
                label2.ForeColor = Color.Yellow;
            }
            else if (n >= 8)
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

        private void iconButton2_Click(object sender, EventArgs e)
        {

            clear();



        }

        void clear()
        {
            txtUser.Text = "";
            staffID.Text="";
            password.Text="";
            confPass.Text="";
            nic.Text = "";
            textBox1.Text = "";
            msgbox.Text = "";
            label2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
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

        private void msgbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || staffID.Text == "" || password.Text == "" || confPass.Text == "" || password.Text!=confPass.Text)
            {
                incorrectLogin lg = new incorrectLogin();
                lg.Show();
            }
            else
            {
                reigisterSuccess rg = new reigisterSuccess();
                rg.Show();

                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        private void keyPressUsname(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void regBtn_MouseEnter(object sender, EventArgs e)
        {
            regBtn.BackColor = Color.Red;
            regBtn.ForeColor = Color.White;
        }

        private void regBtn_MouseLeave(object sender, EventArgs e)
        {
            regBtn.BackColor = Color.White;
            regBtn.ForeColor = Color.Black;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUser_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {
            
    }

        private void nic_TextChanged(object sender, EventArgs e)
        {
            String txtnic = nic.Text;

            if (txtnic.Length == 10 ^ txtnic.Length == 12)
            {
                if (txtnic.Length == 10)
                {
                    String a = txtnic.Substring(9);
                    if (a == "v" || a == "V")
                    {
                        textBox1.Text = "";
                    }
                    else
                    {
                        textBox1.Text = "Wrong NIC";
                    }
                }
                else
                {
                    textBox1.Text = "";
                }
            }
            else
            {
                textBox1.Text = "Wrong NIC";
            }
        }
    }
    
}
