using System;

namespace DemoLambaExpressies
{
    delegate void MijnDelegate(string text);
    class Program
    {
        static void PrintString(string tekst)
        {
            Console.WriteLine(tekst); 
        }
        static void Main(string[] args)
        {
            Action<string> del_action = PrintString;
            del_action("Hallo via Methode met naam");
            //Via anonymous methode en eigen delegate:
            MijnDelegate del_mijnDelAnonymous = delegate (string tekst)
           {
               Console.WriteLine(tekst);
           };
            del_mijnDelAnonymous("Hallo via Methode zonder naam en eigen delegate signatuur");
          
            Action<string> del_Builtin_anonymous = delegate (string text)
            {
                Console.WriteLine(text);
            };
            del_Builtin_anonymous("Hallo via Methode zonder naam en Built-in delegate Action<..>");
            //Lamba expressie = anonymous methode
            //bevat => teken
            //aan linkerkant van => parameter(s)
            //aan rechterkant van => statements
            Action<string> del_lambdaExpr_anonymous = (t) =>  Console.WriteLine(t);
            del_lambdaExpr_anonymous("Hallo via lamba-expression methode (anonymous)");


        }
    }
}
