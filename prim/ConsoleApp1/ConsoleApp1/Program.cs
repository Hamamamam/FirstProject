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
            /*
            Console.WriteLine("Írjon be egy számot!");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            int prim;
            if (n % i == 0)
            {
                n != prim;

           }
            if (n<2)
            {
                n != prim;
            }
            if (n = prim)
            {
                Console.WriteLine("Prímszám!");
                else
                 Console.WriteLine("Nem prímszám!");
                Console.ReadLine();
            }
            */
            double szam;
            bool prime = true;
            Console.WriteLine("Mi a szám?");
            szam = double.Parse(Console.ReadLine());
            for (int i=2; i<=Math.Sqrt(szam); i++)  // ciklus indítunk, ami egészen a négyzetgyökéig számol(eggyel növeljük a i++
            {
                if (szam % i == 0) {                    //osztási maradékot néz
                    prime = false;
                }
            }
            if (szam < 2) prime = false;
            if (prime)
            {
                Console.WriteLine("Prim");
            }
            else {
                Console.WriteLine("Nem prim");
            }
            Console.ReadLine();
            return;
        }
    }
}
