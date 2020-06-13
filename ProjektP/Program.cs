using System;

namespace ProjektP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Menu glowne \n 1.Wybor postaci \n 2.Wybor poziomu trudnosci \n 3.Start gry \nAby kontynuowac wcisnij klawisz");
            Console.ReadKey();
            Silnik.Player();
        }
    }
}
