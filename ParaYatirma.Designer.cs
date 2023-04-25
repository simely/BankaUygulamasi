
namespace WindowsFormsApp6
{
    partial class ParaYatirma
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
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.lblYatirilacakTutar = new System.Windows.Forms.Label();
            this.lblParaYatirmaHesapNumarasi = new System.Windows.Forms.Label();
            this.lblParaYatirmaSayfasiBaslik = new System.Windows.Forms.Label();
            this.mskdtxtParaYatirmaHesapNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtYatirilacakTutar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.Location = new System.Drawing.Point(605, 569);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(223, 50);
            this.btnParaYatir.TabIndex = 11;
            this.btnParaYatir.Text = "Para YATIR";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // lblYatirilacakTutar
            // 
            this.lblYatirilacakTutar.AutoSize = true;
            this.lblYatirilacakTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYatirilacakTutar.Location = new System.Drawing.Point(569, 369);
            this.lblYatirilacakTutar.Name = "lblYatirilacakTutar";
            this.lblYatirilacakTutar.Size = new System.Drawing.Size(101, 25);
            this.lblYatirilacakTutar.TabIndex = 9;
            this.lblYatirilacakTutar.Text = "Tutar (TL)";
            // 
            // lblParaYatirmaHesapNumarasi
            // 
            this.lblParaYatirmaHesapNumarasi.AutoSize = true;
            this.lblParaYatirmaHesapNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaYatirmaHesapNumarasi.Location = new System.Drawing.Point(403, 223);
            this.lblParaYatirmaHesapNumarasi.Name = "lblParaYatirmaHesapNumarasi";
            this.lblParaYatirmaHesapNumarasi.Size = new System.Drawing.Size(237, 25);
            this.lblParaYatirmaHesapNumarasi.TabIndex = 7;
            this.lblParaYatirmaHesapNumarasi.Text = "Hesap Numaranızı Giriniz:";
            // 
            // lblParaYatirmaSayfasiBaslik
            // 
            this.lblParaYatirmaSayfasiBaslik.AutoSize = true;
            this.lblParaYatirmaSayfasiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaYatirmaSayfasiBaslik.Location = new System.Drawing.Point(401, 55);
            this.lblParaYatirmaSayfasiBaslik.Name = "lblParaYatirmaSayfasiBaslik";
            this.lblParaYatirmaSayfasiBaslik.Size = new System.Drawing.Size(547, 38);
            this.lblParaYatirmaSayfasiBaslik.TabIndex = 6;
            this.lblParaYatirmaSayfasiBaslik.Text = "Para Yatırma Sayfasına Hoşgeldiniz!";
            // 
            // mskdtxtParaYatirmaHesapNumarasi
            // 
            this.mskdtxtParaYatirmaHesapNumarasi.Location = new System.Drawing.Point(726, 227);
            this.mskdtxtParaYatirmaHesapNumarasi.Mask = "00000";
            this.mskdtxtParaYatirmaHesapNumarasi.Name = "mskdtxtParaYatirmaHesapNumarasi";
            this.mskdtxtParaYatirmaHesapNumarasi.Size = new System.Drawing.Size(111, 22);
            this.mskdtxtParaYatirmaHesapNumarasi.TabIndex = 12;
            this.mskdtxtParaYatirmaHesapNumarasi.ValidatingType = typeof(int);
            // 
            // mskdtxtYatirilacakTutar
            // 
            this.mskdtxtYatirilacakTutar.Location = new System.Drawing.Point(726, 372);
            this.mskdtxtYatirilacakTutar.Mask = "000000000000";
            this.mskdtxtYatirilacakTutar.Name = "mskdtxtYatirilacakTutar";
            this.mskdtxtYatirilacakTutar.Size = new System.Drawing.Size(111, 22);
            this.mskdtxtYatirilacakTutar.TabIndex = 13;
            this.mskdtxtYatirilacakTutar.ValidatingType = typeof(int);
            // 
            // ParaYatirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 787);
            this.Controls.Add(this.mskdtxtYatirilacakTutar);
            this.Controls.Add(this.mskdtxtParaYatirmaHesapNumarasi);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.lblYatirilacakTutar);
            this.Controls.Add(this.lblParaYatirmaHesapNumarasi);
            this.Controls.Add(this.lblParaYatirmaSayfasiBaslik);
            this.Name = "ParaYatirma";
            this.Text = "ParaYatirma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParaYatirma_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Label lblYatirilacakTutar;
        private System.Windows.Forms.Label lblParaYatirmaHesapNumarasi;
        private System.Windows.Forms.Label lblParaYatirmaSayfasiBaslik;
        private System.Windows.Forms.MaskedTextBox mskdtxtParaYatirmaHesapNumarasi;
        private System.Windows.Forms.MaskedTextBox mskdtxtYatirilacakTutar;
    }
}