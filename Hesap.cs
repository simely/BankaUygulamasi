using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class Hesap
    {
        public const int paraCekmeLimiti = 750;

        protected int hesapNo;
        public int HesapNo { 
            get 
            {
                return hesapNo;
            }
        }
        public Hesap()
        {
            Random random = new Random();
            hesapNo = random.Next(1, 10001);
            Bakiye = 0;
            
        }
        public  List<int> Giderler { get; set; } = new List<int>();
        public  List<int> Gelirler { get; set; } = new List<int>();
        public int AitOlduguMusterininNumarasi { get; set; }

        public int Bakiye { get; set; }
        



        public void HesapOzeti(List<Hesap> musteriHesaplari, ListView lvGelirler,ListView lvGiderler,int i)
        {
            for (int k = 0; k < musteriHesaplari[i].Gelirler.Count; k++)
            {
                if (musteriHesaplari[i].Gelirler.Count > 0)
                {
                    lvGelirler.Items.Add("+ " + musteriHesaplari[i].Gelirler[k] + "TL");
                }
            }
            for (int k = 0; k < musteriHesaplari[i].Gelirler.Count; k++)
            {
                if (musteriHesaplari[i].Giderler.Count > 0)
                {
                    lvGiderler.Items.Add("- " + musteriHesaplari[i].Giderler[k] + "TL");
                }
                
            }
        }



    }
}
