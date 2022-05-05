using Classes;
using Enemies;

namespace ClassSelector
{
    public class Program
    {
        //The player's class
        private static BaseClass playerClass;

        private static Enemy enemy;
        private static List<Enemy> possibleEnemies = new List<Enemy>();
        public static readonly Random rnd = new Random();

        private static void Main()
        {
            possibleEnemies.Add(new Goblin());

            SelectClass();
            SpawnEnemy();
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
                switch (Console.ReadLine().ToUpper())
                {
                    case "WIZARD":
                        Console.WriteLine("You have chosen the class Wizard!");
                        playerClass = new Wizard();
                        return;
                        break;

                    case "ASSASSIN":
                        Console.WriteLine("You have chosen the class Assassin!");
                        playerClass = new Assasin();
                        return;
                        break;

                    case "GUNSLINGER":
                        Console.WriteLine("You have chosen the class Gunslinger!");
                        playerClass = new Gunslinger();
                        return;
                        break;

                    case "PALADIN":
                        Console.WriteLine("You have chosen the class Paladin!");
                        playerClass = new Paladin();
                        return;
                        break;

                    default:
                        Console.WriteLine("Your input does not match one of the given options!");
                        break;
                }
            }
        }

        public static void SpawnEnemy()
        {
            enemy = new Goblin();

            Console.WriteLine($"A {enemy.Name} has appeared and has forced you into Battle!");
        }
    }
}