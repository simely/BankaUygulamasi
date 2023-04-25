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
    public partial class ParaCekme : OrtakKullanilacakKodBloklari
    {
        public ParaCekme()
        {
            InitializeComponent();
        }
       
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            int ParaCekmeHesapNumarasi = Convert.ToInt32(mskdtxtParaCekmeHesapNumarasi.Text);
            int CekilecekTutar = Convert.ToInt32(mskdtxtCekilecekTutar.Text);

            for (int k = 0; k <bireyselMusteriler.Count; k++)
            {
                if (bireyselMusteriler.Count > 0 && musteriHesaplari[k].AitOlduguMusterininNumarasi == bireyselMusteriler[k].MusteriNo)
                {
                    bireyselMusteriler[k].ParaCekme(musteriHesaplari, ParaCekmeHesapNumarasi, CekilecekTutar, s, ToplamGider);
                }
            }
            for(int k=0; k<ticariMusteriler.Count;k++)
            {
                if (ticariMusteriler.Count > 0 && musteriHesaplari[k].AitOlduguMusterininNumarasi == ticariMusteriler[k].MusteriNo && ticariMusteriler.Count > 0)
                {
                    ticariMusteriler[k].ParaCekme(musteriHesaplari, ParaCekmeHesapNumarasi, CekilecekTutar, s, ToplamGider);
                }
            }

                
               
        }

        private void ParaCekme_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
