using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    /*
        Készíts egy Gépjármű absztrakt osztályt amely az alábbi adatokkal rendelkezik:
            Üzemanyag
            Kerekek száma
            Rendszám
     */
   public abstract class Jarmu 
    {

        public string rendszam;
        public int kerekek;
        public string uzemanyag; //a kis nagy betű miatt én az angol megfelelőket fogom használni, petrol - benzin, dízel - diesel

        public int maxSpeed; // az adott jármű maximum sebesége 

        public static Random rnd = new Random();

        protected Jarmu(string rendszam, int kerekek, string uzemanyag)
        {
            this.rendszam = rendszam;
            this.kerekek = kerekek;
            this.uzemanyag = uzemanyag;
        }
    }
}
