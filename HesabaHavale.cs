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
    public partial class HesabaHavale : OrtakKullanilacakKodBloklari
    {
        public HesabaHavale()
        {
            InitializeComponent();
        }

        private void btnHavaleEt_Click(object sender, EventArgs e)
        {
           

            for(int i = 0; i < musteriHesaplari.Count; i++)
            {
                if (Convert.ToInt32(mskdtxtHesabaHavaleHesapNumarasi.Text) == musteriHesaplari[i].HesapNo)
                {
                    for (int k = 0; k <bireyselMusteriler.Count; k++)
                    {
                        if (bireyselMusteriler.Count > 0 && musteriHesaplari[i].AitOlduguMusterininNumarasi == bireyselMusteriler[k].MusteriNo)
                        {
                            if (musteriHesaplari[i].Bakiye >= (Convert.ToInt32(mskdtxtHavaleTutari.Text)) + ((Convert.ToInt32(mskdtxtHavaleTutari.Text)) * 2) / 100)
                            {
                                bireyselMusteriler[k].HesabaHavale(musteriHesaplari, i, mskdtxtHavaleTutari, ToplamGelir);
                                MessageBox.Show("Havale Basari ile Gerceklesti");
                            }
                            else
                            {
                                MessageBox.Show("Hesabinizda Yeterli Bakiye Bulunmamaktadır!");
                            }
                        }
                    }
                    for(int k=0;k<ticariMusteriler.Count;k++)
                    { 
                        if(ticariMusteriler.Count > 0 && musteriHesaplari[i].AitOlduguMusterininNumarasi == ticariMusteriler[k].MusteriNo)
                        {
                            if (musteriHesaplari[i].Bakiye >= Convert.ToInt32(mskdtxtHavaleTutari.Text))
                            {
                                ticariMusteriler[k].HesabaHavale(musteriHesaplari, i, mskdtxtHavaleTutari,ToplamGelir);
                                MessageBox.Show("Havale Basari ile Gerceklesti");
                            }
                            else
                            {
                                MessageBox.Show("Hesabinizda Yeterli Bakiye Bulunmamaktadır!");
                            }
                        }
                    }
                }
            
                else if (Convert.ToInt32(mskdtxtHavaleEdilecekHesap.Text) == musteriHesaplari[i].HesapNo)
                {
                    musteriHesaplari[i].Bakiye += Convert.ToInt32(mskdtxtHavaleTutari.Text);
                }
            }
        }

        private void HesabaHavale_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
