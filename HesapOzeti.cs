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
    public partial class HesapOzeti : OrtakKullanilacakKodBloklari
    {
        public HesapOzeti()
        {
            InitializeComponent();
        }

        private void btnGelirGiderGoruntule_Click(object sender, EventArgs e)
        {
            int GelirGiderGoruntuleHesapNumarasi = Convert.ToInt32(mskdtxtHesapOzetiHesapNumarasi.Text);

            for(int i = 0; i < musteriHesaplari.Count; i++)
            {
                if (musteriHesaplari[i].HesapNo == GelirGiderGoruntuleHesapNumarasi)
                {
                    musteriHesaplari[i].HesapOzeti(musteriHesaplari, lvGelirler, lvGiderler, i);

                }
                else
                {
                    MessageBox.Show("Böyle bir hesap bulunmamaktadır!");
                }
            }
        }

        private void HesapOzeti_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
