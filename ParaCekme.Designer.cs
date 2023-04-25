
namespace WindowsFormsApp6
{
    partial class ParaCekme
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
            this.btnParaCek = new System.Windows.Forms.Button();
            this.lblCekilecekTutar = new System.Windows.Forms.Label();
            this.lblParaCekmeHesapNumarasi = new System.Windows.Forms.Label();
            this.lblParaCekmeSayfasiBaslik = new System.Windows.Forms.Label();
            this.mskdtxtParaCekmeHesapNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtCekilecekTutar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(588, 545);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(223, 50);
            this.btnParaCek.TabIndex = 5;
            this.btnParaCek.Text = "Para ÇEK";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // lblCekilecekTutar
            // 
            this.lblCekilecekTutar.AutoSize = true;
            this.lblCekilecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekilecekTutar.Location = new System.Drawing.Point(552, 345);
            this.lblCekilecekTutar.Name = "lblCekilecekTutar";
            this.lblCekilecekTutar.Size = new System.Drawing.Size(101, 25);
            this.lblCekilecekTutar.TabIndex = 3;
            this.lblCekilecekTutar.Text = "Tutar (TL)";
            // 
            // lblParaCekmeHesapNumarasi
            // 
            this.lblParaCekmeHesapNumarasi.AutoSize = true;
            this.lblParaCekmeHesapNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaCekmeHesapNumarasi.Location = new System.Drawing.Point(386, 199);
            this.lblParaCekmeHesapNumarasi.Name = "lblParaCekmeHesapNumarasi";
            this.lblParaCekmeHesapNumarasi.Size = new System.Drawing.Size(237, 25);
            this.lblParaCekmeHesapNumarasi.TabIndex = 1;
            this.lblParaCekmeHesapNumarasi.Text = "Hesap Numaranızı Giriniz:";
            // 
            // lblParaCekmeSayfasiBaslik
            // 
            this.lblParaCekmeSayfasiBaslik.AutoSize = true;
            this.lblParaCekmeSayfasiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaCekmeSayfasiBaslik.Location = new System.Drawing.Point(384, 31);
            this.lblParaCekmeSayfasiBaslik.Name = "lblParaCekmeSayfasiBaslik";
            this.lblParaCekmeSayfasiBaslik.Size = new System.Drawing.Size(539, 38);
            this.lblParaCekmeSayfasiBaslik.TabIndex = 0;
            this.lblParaCekmeSayfasiBaslik.Text = "Para Çekme Sayfasına Hoşgeldiniz!";
            // 
            // mskdtxtParaCekmeHesapNumarasi
            // 
            this.mskdtxtParaCekmeHesapNumarasi.Location = new System.Drawing.Point(709, 202);
            this.mskdtxtParaCekmeHesapNumarasi.Mask = "00000";
            this.mskdtxtParaCekmeHesapNumarasi.Name = "mskdtxtParaCekmeHesapNumarasi";
            this.mskdtxtParaCekmeHesapNumarasi.Size = new System.Drawing.Size(111, 22);
            this.mskdtxtParaCekmeHesapNumarasi.TabIndex = 6;
            this.mskdtxtParaCekmeHesapNumarasi.ValidatingType = typeof(int);
            // 
            // mskdtxtCekilecekTutar
            // 
            this.mskdtxtCekilecekTutar.Location = new System.Drawing.Point(709, 348);
            this.mskdtxtCekilecekTutar.Mask = "0000000000000";
            this.mskdtxtCekilecekTutar.Name = "mskdtxtCekilecekTutar";
            this.mskdtxtCekilecekTutar.Size = new System.Drawing.Size(111, 22);
            this.mskdtxtCekilecekTutar.TabIndex = 7;
            this.mskdtxtCekilecekTutar.ValidatingType = typeof(int);
            // 
            // ParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 776);
            this.Controls.Add(this.mskdtxtCekilecekTutar);
            this.Controls.Add(this.mskdtxtParaCekmeHesapNumarasi);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.lblCekilecekTutar);
            this.Controls.Add(this.lblParaCekmeHesapNumarasi);
            this.Controls.Add(this.lblParaCekmeSayfasiBaslik);
            this.Name = "ParaCekme";
            this.Text = "ParaCekme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParaCekme_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParaCekmeSayfasiBaslik;
        private System.Windows.Forms.Label lblParaCekmeHesapNumarasi;
        private System.Windows.Forms.Label lblCekilecekTutar;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.MaskedTextBox mskdtxtParaCekmeHesapNumarasi;
        private System.Windows.Forms.MaskedTextBox mskdtxtCekilecekTutar;
    }
}