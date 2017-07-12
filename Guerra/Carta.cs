using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Carta
    {
        public int palo;
        public int valor;
        public string img;

        public Carta(int p, int v, string i)
        {
            palo = p;
            valor = v;
            img = i;
        }
    }
}
