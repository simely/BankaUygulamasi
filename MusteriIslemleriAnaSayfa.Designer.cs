
namespace WindowsFormsApp6
{
    partial class MusteriIslemleriAnaSayfa
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
            this.MusteriIslemleriMenu = new System.Windows.Forms.MenuStrip();
            this.hesapAçmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraCekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatirmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesabaHavaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapOzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKapatmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriIslemleriMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusteriIslemleriMenu
            // 
            this.MusteriIslemleriMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MusteriIslemleriMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapAçmaToolStripMenuItem,
            this.paraCekmeToolStripMenuItem,
            this.paraYatirmaToolStripMenuItem,
            this.hesabaHavaleToolStripMenuItem,
            this.hesapOzetiToolStripMenuItem,
            this.hesapKapatmaToolStripMenuItem});
            this.MusteriIslemleriMenu.Location = new System.Drawing.Point(0, 0);
            this.MusteriIslemleriMenu.Name = "MusteriIslemleriMenu";
            this.MusteriIslemleriMenu.Size = new System.Drawing.Size(1348, 28);
            this.MusteriIslemleriMenu.TabIndex = 0;
            this.MusteriIslemleriMenu.Text = "Müşteri İşlemleri Menüsü";
            // 
            // hesapAçmaToolStripMenuItem
            // 
            this.hesapAçmaToolStripMenuItem.Name = "hesapAçmaToolStripMenuItem";
            this.hesapAçmaToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.hesapAçmaToolStripMenuItem.Text = "Hesap Acma";
            this.hesapAçmaToolStripMenuItem.Click += new System.EventHandler(this.hesapAçmaToolStripMenuItem_Click);
            // 
            // paraCekmeToolStripMenuItem
            // 
            this.paraCekmeToolStripMenuItem.Name = "paraCekmeToolStripMenuItem";
            this.paraCekmeToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.paraCekmeToolStripMenuItem.Text = "Para Cekme";
            this.paraCekmeToolStripMenuItem.Click += new System.EventHandler(this.paraCekmeToolStripMenuItem_Click);
            // 
            // paraYatirmaToolStripMenuItem
            // 
            this.paraYatirmaToolStripMenuItem.Name = "paraYatirmaToolStripMenuItem";
            this.paraYatirmaToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.paraYatirmaToolStripMenuItem.Text = "Para Yatirma";
            this.paraYatirmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatirmaToolStripMenuItem_Click);
            // 
            // hesabaHavaleToolStripMenuItem
            // 
            this.hesabaHavaleToolStripMenuItem.Name = "hesabaHavaleToolStripMenuItem";
            this.hesabaHavaleToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.hesabaHavaleToolStripMenuItem.Text = "Hesaba Havale";
            this.hesabaHavaleToolStripMenuItem.Click += new System.EventHandler(this.hesabaHavaleToolStripMenuItem_Click);
            // 
            // hesapOzetiToolStripMenuItem
            // 
            this.hesapOzetiToolStripMenuItem.Name = "hesapOzetiToolStripMenuItem";
            this.hesapOzetiToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.hesapOzetiToolStripMenuItem.Text = "Hesap Ozeti";
            this.hesapOzetiToolStripMenuItem.Click += new System.EventHandler(this.hesapOzetiToolStripMenuItem_Click);
            // 
            // hesapKapatmaToolStripMenuItem
            // 
            this.hesapKapatmaToolStripMenuItem.Name = "hesapKapatmaToolStripMenuItem";
            this.hesapKapatmaToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.hesapKapatmaToolStripMenuItem.Text = "Hesap Kapatma";
            this.hesapKapatmaToolStripMenuItem.Click += new System.EventHandler(this.hesapKapatmaToolStripMenuItem_Click);
            // 
            // MusteriIslemleriAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 651);
            this.Controls.Add(this.MusteriIslemleriMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MusteriIslemleriMenu;
            this.Name = "MusteriIslemleriAnaSayfa";
            this.Text = "MusteriIslemleriAnaSayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MusteriIslemleriAnaSayfa_FormClosed);
            this.MusteriIslemleriMenu.ResumeLayout(false);
            this.MusteriIslemleriMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MusteriIslemleriMenu;
        private System.Windows.Forms.ToolStripMenuItem hesapAçmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraCekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatirmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesabaHavaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapOzetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKapatmaToolStripMenuItem;
    }
}