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
    public partial class MusteriListeleme : OrtakKullanilacakKodBloklari
    {
        public MusteriListeleme()
        {
            InitializeComponent();
        }

        private void btnMusterileriListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bireyselMusteriler.Count; i++)
            {
                lvBireyselMusteriListesi.Items.Add("Müşteri Numarası: "+ bireyselMusteriler[i].MusteriNo.ToString()+"     "+"Adı: "+bireyselMusteriler[i].Adi);
            }

            for(int i = 0;  i < ticariMusteriler.Count; i++)
            {
                lvTicariMusteriListesi.Items.Add("Müşteri Numarası: "+ ticariMusteriler[i].MusteriNo.ToString()+"     "+"Adı: "+ticariMusteriler[i].Adi);
            } 
        }

        private void MusteriListeleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            IslemSayfasiAcikMi = false;
        }
    }
}
