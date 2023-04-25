
namespace WindowsFormsApp6
{
    partial class GirisYapKaydolSayfasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblGirisYapMusteriNo = new System.Windows.Forms.Label();
            this.lblGirisYapTCNo = new System.Windows.Forms.Label();
            this.lblGirisYapAd = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblHesabinizYokMu = new System.Windows.Forms.Label();
            this.btnKayitOlmayaGit = new System.Windows.Forms.Button();
            this.mskdtxtGirisYapMusteriNo = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtIsim = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(392, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yapma Sayfasına Hoşgediniz!";
            // 
            // lblGirisYapMusteriNo
            // 
            this.lblGirisYapMusteriNo.AutoSize = true;
            this.lblGirisYapMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYapMusteriNo.Location = new System.Drawing.Point(442, 154);
            this.lblGirisYapMusteriNo.Name = "lblGirisYapMusteriNo";
            this.lblGirisYapMusteriNo.Size = new System.Drawing.Size(101, 22);
            this.lblGirisYapMusteriNo.TabIndex = 1;
            this.lblGirisYapMusteriNo.Text = "Müşteri No:";
            // 
            // lblGirisYapTCNo
            // 
            this.lblGirisYapTCNo.AutoSize = true;
            this.lblGirisYapTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYapTCNo.Location = new System.Drawing.Point(445, 236);
            this.lblGirisYapTCNo.Name = "lblGirisYapTCNo";
            this.lblGirisYapTCNo.Size = new System.Drawing.Size(120, 22);
            this.lblGirisYapTCNo.TabIndex = 3;
            this.lblGirisYapTCNo.Text = "TC Kimlik No:";
            // 
            // lblGirisYapAd
            // 
            this.lblGirisYapAd.AutoSize = true;
            this.lblGirisYapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYapAd.Location = new System.Drawing.Point(445, 317);
            this.lblGirisYapAd.Name = "lblGirisYapAd";
            this.lblGirisYapAd.Size = new System.Drawing.Size(68, 22);
            this.lblGirisYapAd.TabIndex = 5;
            this.lblGirisYapAd.Text = "Isminiz:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(576, 411);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(230, 46);
            this.btnGirisYap.TabIndex = 7;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblHesabinizYokMu
            // 
            this.lblHesabinizYokMu.AutoSize = true;
            this.lblHesabinizYokMu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesabinizYokMu.Location = new System.Drawing.Point(446, 561);
            this.lblHesabinizYokMu.Name = "lblHesabinizYokMu";
            this.lblHesabinizYokMu.Size = new System.Drawing.Size(207, 18);
            this.lblHesabinizYokMu.TabIndex = 8;
            this.lblHesabinizYokMu.Text = "Hesabınız Yok Mu? Kayıt Olun";
            // 
            // btnKayitOlmayaGit
            // 
            this.btnKayitOlmayaGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOlmayaGit.Location = new System.Drawing.Point(766, 552);
            this.btnKayitOlmayaGit.Name = "btnKayitOlmayaGit";
            this.btnKayitOlmayaGit.Size = new System.Drawing.Size(126, 37);
            this.btnKayitOlmayaGit.TabIndex = 9;
            this.btnKayitOlmayaGit.Text = "Kayit Ol";
            this.btnKayitOlmayaGit.UseVisualStyleBackColor = true;
            this.btnKayitOlmayaGit.Click += new System.EventHandler(this.btnKayitOlmayaGit_Click);
            // 
            // mskdtxtGirisYapMusteriNo
            // 
            this.mskdtxtGirisYapMusteriNo.Location = new System.Drawing.Point(786, 154);
            this.mskdtxtGirisYapMusteriNo.Mask = "0000";
            this.mskdtxtGirisYapMusteriNo.Name = "mskdtxtGirisYapMusteriNo";
            this.mskdtxtGirisYapMusteriNo.Size = new System.Drawing.Size(131, 22);
            this.mskdtxtGirisYapMusteriNo.TabIndex = 10;
            this.mskdtxtGirisYapMusteriNo.ValidatingType = typeof(int);
            // 
            // mskdtxtTC
            // 
            this.mskdtxtTC.Location = new System.Drawing.Point(786, 236);
            this.mskdtxtTC.Mask = "00000000000";
            this.mskdtxtTC.Name = "mskdtxtTC";
            this.mskdtxtTC.Size = new System.Drawing.Size(131, 22);
            this.mskdtxtTC.TabIndex = 11;
            this.mskdtxtTC.ValidatingType = typeof(int);
            // 
            // mskdtxtIsim
            // 
            this.mskdtxtIsim.Location = new System.Drawing.Point(786, 317);
            this.mskdtxtIsim.Mask = "LLLLLLLLLLLLLLLLLL";
            this.mskdtxtIsim.Name = "mskdtxtIsim";
            this.mskdtxtIsim.Size = new System.Drawing.Size(131, 22);
            this.mskdtxtIsim.TabIndex = 12;
            this.mskdtxtIsim.ValidatingType = typeof(int);
            // 
            // GirisYapKaydolSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 643);
            this.Controls.Add(this.mskdtxtIsim);
            this.Controls.Add(this.mskdtxtTC);
            this.Controls.Add(this.mskdtxtGirisYapMusteriNo);
            this.Controls.Add(this.btnKayitOlmayaGit);
            this.Controls.Add(this.lblHesabinizYokMu);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblGirisYapAd);
            this.Controls.Add(this.lblGirisYapTCNo);
            this.Controls.Add(this.lblGirisYapMusteriNo);
            this.Controls.Add(this.label1);
            this.Name = "GirisYapKaydolSayfasi";
            this.Text = "GirisYapKaydolSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGirisYapMusteriNo;
        private System.Windows.Forms.Label lblGirisYapTCNo;
        private System.Windows.Forms.Label lblGirisYapAd;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblHesabinizYokMu;
        private System.Windows.Forms.Button btnKayitOlmayaGit;
        private System.Windows.Forms.MaskedTextBox mskdtxtGirisYapMusteriNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtTC;
        private System.Windows.Forms.MaskedTextBox mskdtxtIsim;
    }
}