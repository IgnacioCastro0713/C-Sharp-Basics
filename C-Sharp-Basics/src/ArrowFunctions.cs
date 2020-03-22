using System;

namespace C_Sharp_Basics
{
    public class ArrowFunctions
    {
        private static string Name = "Ignacio";
        private static int Age = 24;
        
        public static void Main(string[] args)
        {
            (Name, Age) = Info();
            Console.WriteLine(Name);
        }
        
        
        static string Other() => Name; // string

        static (string, int) Info() => (Name, Age); // multi return type data
    }
}