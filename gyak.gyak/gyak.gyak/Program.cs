using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace gyak.gyak
{
    enum style
    {
        rasta,rocker, páva, hippi, punk, mediocre
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fajl név pls");
            string f = Console.ReadLine();
            StreamReader sr = new StreamReader(f,Encoding.Default);
            string s = sr.ReadLine();
            sr.Close();
            string[] seged = s.Split(':');
            string[] nev = seged[0].Split(',');
            string[] suly = seged[1].Split(',');
            string[] stilus = seged[2].Split(',');
            Csapat uj = new Csapat(nev.Length);
            uj.AdatFeldolgozas(nev, suly, stilus);
            uj.AdatokKiertekel();
        }
    }
}
