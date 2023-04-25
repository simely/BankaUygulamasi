using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class TicariMusteri : Musteri
    {
        public TicariMusteri()
        {
            Random random = new Random();
            musteriNo = random.Next(1, 1001);
            
        }
        public override void HesabaHavale(List<Hesap> hesapNumaralari , int i ,MaskedTextBox mskdtxtHavaleTutari,List<int> ToplamGelir)
        {
           base.HesabaHavale(hesapNumaralari , i,mskdtxtHavaleTutari,ToplamGelir);
       }
    }
}
