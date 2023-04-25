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
    public partial class GirisYapKaydolSayfasi : OrtakKullanilacakKodBloklari
    {
        public GirisYapKaydolSayfasi()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
           
            for(int i = 0; i < bireyselMusteriler.Count + ticariMusteriler.Count;i++)
            {
                if (bireyselMusteriler.Count>0 && bireyselMusteriler[i].MusteriNo == Convert.ToInt32(mskdtxtGirisYapMusteriNo.Text))
                {
                    MessageBox.Show("Basari ile Giriş Yaptınız!");
                    MusteriIslemleriAnaSayfa musteriIslemleriAnaSayfa = new MusteriIslemleriAnaSayfa();
                    musteriIslemleriAnaSayfa.Show();
                    this.Close();
                }
                else if (ticariMusteriler.Count>0 && ticariMusteriler[i].MusteriNo == Convert.ToInt32(mskdtxtGirisYapMusteriNo.Text))
                {
                    MessageBox.Show("Basari ile Giriş Yaptınız!");
                    MusteriIslemleriAnaSayfa musteriIslemleriAnaSayfa = new MusteriIslemleriAnaSayfa();
                    musteriIslemleriAnaSayfa.Show();
                    this.Close();
                }
            }
        }

        private void btnKayitOlmayaGit_Click(object sender, EventArgs e)
        {
            MusteriTipiOgrenme musteriTipiOgrenme = new MusteriTipiOgrenme();
            musteriTipiOgrenme.Show();
            this.Close();
        }
    }
}
