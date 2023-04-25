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
    public partial class HesapKapatma : OrtakKullanilacakKodBloklari
    {
        public HesapKapatma()
        {
            InitializeComponent();
        }
        public int SilinmekIstenenHesapNumarasi;
       
        private void btnHesabimiKapat_Click(object sender, EventArgs e)
        {
            SilinmekIstenenHesapNumarasi = Convert.ToInt32(mskdtxtHesapKapatmaHesapNumarasi.Text);
            if (musteriHesaplari.Count > 0)
            {
                for (int i = 0; i < musteriHesaplari.Count; i++)
                {
                    if (SilinmekIstenenHesapNumarasi == musteriHesaplari[i].HesapNo)
                    {
                        if (musteriHesaplari[i].Bakiye == 0)
                        {
                            for(int k = 0; k<ticariMusteriler.Count+bireyselMusteriler.Count;k++)
                            {
                                if(ticariMusteriler.Count>0 && musteriHesaplari[i].AitOlduguMusterininNumarasi== ticariMusteriler[k].MusteriNo)
                                {
                                    ticariMusteriler[k].HesapKapatma(musteriHesaplari, i);
                                }
                                else if (bireyselMusteriler.Count > 0 && musteriHesaplari[i].AitOlduguMusterininNumarasi == bireyselMusteriler[k].MusteriNo) {
                                    bireyselMusteriler[k].HesapKapatma(musteriHesaplari, i);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hesabınızı Silmek Için Hesap Bakiyeniz 0 olmalıdır.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(SilinmekIstenenHesapNumarasi + "numarali bir hesap kaydımız bulunmamaktadır.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bankamızda kayıtlı hesap bulunmamaktadır!");
            }
            
            
        }

        private void HesapKapatma_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
