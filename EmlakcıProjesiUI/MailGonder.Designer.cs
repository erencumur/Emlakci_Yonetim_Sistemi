namespace EmlakcıProjesiUI
{
    partial class MailGonder
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAliciMail = new System.Windows.Forms.TextBox();
            this.txtMailIcerik = new System.Windows.Forms.RichTextBox();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.btnMailGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(926, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAliciMail
            // 
            this.txtAliciMail.Location = new System.Drawing.Point(357, 189);
            this.txtAliciMail.Name = "txtAliciMail";
            this.txtAliciMail.Size = new System.Drawing.Size(474, 22);
            this.txtAliciMail.TabIndex = 1;
            // 
            // txtMailIcerik
            // 
            this.txtMailIcerik.Location = new System.Drawing.Point(357, 273);
            this.txtMailIcerik.Name = "txtMailIcerik";
            this.txtMailIcerik.Size = new System.Drawing.Size(474, 188);
            this.txtMailIcerik.TabIndex = 2;
            this.txtMailIcerik.Text = "";
            this.txtMailIcerik.TextChanged += new System.EventHandler(this.txtMailIcerik_TextChanged);
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaEkle.Location = new System.Drawing.Point(621, 545);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(210, 73);
            this.btnDosyaEkle.TabIndex = 3;
            this.btnDosyaEkle.Text = "Dosya Ekle";
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMailGonder.Location = new System.Drawing.Point(357, 545);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(210, 74);
            this.btnMailGonder.TabIndex = 4;
            this.btnMailGonder.Text = "Mail Gönder";
            this.btnMailGonder.UseVisualStyleBackColor = true;
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alıcı Mail Adresini Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mail İçeriğini Yazınız :";
            // 
            // MailGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1138, 778);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMailGonder);
            this.Controls.Add(this.btnDosyaEkle);
            this.Controls.Add(this.txtMailIcerik);
            this.Controls.Add(this.txtAliciMail);
            this.Controls.Add(this.button1);
            this.Name = "MailGonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailGonder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailGonder_FormClosing);
            this.Load += new System.EventHandler(this.MailGonder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAliciMail;
        private System.Windows.Forms.RichTextBox txtMailIcerik;
        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.Button btnMailGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}