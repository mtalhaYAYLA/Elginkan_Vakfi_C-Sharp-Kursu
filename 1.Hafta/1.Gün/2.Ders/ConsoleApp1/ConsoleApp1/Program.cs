// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            byte a = 5;
            bool b = true;
            double c = 5.5;
            float d = 5.5f;
            decimal e = 5.5m;
            char f = 'a';
            string g = "a";
            int h = 5;
            long i = 5;
            short j = 5;
            uint k = 5;
            ulong l = 5;
            ushort m = 5;
            object n = 5;

            double x = 5;
            double y = 5.5;
            int toplam;

            toplam = (int)(x + y);
            toplam = Convert.ToInt32(x + y);
            toplam = (int)x + (int)y;
            toplam = (int)x + Convert.ToInt32(y);
            toplam = Convert.ToInt32(x) + (int)y;
            toplam = Convert.ToInt32(x) + Convert.ToInt32(y);

            toplam = int.Parse(x.ToString()) + int.Parse(y.ToString());
            toplam = int.Parse(x.ToString()) + (int)y;
            toplam = (int)x + int.Parse(y.ToString());
            

            Console.WriteLine("Hello World!  "+toplam);
            Console.WriteLine("Hello World!  "+sizeof(byte));
        }
    }
}
