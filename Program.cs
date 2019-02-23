using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolKombinasyonu
{
    class Program
    {
        public static string dogru = "t";
        public static string yanlis = "f";
        public static int u;
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet True, False için tüm kombinasyonları görmek istiyorsunuz?");
            u = Convert.ToInt32(Console.ReadLine());
            if (u != 0)
            BoolKombinasyonu(u, "");
            Console.ReadKey();
        }
        static void BoolKombinasyonu(int n, string a)
        {
            if (n > 0)
            {
                BoolKombinasyonu(n - 1, a + "t");
                BoolKombinasyonu(n - 1, a + "f");
                return;
            }
            Console.WriteLine(a);
        }
    }
}
