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
            //Reading data from cli
            Console.WriteLine("A =");
            double a = double.Parse(Console.ReadLine());
           // Console.WriteLine();
            Console.WriteLine("B =");
            double b = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            Console.WriteLine("C =");
            double c = double.Parse(Console.ReadLine());
            // Console.WriteLine();

            //here comes the magic
            if (a == 0)
            {
                Console.WriteLine("Nem megoldahato, nem masodfoku az egyenlet!");
                Console.ReadLine();
                return;
         
            }
            double d = (b * b) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Nem megoldhato a valos szamokhalmazan!");
                Console.ReadLine();
                return;
            } else if (d == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("x="+x);
                Console.ReadLine();
                return;

            }
            double x1 = ((-b) +Math.Sqrt(d)) / (2 * a);
                double x2 = ((-b) -Math.Sqrt(d) )/ (2 * a);
            Console.WriteLine("x1="+x1);
            Console.WriteLine("x2="+x2);
            Console.ReadLine();
          

        }
    }
}
