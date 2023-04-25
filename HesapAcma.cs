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
    public partial class HesapAcma : OrtakKullanilacakKodBloklari
    {
        public HesapAcma()
        {
            InitializeComponent();
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ticariMusteriler.Count; i++)
            {
                if (ticariMusteriler.Count > 0 && Convert.ToInt32(mskdtxtMusteriNo.Text) == ticariMusteriler[i].MusteriNo)
                {
                    ticariMusteriler[i].HesapAcma(mskdtxtMusteriNo, mskdtxtHesapNumarasi, musteriHesaplari);
                }
            }
            for (int i = 0; i < bireyselMusteriler.Count; i++)
            {
                if (bireyselMusteriler.Count > 0 && Convert.ToInt32(mskdtxtMusteriNo.Text) == bireyselMusteriler[i].MusteriNo)
                {
                    bireyselMusteriler[i].HesapAcma(mskdtxtMusteriNo, mskdtxtHesapNumarasi, musteriHesaplari);
                }
            }
        }

        private void HesapAcma_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
