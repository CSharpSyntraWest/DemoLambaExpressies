using System;
using System.Collections.Generic;

namespace Demo2LamdaExpressies
{

    class Program
    {
        static bool IsEven(int getal)
        {
            return getal % 2 == 0;
        }
        static bool IsGroterDan5(int getal)
        {
            return getal > 5;
        }
        static void Main(string[] args)
        {
            List<int> getallenLijst= new List<int> { -8, 5, 50, -6, 2, 3, 7, 5 };
            Predicate<int> pred = IsEven;
            List<int> evenGetallenLijst = getallenLijst.FindAll(pred);
            foreach (int g in evenGetallenLijst)
            {
                Console.Write(g + " ");
            }
            Console.WriteLine();
            //Korter via lamda-expressie:
            Console.WriteLine("zelfde maar via Lambda-expressie:");
            List<int> evenGetallenLijstLamba = getallenLijst.FindAll(getal => getal % 2 == 0);
            evenGetallenLijstLamba.ForEach(g => Console.Write(g + " "));
            Console.WriteLine("\nGetallen groter dan 5:");
            //Via klassieke manier: testen of een getal groter is dan 5:
            Predicate<int> pred2 = IsGroterDan5;
            List<int> getallenGroterDan5 = getallenLijst.FindAll(pred2);
            foreach (int getal in getallenGroterDan5)
            {
                Console.Write(getal + " ");
            }
            Console.WriteLine();
            //Korter, via Lambda-expressie:
            Console.WriteLine("Getallen > 5 maar via Lambda-expressie:");
            List<int> getallenGroterDan5MetLambda = getallenLijst.FindAll(g => g > 5);
            getallenGroterDan5MetLambda.ForEach(getal => Console.Write(getal + " "));
            //Oefening 1: Maak een nieuwe lijst uit getallenLijst met enkel de getallen >= 2 en < 7
            //via een lamba-expressie en druk de lijst af via ForEach
            Console.WriteLine("\nGetallen >=2 en < 7  via Lambda-expressie:");
            List<int> getallenTussen2en6 = getallenLijst.FindAll(g => g >=2 && g < 7);
            getallenTussen2en6.ForEach(g => Console.Write(g + " "));
            //Oefening 2: Gebruik RemoveAll om alle getallen groter dan 3 te verwijderen uit getallenLijst
            //en druk de aangepaste lijst af met ForEach
            Console.WriteLine("\nVerwijder getallen uit getallenLijst > 3  via Lambda-expressie:");
            getallenLijst.RemoveAll(g => g > 3);
            getallenLijst.ForEach(g => Console.Write(g + " "));
        }
    }
}
