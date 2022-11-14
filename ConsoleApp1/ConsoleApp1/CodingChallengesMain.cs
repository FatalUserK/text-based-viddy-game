using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CodingChallengesMain
    {
        static void fight()
        {
            int battleEnd = 0;
            int MonsterHealth = 30;
            int PlayerHealth = 20;
            while (battleEnd == 0)
            {
                Text.Print("\n\nA monster appears!\n", 30);
                Text.Print("Monster Health: " + MonsterHealth + "\n", 5);
                Text.Print("Player Health: " + PlayerHealth + "\n", 5);
                Random rnd = new Random();
                int randNumber = rnd.Next(1, 3);
                switch (randNumber)
                {
                    case 1:
                        Text.Print("Monster gets up close!", 30);
                        break;
                    case 2:
                        Text.Print("Monster Attempts to Flee", 30);
                        break;
                    case 3:
                        Text.Print("Monster prepares a healing spell", 30);
                        break;
                }
                Text.Print("\n\n What will you do?\n  Punch [Z]\n  Shoot [X]\n Block [C]\n\n", 20);

                bool PlayerTurn = true;

                while (PlayerTurn == true)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true);

                        switch (key.Key)
                        {
                            case ConsoleKey.Z:
                                PlayerTurn = false;
                                break;
                            case ConsoleKey.X:
                                PlayerTurn = false;
                                randNumber += 3;
                                break;
                            case ConsoleKey.C:
                                PlayerTurn = false;
                                randNumber += 6;
                                break;

                        }
                    }
                }

                switch (randNumber)
                {
                    case 1:
                        Text.Print("Monster successfully blocks and counters dealing 5 Damage!\n", 30);
                        PlayerHealth -= 5;
                        break;
                    case 2:
                        Text.Print("Monster escapes you successfully, Battle End!", 30);
                        battleEnd = 3;
                        break;
                    case 3:
                        Text.Print("Monster is caught off guard and takes 10 Damage!", 30);
                        MonsterHealth -= 10;
                        break;
                    case 4:
                        Text.Print("Monster is too close! Monster deals 10 Damage", 30);
                        PlayerHealth -= 10;
                        break;
                    case 5:
                        Text.Print("Player successfully hits Monster, Monster takes 10 Damage!", 30);
                        MonsterHealth -= 10;
                        break;
                    case 6:
                        Text.Print("Monster sees Player readying their bow and succesfully dodges!", 30);
                        break;
                    case 7:
                        Text.Print("Monster attempts to attack but is blocked, Player counters and deals 5 Damage!", 30);
                        break;
                    case 8:
                        Text.Print("Monster successfully flees as Player does nothing, Battle End!", 30);
                        battleEnd = 3;
                        break;
                    case 9:
                        Text.Print("Monster Successfully Heals 5 HP!", 30);
                        MonsterHealth += 5;
                        break;
                }

                if (MonsterHealth < 1) { battleEnd = 1; }
                else if (PlayerHealth < 1) { battleEnd = 2; }
                else { battleEnd = 0; };

            }
            switch (battleEnd)
            {
                case 1:
                    Text.Print("\n\nPlayer Successfully Won with " + PlayerHealth + " HP!\n\n", 50);
                    break;
                case 2:
                    Text.Print("\n\nPlayer Died! Monster survived with " + MonsterHealth + " HP!\n\n", 50);
                    break;
                case 3:
                    Text.Print("\n\nMonster escaped the Player successfully and went on to murder 37 people, Player was then tried for their crimes of failing to subjugate the monster and was sentenced to public execution, along with all those related and associated to them.\n\n", 50);
                    break;


            }
        }
    }
}
