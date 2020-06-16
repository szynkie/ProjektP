using System;

namespace ProjektP
{
    public class Silnik
    {
        public static int lifePoints = 0;
        public static int attackPoints = 0;
        public static int monsterLife = 0;
        public static int monsterAttack = 0;
        public static string playerName = "";
        public static void Player()
        {
            int playerId = 0;
            //int lifePoints;
            //int attackPoints;
            Console.WriteLine("Wybierz postac: \n 1.Mnich \n 2.Nekromanta");
            playerId = Int32.Parse(Console.ReadLine());
            switch (playerId)
            {
                case 1:
                    lifePoints = 20;
                    attackPoints = 5;
                    break;
                case 2:
                    lifePoints = 15;
                    attackPoints = 8;
                    break;
            }
            Monster();
        }

        public static void Monster()
        {
            int monsterId = 0;
            //int monsterLife;
            //int monsterAttack;
            Console.WriteLine("Wybierz przeciwnika: \n 1.Bezlebub(latwy) \n 2.Lucyfer(trudny)");
            monsterId = Int32.Parse(Console.ReadLine());
            switch (monsterId)
            {
                case 1:
                    monsterLife = 15;
                    monsterAttack = 5;
                    break;
                case 2:
                    monsterLife = 20;
                    monsterAttack = 8;
                    break;
            }

            Program.Gameplay();
        }

        public static void RPS()
        {
            while (lifePoints > 0 && monsterLife > 0)
            {
                Console.WriteLine("Wpisz: \nPapier \nKamien \nNozyce");
                string[] choices = new string[3] {"PAPIER", "KAMIEN", "NOZYCE"};
                Random random = new Random();
                int i = random.Next(0, 3);
                //var playerChoice = Console.ReadLine();
                string playerChoice = Console.ReadLine().ToUpper();
                Console.WriteLine($"{playerName}: {playerChoice}");
                Console.WriteLine("Przeciwnik: " + choices[i]);

                if (playerChoice == "KAMIEN" && choices[i] == "NOZYCE")
                {
                    Console.WriteLine($"{playerName} wygrywa!");
                    monsterLife = monsterLife - attackPoints;
                    lifePoints++;
                    Console.WriteLine($"{playerName} ma {lifePoints} punktow zycia" +
                                      $" \nPrzeciwnik ma {monsterLife} punktow zycia");
                }
                else if (playerChoice == "KAMIEN" && choices[i] == "PAPIER")
                {
                    Console.WriteLine("Przeciwnik wygrywa!");
                    lifePoints = lifePoints - monsterAttack;
                    monsterLife++;
                    Console.WriteLine($"{playerName} ma {lifePoints} punktow zycia" +
                                      $" \nPrzeciwnik ma {monsterLife} punktow zycia");
                }
                else if (playerChoice == "PAPIER" && choices[i] == "KAMIEN")
                {
                    Console.WriteLine($"{playerName} wygrywa!");
                    monsterLife = monsterLife - attackPoints;
                    lifePoints++;
                    Console.WriteLine($"{playerName} ma {lifePoints} punktow zycia" +
                                      $" \nPrzeciwnik ma {monsterLife} punktow zycia");
                }
                else if (playerChoice == "PAPIER" && choices[i] == "NOZYCE")
                {
                    Console.WriteLine("Przeciwnik wygrywa!");
                    lifePoints = lifePoints - monsterAttack;
                    monsterLife++;
                    Console.WriteLine($"{playerName} ma {lifePoints} punktow zycia" +
                                      $" \nPrzeciwnik ma {monsterLife} punktow zycia");  
                }
                else if (playerChoice == "NOZYCE" && choices[i] == "KAMIEN")
                {
                    Console.WriteLine($"{playerName} wygrywa!");
                    monsterLife = monsterLife - attackPoints;
                    lifePoints++;
                    Console.WriteLine($"{playerName} ma {lifePoints} punktow zycia" +
                                      $" \nPrzeciwnik ma {monsterLife} punktow zycia");
                }
                else if (playerChoice == "NOZYCE" && choices[i] == "PAPIER")
                {
                    Console.WriteLine("Przeciwnik wygrywa!");
                    lifePoints = lifePoints - monsterAttack;
                    monsterLife++;
                    Console.WriteLine($"{playerName} ma {lifePoints} punktow zycia" +
                                      $" \nPrzeciwnik ma {monsterLife} punktow zycia");  
                }
                else
                {
                        Console.WriteLine("Remis!");
                }
                /*Console.WriteLine($"{playerName} ma {lifePoints} punktow zycia" +
                                  $" \nPrzeciwnik ma {monsterLife} punktow zycia");*/
                if (lifePoints <= 0)
                {
                    Console.WriteLine("Przeciwnik zwyciezyl!");
                }
                else if (monsterLife <= 0)
                {
                    Console.WriteLine($"{playerName} zwyciezyl!");
                }
            }
        }
    }
}