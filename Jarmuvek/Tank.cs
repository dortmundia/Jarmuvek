using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Tank : Jarmu
    {
        public Tank(string rendszam, int kerekek, string uzemanyag) : base(rendszam, 0, "petrol") // sima tankra gondoltam nem EBR-re, ezért 0 a kereke ugyanis a rendes tankoknak lánctalpa van 
        {

        }
        public int maxSpeed =rnd.Next(35, 71); 
        
    }
}
