using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace gyak.gyak
{
    class Csapat
    {
        Vendég[] vendégek;

        public Csapat(int meret)
        {
            vendégek = new Vendég[meret];
        }
        void Ujvendeg(Vendég a)
        {
            int i = 0;
            while (i<vendégek.Length && vendégek[i]!=null)
            {
                i++;
            }
            vendégek[i] = a;
        }
        public void AdatFeldolgozas(string[]nev,string[]suly, string[] stilus)
        {
            Vendég seged;
            bool bt;
            for (int i = 0; i < nev.Length; i++)
            {
                if (suly[i].Trim()=="-" && stilus[i].Trim()=="-")
                {
                    seged = new Vendég(nev[i]);
                }
                else
                {
                    if (stilus[i]=="rasta"|| int.Parse(suly[i])<600)
                    {
                        bt = true;
                    }
                    else
                    {
                        bt = false;
                    }
                    seged = Seged2(nev, suly, stilus, bt, i);
                }
                Ujvendeg(seged);
            }
        }
        static Vendég Seged1(string[]nev,string[]suly, string[]stilus, bool betepve, int i)
        {
            return new Vendég(nev[i], betepve, int.Parse(suly[i]), (style)Enum.Parse(typeof(style), stilus[i]));
        }
        static Vendég Seged2(string[]nev, string[]s,string[]st, bool bt, int i)
        {
            return Seged1(nev, s, st, bt, i);
        }
        int KoltsegetSzamol()
        {
            int seged = 0;
            int vissza = 0;
            for (int i = 0; i < vendégek.Length; i++)
            {
                if (vendégek[i].Suly>700)
                {
                    seged = 4000;
                }
                else
                {
                    seged = 2000;
                }
                if (vendégek[i].Stilus==style.rasta || vendégek[i].Stilus==style.rocker || vendégek[i].Stilus==style.hippi)
        
                {
                    seged += 3000;
                }
                else
                {
                    seged += 2500;
                }
                if (vendégek[i].Drog == true)
                {
                    seged *= 2;
                }
                vissza = seged;
                seged = 0;
            }
           
            return vissza;
        }
        string[] Bajosok()
        {
            int db = 0;
            int j = 0;
            for (int i = 0; i < vendégek.Length; i++)
            {
                if (vendégek[i].Suly>=900 && vendégek[i].Stilus==style.punk || vendégek[i].Suly<700 && vendégek[i].Stilus==style.páva)
                {
                    db++;
                }
            }
            string[] bajos = new string[db];
            for (int i = 0; i < vendégek.Length; i++)
            {
                if (vendégek[i].Suly >= 900 && vendégek[i].Stilus == style.punk || vendégek[i].Suly < 700 && vendégek[i].Stilus == style.páva)
                {
                    bajos[j] = vendégek[i].Nev;
                    j++;
                }
            }
            return bajos;
        }
        public void AdatokKiertekel()
        {
            string s;
            StreamWriter sw = new StreamWriter("adatok.txt");
            for (int i = 0; i < vendégek.Length; i++)
            {
                s = "";
                s += "Név:" + vendégek[i].Nev + "(" + vendégek[i].Stilus + ")," + vendégek[i].Suly + "N";
                if (vendégek[i].Drog==true)
                {
                    s += "(be van tépve)";

                }
                else
                {
                    s += "(tiszta)";
                }
                sw.WriteLine(s);
            }
            sw.Write("bajosak:");
            string[] baj = Bajosok();
            for (int i = 0; i < baj.Length; i++)
            {
                s = "";
                s += baj[i];
                sw.WriteLine(s);
            }
            sw.WriteLine("Fogyasztas");
            sw.WriteLine(KoltsegetSzamol().ToString());
            sw.Close();
            
        }

    }
}
