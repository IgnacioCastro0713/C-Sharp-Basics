using System;
using System.Linq;

namespace C_Sharp_Basics
{
    class Program
    {
        private static string Name = "Ignacio";
        private static int Age = 24;

        public static void Main(string[] args)
        {
            const string world = "World";
            //Console.WriteLine($"Hello {world}");
            //Console.WriteLine(Other());
            //Console.WriteLine(Info());
            (Name, Age) = Info();
            Console.WriteLine(Name);
        }

        static string Other() => Name; // string

        static (string, int) Info() => (Name, Age); // multi return type data
    }
}