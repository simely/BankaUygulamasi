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
    public partial class BankaIslemleriAnaSayfa : OrtakKullanilacakKodBloklari
    {
        public BankaIslemleriAnaSayfa()
        {
            InitializeComponent();
        }

        private void musteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriListeleme musteriListeleme = new MusteriListeleme();
            musteriListeleme.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
                musteriListeleme.Show();
                IslemSayfasiAcikMi = true;
            }
        }

        private void gelirGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderRaporu gelirGiderRaporu = new GelirGiderRaporu();
            gelirGiderRaporu.MdiParent = this;
            if (IslemSayfasiAcikMi == false)
            {
                gelirGiderRaporu.Show();
                IslemSayfasiAcikMi = true;
            }
        }

        private void BankaIslemleriAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            BankaYaDaMusteriIslemleriAcikMi = false;
        }
    }
}
