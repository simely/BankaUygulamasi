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
    public partial class GelirGiderRaporu : OrtakKullanilacakKodBloklari
    {
        public GelirGiderRaporu()
        {
            InitializeComponent();
        }

        private void btnGelirGiderGoruntule_Click(object sender, EventArgs e)
        {
            banka.GelirGiderRaporuGoruntuleme(ToplamGelir, ToplamGider, lvGelirTablosu, lvGiderTablosu);

        }

        private void GelirGiderRaporu_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
