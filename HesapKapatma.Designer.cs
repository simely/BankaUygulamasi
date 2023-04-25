
namespace WindowsFormsApp6
{
    partial class HesapKapatma
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
            this.lblHesapKapatmaSayfasiBaslik = new System.Windows.Forms.Label();
            this.lblHesapKapatmaHesapNumarasi = new System.Windows.Forms.Label();
            this.btnHesabimiKapat = new System.Windows.Forms.Button();
            this.mskdtxtHesapKapatmaHesapNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblHesapKapatmaSayfasiBaslik
            // 
            this.lblHesapKapatmaSayfasiBaslik.AutoSize = true;
            this.lblHesapKapatmaSayfasiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapKapatmaSayfasiBaslik.Location = new System.Drawing.Point(365, 41);
            this.lblHesapKapatmaSayfasiBaslik.Name = "lblHesapKapatmaSayfasiBaslik";
            this.lblHesapKapatmaSayfasiBaslik.Size = new System.Drawing.Size(591, 38);
            this.lblHesapKapatmaSayfasiBaslik.TabIndex = 0;
            this.lblHesapKapatmaSayfasiBaslik.Text = "Hesap Kapatma Sayfasina Hoşgeldiniz!";
            // 
            // lblHesapKapatmaHesapNumarasi
            // 
            this.lblHesapKapatmaHesapNumarasi.AutoSize = true;
            this.lblHesapKapatmaHesapNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapKapatmaHesapNumarasi.Location = new System.Drawing.Point(427, 233);
            this.lblHesapKapatmaHesapNumarasi.Name = "lblHesapKapatmaHesapNumarasi";
            this.lblHesapKapatmaHesapNumarasi.Size = new System.Drawing.Size(237, 25);
            this.lblHesapKapatmaHesapNumarasi.TabIndex = 1;
            this.lblHesapKapatmaHesapNumarasi.Text = "Hesap Numaranızı Giriniz:";
            // 
            // btnHesabimiKapat
            // 
            this.btnHesabimiKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesabimiKapat.Location = new System.Drawing.Point(574, 400);
            this.btnHesabimiKapat.Name = "btnHesabimiKapat";
            this.btnHesabimiKapat.Size = new System.Drawing.Size(258, 46);
            this.btnHesabimiKapat.TabIndex = 3;
            this.btnHesabimiKapat.Text = "Hesabımı Kapat";
            this.btnHesabimiKapat.UseVisualStyleBackColor = true;
            this.btnHesabimiKapat.Click += new System.EventHandler(this.btnHesabimiKapat_Click);
            // 
            // mskdtxtHesapKapatmaHesapNumarasi
            // 
            this.mskdtxtHesapKapatmaHesapNumarasi.Location = new System.Drawing.Point(670, 233);
            this.mskdtxtHesapKapatmaHesapNumarasi.Mask = "00000";
            this.mskdtxtHesapKapatmaHesapNumarasi.Name = "mskdtxtHesapKapatmaHesapNumarasi";
            this.mskdtxtHesapKapatmaHesapNumarasi.Size = new System.Drawing.Size(162, 22);
            this.mskdtxtHesapKapatmaHesapNumarasi.TabIndex = 4;
            this.mskdtxtHesapKapatmaHesapNumarasi.ValidatingType = typeof(int);
            // 
            // HesapKapatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 786);
            this.Controls.Add(this.mskdtxtHesapKapatmaHesapNumarasi);
            this.Controls.Add(this.btnHesabimiKapat);
            this.Controls.Add(this.lblHesapKapatmaHesapNumarasi);
            this.Controls.Add(this.lblHesapKapatmaSayfasiBaslik);
            this.Name = "HesapKapatma";
            this.Text = "HesapKapatma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HesapKapatma_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHesapKapatmaSayfasiBaslik;
        private System.Windows.Forms.Label lblHesapKapatmaHesapNumarasi;
        private System.Windows.Forms.Button btnHesabimiKapat;
        private System.Windows.Forms.MaskedTextBox mskdtxtHesapKapatmaHesapNumarasi;
    }
}