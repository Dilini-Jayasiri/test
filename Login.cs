using BDMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            picuser.Visible = false;
            panel1.BackColor = Color.Red;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (txtuser.Text=="admin" && password.Text==("12345678"))
             {
                 AdminDash obj1 = new AdminDash();
                 obj1.Show();
                 this.Hide();
             }
             else if(txtuser.Text == "demo" && password.Text == ("123")){
                Hospital hs = new Hospital();
                hs.Show();
                this.Hide();

            }
             else 
             {
                incorrectLogin inl = new incorrectLogin();
                inl.Show();
                clear();

            }
            void clear()
            {

                txtuser.Text = "";
                password.Text = "";
                
            }


          

        }

        private void txtuser_MouseClick(object sender, MouseEventArgs e)
        {
            //txtuser.Clear();
            picuser.Visible = false;
            picpass.Visible = true;
            panel1.BackColor = Color.Red;


        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {

            
            //password.Clear();
            picuser.Visible = true;
            picpass.Visible = false;
            panel1.BackColor = Color.White;
            //txtuser.ForeColor = Color.White;
            panel2.BackColor = Color.Red;
            password.ForeColor = Color.Red;
            

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.Red;
            panel2.BackColor = Color.White;
            password.ForeColor = Color.White;
            picpass.Visible = true;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.Transparent;
        }

        private void btnreg_MouseClick(object sender, MouseEventArgs e)
        {
            btnreg.BackColor = Color.Red;
            AdminDash obj1 = new AdminDash();
            obj1.Show();
            this.Hide();
        }

        private void password_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btnlogin_MouseClick(object sender, EventArgs e)
        {
            
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            UserRegister obj2 = new UserRegister();
            obj2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserRegister rg = new UserRegister();
            rg.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            changePW pw = new changePW();
            pw.Show();
            this.Hide();
        }

        private void keyPressUn(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtuser_TabIndexChanged(object sender, EventArgs e)
        {
            //txtuser.Clear();
            picuser.Visible = false;
            picpass.Visible = true;
            panel1.BackColor = Color.Red;
        }

        private void password_TabIndexChanged(object sender, EventArgs e)
        {
            picuser.Visible = true;
            picpass.Visible = false;
            panel1.BackColor = Color.White;
            //txtuser.ForeColor = Color.White;
            panel2.BackColor = Color.Red;
            password.ForeColor = Color.Red;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(34, 33, 74);
        }
    }
}
