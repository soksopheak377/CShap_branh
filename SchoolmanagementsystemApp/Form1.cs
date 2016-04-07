using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SchoolmanagementsystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnlogout.Hide();
            tbl_main.Hide();
            tableLayoutPanel2.Hide();

            btnhome.Enabled = false;
            btnstudent.Enabled = false;
            btnemployee.Enabled = false;
            btncard.Enabled = false;
            btnreport.Enabled = false;
            btnscore.Enabled = false;
            btnpayment.Enabled = false;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            if (txtpassword.Text == "9090" && txtusername.Text == "admin")
            {
                //pnellogin.Hide();
                btnlogout.Show();
                tbl_main.Show();
                tableLayoutPanel2.Show();

                btnhome.Enabled = true;
                btnstudent.Enabled = true;
                btnemployee.Enabled = true;
                btncard.Enabled = true;
                btnreport.Enabled = true;
                btnscore.Enabled = true;
                btnpayment.Enabled = true;

                txtusername.Clear();
                txtpassword.Clear();
            }
            else
            {
                MessageBox.Show("Please enter username and password !", "Error Invalid Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Clear();
                txtpassword.Clear();
            }
        }
    }
}
