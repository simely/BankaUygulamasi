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
    public partial class OrtakKullanilacakKodBloklari : Form
    {
        public static int s = 0;
        public static int s2 = 0;
        public static string MusteriTipi;
        public  static int MusteriSayisi = 1;
        public static List<int> MusteriNumaralari = new List<int>();
        public static List<TicariMusteri> ticariMusteriler = new List<TicariMusteri>();
        public static List<BireyselMusteri> bireyselMusteriler = new List<BireyselMusteri>();
        public static Banka banka = new Banka();
        public static List<Hesap> musteriHesaplari = new List<Hesap>();
        public static List<int> ToplamGelir = new List<int>();
        public static List<int> ToplamGider = new List<int>();
        public static bool BankaYaDaMusteriIslemleriAcikMi = false;
        public static bool IslemSayfasiAcikMi = false;
        
        
        
        public OrtakKullanilacakKodBloklari()
        {
            InitializeComponent();
        }
    }
}
