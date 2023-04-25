
namespace WindowsFormsApp6
{
    partial class HesabaHavale
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
            this.lblHesabaHavaleHesapNumarasi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHavaleEdilecekTutar = new System.Windows.Forms.Label();
            this.btnHavaleEt = new System.Windows.Forms.Button();
            this.mskdtxtHesabaHavaleHesapNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtHavaleEdilecekHesap = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtHavaleTutari = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblHesabaHavaleHesapNumarasi
            // 
            this.lblHesabaHavaleHesapNumarasi.AutoSize = true;
            this.lblHesabaHavaleHesapNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesabaHavaleHesapNumarasi.Location = new System.Drawing.Point(114, 150);
            this.lblHesabaHavaleHesapNumarasi.Name = "lblHesabaHavaleHesapNumarasi";
            this.lblHesabaHavaleHesapNumarasi.Size = new System.Drawing.Size(237, 25);
            this.lblHesabaHavaleHesapNumarasi.TabIndex = 0;
            this.lblHesabaHavaleHesapNumarasi.Text = "Hesap Numaranızı Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(637, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Havale Edeceğiniz Hesabın Numarasını Giriniz:";
            // 
            // lblHavaleEdilecekTutar
            // 
            this.lblHavaleEdilecekTutar.AutoSize = true;
            this.lblHavaleEdilecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHavaleEdilecekTutar.Location = new System.Drawing.Point(572, 296);
            this.lblHavaleEdilecekTutar.Name = "lblHavaleEdilecekTutar";
            this.lblHavaleEdilecekTutar.Size = new System.Drawing.Size(101, 25);
            this.lblHavaleEdilecekTutar.TabIndex = 4;
            this.lblHavaleEdilecekTutar.Text = "Tutar (TL)";
            // 
            // btnHavaleEt
            // 
            this.btnHavaleEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavaleEt.Location = new System.Drawing.Point(577, 498);
            this.btnHavaleEt.Name = "btnHavaleEt";
            this.btnHavaleEt.Size = new System.Drawing.Size(268, 73);
            this.btnHavaleEt.TabIndex = 6;
            this.btnHavaleEt.Text = "Havale ET!";
            this.btnHavaleEt.UseVisualStyleBackColor = true;
            this.btnHavaleEt.Click += new System.EventHandler(this.btnHavaleEt_Click);
            // 
            // mskdtxtHesabaHavaleHesapNumarasi
            // 
            this.mskdtxtHesabaHavaleHesapNumarasi.Location = new System.Drawing.Point(370, 154);
            this.mskdtxtHesabaHavaleHesapNumarasi.Mask = "00000";
            this.mskdtxtHesabaHavaleHesapNumarasi.Name = "mskdtxtHesabaHavaleHesapNumarasi";
            this.mskdtxtHesabaHavaleHesapNumarasi.Size = new System.Drawing.Size(130, 22);
            this.mskdtxtHesabaHavaleHesapNumarasi.TabIndex = 7;
            this.mskdtxtHesabaHavaleHesapNumarasi.ValidatingType = typeof(int);
            // 
            // mskdtxtHavaleEdilecekHesap
            // 
            this.mskdtxtHavaleEdilecekHesap.Location = new System.Drawing.Point(1071, 154);
            this.mskdtxtHavaleEdilecekHesap.Mask = "00000";
            this.mskdtxtHavaleEdilecekHesap.Name = "mskdtxtHavaleEdilecekHesap";
            this.mskdtxtHavaleEdilecekHesap.Size = new System.Drawing.Size(132, 22);
            this.mskdtxtHavaleEdilecekHesap.TabIndex = 8;
            this.mskdtxtHavaleEdilecekHesap.ValidatingType = typeof(int);
            // 
            // mskdtxtHavaleTutari
            // 
            this.mskdtxtHavaleTutari.Location = new System.Drawing.Point(688, 300);
            this.mskdtxtHavaleTutari.Mask = "0000000000000";
            this.mskdtxtHavaleTutari.Name = "mskdtxtHavaleTutari";
            this.mskdtxtHavaleTutari.Size = new System.Drawing.Size(100, 22);
            this.mskdtxtHavaleTutari.TabIndex = 9;
            this.mskdtxtHavaleTutari.ValidatingType = typeof(int);
            // 
            // HesabaHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 782);
            this.Controls.Add(this.mskdtxtHavaleTutari);
            this.Controls.Add(this.mskdtxtHavaleEdilecekHesap);
            this.Controls.Add(this.mskdtxtHesabaHavaleHesapNumarasi);
            this.Controls.Add(this.btnHavaleEt);
            this.Controls.Add(this.lblHavaleEdilecekTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHesabaHavaleHesapNumarasi);
            this.Name = "HesabaHavale";
            this.Text = "HesabaHavale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HesabaHavale_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHesabaHavaleHesapNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHavaleEdilecekTutar;
        private System.Windows.Forms.Button btnHavaleEt;
        private System.Windows.Forms.MaskedTextBox mskdtxtHesabaHavaleHesapNumarasi;
        private System.Windows.Forms.MaskedTextBox mskdtxtHavaleEdilecekHesap;
        private System.Windows.Forms.MaskedTextBox mskdtxtHavaleTutari;
    }
}