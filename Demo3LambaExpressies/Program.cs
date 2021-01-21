using System;
using System.Linq;

namespace Demo3LambaExpressies
{
    class Hond
    { 
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hond[] honden = new Hond[]
            {
                  new Hond{ Naam= "Bobby", Leeftijd= 8},
                  new Hond { Naam = "Bobby", Leeftijd = 4 },
                  new Hond { Naam = "Fifi", Leeftijd = 1 },
                  new Hond { Naam = "Rex", Leeftijd = 3 }
            };

            var gesorteerdeLijst = honden.OrderByDescending(h => h.Naam).ThenBy(h => h.Leeftijd);
            foreach (Hond hond in gesorteerdeLijst)
            {
                Console.WriteLine($"{hond.Naam} - Leeftijd {hond.Leeftijd}");
            }

            //Oefening: Maak een extra Property "Ras" met het ras van de hond in de klasse Hond
            //Sorteer eerst op Ras, dan omgekeerd (van groot naar klein) op Leeftijd en daarna alfabetisch op naam
        }
    }
}
