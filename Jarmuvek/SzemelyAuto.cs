using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class SzemelyAuto : Jarmu
    {
        public SzemelyAuto(string rendszam, int kerekek, string uzemanyag) : base(rendszam,4,uzemanyag)
        { 
        
        }

        public int maxSpeed =rnd.Next(110,171); 
        
    }
}
