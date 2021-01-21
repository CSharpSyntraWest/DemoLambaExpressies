using System;
using System.Linq;

namespace Demo1LinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] getallen = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //LINQ Query syntax:
            var resultKleineGetallen =
                from getal in getallen
                where getal <= 3
                select getal;
            //LINQ Method syntax:
            var resultKleineGetallen2 = getallen.Where(getal => getal <= 3).Select(getal =>getal);
            foreach (int getal in resultKleineGetallen)
                Console.WriteLine(getal + " ");
            foreach (int getal in resultKleineGetallen2)
                Console.WriteLine(getal + " ");
        }
    }
}
