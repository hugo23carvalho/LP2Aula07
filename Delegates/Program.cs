using System;

namespace Delegates
{
    class Program
    {

        static void Main(string[args] args)
        {
            MyDelegate del;

            Joiner joiner = new Joiner("cena");

            string s = "outra cena";

            del = PrintUpper;
            del += PrintLower;
            del += Joiner.JoinAndPrint;

            del.Invoke(s);

        }  
        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());


        } 
        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());


        }   

        
    }
}
