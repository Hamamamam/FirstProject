using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hogy hívnak?");
            string nev = Console.ReadLine();
            if (nev == "Béla")
            {
                Console.WriteLine("Szia," + nev + "!");
            }
            else if (nev == "Dani")
            {
                Console.WriteLine("Puszi " + nev + "!");
            }
            else {
                Console.WriteLine("Hi.");
            }
            Console.ReadLine();
        }
    }
}
