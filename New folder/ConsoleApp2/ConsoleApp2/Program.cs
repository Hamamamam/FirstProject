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
            int februar = 28;
            //31 day
            int[] x=new int[] { 1, 3, 5, 7, 8, 10, 12 };
            //30 day
            int[] y=new int[] { 4, 6, 9, 11 };
            int result=0;
            Console.WriteLine("Írjon be egy évszámot!");
            int ev=int.Parse(Console.ReadLine());
            if (ev % 4 == 0)
            {
                 februar = 29;
            }
            Console.WriteLine("Írjon be egy hónapot szám formátumban!");
            int honapszam = int.Parse(Console.ReadLine());
            if (x.Contains(honapszam))
            {
                result = 31;
            }
            else if (y.Contains(honapszam))//honapszam=amit beolvastunk
            {
                result = 30;
            }
            else if (honapszam == 2)
            {
                result = februar;
            }
            else {
                Console.WriteLine("Nincs ilyen hónap!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("A(z) " + ev + " év " + honapszam + ". hónapja " + result + " napos.");
            Console.ReadLine();

        }
    }
}
