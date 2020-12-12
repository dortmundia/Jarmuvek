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
        public string uzemanyag; //a kis nagy betű miatt én az angol megfelelőket fogom használni, petrol - benzin, dízel - diesel, nekem a windoseomnak szokot ezzel baja lenni, buggolni

        public int maxSpeed; // az adott jármű maximum sebesége 

        public static Random rnd = new Random();

        protected Jarmu(string rendszam, int kerekek)
        {
            this.rendszam = rendszam;
            this.kerekek = kerekek;
        }

        protected Jarmu(string rendszam, string uzemanyag)
        {
            this.rendszam = rendszam;
            this.uzemanyag = uzemanyag;
        }

        protected Jarmu(string rendszam)
        {
            this.rendszam = rendszam;
        }

        public override string ToString()
        {
            return String.Format("Jarmu rendszama: {0} \n Kerekszama:{1} \n Uzemanyag tipusa: {2} \n Maximalis sebesseg: {3} \n",this.rendszam,this.kerekek,this.uzemanyag,this.maxSpeed);
        }
    }
}
