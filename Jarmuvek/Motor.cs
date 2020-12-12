using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Motor : Jarmu
    {
        public Motor(string rendszam, int kerekek, string uzemanyag) : base(rendszam, 2, uzemanyag)
        {

        }


        public int maxSpeed = rnd.Next(200, 296); // én itt nem egy sima robogora gondoltam hanem yamaha R6-re (jelenlegi rekordot egy 2007-es Yamaha R6 tartja 295-el, auto úton....)
        
    }
}
