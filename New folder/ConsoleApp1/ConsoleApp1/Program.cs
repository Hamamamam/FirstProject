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
            int ev;
            Console.WriteLine("Írjon be egy évszámot!");
            ev = int.Parse(Console.ReadLine());
            if (ev % 4 == 0)
            {
                Console.WriteLine("Szökőév!");
            }
            else
            {
                Console.WriteLine("Nem szökőéve!");
            }
            Console.ReadLine();
            return;
        }
    }
}
