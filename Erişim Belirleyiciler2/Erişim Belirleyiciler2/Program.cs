using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Belirleyiciler2
{
    internal class Program
    {
        class Arac
        {
            public string Marka;
            private string MotorNo;
            protected int Hiz;
            internal string Renk;

            public Arac(string marka, string motorNo, int hiz, string renk)
            {
                Marka = marka;
                MotorNo = motorNo;
                Hiz = hiz;
                Renk = renk;
            }

            public void AracBilgi()
            {
                Console.WriteLine($"Marka: {Marka}, MotorNo: {MotorNo}, Hız: {Hiz}, Renk: {Renk}");
            }
        }

        class Araba : Arac
        {
            public Araba(string marka, string motorNo, int hiz, string renk)
                : base(marka, motorNo, hiz, renk) { }

            public void HizArtir()
            {
                Hiz += 10; // protected erişilebilir
                Console.WriteLine($"Yeni hız: {Hiz}");
            }
        }
        static void Main(string[] args)
        {
            Araba araba1 = new Araba("BMW", "XYZ123", 120, "Siyah");
            araba1.AracBilgi();
            araba1.HizArtir();

            Console.WriteLine($"Renk: {araba1.Renk}");
            Console.WriteLine($"Marka: {araba1.Marka}");

            // araba1.MotorNo → private olduğu için erişilemez
            // araba1.Hiz → protected olduğu için burada erişilemez
        }
    }
}
