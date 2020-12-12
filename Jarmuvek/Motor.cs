using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Motor : Jarmu
    {
        public Motor(string rendszam) : base(rendszam)
        {

        }

        int kerekek = 2;
        public string uzemanyag = "petrol";
        public int maxSpeed = rnd.Next(200, 296); // én itt nem egy sima robogora gondoltam hanem yamaha R6-re (jelenlegi rekordot egy 2007-es Yamaha R6 tartja 295-el, auto úton....)

        public override string ToString()
        {
            return String.Format("Jarmu rendszama: {0} \n Kerekszama:{1} \n Uzemanyag tipusa: {2} \n Maximalis sebesseg: {3} \n", this.rendszam, this.kerekek, this.uzemanyag, this.maxSpeed);
        }
    }
}
