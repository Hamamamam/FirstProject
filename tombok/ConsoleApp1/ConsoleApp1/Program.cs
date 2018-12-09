using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static int[] TombLetrehozas(int hosszusag)
        {
            int[] vissza = new int[hosszusag];
            Random rand = new Random();
            for (int i = 0; i < vissza.Length; i++)
            {
                vissza[i] = rand.Next(0, 101);
            }

            return vissza;
        }



        static void Kilistazas(int[] bemenetiTomb)
        {
            Console.WriteLine();
            for (int i = 0; i < bemenetiTomb.Length; i++)
            {
                Console.WriteLine(bemenetiTomb[i]+" ");
            }
            Console.ReadLine();
        }
        static bool OszthatoOttel(int szam)
        {
            return szam % 5 == 0;
        }
    }
}
