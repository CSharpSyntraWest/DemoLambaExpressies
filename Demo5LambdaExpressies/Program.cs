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

            List<string> fruitMetEenE =
                fruit.FindAll(delegate(string f)
                {
                   // Console.WriteLine("Waarde van f:" + f);
                    return f.Contains("e");
                });
            //Zelfde, maar met lambda expressie
            List<string> fruitMetEenELambda =
                fruit.FindAll(f => f.Contains("e"));

            fruitMetEenELambda.ForEach(f=> Console.WriteLine(f + " "));
            //Oefening:
            //Geef een lijst terug waarin enkel het fruit zit die eindigen 
            //op de letter n

        }
    }
}
