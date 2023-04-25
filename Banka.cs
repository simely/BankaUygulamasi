using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class Banka
    {
        public int ToplamParaMiktari { get; set; }
        public int EksilenParaMiktari { get; set; }
        public int GelenParaMiktari { get; set; }

        public void MusteriEkle(string MusteriTipi,MaskedTextBox mskdtxtMusteriAd,MaskedTextBox mskdtxtMusteriEklemeMusteriNumarasi,List<TicariMusteri> ticariMusteriler,MusteriIslemleriAnaSayfa musteriIslemleriAnaSayfa,List<BireyselMusteri>bireyselMusteriler,MusteriKayit musteriKayitEkrani)
        {
            if (MusteriTipi == "Ticari")
            {
                TicariMusteri ticariMusteri = new TicariMusteri();
                ticariMusteri.Adi = mskdtxtMusteriAd.Text;
                mskdtxtMusteriEklemeMusteriNumarasi.Text = ticariMusteri.MusteriNo.ToString();
                ticariMusteriler.Add(ticariMusteri);
                MessageBox.Show(ticariMusteri.MusteriNo.ToString());
                musteriIslemleriAnaSayfa.Show();
                musteriKayitEkrani.Close();




            }
            else if (MusteriTipi == "Bireysel")
            {
                BireyselMusteri bireyselMusteri = new BireyselMusteri();
                bireyselMusteri.Adi = mskdtxtMusteriAd.Text;
                mskdtxtMusteriEklemeMusteriNumarasi.Text = bireyselMusteri.MusteriNo.ToString();
                bireyselMusteriler.Add(bireyselMusteri);
                MessageBox.Show(bireyselMusteri.MusteriNo.ToString());
                musteriIslemleriAnaSayfa.Show();
                musteriKayitEkrani.Close();

            }
            else
            {
                MessageBox.Show("Hatali Giriş");
            }
        }
        public void GelirGiderRaporuGoruntuleme(List<int> ToplamGelir,List<int> ToplamGider,ListView lvGelirTablosu,ListView lvGiderTablosu)
        {
            for (int i = 0; i < ToplamGelir.Count; i++)
            {
                lvGelirTablosu.Items.Add("+ " + ToplamGelir[i] + "TL");
            }
            for (int i = 0; i < ToplamGider.Count; i++)
            {
                lvGiderTablosu.Items.Add("- " + ToplamGider[i] + "TL");
            }
        }
    }
}
