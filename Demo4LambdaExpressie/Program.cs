using System;
using System.Collections.Generic;

namespace Demo4LambdaExpressie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 20, 1, 4, 18, 9, 44 };
            List<int> evenGetallen = list.FindAll(i =>
            {
                Console.WriteLine("Waarde van i is: " + i);
                return i % 2 == 0;
            });
            evenGetallen.ForEach(g => Console.Write(g + " "));
        }
    }
}
