using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS.Forms
{
    public partial class Requests : Form
    {
        
        public Requests()
        {
            InitializeComponent();
             

                }
       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Requests_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            //OpenChildForm(new Donors());
            Donors ds = new Donors();
            ds.Show();
            //this.Hide();
        }

        private void txtReqUnits_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReqUnits.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtReqUnits.Text = txtReqUnits.Text.Remove(txtReqUnits.Text.Length - 1);
            }
            int availble = int.Parse(txtAviUnits.Text);
          int requested = int.Parse(txtReqUnits.Text);

            if (availble > requested)
            {
                btnContact.Visible = false;
            }
            else
            {
                btnContact.Visible = true;

            }

        }

        private void txtAvailable_TextChanged(object sender, EventArgs e)
        {
           if (System.Text.RegularExpressions.Regex.IsMatch(txtAviUnits.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtAviUnits.Text = txtAvailable.Text.Remove(txtAviUnits.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
