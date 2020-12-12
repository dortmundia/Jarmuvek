using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    //A létrehozott osztályokból hozz létre különböző példányokat amelyek adatait a konzolra írasd ki.
    //5db 
    //a kis nagy betű miatt én az angol megfelelőket fogom használni, petrol = benzin,  diesel = dízel
    //nekem a windoseomnak szokot ezzel baja lenni, buggolni
    class Program
    {
        static void Main(string[] args)
        {

            MunkaGep traktor = new MunkaGep("ABC-123",4);
            
            Busz ikarusz = new Busz("CBA-123", "diesel");
            
            Tank leopard_1 = new Tank("NFS-420", ""); // alapértelmezetten megkapja az üzemanyag tipusát
            //Console.WriteLine(leopard_1.uzemanyag);

            Motor r6 = new Motor("RRR-666");
            
            SzemelyAuto mustangMcQueen = new SzemelyAuto("FSTGTCS","Diesel");    //A rendszám amerikai mivel ezt nem én találtam ki: https://www.instagram.com/mustangmcqueen/

            Console.WriteLine(traktor);
            Console.WriteLine(ikarusz);
            Console.WriteLine(leopard_1);
            Console.WriteLine(r6);
            Console.WriteLine(mustangMcQueen);

            Console.ReadKey();
        }
    }
}
