using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elso tag");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Masodik tag");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Harmadik tag");
            int c = int.Parse(Console.ReadLine());
            double eredmeny1 = 0;
            double eredmeny2 = 0;
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d == 0)
            {
                eredmeny1 = -b / 2 * a;
                Console.WriteLine(eredmeny1);

            }
            else if (d > 0)
            {
                eredmeny1 = -b / 2 * a;
                Console.WriteLine(eredmeny1);
                eredmeny1 = -b + Math.Sqrt(d) / 2 * a;
                eredmeny2 = -b - Math.Sqrt(d) / 2 * a;
                Console.WriteLine("Elso erteke: " + eredmeny1 + "; masik erteke: " + eredmeny2);


            }
            else
            {
                Console.WriteLine("Nincs megoldása");
            }
            
            Console.ReadLine();
        }
    }
}
