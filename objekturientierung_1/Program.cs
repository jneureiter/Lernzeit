using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objekturientierung_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable vorname erstellen
            string vorname = "Josef";

            // Schablone Auto . . . zur Erstellung eines Autos
            Auto meinAuto = new Auto();
            meinAuto.Fahre("Zell am See");

            Auto deinAuto = new Auto();
            deinAuto.Fahre();

            Auto mustang = new Auto();

            // Eigenschaft ohne Zuweisung ruft den get-Bereich der Eigenschaft auf
            Console.WriteLine("Die Farbe des Autos ist {0}",mustang.Farbe);

            // Zuweisung ruft den set-Bereich der Eigenschaft auf
            mustang.Farbe = "rot";
            Console.WriteLine("Die Farbe des Autos ist {0}", mustang.Farbe);
            
            Console.WriteLine(mustang.Farbe); //wieder rot
            mustang.Fahre();

            Person dani = new Person();

            dani.AugenFarbe = "braun";
            dani.AugenFarbe = "blau";

            Console.WriteLine($"Dani hat die Augenfarbe {dani.AugenFarbe}.");

            Auto demo = new Auto();
            demo.Farbe = "lila";
            demo.Fahre();
            demo.Fahre("Rauris");

            demo.Bremse();


            Console.WriteLine(demo.Geschwindigkeit);

            Person name = new Person();

            name.VorName = "Hans";
            name.NachName = "Huber";

            Console.WriteLine(name.VorName);
            Console.WriteLine(name.NachName);


            
        }
    }
}
