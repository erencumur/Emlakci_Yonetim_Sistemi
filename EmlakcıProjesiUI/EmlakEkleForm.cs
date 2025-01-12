using BLL;
using DAL;
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
    public partial class EmlakEkleForm : Form
    {
        private EmlakService emlakService = new EmlakService();
        public EmlakEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            bool alanEksik = false;

            // TextBox'ların arka planını varsayılan rengine döndür
            txtMulkTipi.BackColor = Color.White;
            txtAdres.BackColor = Color.White;
            txtFiyat.BackColor = Color.White;
            txtOdaSayisi.BackColor = Color.White;
            txtMetrekare.BackColor = Color.White;
            txtToplamKatSayisi.BackColor = Color.White;
            txtBulunduguKat.BackColor = Color.White;

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtMulkTipi.Text)) { txtMulkTipi.BackColor = Color.LightCoral; alanEksik = true; }
            if (string.IsNullOrWhiteSpace(txtAdres.Text)) { txtAdres.BackColor = Color.LightCoral; alanEksik = true; }
            if (string.IsNullOrWhiteSpace(txtFiyat.Text)) { txtFiyat.BackColor = Color.LightCoral; alanEksik = true; }
            if (string.IsNullOrWhiteSpace(txtOdaSayisi.Text)) { txtOdaSayisi.BackColor = Color.LightCoral; alanEksik = true; }
            if (string.IsNullOrWhiteSpace(txtMetrekare.Text)) { txtMetrekare.BackColor = Color.LightCoral; alanEksik = true; }
            if (string.IsNullOrWhiteSpace(txtToplamKatSayisi.Text)) { txtToplamKatSayisi.BackColor = Color.LightCoral; alanEksik = true; }
            if (string.IsNullOrWhiteSpace(txtBulunduguKat.Text)) { txtBulunduguKat.BackColor = Color.LightCoral; alanEksik = true; }

            // Eksik alan varsa kullanıcıyı uyar ve işlemi durdur
            if (alanEksik)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Emlak yeniEmlak = new Emlak
            {
                MulkTipi = txtMulkTipi.Text,
                Adres = txtAdres.Text,
                Fiyat = Convert.ToDouble(txtFiyat.Text.Replace("₺", "").Replace(".", "").Replace(",", ".")), // ₺ ve formatı temizle
                OdaSayisi = Convert.ToInt32(txtOdaSayisi.Text),
                Metrekare = Convert.ToDouble(txtMetrekare.Text),
                ToplamKatSayisi = Convert.ToInt32(txtToplamKatSayisi.Text),
                BulunduguKat = Convert.ToInt32(txtBulunduguKat.Text)


            };
            emlakService.AddEmlak(yeniEmlak);
            MessageBox.Show("Emlak başarıyla eklendi!");
            txtMulkTipi.Text = string.Empty;
            txtAdres.Text = string.Empty;
            txtFiyat.Text = string.Empty;
            txtOdaSayisi.Text = string.Empty;
            txtMetrekare.Text = string.Empty;
            txtToplamKatSayisi.Text = string.Empty;
            txtBulunduguKat.Text = string.Empty;

            // TextBox'ların arka plan rengini varsayılana döndür
            txtMulkTipi.BackColor = Color.White;
            txtAdres.BackColor = Color.White;
            txtFiyat.BackColor = Color.White;
            txtOdaSayisi.BackColor = Color.White;
            txtMetrekare.BackColor = Color.White;
            txtToplamKatSayisi.BackColor = Color.White;
            txtBulunduguKat.BackColor = Color.White;
            //this.Close(); // Formu kapatır
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            if (mainForm != null)
            {
                mainForm.Show();
            }
            else
            {
                mainForm = new MainForm();
                mainForm.Show();
            }
            this.Hide();
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmlakEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void EmlakEkleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kapatmayı iptal et
           // e.Cancel = true;

            // Bunun yerine formu gizle
            //this.Hide();
            Application.Exit(); 
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOdaSayisi_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOdaSayisi.Text, out _) && !string.IsNullOrWhiteSpace(txtOdaSayisi.Text))
            {
                MessageBox.Show("Lütfen rakam giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdaSayisi.Clear();
            }
        }

        private void txtMetrekare_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMetrekare.Text, out _) && !string.IsNullOrWhiteSpace(txtMetrekare.Text))
            {
                MessageBox.Show("Lütfen rakam giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetrekare.Clear();
            }
        }

        private void txtBulunduguKat_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBulunduguKat.Text, out _) && !string.IsNullOrWhiteSpace(txtBulunduguKat.Text))
            {
                MessageBox.Show("Lütfen rakam giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBulunduguKat.Clear();
            }
        }

        private void txtToplamKatSayisi_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtToplamKatSayisi.Text, out _) && !string.IsNullOrWhiteSpace(txtToplamKatSayisi.Text))
            {
                MessageBox.Show("Lütfen rakam giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtToplamKatSayisi.Clear();
            }
        }

        private void txtFiyat_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtFiyat.Text, out double fiyat))
            {
                txtFiyat.Text = string.Format("{0:N2} ₺", fiyat); // 10.000,00 ₺ gibi formatlar
            }
            else if (!string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFiyat.Clear();
            }
        }
    }
}
