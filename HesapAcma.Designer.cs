
namespace WindowsFormsApp6
{
    partial class HesapAcma
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
            this.lblHesapNumarasi = new System.Windows.Forms.Label();
            this.btnHesapOlustur = new System.Windows.Forms.Button();
            this.lblHesapOlusturmaSayfasiBaslik = new System.Windows.Forms.Label();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblMusteriIsim = new System.Windows.Forms.Label();
            this.lblMusteriSoyIsim = new System.Windows.Forms.Label();
            this.mskdtxtMusteriNo = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtMusteriIsim = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtMusteriSoyIsim = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtHesapNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblHesapNumarasi
            // 
            this.lblHesapNumarasi.AutoSize = true;
            this.lblHesapNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNumarasi.Location = new System.Drawing.Point(502, 580);
            this.lblHesapNumarasi.Name = "lblHesapNumarasi";
            this.lblHesapNumarasi.Size = new System.Drawing.Size(144, 20);
            this.lblHesapNumarasi.TabIndex = 0;
            this.lblHesapNumarasi.Text = "Hesap Numaranız";
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.Location = new System.Drawing.Point(586, 454);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(252, 63);
            this.btnHesapOlustur.TabIndex = 2;
            this.btnHesapOlustur.Text = "Hesap Oluştur";
            this.btnHesapOlustur.UseVisualStyleBackColor = true;
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // lblHesapOlusturmaSayfasiBaslik
            // 
            this.lblHesapOlusturmaSayfasiBaslik.AutoSize = true;
            this.lblHesapOlusturmaSayfasiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapOlusturmaSayfasiBaslik.Location = new System.Drawing.Point(397, 21);
            this.lblHesapOlusturmaSayfasiBaslik.Name = "lblHesapOlusturmaSayfasiBaslik";
            this.lblHesapOlusturmaSayfasiBaslik.Size = new System.Drawing.Size(612, 38);
            this.lblHesapOlusturmaSayfasiBaslik.TabIndex = 3;
            this.lblHesapOlusturmaSayfasiBaslik.Text = "Hesap Oluşturma Sayfasına Hoşgeldiniz!";
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriNo.Location = new System.Drawing.Point(506, 135);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(156, 20);
            this.lblMusteriNo.TabIndex = 4;
            this.lblMusteriNo.Text = "Müşteri Numaranız:";
            // 
            // lblMusteriIsim
            // 
            this.lblMusteriIsim.AutoSize = true;
            this.lblMusteriIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriIsim.Location = new System.Drawing.Point(506, 207);
            this.lblMusteriIsim.Name = "lblMusteriIsim";
            this.lblMusteriIsim.Size = new System.Drawing.Size(67, 20);
            this.lblMusteriIsim.TabIndex = 6;
            this.lblMusteriIsim.Text = "İsminiz:";
            // 
            // lblMusteriSoyIsim
            // 
            this.lblMusteriSoyIsim.AutoSize = true;
            this.lblMusteriSoyIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyIsim.Location = new System.Drawing.Point(506, 285);
            this.lblMusteriSoyIsim.Name = "lblMusteriSoyIsim";
            this.lblMusteriSoyIsim.Size = new System.Drawing.Size(100, 20);
            this.lblMusteriSoyIsim.TabIndex = 8;
            this.lblMusteriSoyIsim.Text = "Soy İsminiz:";
            // 
            // mskdtxtMusteriNo
            // 
            this.mskdtxtMusteriNo.Location = new System.Drawing.Point(738, 135);
            this.mskdtxtMusteriNo.Mask = "0000";
            this.mskdtxtMusteriNo.Name = "mskdtxtMusteriNo";
            this.mskdtxtMusteriNo.Size = new System.Drawing.Size(166, 22);
            this.mskdtxtMusteriNo.TabIndex = 10;
            this.mskdtxtMusteriNo.ValidatingType = typeof(int);
            // 
            // mskdtxtMusteriIsim
            // 
            this.mskdtxtMusteriIsim.Location = new System.Drawing.Point(738, 205);
            this.mskdtxtMusteriIsim.Mask = "LLLLLLLLLLLLLLLLLLLLLLL";
            this.mskdtxtMusteriIsim.Name = "mskdtxtMusteriIsim";
            this.mskdtxtMusteriIsim.Size = new System.Drawing.Size(166, 22);
            this.mskdtxtMusteriIsim.TabIndex = 11;
            // 
            // mskdtxtMusteriSoyIsim
            // 
            this.mskdtxtMusteriSoyIsim.Location = new System.Drawing.Point(737, 283);
            this.mskdtxtMusteriSoyIsim.Mask = "LLLLLLLLLLLLLLLLLLLLLLL";
            this.mskdtxtMusteriSoyIsim.Name = "mskdtxtMusteriSoyIsim";
            this.mskdtxtMusteriSoyIsim.Size = new System.Drawing.Size(167, 22);
            this.mskdtxtMusteriSoyIsim.TabIndex = 12;
            // 
            // mskdtxtHesapNumarasi
            // 
            this.mskdtxtHesapNumarasi.Location = new System.Drawing.Point(706, 578);
            this.mskdtxtHesapNumarasi.Name = "mskdtxtHesapNumarasi";
            this.mskdtxtHesapNumarasi.ReadOnly = true;
            this.mskdtxtHesapNumarasi.Size = new System.Drawing.Size(198, 22);
            this.mskdtxtHesapNumarasi.TabIndex = 13;
            // 
            // HesapAcma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 652);
            this.Controls.Add(this.mskdtxtHesapNumarasi);
            this.Controls.Add(this.mskdtxtMusteriSoyIsim);
            this.Controls.Add(this.mskdtxtMusteriIsim);
            this.Controls.Add(this.mskdtxtMusteriNo);
            this.Controls.Add(this.lblMusteriSoyIsim);
            this.Controls.Add(this.lblMusteriIsim);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.lblHesapOlusturmaSayfasiBaslik);
            this.Controls.Add(this.btnHesapOlustur);
            this.Controls.Add(this.lblHesapNumarasi);
            this.Name = "HesapAcma";
            this.Text = "HesapAcma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HesapAcma_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHesapNumarasi;
        private System.Windows.Forms.Button btnHesapOlustur;
        private System.Windows.Forms.Label lblHesapOlusturmaSayfasiBaslik;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblMusteriIsim;
        private System.Windows.Forms.Label lblMusteriSoyIsim;
        private System.Windows.Forms.MaskedTextBox mskdtxtMusteriNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtMusteriIsim;
        private System.Windows.Forms.MaskedTextBox mskdtxtMusteriSoyIsim;
        private System.Windows.Forms.MaskedTextBox mskdtxtHesapNumarasi;
    }
}