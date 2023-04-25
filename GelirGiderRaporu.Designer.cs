
namespace WindowsFormsApp6
{
    partial class GelirGiderRaporu
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
            this.lblGelirGiderRaporuBaslik = new System.Windows.Forms.Label();
            this.lbGelirGiderTablosu = new System.Windows.Forms.ListBox();
            this.lvGelirTablosu = new System.Windows.Forms.ListView();
            this.lvGiderTablosu = new System.Windows.Forms.ListView();
            this.lblGelir = new System.Windows.Forms.Label();
            this.lblGiderTablosu = new System.Windows.Forms.Label();
            this.btnGelirGiderGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGelirGiderRaporuBaslik
            // 
            this.lblGelirGiderRaporuBaslik.AutoSize = true;
            this.lblGelirGiderRaporuBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirGiderRaporuBaslik.Location = new System.Drawing.Point(282, 33);
            this.lblGelirGiderRaporuBaslik.Name = "lblGelirGiderRaporuBaslik";
            this.lblGelirGiderRaporuBaslik.Size = new System.Drawing.Size(735, 38);
            this.lblGelirGiderRaporuBaslik.TabIndex = 0;
            this.lblGelirGiderRaporuBaslik.Text = "Banka Gelir-Gider Raporu Sayfasına Hoşgeldiniz!";
            // 
            // lbGelirGiderTablosu
            // 
            this.lbGelirGiderTablosu.FormattingEnabled = true;
            this.lbGelirGiderTablosu.ItemHeight = 16;
            this.lbGelirGiderTablosu.Location = new System.Drawing.Point(298, 241);
            this.lbGelirGiderTablosu.Name = "lbGelirGiderTablosu";
            this.lbGelirGiderTablosu.Size = new System.Drawing.Size(758, 500);
            this.lbGelirGiderTablosu.TabIndex = 1;
            // 
            // lvGelirTablosu
            // 
            this.lvGelirTablosu.HideSelection = false;
            this.lvGelirTablosu.Location = new System.Drawing.Point(379, 303);
            this.lvGelirTablosu.Name = "lvGelirTablosu";
            this.lvGelirTablosu.Size = new System.Drawing.Size(160, 397);
            this.lvGelirTablosu.TabIndex = 2;
            this.lvGelirTablosu.UseCompatibleStateImageBehavior = false;
            // 
            // lvGiderTablosu
            // 
            this.lvGiderTablosu.HideSelection = false;
            this.lvGiderTablosu.Location = new System.Drawing.Point(823, 303);
            this.lvGiderTablosu.Name = "lvGiderTablosu";
            this.lvGiderTablosu.Size = new System.Drawing.Size(155, 397);
            this.lvGiderTablosu.TabIndex = 3;
            this.lvGiderTablosu.UseCompatibleStateImageBehavior = false;
            // 
            // lblGelir
            // 
            this.lblGelir.AutoSize = true;
            this.lblGelir.Location = new System.Drawing.Point(376, 273);
            this.lblGelir.Name = "lblGelir";
            this.lblGelir.Size = new System.Drawing.Size(93, 17);
            this.lblGelir.TabIndex = 4;
            this.lblGelir.Text = "Gelir Tablosu";
            // 
            // lblGiderTablosu
            // 
            this.lblGiderTablosu.AutoSize = true;
            this.lblGiderTablosu.Location = new System.Drawing.Point(820, 273);
            this.lblGiderTablosu.Name = "lblGiderTablosu";
            this.lblGiderTablosu.Size = new System.Drawing.Size(98, 17);
            this.lblGiderTablosu.TabIndex = 5;
            this.lblGiderTablosu.Text = "Gider Tablosu";
            // 
            // btnGelirGiderGoruntule
            // 
            this.btnGelirGiderGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirGiderGoruntule.Location = new System.Drawing.Point(558, 128);
            this.btnGelirGiderGoruntule.Name = "btnGelirGiderGoruntule";
            this.btnGelirGiderGoruntule.Size = new System.Drawing.Size(288, 53);
            this.btnGelirGiderGoruntule.TabIndex = 6;
            this.btnGelirGiderGoruntule.Text = "GÖRÜNTÜLE";
            this.btnGelirGiderGoruntule.UseVisualStyleBackColor = true;
            this.btnGelirGiderGoruntule.Click += new System.EventHandler(this.btnGelirGiderGoruntule_Click);
            // 
            // GelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 784);
            this.Controls.Add(this.btnGelirGiderGoruntule);
            this.Controls.Add(this.lblGiderTablosu);
            this.Controls.Add(this.lblGelir);
            this.Controls.Add(this.lvGiderTablosu);
            this.Controls.Add(this.lvGelirTablosu);
            this.Controls.Add(this.lbGelirGiderTablosu);
            this.Controls.Add(this.lblGelirGiderRaporuBaslik);
            this.Name = "GelirGiderRaporu";
            this.Text = "GelirGiderRaporu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GelirGiderRaporu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGelirGiderRaporuBaslik;
        private System.Windows.Forms.ListBox lbGelirGiderTablosu;
        private System.Windows.Forms.ListView lvGelirTablosu;
        private System.Windows.Forms.ListView lvGiderTablosu;
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Label lblGiderTablosu;
        private System.Windows.Forms.Button btnGelirGiderGoruntule;
    }
}