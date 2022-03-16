using System;
using Selector;

namespace ClassSelector
{
    public class Program
    {
        static void Main()
        {
            SelectClasses();
            //Somehow make a system where you can interact and choose what class you want to create and play as 
            //Create enemys and make the player able to fight them
            //Create a skill menu / Skill tree with EXP
            //Create a shop and make gear upgradable 
        }

        public static void SelectClasses()
        {
            Console.WriteLine("Pick Your Class!");
            string answer = Console.ReadLine();
            string answerbutuppercase = answer.ToUpper();

            while (answerbutuppercase != "Wizard" | answerbutuppercase != "Assasin" | answerbutuppercase != "Gunslinger" | answerbutuppercase != "Paladin")
            {
                if (answerbutuppercase == "WIZARD")
                {
                    Console.WriteLine("You have choosen the class Wizard!");
                    //Console.ReadLine();
                    break;
                }
                else if (answerbutuppercase == "ASSASSIN")
                {
                    Console.WriteLine("You have choose the class Assasin!");
                    //Console.ReadLine();
                    break;
                }
                else if (answerbutuppercase == "GUNSLINGER")
                {
                    Console.WriteLine("You have choose the class Gunslinger!");
                    //Console.ReadLine();
                    break;
                }
                else if (answerbutuppercase == "PALADIN")
                {
                    Console.WriteLine("You have choose the class Paladin!");
                    //Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Your input does not match one of the given options!");
                    answer = Console.ReadLine();
                }
            }
        }
    }
}