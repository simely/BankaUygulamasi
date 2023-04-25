
namespace WindowsFormsApp6
{
    partial class MusteriKayit
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
            this.btnMusteriKayitOlusturma = new System.Windows.Forms.Button();
            this.lblMusteriEklemeMusteriNumarasi = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblTCKimlikNo = new System.Windows.Forms.Label();
            this.mskdtxtMusteriAd = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtMusteriSoyad = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtTCKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtMusteriEklemeMusteriNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnMusteriKayitOlusturma
            // 
            this.btnMusteriKayitOlusturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriKayitOlusturma.Location = new System.Drawing.Point(487, 428);
            this.btnMusteriKayitOlusturma.Name = "btnMusteriKayitOlusturma";
            this.btnMusteriKayitOlusturma.Size = new System.Drawing.Size(329, 74);
            this.btnMusteriKayitOlusturma.TabIndex = 18;
            this.btnMusteriKayitOlusturma.Text = "Kayit Ol";
            this.btnMusteriKayitOlusturma.UseVisualStyleBackColor = true;
            this.btnMusteriKayitOlusturma.Click += new System.EventHandler(this.btnMusteriKayitOlusturma_Click_1);
            // 
            // lblMusteriEklemeMusteriNumarasi
            // 
            this.lblMusteriEklemeMusteriNumarasi.AutoSize = true;
            this.lblMusteriEklemeMusteriNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriEklemeMusteriNumarasi.Location = new System.Drawing.Point(392, 630);
            this.lblMusteriEklemeMusteriNumarasi.Name = "lblMusteriEklemeMusteriNumarasi";
            this.lblMusteriEklemeMusteriNumarasi.Size = new System.Drawing.Size(163, 22);
            this.lblMusteriEklemeMusteriNumarasi.TabIndex = 16;
            this.lblMusteriEklemeMusteriNumarasi.Text = "Müşteri Numaranız:";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyad.Location = new System.Drawing.Point(392, 324);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(61, 22);
            this.lblMusteriSoyad.TabIndex = 14;
            this.lblMusteriSoyad.Text = "Soyad";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAd.Location = new System.Drawing.Point(392, 220);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(32, 22);
            this.lblMusteriAd.TabIndex = 12;
            this.lblMusteriAd.Text = "Ad";
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.AutoSize = true;
            this.lblTCKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKimlikNo.Location = new System.Drawing.Point(392, 127);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(120, 22);
            this.lblTCKimlikNo.TabIndex = 10;
            this.lblTCKimlikNo.Text = "TC Kimlik No:";
            // 
            // mskdtxtMusteriAd
            // 
            this.mskdtxtMusteriAd.Location = new System.Drawing.Point(711, 220);
            this.mskdtxtMusteriAd.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mskdtxtMusteriAd.Name = "mskdtxtMusteriAd";
            this.mskdtxtMusteriAd.Size = new System.Drawing.Size(227, 22);
            this.mskdtxtMusteriAd.TabIndex = 19;
            // 
            // mskdtxtMusteriSoyad
            // 
            this.mskdtxtMusteriSoyad.Location = new System.Drawing.Point(711, 324);
            this.mskdtxtMusteriSoyad.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mskdtxtMusteriSoyad.Name = "mskdtxtMusteriSoyad";
            this.mskdtxtMusteriSoyad.Size = new System.Drawing.Size(227, 22);
            this.mskdtxtMusteriSoyad.TabIndex = 20;
            // 
            // mskdtxtTCKimlikNo
            // 
            this.mskdtxtTCKimlikNo.Location = new System.Drawing.Point(716, 127);
            this.mskdtxtTCKimlikNo.Mask = "00000000000";
            this.mskdtxtTCKimlikNo.Name = "mskdtxtTCKimlikNo";
            this.mskdtxtTCKimlikNo.Size = new System.Drawing.Size(222, 22);
            this.mskdtxtTCKimlikNo.TabIndex = 21;
            this.mskdtxtTCKimlikNo.ValidatingType = typeof(int);
            // 
            // mskdtxtMusteriEklemeMusteriNumarasi
            // 
            this.mskdtxtMusteriEklemeMusteriNumarasi.Location = new System.Drawing.Point(636, 630);
            this.mskdtxtMusteriEklemeMusteriNumarasi.Name = "mskdtxtMusteriEklemeMusteriNumarasi";
            this.mskdtxtMusteriEklemeMusteriNumarasi.ReadOnly = true;
            this.mskdtxtMusteriEklemeMusteriNumarasi.Size = new System.Drawing.Size(273, 22);
            this.mskdtxtMusteriEklemeMusteriNumarasi.TabIndex = 22;
            // 
            // MusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 781);
            this.Controls.Add(this.mskdtxtMusteriEklemeMusteriNumarasi);
            this.Controls.Add(this.mskdtxtTCKimlikNo);
            this.Controls.Add(this.mskdtxtMusteriSoyad);
            this.Controls.Add(this.mskdtxtMusteriAd);
            this.Controls.Add(this.btnMusteriKayitOlusturma);
            this.Controls.Add(this.lblMusteriEklemeMusteriNumarasi);
            this.Controls.Add(this.lblMusteriSoyad);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.lblTCKimlikNo);
            this.Name = "MusteriKayit";
            this.Text = "MusteriKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriKayitOlusturma;
        private System.Windows.Forms.Label lblMusteriEklemeMusteriNumarasi;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtMusteriAd;
        private System.Windows.Forms.MaskedTextBox mskdtxtMusteriSoyad;
        private System.Windows.Forms.MaskedTextBox mskdtxtTCKimlikNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtMusteriEklemeMusteriNumarasi;
    }
}