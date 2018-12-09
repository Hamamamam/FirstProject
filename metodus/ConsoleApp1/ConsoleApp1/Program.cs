using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    class Program
    {
        static int[] TombLetrehozas(int hosszusag)
        {
            int[] vissza = new int[hosszusag];
            Random ran = new Random();
            for (int i = 0; i < vissza.Length; i++)
            {
                vissza[i]=ran.Next(0,101)
            }
            return vissza;
        }
        static void Kilistazas(int[] BemenetiTombike)
        {
            Console.WriteLine();
            for (int i = 0; i < BemenetiTombike.Length; i++)
            {
                Console.WriteLine(BemenetiTombike[i]+" ");

            }
        }
        static bool Otteloszt(int szam)
        {
           return szam%5 == 0;
        }
        static int Sorozatszamitas(int[] tomb)
        {
            int vissza = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                vissza += tomb[i];
            }
            return vissza;
        }
        static bool Eldontes(int[] tombt)
        {
            bool van = false;
            int i = 0;
            while (i<tombt.Length && !Otteloszt(tombt[i]))
            {
                i++;
            }
            van = (i < tombt.Length);
            return van;
        }
        static int Kivalasztas(int[] tombb)
        {
            int index;
            int i = 0;
            while (!Otteloszt(tombb[i])
            {
                i++;
            }
            index = i;
            return index;
        }
        static int Linearisk(int[] tomb)
        {
            int index = -1;
            int i = 0;
            while (i<tomb.Length && !Otteloszt(tomb[i])
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
        static int Megszamlalas(int [] tomb)
        {
            int vissza=0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (Otteloszt(tomb[i])
                {
                    vissza++;
                }
            }
            return vissza;

        }
        static int MinimumKivalasztas(int[] tomb)
        {
            int minimum = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[minimum] > tomb[i])
                {
                    minimum = i;
                }
            }
            return minimum;
        }
    }
}
