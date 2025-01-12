using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakcıProjesiUI
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btnEmlakIslemleri_Click(object sender, EventArgs e)
        {
            // MainForm'u aç
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // GirisFormu'nu kapat
            this.Hide();
        }

        private void GirisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSozlesmeIslemleri_Click(object sender, EventArgs e)
        {
            SozlesmeForm sozlesmeForm = new SozlesmeForm(); // Yeni sözleşme formunu oluştur
            sozlesmeForm.Show(); // Formu göster
            this.Hide(); // Mevcut formu gizle
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // Form1'i tekrar göster
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                form1.Show(); // Eğer Form1 açıksa tekrar göster
            }
            else
            {
                form1 = new Form1(); // Açıksa yeni bir instance oluşturma
                form1.Show();
            }

            // Giriş Formunu gizle
            this.Hide();
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            AnalizFormu analizFormu = new AnalizFormu();
            analizFormu.Show(); // Yeni formu aç
            this.Hide(); // Giriş formunu gizle
        }

        private void GirisFormu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailGonder mailFormu = new MailGonder();
            mailFormu.Show();

            // Form1'i gizle
            this.Hide();
        }
    }
}
