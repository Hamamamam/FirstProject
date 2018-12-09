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
           // int[] tomb = new int[] { 1, 2, 4, 5, 6, 8, 10 };
            //int osszeg = 0;
           // for (int i = 0; i < tomb.Length; i++)
            {
           //     osszeg += tomb[i];
            }
            //  Console.WriteLine(osszeg);
            //Console.ReadLine();

            //int[] tombike = new int[] { 3, 4, 5, 7, 2, 1, 10 };
            //int vizsgalt = 6;
            //int szamlalo=0;
            //for (int i = 0; i < tombike.Length; i++)
            //{
            /// if (tombike[i] > vizsgalt)
            //{
            /// szamlalo++;
            // }

            ////  }
            // Console.WriteLine(szamlalo);

            // Console.ReadLine();


            // int[] tomb = new int[] { 1, 3, 5, 8, 543 };
            //  int keresendo = 8;
            //  int i = 0;
            // while (i < tomb.Length && tomb[i] != keresendo) 
            // {
            //   i++;}
            //if (i<tomb.Length)
            /// {
            //  Console.WriteLine("Találat!");
            //}
            //else
            ////{
            // Console.WriteLine("Nincs");
            //}
            // Console.ReadLine();
            int[] tombike = new int[] { 1, 3, 5, 6, 43, 8 };
            int keresett = 43;
            int i = 0;
            while (tombike[i]!=keresett && i<tombike.Length)
            {
                i++;
            }
            int eredmeny = i + 1;
            Console.WriteLine(eredmeny);
            Console.ReadLine();



        }
    }
}
