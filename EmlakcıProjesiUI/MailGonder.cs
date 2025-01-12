using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Net.Mime;

namespace EmlakcıProjesiUI
{
    public partial class MailGonder : Form
    {
        public MailGonder()
        {
            InitializeComponent();

        }
        private List<string> eklenenDosyalar = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {

            GirisFormu girisFormu = Application.OpenForms["GirisFormu"] as GirisFormu;
            if (girisFormu != null)
            {
                girisFormu.Show(); // Daha önce açılmışsa, tekrar göster
            }
            else
            {
                girisFormu = new GirisFormu(); // Açılmamışsa yeni bir form oluştur
                girisFormu.Show();
            }


            this.Hide();
        }

        private void MailGonder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void MailGonder_Load(object sender, EventArgs e)
        {

        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Dosya Seç";
                openFileDialog.Filter = "Tüm Dosyalar (*.*)|*.*";
                openFileDialog.Multiselect = true; // Birden fazla dosya seçimine izin ver

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    eklenenDosyalar.AddRange(openFileDialog.FileNames);
                    MessageBox.Show("Dosya(lar) başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alıcı e-posta adresini al
                string aliciMail = txtAliciMail.Text.Trim();
                string mailIcerik = txtMailIcerik.Text.Trim();

                // Alıcı mail adresi kontrolü
                if (string.IsNullOrEmpty(aliciMail))
                {
                    MessageBox.Show("Lütfen bir alıcı e-posta adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // İmza görselinin yolu
                string imzaYolu = Path.Combine(Environment.CurrentDirectory, "imza.jpeg");

                // İmza görseli kontrolü
                //  if (!File.Exists(imzaYolu))
                //{
                // MessageBox.Show("İmza görseli bulunamadı. Lütfen görseli doğru dizine ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  return;
                //}

                // Mail mesajını oluştur
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("cmrkurumsal@gmail.com");
                mail.To.Add(aliciMail);
                mail.Subject = "CMR EMLAK";
                mail.IsBodyHtml = true;

                // HTML içerik ve LinkedResource ayarı
               // LinkedResource resim = new LinkedResource(imzaYolu)
                //{
                  //  ContentId = "imzaGorsel",
                   // ContentType = new System.Net.Mime.ContentType("image/jpeg")
                //};

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(
                   $"{mailIcerik} ",
                    null, "text/html");
               // htmlView.LinkedResources.Add(resim);
                mail.AlternateViews.Add(htmlView);

                // Dosya eklerini ekle (yalnızca dosya varsa)
                if (eklenenDosyalar != null && eklenenDosyalar.Count > 0)
                {
                    foreach (string dosyaYolu in eklenenDosyalar)
                    {
                        if (File.Exists(dosyaYolu))
                        {
                            Attachment attachment = new Attachment(dosyaYolu);
                            mail.Attachments.Add(attachment);
                        }
                    }
                }

                // SMTP istemcisi oluştur
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("cmrkurumsal@gmail.com", "v r z ly k z k s z x p e l m n");
                smtpClient.EnableSsl = true;

                // Mail gönder
                smtpClient.Send(mail);

                MessageBox.Show("Mail başarıyla gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Eklenen dosyaları temizle
                eklenenDosyalar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail gönderilirken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMailIcerik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
