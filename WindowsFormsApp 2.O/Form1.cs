using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_2.O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string fname = "pratik";           
            string mname = " ";
            string lname = "pratik";

            string Fname = txt_fname.Text;
            string Mname = txt_mname.Text;
            string Lname = txt_lname.Text; 

            if (Fname == fname)
            {
                MessageBox.Show("Your Sign in is complete", "Sucessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();   
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string img= openFileDialog.FileName;
                pbImg.ImageLocation = img;
            }
        }
    }
    
}
