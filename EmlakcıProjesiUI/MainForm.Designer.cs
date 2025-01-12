namespace EmlakcıProjesiUI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmlakListesi = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYeniEmlakEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOdaSayisignclle = new System.Windows.Forms.TextBox();
            this.txtMulkTipignclle = new System.Windows.Forms.TextBox();
            this.txtAdresgnclle = new System.Windows.Forms.TextBox();
            this.txtFiyatgnclle = new System.Windows.Forms.TextBox();
            this.txtToplamKatSayisignclle = new System.Windows.Forms.TextBox();
            this.txtMetrekaregnclle = new System.Windows.Forms.TextBox();
            this.txtBulunduguKatgnclle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmlakListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmlakListesi
            // 
            this.dgvEmlakListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmlakListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmlakListesi.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmlakListesi.Location = new System.Drawing.Point(29, 71);
            this.dgvEmlakListesi.Name = "dgvEmlakListesi";
            this.dgvEmlakListesi.RowHeadersWidth = 51;
            this.dgvEmlakListesi.RowTemplate.Height = 24;
            this.dgvEmlakListesi.Size = new System.Drawing.Size(1041, 281);
            this.dgvEmlakListesi.TabIndex = 0;
            this.dgvEmlakListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmlakListesi_CellContentClick);
            this.dgvEmlakListesi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmlakListesi_CellFormatting);
            this.dgvEmlakListesi.SelectionChanged += new System.EventHandler(this.dgvEmlakListesi_SelectionChanged);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(29, 358);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(189, 57);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Emlakları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnYeniEmlakEkle
            // 
            this.btnYeniEmlakEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniEmlakEkle.Location = new System.Drawing.Point(876, 358);
            this.btnYeniEmlakEkle.Name = "btnYeniEmlakEkle";
            this.btnYeniEmlakEkle.Size = new System.Drawing.Size(189, 55);
            this.btnYeniEmlakEkle.TabIndex = 2;
            this.btnYeniEmlakEkle.Text = "Emlak Ekle";
            this.btnYeniEmlakEkle.UseVisualStyleBackColor = true;
            this.btnYeniEmlakEkle.Click += new System.EventHandler(this.btnYeniEmlakEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(303, 358);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(189, 55);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Emlak Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(926, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtOdaSayisignclle
            // 
            this.txtOdaSayisignclle.Location = new System.Drawing.Point(749, 487);
            this.txtOdaSayisignclle.Multiline = true;
            this.txtOdaSayisignclle.Name = "txtOdaSayisignclle";
            this.txtOdaSayisignclle.Size = new System.Drawing.Size(316, 22);
            this.txtOdaSayisignclle.TabIndex = 5;
            // 
            // txtMulkTipignclle
            // 
            this.txtMulkTipignclle.Location = new System.Drawing.Point(157, 500);
            this.txtMulkTipignclle.Multiline = true;
            this.txtMulkTipignclle.Name = "txtMulkTipignclle";
            this.txtMulkTipignclle.Size = new System.Drawing.Size(316, 22);
            this.txtMulkTipignclle.TabIndex = 6;
            // 
            // txtAdresgnclle
            // 
            this.txtAdresgnclle.Location = new System.Drawing.Point(157, 575);
            this.txtAdresgnclle.Multiline = true;
            this.txtAdresgnclle.Name = "txtAdresgnclle";
            this.txtAdresgnclle.Size = new System.Drawing.Size(316, 74);
            this.txtAdresgnclle.TabIndex = 7;
            // 
            // txtFiyatgnclle
            // 
            this.txtFiyatgnclle.Location = new System.Drawing.Point(157, 695);
            this.txtFiyatgnclle.Multiline = true;
            this.txtFiyatgnclle.Name = "txtFiyatgnclle";
            this.txtFiyatgnclle.Size = new System.Drawing.Size(316, 21);
            this.txtFiyatgnclle.TabIndex = 8;
            // 
            // txtToplamKatSayisignclle
            // 
            this.txtToplamKatSayisignclle.Location = new System.Drawing.Point(749, 691);
            this.txtToplamKatSayisignclle.Multiline = true;
            this.txtToplamKatSayisignclle.Name = "txtToplamKatSayisignclle";
            this.txtToplamKatSayisignclle.Size = new System.Drawing.Size(316, 22);
            this.txtToplamKatSayisignclle.TabIndex = 9;
            // 
            // txtMetrekaregnclle
            // 
            this.txtMetrekaregnclle.Location = new System.Drawing.Point(749, 560);
            this.txtMetrekaregnclle.Multiline = true;
            this.txtMetrekaregnclle.Name = "txtMetrekaregnclle";
            this.txtMetrekaregnclle.Size = new System.Drawing.Size(316, 22);
            this.txtMetrekaregnclle.TabIndex = 10;
            // 
            // txtBulunduguKatgnclle
            // 
            this.txtBulunduguKatgnclle.Location = new System.Drawing.Point(749, 624);
            this.txtBulunduguKatgnclle.Multiline = true;
            this.txtBulunduguKatgnclle.Name = "txtBulunduguKatgnclle";
            this.txtBulunduguKatgnclle.Size = new System.Drawing.Size(316, 22);
            this.txtBulunduguKatgnclle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(24, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mülk Tipi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(527, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bulunduğu Kat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(527, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam Kat Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(527, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "MetreKare :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(527, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Oda Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 691);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fiyat :";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(598, 358);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(189, 55);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Emlak Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExportPDF.Location = new System.Drawing.Point(29, 421);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(189, 54);
            this.btnExportPDF.TabIndex = 20;
            this.btnExportPDF.Text = "Listeyi PDF Olarak Kaydet";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1138, 778);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBulunduguKatgnclle);
            this.Controls.Add(this.txtMetrekaregnclle);
            this.Controls.Add(this.txtToplamKatSayisignclle);
            this.Controls.Add(this.txtFiyatgnclle);
            this.Controls.Add(this.txtAdresgnclle);
            this.Controls.Add(this.txtMulkTipignclle);
            this.Controls.Add(this.txtOdaSayisignclle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYeniEmlakEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvEmlakListesi);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmlakListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmlakListesi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYeniEmlakEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOdaSayisignclle;
        private System.Windows.Forms.TextBox txtMulkTipignclle;
        private System.Windows.Forms.TextBox txtAdresgnclle;
        private System.Windows.Forms.TextBox txtFiyatgnclle;
        private System.Windows.Forms.TextBox txtToplamKatSayisignclle;
        private System.Windows.Forms.TextBox txtMetrekaregnclle;
        private System.Windows.Forms.TextBox txtBulunduguKatgnclle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnExportPDF;
    }
}