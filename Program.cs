using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VjezbaIspit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console. WriteLine("Upisite vrijednost 1. katete");
      mjau: int a = Convert.ToInt32(Console.ReadLine());
            if(a ==0)
            {
                Console.WriteLine("Upisali ste vrijednost 0 PONOVITE");
                goto mjau;
            }
            Console.WriteLine("Upisite vrijednost 2. katete");
      deam: int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Upisali ste vrijednost 0 PONOVITE");
                goto deam;
            }
            Console.WriteLine("Upisite vrijednost hipotenuze");
    jabuka: int c = Convert.ToInt32(Console.ReadLine());
            if (c == 0)
            {
                Console.WriteLine("Upisali ste vrijednost 0 PONOVITE");
                goto jabuka;
            }
            if (Math.Pow(c,2) == (a*a) + (b*b))
            {
                Console.WriteLine("Trokut je pravokutan ");
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan");
            }

            Console.ReadKey();
        }
    }
}
