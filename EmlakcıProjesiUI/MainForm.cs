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
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Layout.Borders;
using System.Windows.Forms.DataVisualization.Charting;
using iText.Bouncycastle;




namespace EmlakcıProjesiUI
{
    public partial class MainForm : Form
    {

        private EmlakService emlakService = new EmlakService();
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var emlakList = emlakService.GetEmlakList();
            dgvEmlakListesi.DataSource = emlakList;


        }

        private void btnYeniEmlakEkle_Click(object sender, EventArgs e)
        {
            EmlakEkleForm emlakEkleForm = new EmlakEkleForm();
            emlakEkleForm.Show(); // Emlak ekleme formunu modal olarak aç
            this.Hide();
            // EmlakEkleForm'u modal olarak aç


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvEmlakListesi.ReadOnly = true;

            // Sadece tam satır seçimi sağla
            // dgvEmlakListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Kullanıcıların manuel satır eklemesini engelle
            dgvEmlakListesi.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in dgvEmlakListesi.Columns)
            {
                Console.WriteLine($"Sütun Adı: {column.Name}, Başlık: {column.HeaderText}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dgvEmlakListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEmlakListesi.SelectedRows.Count > 0) // Satır seçilmiş mi kontrol et
            {
                // Seçilen satırın adresini al
                string adres = dgvEmlakListesi.SelectedRows[0].Cells["Adres"].Value.ToString();

                // Güncellenecek emlak nesnesini oluştur
                Emlak guncellenenEmlak = new Emlak
                {
                    MulkTipi = txtMulkTipignclle.Text,
                    Adres = txtAdresgnclle.Text, // Yeni adres
                    Fiyat = Convert.ToDouble(txtFiyatgnclle.Text),
                    OdaSayisi = Convert.ToInt32(txtOdaSayisignclle.Text),
                    Metrekare = Convert.ToDouble(txtMetrekaregnclle.Text),
                    BulunduguKat = Convert.ToInt32(txtBulunduguKatgnclle.Text),
                    ToplamKatSayisi = Convert.ToInt32(txtToplamKatSayisignclle.Text)
                };

                // Güncelleme işlemini gerçekleştir
                string eskiAdres = dgvEmlakListesi.SelectedRows[0].Cells["Adres"].Value.ToString(); // Seçili satırdaki eski adres
                emlakService.UpdateEmlak(eskiAdres, guncellenenEmlak);

                // Kullanıcıya başarı mesajı göster
                MessageBox.Show("Emlak başarıyla güncellendi!");

                // DataGridView'i yenile
                dgvEmlakListesi.DataSource = emlakService.GetEmlakList();
            }
            else
            {
                MessageBox.Show("Güncellenecek bir satır seçmelisiniz!");
            }
        }

        private void dgvEmlakListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmlakListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmlakListesi.SelectedRows[0];
                txtMulkTipignclle.Text = selectedRow.Cells["MulkTipi"].Value.ToString();
                txtAdresgnclle.Text = selectedRow.Cells["Adres"].Value.ToString();
                txtFiyatgnclle.Text = selectedRow.Cells["Fiyat"].Value.ToString();
                txtOdaSayisignclle.Text = selectedRow.Cells["OdaSayisi"].Value.ToString();
                txtMetrekaregnclle.Text = selectedRow.Cells["Metrekare"].Value.ToString();
                txtBulunduguKatgnclle.Text = selectedRow.Cells["BulunduguKat"].Value.ToString();
                txtToplamKatSayisignclle.Text = selectedRow.Cells["ToplamKatSayisi"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvEmlakListesi.SelectedRows.Count > 0)
            {
                // Datagridview'den seçilen adresi al
                string secilenAdres = dgvEmlakListesi.SelectedRows[0].Cells["Adres"].Value.ToString();

                // Kullanıcıdan onay al
                DialogResult onay = MessageBox.Show("Bu emlağı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (onay == DialogResult.Yes)
                {
                    // Emlak silme işlemini çağır
                    emlakService.DeleteEmlak(secilenAdres);
                    MessageBox.Show("Emlak başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Datagridview'i güncelle
                    dgvEmlakListesi.DataSource = emlakService.GetEmlakList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz emlağı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvEmlakListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmlakListesi.Columns[e.ColumnIndex].Name == "Fiyat" && e.Value != null)
            {
                if (double.TryParse(e.Value.ToString(), out double fiyat))
                {
                    e.Value = string.Format("{0:N2} ₺", fiyat); // 10.000,00 ₺ gibi formatlar
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            {

                 
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "PDF Olarak Kaydet";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new PdfWriter(saveFileDialog.FileName)) // Burada dosya adını geçiriyoruz
                        using (var pdf = new PdfDocument(writer)) // PdfDocument'ı oluşturuyoruz
                        {
                            var document = new Document(pdf);
                            document.Add(new Paragraph("Emlak Bilgileri").SetTextAlignment(TextAlignment.CENTER));


                            // DataGridView'deki verileri PDF'ye ekle
                            foreach (DataGridViewRow row in dgvEmlakListesi.Rows)
                            {
                                if (row.IsNewRow) continue;

                                string emlakDetails = $"Mülk Tipi: {(row.Cells["MulkTipi"].Value ?? "N/A")}  ||  " +
                                                      $"Adres: {(row.Cells["Adres"].Value ?? "N/A")}  ||  " +
                                                      $"Fiyat: {(row.Cells["Fiyat"].Value ?? "N/A")}  ||  " +
                                                      $"Oda Sayısı: {(row.Cells["OdaSayisi"].Value ?? "N/A")}  ||  " +
                                                      $"Metrekare: {(row.Cells["Metrekare"].Value ?? "N/A")}  ||   " +
                                                      $"Toplam Kat Sayısı: {(row.Cells["ToplamKatSayisi"].Value ?? "N/A")}  ||   " +
                                                      $"Bulunduğu Kat: {(row.Cells["BulunduguKat"].Value ?? "N/A")}  ||   ";


                                document.Add(new Paragraph(emlakDetails));
                            }
                            document.Close();

                        }
                        MessageBox.Show("PDF başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

        }

    }
}
