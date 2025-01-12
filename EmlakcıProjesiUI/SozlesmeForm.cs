using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText;

namespace EmlakcıProjesiUI
{
    public partial class SozlesmeForm : Form
    {
        public SozlesmeForm()
        {
            InitializeComponent();
        }

        

        private void SozlesmeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDownloadPdf_Click(object sender, EventArgs e)
        {
            try
            {
                // PDF dosyasının bulunduğu yol
                string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gayrimenkul-satisi-aracilik-sozlesmesi.pdf");

                // Dosya mevcut mu kontrol et
                if (!File.Exists(sourcePath))
                {
                    MessageBox.Show($"PDF dosyası bulunamadı! Yol: {sourcePath}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kullanıcıya nereye kaydedeceğini sor
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf"; // Sadece PDF dosyalarını göster
                    saveFileDialog.FileName = "gayrimenkul-satisi-aracilik-sozlesmesi.pdf"; // Varsayılan isim

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // PDF dosyasını seçilen yere kopyala
                        File.Copy(sourcePath, saveFileDialog.FileName, overwrite: true);

                        MessageBox.Show("PDF başarıyla indirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // GirisFormu'nu tekrar göster
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

            // MainForm'u kapat
            this.Hide();
        }
    }
}
