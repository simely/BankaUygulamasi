using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class MusteriIslemleriAnaSayfa : OrtakKullanilacakKodBloklari
    {
        public MusteriIslemleriAnaSayfa()
        {
            InitializeComponent();
        }

        private void hesapAçmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapAcma hesapAcma = new HesapAcma();
            hesapAcma.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
                hesapAcma.Show();
                IslemSayfasiAcikMi = true;
            }
  
        }

        private void paraCekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaCekme paraCekme = new ParaCekme();
            paraCekme.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
                paraCekme.Show();
                IslemSayfasiAcikMi = true;
            }
        }

        private void paraYatirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaYatirma paraYatirma = new ParaYatirma();
            paraYatirma.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
                paraYatirma.Show();
                IslemSayfasiAcikMi = true;
            }
        }

        private void hesabaHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesabaHavale hesabaHavale = new HesabaHavale();
            hesabaHavale.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
               hesabaHavale.Show();
                IslemSayfasiAcikMi = true;
            }
        }

        private void hesapOzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapOzeti hesapOzeti = new HesapOzeti();
            hesapOzeti.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
                hesapOzeti.Show();
                IslemSayfasiAcikMi = true;
            }
;        }

        private void hesapKapatmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapKapatma hesapKapatma = new HesapKapatma();
            hesapKapatma.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
                hesapKapatma.Show();
                IslemSayfasiAcikMi = true;
            }
        }

        private void MusteriIslemleriAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            BankaYaDaMusteriIslemleriAcikMi = false;
        }
    }
}
