using System;

namespace ProjektP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wpisz nazwe gracza:");
            Silnik.playerName = Console.ReadLine();
            Console.WriteLine($"Menu glowne \n 1.Wybor postaci \n 2.Wybor poziomu trudnosci \n 3.Start gry \nAby kontynuowac wcisnij klawisz");
            Console.ReadKey();
            Silnik.Player();
        }

        public static void Gameplay()
        {
            Console.WriteLine($"Witaj w grze papier, kamien, nozyce {Silnik.playerName}! Masz {Silnik.lifePoints} punktow zycia oraz {Silnik.attackPoints} punktow ataku." +
                              $" \nTwoj przeciwnik ma {Silnik.monsterLife} punktow zycia oraz {Silnik.monsterAttack} punktow ataku" +
                              $" \nPo kazdej wygranej turze otrzymasz dodatkowy punkt zycia");
            Silnik.RPS();
        }
    }
}
