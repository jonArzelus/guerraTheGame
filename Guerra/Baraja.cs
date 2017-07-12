using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Baraja
    {
        List<Carta> t;

        public Baraja()
        {
            t = new List<Carta>();
            for (int p = 1; p < 5; p++)
            {
                for (int v = 1; v < 13; v++)
                {
                    if (v < 10)
                    {
                        t.Add(new Carta(p, v, "Guerra.Properties.Resources._" + p.ToString() + "0" + v.ToString()));
                    }
                    else
                    {
                        t.Add(new Carta(p, v, "Guerra.Properties.Resources._" + p.ToString() + v.ToString()));
                    }
                }
            }
        }

        public static List<Carta> newBaraja()
        {
            List<Carta> l = new List<Carta>();
            for (int p = 1; p < 5; p++)
            {
                for (int v = 1; v < 13; v++)
                {
                    if (v < 10)
                    {
                        //l.Add(new Carta(p, v, "Guerra.Properties.Resources._" + p.ToString() + "0" + v.ToString()));
                        l.Add(new Carta(p, v, "_" + p.ToString() + "0" + v.ToString()));
                    }
                    else
                    {
                        //l.Add(new Carta(p, v, "Guerra.Properties.Resources._" + p.ToString() + v.ToString()));
                        l.Add(new Carta(p, v, "_" + p.ToString() + v.ToString()));
                    }
                }
            }
            return l;
        }
    }
}
