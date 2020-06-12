using System;

namespace ProjektP
{
    class Program
    {
        public static int Characters()
        {
            int characterSelector = 0;
            
            return characterSelector;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz imie:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Witaj {userName}");

            Console.WriteLine($"Menu glowne \n 1.Wybor postaci \n 2.xxx \n 3.xxx");
            int menuSelector = Int32.Parse(Console.ReadLine());
            switch (menuSelector)
            {
                
            }
        }
    }
}
