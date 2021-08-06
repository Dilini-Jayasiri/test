using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BDMS.Forms;
using FontAwesome.Sharp;

namespace BDMS
{
    public partial class AdminDash : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentchildform;
        
        

        public AdminDash()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,50);
            panelMenue.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
          


        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 118, 176);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 155);

        }
       private void ActiveButton(Object sendBtn, Color color)
        {
            if(sendBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)sendBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //leftborderbutton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icontitlebar
                iconcurrnt.IconChar =  currentBtn.IconChar;
                iconcurrnt.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;                   ;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childform)
        {
            if(currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            desktoppanel.Controls.Add(childform);
            desktoppanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbltitlebar.Text = childform.Text;
        }
        
        private void AdminDash_Load(object sender, EventArgs e)
        {

        }

        private void iconDash_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Dashboard());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new Donors());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Requests());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new DonationCamping());
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentchildform.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconcurrnt.IconChar = IconChar.Home;
            iconcurrnt.IconColor = Color.Red;
            lbltitlebar.Text = "Home";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnminimiz_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void desktoppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Registration());
          
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Donations());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void treeView7_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView14_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void treeView15_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView16_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView8_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView4_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView5_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView6_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void treeView9_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView10_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView11_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView12_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView13_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView18_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
