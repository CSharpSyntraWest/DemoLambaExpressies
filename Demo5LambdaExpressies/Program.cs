using System;
using System.Collections.Generic;

namespace Demo5LambdaExpressies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>() { 
                "appel","peer","citroen","banaan"
            };
            Console.WriteLine("Enkel fruit die letter 'e' bevat:");
            List<string> fruitMetEenE =
                fruit.FindAll(delegate(string f)
                {
                   // Console.WriteLine("Waarde van f:" + f);
                    return f.Contains("e");
                });
            //Zelfde, maar met lambda expressie
            List<string> fruitMetEenELambda =
                fruit.FindAll(f => f.Contains("e"));

            fruitMetEenELambda.ForEach(f => Console.WriteLine(f + " "));
            //Oefening:
            //Geef een lijst terug waarin enkel het fruit zit die eindigt 
            //op de letter n (met lambda expressie)
            Console.WriteLine("Enkel fruit die eindigt op 'n':");
            List<string> fruitMetEenNLambda = fruit.FindAll(f => f.EndsWith("n"));
            fruitMetEenNLambda.ForEach(f => Console.WriteLine(f + " "));
        }
    }
}
