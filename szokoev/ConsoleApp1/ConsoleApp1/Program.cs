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
            Console.WriteLine("Írj be egy évszámot!");
            int ev = int.Parse(Console.ReadLine());
            if (ev % 4 == 0 || ev % 100 == 0 && ev % 400 != 0)
            {
                Console.WriteLine("Szökőév");
            }
            else
            {
                Console.WriteLine("Nem szökőév!");
            }
            Console.ReadLine();
            return;
        }
    }
}
