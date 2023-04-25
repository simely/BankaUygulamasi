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
    public partial class MusteriKayit : OrtakKullanilacakKodBloklari
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }
        
       

        private void btnMusteriKayitOlusturma_Click_1(object sender, EventArgs e)
        {
            MusteriIslemleriAnaSayfa musteriIslemleriAnaSayfa = new MusteriIslemleriAnaSayfa();
            MusteriKayit musteriKayitEkrani = new MusteriKayit();
            banka.MusteriEkle(MusteriTipi, mskdtxtMusteriAd, mskdtxtMusteriEklemeMusteriNumarasi, ticariMusteriler, musteriIslemleriAnaSayfa, bireyselMusteriler,musteriKayitEkrani);
        }
    }
}
