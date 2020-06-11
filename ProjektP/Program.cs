using System;

namespace ProjektP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz imie:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Witaj {userName}");
            Console.ReadKey();
        }
    }
}
