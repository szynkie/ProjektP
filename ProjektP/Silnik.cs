using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace ProjektP
{
    public class Silnik
    {
        public static void Player()
        {
            int playerId = 0;
            int lifePoints;
            int attackPoints;
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
            int monsterLife;
            int monsterAttack;
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
        }
    }
}