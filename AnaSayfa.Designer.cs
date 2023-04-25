
namespace WindowsFormsApp6
{
    partial class AnaSayfa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBankaIslemleri = new System.Windows.Forms.Button();
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Otomasyonu Uygulamasına Hoşgeldiniz!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bankanın Yapacağı İşlemlere Erişmek İçin Buraya Tıklayınız!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(732, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşterilerin Yapacağı İşlemlere Erişmek İçin Buraya Tıklayınız!";
            // 
            // btnBankaIslemleri
            // 
            this.btnBankaIslemleri.Location = new System.Drawing.Point(259, 378);
            this.btnBankaIslemleri.Name = "btnBankaIslemleri";
            this.btnBankaIslemleri.Size = new System.Drawing.Size(208, 69);
            this.btnBankaIslemleri.TabIndex = 3;
            this.btnBankaIslemleri.Text = "Banka İşlemleri";
            this.btnBankaIslemleri.UseVisualStyleBackColor = true;
            this.btnBankaIslemleri.Click += new System.EventHandler(this.btnBankaIslemleri_Click);
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(928, 378);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(208, 69);
            this.btnMusteriIslemleri.TabIndex = 4;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = true;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnMusteriIslemleri_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 649);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Controls.Add(this.btnBankaIslemleri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBankaIslemleri;
        private System.Windows.Forms.Button btnMusteriIslemleri;
    }
}