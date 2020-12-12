using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Tank : Jarmu
    {
        public Tank(string rendszam,  string uzemanyag) : base(rendszam, "petrol") // sima tankra gondoltam nem EBR-re, ezért 0 a kereke ugyanis a rendes tankoknak lánctalpa van 
        {

        }

        int kerekek = 0;
        public int maxSpeed =rnd.Next(35, 71);

        public override string ToString()
        {
            return String.Format(" Jarmu rendszama: {0} \n Kerekszama:{1} \n Uzemanyag tipusa: {2} \n Maximalis sebesseg: {3} \n", this.rendszam, this.kerekek, this.uzemanyag, this.maxSpeed);
        }
    }
}
