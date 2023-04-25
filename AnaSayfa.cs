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
    public partial class AnaSayfa : OrtakKullanilacakKodBloklari
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnBankaIslemleri_Click(object sender, EventArgs e)
        {
            BankaIslemleriAnaSayfa bankaIslemleriAnaSayfa = new BankaIslemleriAnaSayfa();

            if (BankaYaDaMusteriIslemleriAcikMi == false)
            {
                bankaIslemleriAnaSayfa.Show();
                BankaYaDaMusteriIslemleriAcikMi = true;
            }
        }    


        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            GirisYapKaydolSayfasi girisYapKaydolSayfasi = new GirisYapKaydolSayfasi();
            if (BankaYaDaMusteriIslemleriAcikMi == false)
            {
                girisYapKaydolSayfasi.Show();
                BankaYaDaMusteriIslemleriAcikMi = true;
            }
        }
    }
}
