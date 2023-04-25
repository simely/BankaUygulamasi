using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class Musteri
    {
        protected int musteriNo;

        public string Adi { get; set; }
        public int MusteriNo { 
            get
            {
                return musteriNo;
            } 
        }
        public Hesap MusteriHesabi { get; set; }

        public Musteri()
        {
            
        }
        public void HesapAcma(MaskedTextBox mskdtxtMusteriNo,MaskedTextBox mskdtxtHesapNumarasi,List<Hesap>musteriHesaplari)
        {
            Hesap hesap = new Hesap();
            hesap.AitOlduguMusterininNumarasi = Convert.ToInt32(mskdtxtMusteriNo.Text);
            mskdtxtHesapNumarasi.Text = hesap.HesapNo.ToString();
            musteriHesaplari.Add(hesap);
        }
        public void ParaCekme(List<Hesap>musteriHesaplari,int ParaCekmeHesapNumarasi,int CekilecekTutar,int s,List<int> ToplamGider)
        {
            for (int i = 0; i < musteriHesaplari.Count; i++)
            {


                if (ParaCekmeHesapNumarasi == musteriHesaplari[i].HesapNo)
                {
                    if (CekilecekTutar < 750 && CekilecekTutar > 0)
                    {

                        if (musteriHesaplari[i].Bakiye >= CekilecekTutar)
                        {
                            musteriHesaplari[i].Bakiye -= CekilecekTutar;
                            musteriHesaplari[i].Giderler.Add(CekilecekTutar);
                            ToplamGider.Add(CekilecekTutar);
                            
                            MessageBox.Show("Para Çekme Başarılı!\n " + musteriHesaplari[i].HesapNo + " numarali hesabin yeni bakiyesi: " + musteriHesaplari[i].Bakiye);
                        }
                        else
                        {
                            MessageBox.Show("Cekilmek istenen tutar hesap bakiyesinden büyük olamaz!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir gün içinde 750TL'den fazla Para Cekemezsiniz!");
                    }
                }
            }
        }
        public void ParaYatirma(List<Hesap> musteriHesaplari , int ParaYatirmaHesapNumarasi , int YatirilacakTutar,int s2,List<int> ToplamGelir)
        {
            for (int i = 0; i < musteriHesaplari.Count; i++)
            {
                if (ParaYatirmaHesapNumarasi == musteriHesaplari[i].HesapNo)
                {
                    musteriHesaplari[i].Bakiye += YatirilacakTutar;
                    musteriHesaplari[i].Gelirler.Add(YatirilacakTutar);
                    ToplamGelir.Add(YatirilacakTutar);
                    
                    s2++;
                    MessageBox.Show("Para yatirma basarili!\n" + musteriHesaplari[i].HesapNo + "Numarali hesabin yeni bakiyesi : " + musteriHesaplari[i].Bakiye);
                }
            }
        }
        public virtual void HesabaHavale(List<Hesap> musteriHesaplari,int i,MaskedTextBox mskdtxtHavaleTutari,List<int> ToplamGelir)
        {
            musteriHesaplari[i].Bakiye -= Convert.ToInt32(mskdtxtHavaleTutari.Text);
        }
        public void HesapKapatma(List<Hesap>musteriHesaplari,int i)
        {
            MessageBox.Show(musteriHesaplari[i].HesapNo + "numarali hesap kapatılmıştır");
            musteriHesaplari.RemoveAt(i);
        }
    }
}
