using System;
using Selector;

namespace ClassSelector
{
    public class Program
    {
        static void Main()
        {
            SelectClass();
            //Somehow make a system where you can interact and choose what class you want to create and play as 
            //Create enemys and make the player able to fight them
            //Create a skill menu / Skill tree with EXP
            //Create a shop and make gear upgradable 
        }

        public static void SelectClass()
        {
            Console.Clear();
            Console.WriteLine("Pick Your Class!");
            while (true)
            {
                string pickclass = Console.ReadLine();
                string classbutfoolproof = pickclass.ToUpper();
                if (classbutfoolproof == "WIZARD")
                {
                    Console.WriteLine("You have chosen the class Wizard!");
                    break;
                }
                else if (classbutfoolproof == "ASSASSIN")
                {
                    Console.WriteLine("You have chosen the class Assassin!");
                    break;
                }
                else if (classbutfoolproof == "GUNSLINGER")
                {
                    Console.WriteLine("You have chosen the class Gunslinger!");
                    break;
                }
                else if (classbutfoolproof == "PALADIN")
                {
                    Console.WriteLine("You have chosen the class Paladin!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your input does not match one of the given options!");
                }
            }
        }
    }
}