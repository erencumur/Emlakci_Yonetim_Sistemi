namespace EmlakcıProjesiUI
{
    partial class AnalizFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGeri = new System.Windows.Forms.Button();
            this.chartAnaliz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFiyatGrafik = new System.Windows.Forms.Button();
            this.btnOdaSayisiGrafik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnaliz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(926, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(200, 48);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // chartAnaliz
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAnaliz.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAnaliz.Legends.Add(legend2);
            this.chartAnaliz.Location = new System.Drawing.Point(12, 81);
            this.chartAnaliz.Name = "chartAnaliz";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAnaliz.Series.Add(series2);
            this.chartAnaliz.Size = new System.Drawing.Size(1114, 538);
            this.chartAnaliz.TabIndex = 1;
            this.chartAnaliz.Text = "chart1";
            // 
            // btnFiyatGrafik
            // 
            this.btnFiyatGrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGrafik.Location = new System.Drawing.Point(179, 659);
            this.btnFiyatGrafik.Name = "btnFiyatGrafik";
            this.btnFiyatGrafik.Size = new System.Drawing.Size(292, 90);
            this.btnFiyatGrafik.TabIndex = 2;
            this.btnFiyatGrafik.Text = "Fiyat Grafiği";
            this.btnFiyatGrafik.UseVisualStyleBackColor = true;
            this.btnFiyatGrafik.Click += new System.EventHandler(this.btnFiyatGrafik_Click);
            // 
            // btnOdaSayisiGrafik
            // 
            this.btnOdaSayisiGrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaSayisiGrafik.Location = new System.Drawing.Point(672, 659);
            this.btnOdaSayisiGrafik.Name = "btnOdaSayisiGrafik";
            this.btnOdaSayisiGrafik.Size = new System.Drawing.Size(292, 90);
            this.btnOdaSayisiGrafik.TabIndex = 3;
            this.btnOdaSayisiGrafik.Text = "Oda Sayısı Grafiği";
            this.btnOdaSayisiGrafik.UseVisualStyleBackColor = true;
            this.btnOdaSayisiGrafik.Click += new System.EventHandler(this.btnOdaSayisiGrafik_Click);
            // 
            // AnalizFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1138, 778);
            this.Controls.Add(this.btnOdaSayisiGrafik);
            this.Controls.Add(this.btnFiyatGrafik);
            this.Controls.Add(this.chartAnaliz);
            this.Controls.Add(this.btnGeri);
            this.Name = "AnalizFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalizFormu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalizFormu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnaliz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnaliz;
        private System.Windows.Forms.Button btnFiyatGrafik;
        private System.Windows.Forms.Button btnOdaSayisiGrafik;
    }
}