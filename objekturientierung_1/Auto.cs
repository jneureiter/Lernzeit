using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objekturientierung_1
{
    public class Auto
    {
        public string Farbe { get; set; } = "blau";

        public int Geschwindigkeit { get; private set; } = 0;


        public void Fahre()
        {
            Console.WriteLine("Meine Farbe ist {0}. brum brum brum ...", this.Farbe);
            this.Geschwindigkeit = 100;
        }

        /// <summary>
        /// Das Auto fährt. (in dein Arschloch)
        /// </summary>
        /// <param name="ort">Geben Sie den Zielort an.</param>
        public void Fahre(string ort)
        {
            Console.WriteLine($"brum brum brum nach {ort}.");
            this.Geschwindigkeit = 100;
        }

        public void Bremse()
        {
            if (this.Geschwindigkeit > 0)
            {
                this.Geschwindigkeit = this.Geschwindigkeit - 10;
            }
           
        }
    }
}
