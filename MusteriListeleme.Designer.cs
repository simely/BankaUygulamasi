
namespace WindowsFormsApp6
{
    partial class MusteriListeleme
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
            this.lblMusteriListelemeBaslik = new System.Windows.Forms.Label();
            this.lbMusteriListeleri = new System.Windows.Forms.ListBox();
            this.lvBireyselMusteriListesi = new System.Windows.Forms.ListView();
            this.BireyselMusteriler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTicariMusteriListesi = new System.Windows.Forms.ListView();
            this.TicariMusteriler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMusterileriListele = new System.Windows.Forms.Button();
            this.lblBireysel = new System.Windows.Forms.Label();
            this.lblTicari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMusteriListelemeBaslik
            // 
            this.lblMusteriListelemeBaslik.AutoSize = true;
            this.lblMusteriListelemeBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriListelemeBaslik.Location = new System.Drawing.Point(352, 9);
            this.lblMusteriListelemeBaslik.Name = "lblMusteriListelemeBaslik";
            this.lblMusteriListelemeBaslik.Size = new System.Drawing.Size(621, 38);
            this.lblMusteriListelemeBaslik.TabIndex = 0;
            this.lblMusteriListelemeBaslik.Text = "Müşteri Listeleme Sayfasina Hoşgeldiniz!!";
            // 
            // lbMusteriListeleri
            // 
            this.lbMusteriListeleri.FormattingEnabled = true;
            this.lbMusteriListeleri.ItemHeight = 16;
            this.lbMusteriListeleri.Location = new System.Drawing.Point(239, 176);
            this.lbMusteriListeleri.Name = "lbMusteriListeleri";
            this.lbMusteriListeleri.Size = new System.Drawing.Size(905, 596);
            this.lbMusteriListeleri.TabIndex = 1;
            // 
            // lvBireyselMusteriListesi
            // 
            this.lvBireyselMusteriListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BireyselMusteriler});
            this.lvBireyselMusteriListesi.HideSelection = false;
            this.lvBireyselMusteriListesi.Location = new System.Drawing.Point(293, 261);
            this.lvBireyselMusteriListesi.Name = "lvBireyselMusteriListesi";
            this.lvBireyselMusteriListesi.Size = new System.Drawing.Size(343, 461);
            this.lvBireyselMusteriListesi.TabIndex = 2;
            this.lvBireyselMusteriListesi.UseCompatibleStateImageBehavior = false;
            this.lvBireyselMusteriListesi.View = System.Windows.Forms.View.List;
            // 
            // BireyselMusteriler
            // 
            this.BireyselMusteriler.Width = 339;
            // 
            // lvTicariMusteriListesi
            // 
            this.lvTicariMusteriListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TicariMusteriler});
            this.lvTicariMusteriListesi.HideSelection = false;
            this.lvTicariMusteriListesi.Location = new System.Drawing.Point(741, 261);
            this.lvTicariMusteriListesi.Name = "lvTicariMusteriListesi";
            this.lvTicariMusteriListesi.Size = new System.Drawing.Size(343, 461);
            this.lvTicariMusteriListesi.TabIndex = 3;
            this.lvTicariMusteriListesi.UseCompatibleStateImageBehavior = false;
            this.lvTicariMusteriListesi.View = System.Windows.Forms.View.List;
            // 
            // TicariMusteriler
            // 
            this.TicariMusteriler.Width = 341;
            // 
            // btnMusterileriListele
            // 
            this.btnMusterileriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusterileriListele.Location = new System.Drawing.Point(567, 82);
            this.btnMusterileriListele.Name = "btnMusterileriListele";
            this.btnMusterileriListele.Size = new System.Drawing.Size(236, 58);
            this.btnMusterileriListele.TabIndex = 6;
            this.btnMusterileriListele.Text = "Müşterileri Listele";
            this.btnMusterileriListele.UseVisualStyleBackColor = true;
            this.btnMusterileriListele.Click += new System.EventHandler(this.btnMusterileriListele_Click);
            // 
            // lblBireysel
            // 
            this.lblBireysel.AutoSize = true;
            this.lblBireysel.Location = new System.Drawing.Point(290, 226);
            this.lblBireysel.Name = "lblBireysel";
            this.lblBireysel.Size = new System.Drawing.Size(117, 16);
            this.lblBireysel.TabIndex = 7;
            this.lblBireysel.Text = "Bireysel Müşteriler";
            // 
            // lblTicari
            // 
            this.lblTicari.AutoSize = true;
            this.lblTicari.Location = new System.Drawing.Point(738, 226);
            this.lblTicari.Name = "lblTicari";
            this.lblTicari.Size = new System.Drawing.Size(102, 16);
            this.lblTicari.TabIndex = 8;
            this.lblTicari.Text = "Ticari Müşteriler";
            // 
            // MusteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 787);
            this.Controls.Add(this.lblTicari);
            this.Controls.Add(this.lblBireysel);
            this.Controls.Add(this.btnMusterileriListele);
            this.Controls.Add(this.lvTicariMusteriListesi);
            this.Controls.Add(this.lvBireyselMusteriListesi);
            this.Controls.Add(this.lbMusteriListeleri);
            this.Controls.Add(this.lblMusteriListelemeBaslik);
            this.Name = "MusteriListeleme";
            this.Text = "MusteriEkleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MusteriListeleme_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriListelemeBaslik;
        private System.Windows.Forms.ListBox lbMusteriListeleri;
        private System.Windows.Forms.ListView lvBireyselMusteriListesi;
        private System.Windows.Forms.ListView lvTicariMusteriListesi;
        private System.Windows.Forms.Button btnMusterileriListele;
        private System.Windows.Forms.ColumnHeader BireyselMusteriler;
        private System.Windows.Forms.ColumnHeader TicariMusteriler;
        private System.Windows.Forms.Label lblBireysel;
        private System.Windows.Forms.Label lblTicari;
    }
}