using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class BireyselMusteri : Musteri
    {
        public const double HavaleKesintisi = 2.5;

        public BireyselMusteri()
        {
            Random random = new Random();
            musteriNo = random.Next(1, 1001);
            
        }
        public override void HesabaHavale(List<Hesap> musterihesaplari, int i , MaskedTextBox mskdtxtHavaleTutari , List<int> ToplamGelir)
        {
            base.HesabaHavale(musterihesaplari, i, mskdtxtHavaleTutari,ToplamGelir);
            musterihesaplari[i].Bakiye -= (Convert.ToInt32(mskdtxtHavaleTutari.Text) * 2) / 100;
            ToplamGelir.Add((Convert.ToInt32(mskdtxtHavaleTutari.Text) * 2) / 100);
            
        }
    }
}
