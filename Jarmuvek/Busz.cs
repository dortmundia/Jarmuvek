using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Busz : Jarmu
    {
        public Busz(string rendszam, string uzemanyag) : base(rendszam, uzemanyag)
        {

        }
        int kerekek = 4;
        public int maxSpeed = rnd.Next(90, 126);

        public override string ToString()
        {
            return String.Format("Jarmu rendszama: {0} \n Kerekszama:{1} \n Uzemanyag tipusa: {2} \n Maximalis sebesseg: {3} \n", this.rendszam, this.kerekek, this.uzemanyag, this.maxSpeed);
        }
    }
}
