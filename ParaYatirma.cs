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
    public partial class ParaYatirma : OrtakKullanilacakKodBloklari
    {
        public ParaYatirma()
        {
            InitializeComponent();
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            int ParaYatirmaHesapNumarasi = Convert.ToInt32(mskdtxtParaYatirmaHesapNumarasi.Text);
            int YatirilacakTutar = Convert.ToInt32(mskdtxtYatirilacakTutar.Text);

            for (int k = 0; k <bireyselMusteriler.Count; k++)
            {
                if (bireyselMusteriler.Count > 0 && musteriHesaplari[k].AitOlduguMusterininNumarasi == bireyselMusteriler[k].MusteriNo)
                {
                    bireyselMusteriler[k].ParaYatirma(musteriHesaplari, ParaYatirmaHesapNumarasi, YatirilacakTutar, s2, ToplamGelir);
                }
            }
            for(int k = 0;k<ticariMusteriler.Count;k++)
            {
                if (ticariMusteriler.Count > 0 && musteriHesaplari[k].AitOlduguMusterininNumarasi == ticariMusteriler[k].MusteriNo && ticariMusteriler.Count > 0)
                {
                    ticariMusteriler[k].ParaYatirma(musteriHesaplari, ParaYatirmaHesapNumarasi, YatirilacakTutar, s2, ToplamGelir);
                }
            }
                
              
        }

        private void ParaYatirma_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
