using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_tombi
{
    class Program
    {
        static int[] TombLetrehozasa(int hosszusag)
        {
            int[] tomb = new int[hosszusag];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(0, 101);
            }
            return tomb;
        }
        static void Kilistaz(int [] BemenetiTomb)
        {
            Console.WriteLine();
            for (int i = 0; i < BemenetiTomb.Length; i++)
            {
                Console.WriteLine(BemenetiTomb[i]+" ");
            }
        }
        static bool OszthatoOttel(int szam)
        {
            return szam % 5 == 0;
        }
        static int Osszegzes(int [] tomb)
        {
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];

            }
            return osszeg;
        } 
        static bool OTvan(int [] tomb)
        {
            bool van = false;
            int i = 0;
            while (i<tomb.Length && !OszthatoOttel(tomb[i]))
            {
                i++;
            }
            van =( i < tomb.Length);
            return van;
         
        }
        static int Kivalasztas(int[] tomb)
        {
            int index = 0;
            int i = 0;
            while (!OszthatoOttel(tomb[i]))
            {
                i++;
            }
            index = i;
            return index;
        }
        static int LinearisKereses(int [] tomb)
        {
            int index = -1;
            int i = 0;
            while (i < tomb.Length && !OszthatoOttel(tomb[i]))
            {
                i++;
            }
                if (i<tomb.Length)
                {
                    index = i;
                    return index;
                }
                else
                {
                    return index;
                }
            
        }
        static int Megszamlalas(int[] tomb)
        {
            int szamlalo = 0;
            
            for (int i = 0; i < tomb.Length; i++)
            {
                if (OszthatoOttel(tomb[i]))
                {
                    szamlalo++;

                }
            }
            return szamlalo;
        }
        static int Minimum(int[] tomb)
        {
            int min = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[min]>tomb[i])
                {
                    min = i;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Milyen hosszú legyen a tömb?");
            int[] tomb = TombLetrehozasa(int.Parse(Console.ReadLine()));
            Kilistaz(tomb);
            Console.WriteLine("\n");
            Console.WriteLine(Megszamlalas(tomb)); 
            Console.ReadLine();
          
        }
    }
}
