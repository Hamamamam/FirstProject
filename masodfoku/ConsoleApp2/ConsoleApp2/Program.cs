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
            //P1(x1,y1)
            //P2(x2,y2)
            double x1, x2, y1, y2;
            Console.WriteLine("Adjon meg egy pont koordinátáit!");
            x1 = double.Parse(Console.ReadLine());
            // console.writeline();
             y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a másik pont koordinátáit!");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            double dx = x2 - x1; // egyik tavolsag
            double dy = y2 - y1;
            dx = (-dx);
            //a normál vektor dy, dx
            double jobboldal = x1 * dy + y1 * dx;
            Console.WriteLine("e: "+dy+"x + "+dx+"y = "+jobboldal);
            Console.ReadLine();



        }
    }
}
