
namespace WindowsFormsApp6
{
    partial class HesapOzeti
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
            this.lblHesapOzetiHesapNumarasi = new System.Windows.Forms.Label();
            this.lbHesapGelirGiderleri = new System.Windows.Forms.ListBox();
            this.lvGelirler = new System.Windows.Forms.ListView();
            this.lvGiderler = new System.Windows.Forms.ListView();
            this.btnGelirGiderGoruntule = new System.Windows.Forms.Button();
            this.mskdtxtHesapOzetiHesapNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(291, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Özeti Görüntüleme Sayfasına Hoşgeldiniz!";
            // 
            // lblHesapOzetiHesapNumarasi
            // 
            this.lblHesapOzetiHesapNumarasi.AutoSize = true;
            this.lblHesapOzetiHesapNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapOzetiHesapNumarasi.Location = new System.Drawing.Point(293, 175);
            this.lblHesapOzetiHesapNumarasi.Name = "lblHesapOzetiHesapNumarasi";
            this.lblHesapOzetiHesapNumarasi.Size = new System.Drawing.Size(237, 25);
            this.lblHesapOzetiHesapNumarasi.TabIndex = 1;
            this.lblHesapOzetiHesapNumarasi.Text = "Hesap Numaranızı Giriniz:";
            // 
            // lbHesapGelirGiderleri
            // 
            this.lbHesapGelirGiderleri.FormattingEnabled = true;
            this.lbHesapGelirGiderleri.ItemHeight = 16;
            this.lbHesapGelirGiderleri.Location = new System.Drawing.Point(283, 356);
            this.lbHesapGelirGiderleri.Name = "lbHesapGelirGiderleri";
            this.lbHesapGelirGiderleri.Size = new System.Drawing.Size(812, 404);
            this.lbHesapGelirGiderleri.TabIndex = 3;
            // 
            // lvGelirler
            // 
            this.lvGelirler.HideSelection = false;
            this.lvGelirler.Location = new System.Drawing.Point(330, 422);
            this.lvGelirler.Name = "lvGelirler";
            this.lvGelirler.Size = new System.Drawing.Size(288, 316);
            this.lvGelirler.TabIndex = 4;
            this.lvGelirler.UseCompatibleStateImageBehavior = false;
            // 
            // lvGiderler
            // 
            this.lvGiderler.HideSelection = false;
            this.lvGiderler.Location = new System.Drawing.Point(731, 422);
            this.lvGiderler.Name = "lvGiderler";
            this.lvGiderler.Size = new System.Drawing.Size(324, 316);
            this.lvGiderler.TabIndex = 5;
            this.lvGiderler.UseCompatibleStateImageBehavior = false;
            // 
            // btnGelirGiderGoruntule
            // 
            this.btnGelirGiderGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirGiderGoruntule.Location = new System.Drawing.Point(548, 246);
            this.btnGelirGiderGoruntule.Name = "btnGelirGiderGoruntule";
            this.btnGelirGiderGoruntule.Size = new System.Drawing.Size(256, 68);
            this.btnGelirGiderGoruntule.TabIndex = 6;
            this.btnGelirGiderGoruntule.Text = "GÖRÜNTÜLE";
            this.btnGelirGiderGoruntule.UseVisualStyleBackColor = true;
            this.btnGelirGiderGoruntule.Click += new System.EventHandler(this.btnGelirGiderGoruntule_Click);
            // 
            // mskdtxtHesapOzetiHesapNumarasi
            // 
            this.mskdtxtHesapOzetiHesapNumarasi.Location = new System.Drawing.Point(604, 178);
            this.mskdtxtHesapOzetiHesapNumarasi.Mask = "00000";
            this.mskdtxtHesapOzetiHesapNumarasi.Name = "mskdtxtHesapOzetiHesapNumarasi";
            this.mskdtxtHesapOzetiHesapNumarasi.Size = new System.Drawing.Size(360, 22);
            this.mskdtxtHesapOzetiHesapNumarasi.TabIndex = 7;
            this.mskdtxtHesapOzetiHesapNumarasi.ValidatingType = typeof(int);
            // 
            // HesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 791);
            this.Controls.Add(this.mskdtxtHesapOzetiHesapNumarasi);
            this.Controls.Add(this.btnGelirGiderGoruntule);
            this.Controls.Add(this.lvGiderler);
            this.Controls.Add(this.lvGelirler);
            this.Controls.Add(this.lbHesapGelirGiderleri);
            this.Controls.Add(this.lblHesapOzetiHesapNumarasi);
            this.Controls.Add(this.label1);
            this.Name = "HesapOzeti";
            this.Text = "HesapOzeti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HesapOzeti_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHesapOzetiHesapNumarasi;
        private System.Windows.Forms.ListBox lbHesapGelirGiderleri;
        private System.Windows.Forms.ListView lvGelirler;
        private System.Windows.Forms.ListView lvGiderler;
        private System.Windows.Forms.Button btnGelirGiderGoruntule;
        private System.Windows.Forms.MaskedTextBox mskdtxtHesapOzetiHesapNumarasi;
    }
}