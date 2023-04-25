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
    public partial class MusteriTipiOgrenme : OrtakKullanilacakKodBloklari
    {
        public MusteriTipiOgrenme()
        {
            InitializeComponent();
        }
        
        private void btnTicariMusteriSecimi_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            MusteriTipi = "Ticari";
            musteriKayit.Show();
            this.Close();
        }

        private void btnBireyselMusteriSecimi_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            MusteriTipi = "Bireysel";
            musteriKayit.Show();
            this.Close();
        }
    }
}
