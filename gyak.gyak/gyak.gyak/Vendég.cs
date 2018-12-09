using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak.gyak
{
    class Vendég
    {
        string vendegNeve;
        bool betepve;
        int testSuly;
        style style;

        public Vendég(string vendegNeve,bool betepve, int testSuly,style style)
        {
            this.vendegNeve = vendegNeve;
            this.betepve = betepve;
            this.testSuly = testSuly;
            this.style = style;
        }
        public Vendég(string vendegNeve)
        {
            this.vendegNeve = vendegNeve;
            int i = rnd.Next(1, 101);
            if (i<=50)
           {
                betepve = true;
            }
            else
            {
                betepve = false;
            }
            testSuly = SulyGeneral();
            style = style.mediocre;
        }
        static Random rnd = new Random();
        int SulyGeneral()
        {
            int j = 0;
            return j = rnd.Next(500, 1001);
        }
        public string Nev { get { return vendegNeve; } }
        public int Suly { get { return testSuly; } }
        public bool Drog { get { return betepve; } }
        public style Stilus { get { return style; } }
    }
}
