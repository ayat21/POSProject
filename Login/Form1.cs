using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
          customer frm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();             
         }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "Ayat" && metroTextBox2.Text == "123")
            {
                frm = new customer();
                frm.Show();
            }
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }
    }
}
