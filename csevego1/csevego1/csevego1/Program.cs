using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csevego1
{
    class Program
    {
        static int[]TombLetrehozasa(int hosszusag)
        {
            int[] tomb = new int[hosszusag];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                
                tomb[i] = r.Next(1, 101);
            }
            return tomb;
        }
        static void Kilistaz(int[] tomb)
        {
            Console.WriteLine();
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]+ " ");
            }

        }
        static bool OttelOszthato(int szam)
        {
            return szam % 5 == 0;
        }
        static int ElemekOsszege(int[] tomb)
        {
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            return osszeg;
        }
        static bool VanESzam(int[] tomb)
        {
            bool van = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (OttelOszthato(tomb[i]))
                {
                    van = true;
                }
                else { van = false; }

            }
            return van;
        }
        static int HolVan(int[]tomb)
        {
            int index = 0;
            int i = 0;
            while (i<tomb.Length && !OttelOszthato(tomb[i]))
            {
                i++;
                index = tomb[i];


            }
            return index;
        }
        static int PontosanVanE(int[] tomb)
        {
            int index = -1;
            int i = 0;
            bool van = false;
            while (i<tomb.Length && !OttelOszthato(tomb[i]))
            {
                if (OttelOszthato(tomb[i]))
                {
                    i++;
                    van = true;
                    return index;
                }
                

            }
            return index;
        }
        static int Darab(int[] tomb)
        {
            int db = 0;
            int i = 0;
            while (i<tomb.Length && OttelOszthato(tomb[i]))
            {
                db++;

            }
            return db;
        }
        static int Legkisebbertek(int[] tomb)
        {
            int min = 1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]<tomb[min])
                {
                    min = i;
                }

            }
            return min;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Milyen hosszú legyen a tömb?");
            int[] tombi = TombLetrehozasa(int.Parse(Console.ReadLine()));
            Kilistaz(tombi);
        }
    }
}
