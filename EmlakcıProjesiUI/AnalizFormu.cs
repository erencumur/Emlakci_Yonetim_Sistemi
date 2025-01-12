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
using System.Windows.Forms.DataVisualization.Charting;
using iText;
using System.IO;



namespace EmlakcıProjesiUI
{
    public partial class AnalizFormu : Form
    {
        public AnalizFormu()
        {
            InitializeComponent();
            emlakService = new EmlakService();


        }
        private readonly EmlakService emlakService;
        private void AnalizFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void btnGeri_Click(object sender, EventArgs e)
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

        private void btnFiyatGrafik_Click(object sender, EventArgs e)
        {
            // Chart temizlenir
            chartAnaliz.Series.Clear();

            // Yeni bir grafik serisi oluşturulur
            Series fiyatSeries = new Series("Emlak Fiyatları");
            fiyatSeries.ChartType = SeriesChartType.Column; // Sütun grafiği

            // Fiyat verilerini gruplandır ve seriye ekle
            var emlaklar = emlakService.GetEmlakList();
            foreach (var emlak in emlaklar)
            {
                fiyatSeries.Points.AddXY(emlak.Adres, emlak.Fiyat);
            }

            // Chart kontrolüne seri eklenir
            chartAnaliz.Series.Add(fiyatSeries);

            // Başlık ve görselleştirme detayları
            chartAnaliz.Titles.Clear();
            chartAnaliz.Titles.Add("Emlak Fiyat Analizi");
            chartAnaliz.ChartAreas[0].AxisX.Title = "Adres";
            chartAnaliz.ChartAreas[0].AxisY.Title = "Fiyat (TL)";
        }

        private void btnOdaSayisiGrafik_Click(object sender, EventArgs e)
        {// Chart temizlenir
            chartAnaliz.Series.Clear();

            // Yeni bir grafik serisi oluşturulur
            Series odaSeries = new Series("Oda Sayıları");
            odaSeries.ChartType = SeriesChartType.Pie; // Pasta grafiği

            // Oda sayısı dağılımını gruplandır
            var emlaklar = emlakService.GetEmlakList();
            var odaSayisiGruplari = emlaklar
                .GroupBy(emlak => emlak.OdaSayisi)
                .Select(grup => new { OdaSayisi = grup.Key, Adet = grup.Count() });

            foreach (var grup in odaSayisiGruplari)
            {
                odaSeries.Points.AddXY($"{grup.OdaSayisi} Odalı", grup.Adet);
            }

            // Chart kontrolüne seri eklenir
            chartAnaliz.Series.Add(odaSeries);

            // Başlık ve görselleştirme detayları
            chartAnaliz.Titles.Clear();
            chartAnaliz.Titles.Add("Oda Sayısı Dağılımı");
        }

        
    }
}
