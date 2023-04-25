
namespace WindowsFormsApp6
{
    partial class MusteriTipiOgrenme
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
            this.btnBireyselMusteriSecimi = new System.Windows.Forms.Button();
            this.btnTicariMusteriSecimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBireyselMusteriSecimi
            // 
            this.btnBireyselMusteriSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBireyselMusteriSecimi.Location = new System.Drawing.Point(809, 241);
            this.btnBireyselMusteriSecimi.Name = "btnBireyselMusteriSecimi";
            this.btnBireyselMusteriSecimi.Size = new System.Drawing.Size(242, 91);
            this.btnBireyselMusteriSecimi.TabIndex = 5;
            this.btnBireyselMusteriSecimi.Text = "Bireysel Müşteriyim";
            this.btnBireyselMusteriSecimi.UseVisualStyleBackColor = true;
            this.btnBireyselMusteriSecimi.Click += new System.EventHandler(this.btnBireyselMusteriSecimi_Click);
            // 
            // btnTicariMusteriSecimi
            // 
            this.btnTicariMusteriSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicariMusteriSecimi.Location = new System.Drawing.Point(318, 241);
            this.btnTicariMusteriSecimi.Name = "btnTicariMusteriSecimi";
            this.btnTicariMusteriSecimi.Size = new System.Drawing.Size(242, 91);
            this.btnTicariMusteriSecimi.TabIndex = 4;
            this.btnTicariMusteriSecimi.Text = "Ticari Müşteriyim";
            this.btnTicariMusteriSecimi.UseVisualStyleBackColor = true;
            this.btnTicariMusteriSecimi.Click += new System.EventHandler(this.btnTicariMusteriSecimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(310, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hangi Tipte Musteri Oldugunuzu Seciniz!";
            // 
            // MusteriTipiOgrenme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 641);
            this.Controls.Add(this.btnBireyselMusteriSecimi);
            this.Controls.Add(this.btnTicariMusteriSecimi);
            this.Controls.Add(this.label1);
            this.Name = "MusteriTipiOgrenme";
            this.Text = "MusteriTipiOgrenme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBireyselMusteriSecimi;
        private System.Windows.Forms.Button btnTicariMusteriSecimi;
        private System.Windows.Forms.Label label1;
    }
}