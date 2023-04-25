
namespace WindowsFormsApp6
{
    partial class BankaIslemleriAnaSayfa
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
            this.BankaIslemleriMenu = new System.Windows.Forms.MenuStrip();
            this.musteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BankaIslemleriMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankaIslemleriMenu
            // 
            this.BankaIslemleriMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BankaIslemleriMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriEklemeToolStripMenuItem,
            this.gelirGiderRaporuToolStripMenuItem});
            this.BankaIslemleriMenu.Location = new System.Drawing.Point(0, 0);
            this.BankaIslemleriMenu.Name = "BankaIslemleriMenu";
            this.BankaIslemleriMenu.Size = new System.Drawing.Size(1349, 30);
            this.BankaIslemleriMenu.TabIndex = 0;
            this.BankaIslemleriMenu.Text = "Banka İşlemleri Menüsü";
            // 
            // musteriEklemeToolStripMenuItem
            // 
            this.musteriEklemeToolStripMenuItem.Name = "musteriEklemeToolStripMenuItem";
            this.musteriEklemeToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.musteriEklemeToolStripMenuItem.Text = "Musteri Listeleme";
            this.musteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.musteriEklemeToolStripMenuItem_Click);
            // 
            // gelirGiderRaporuToolStripMenuItem
            // 
            this.gelirGiderRaporuToolStripMenuItem.Name = "gelirGiderRaporuToolStripMenuItem";
            this.gelirGiderRaporuToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.gelirGiderRaporuToolStripMenuItem.Text = "Gelir-Gider Raporu";
            this.gelirGiderRaporuToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderRaporuToolStripMenuItem_Click);
            // 
            // BankaIslemleriAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 640);
            this.Controls.Add(this.BankaIslemleriMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.BankaIslemleriMenu;
            this.Name = "BankaIslemleriAnaSayfa";
            this.Text = "BankaIslemleriAnaSayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankaIslemleriAnaSayfa_FormClosed);
            this.BankaIslemleriMenu.ResumeLayout(false);
            this.BankaIslemleriMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BankaIslemleriMenu;
        private System.Windows.Forms.ToolStripMenuItem musteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderRaporuToolStripMenuItem;
    }
}