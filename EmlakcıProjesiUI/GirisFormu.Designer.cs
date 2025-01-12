namespace EmlakcıProjesiUI
{
    partial class GirisFormu
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
            this.btnEmlakIslemleri = new System.Windows.Forms.Button();
            this.btnSozlesmeIslemleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmlakIslemleri
            // 
            this.btnEmlakIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmlakIslemleri.Location = new System.Drawing.Point(29, 109);
            this.btnEmlakIslemleri.Name = "btnEmlakIslemleri";
            this.btnEmlakIslemleri.Size = new System.Drawing.Size(230, 91);
            this.btnEmlakIslemleri.TabIndex = 0;
            this.btnEmlakIslemleri.Text = "Emlak İşlemleri";
            this.btnEmlakIslemleri.UseVisualStyleBackColor = true;
            this.btnEmlakIslemleri.Click += new System.EventHandler(this.btnEmlakIslemleri_Click);
            // 
            // btnSozlesmeIslemleri
            // 
            this.btnSozlesmeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSozlesmeIslemleri.Location = new System.Drawing.Point(29, 293);
            this.btnSozlesmeIslemleri.Name = "btnSozlesmeIslemleri";
            this.btnSozlesmeIslemleri.Size = new System.Drawing.Size(230, 91);
            this.btnSozlesmeIslemleri.TabIndex = 1;
            this.btnSozlesmeIslemleri.Text = "Sözleşme İşlemleri";
            this.btnSozlesmeIslemleri.UseVisualStyleBackColor = true;
            this.btnSozlesmeIslemleri.Click += new System.EventHandler(this.btnSozlesmeIslemleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(926, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(200, 48);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaliz.Location = new System.Drawing.Point(29, 468);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(230, 91);
            this.btnAnaliz.TabIndex = 3;
            this.btnAnaliz.Text = "Analiz İşlemleri";
            this.btnAnaliz.UseVisualStyleBackColor = true;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(29, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mail İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmlakcıProjesiUI.Properties.Resources.istockphoto_1409298953_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(455, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 379);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 778);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnaliz);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSozlesmeIslemleri);
            this.Controls.Add(this.btnEmlakIslemleri);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisFormu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisFormu_FormClosing);
            this.Load += new System.EventHandler(this.GirisFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmlakIslemleri;
        private System.Windows.Forms.Button btnSozlesmeIslemleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}