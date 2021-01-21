using System;
using System.Linq;

namespace Demo3LambaExpressies
{
    class Hond
    { 
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Ras { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hond[] honden = new Hond[]
            {
                  new Hond{ Naam= "Bobby", Leeftijd= 8, Ras="Golden Retriever"},
                  new Hond { Naam = "Bobby", Leeftijd = 4 , Ras="Labrador"},
                  new Hond { Naam = "Fifi", Leeftijd = 1, Ras="Golden Retriever" },
                  new Hond { Naam = "Rex", Leeftijd = 3, Ras="Labrador" }
            };
            var gesorteerdeLijst = honden.OrderByDescending(h => h.Naam).ThenBy(h => h.Leeftijd);
            foreach (Hond hond in gesorteerdeLijst)
            {
                Console.WriteLine($"{hond.Naam} - Leeftijd {hond.Leeftijd}");
            }
            Console.WriteLine("Gesorteerd op Ras, omgekeerd op leeftijd, dan op naam:");
            //Oefening: Maak een extra Property "Ras" met het ras van de hond in de klasse Hond
            //Sorteer eerst op Ras, dan omgekeerd (van groot naar klein) op Leeftijd en daarna alfabetisch op naam
            var gesorteerdeLijst2 = honden.OrderBy(h => h.Ras).ThenByDescending(h => h.Leeftijd).ThenBy(h => h.Naam);
            foreach (Hond hond in gesorteerdeLijst2)
            {
                Console.WriteLine($"{hond.Naam} - Leeftijd {hond.Leeftijd}");
            }
        }
    }
}
