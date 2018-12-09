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
            Console.WriteLine("Írd be a zh-k eredményeit!");
            double osszeg = 0;
            int i = 0;
            string bemenet;
            while (true)
            {
                bemenet = Console.ReadLine();
                if (bemenet == "")
                {
                    break;
                }
                else
                {
                    i++;
                    osszeg += double.Parse(bemenet);
                }
            }
            double avg = osszeg / i;
            Console.WriteLine("Átlag= " + avg);
            Console.ReadLine();
            return;
        }
    }
}
