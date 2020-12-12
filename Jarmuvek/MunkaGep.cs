using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class MunkaGep : Jarmu
    {
        public MunkaGep(string rendszam, int kerekek) : base(rendszam, kerekek)
        {

        }
        public string uzemanyag = "Diesel";
        public int maxSpeed = rnd.Next(30, 91); // a világ leggyorsabb traktora: 217.6 km/h - JCB Fastrac tractor, de én itt maradnék csak egy sima traktornál

        public override string ToString()
        {
            return String.Format("Jarmu rendszama: {0} \n Kerekszama:{1} \n Uzemanyag tipusa: {2} \n Maximalis sebesseg: {3} \n", this.rendszam, this.kerekek, this.uzemanyag, this.maxSpeed);
        }
    }
}
