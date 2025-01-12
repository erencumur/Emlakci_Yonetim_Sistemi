using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;



namespace EmlakcıProjesiUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAktifTarih.Text = DateTime.Now.ToString("dd.MM.yyyy") + "\n" + DateTime.Now.ToString("HH:mm");
            timerTarih.Start();
        }

       
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            girisFormu.Show();

            // Form1'i gizle
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timerTarih_Tick(object sender, EventArgs e)
        {
            lblAktifTarih.Text = DateTime.Now.ToString("dd.MM.yyyy") + "\n" + DateTime.Now.ToString("HH:mm");
        }

        private void lblAktifTarih_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
