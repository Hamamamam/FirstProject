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
            Console.WriteLine("Adjon meg egy hőmérsékletet celsiusfokban");
            double c = double.Parse(Console.ReadLine());
            double f;
            f = c * 9 / 5 + 32;
            Console.WriteLine("A kívánt hőmérséklet:" +f+" Fahrenheit!");
            Console.ReadLine();
            return;

        }
       
    }
}
