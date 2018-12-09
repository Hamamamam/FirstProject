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
            double a, b, k, t;
            Console.WriteLine("Adja meg a téglalap két szomszédos oldalát!");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a < 0 || b<0)
            {
                Console.WriteLine("Értelmetlen!");

            }
            k = 2 * a + 2 * b;
            t = a * b;
            Console.WriteLine("A téglalap kerülte:"+k+"; a területe pedig:"+t+"!");
            Console.ReadLine();
            return;
        }
    }

}
