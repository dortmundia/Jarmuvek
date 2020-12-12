using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class MunkaGep : Jarmu
    {
        public MunkaGep(string rendszam, int kerekek, string uzemanyag) : base(rendszam, kerekek, "Diesel")
        {

        }
        public int maxSpeed = rnd.Next(30, 91); // a világ leggyorsabb traktora: 217.6 km/h - JCB Fastrac tractor, de én itt maradnék csak egy sima traktornál
        
    }
}
