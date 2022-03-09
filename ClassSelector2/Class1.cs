using System;

namespace Selector
{
    public class Wizard
    {
        public string Name_Wizard;
        public string Skill_Wizard;
        public int Mana;
        public float Experience_Wizard;
        public float Gold_Wizard;

        public Wizard(string name_Wizard, string skill_Wizard)
        {
            Name_Wizard = name_Wizard;
            Skill_Wizard = skill_Wizard;
            Mana = 3;
            Experience_Wizard = 0f;
            Gold_Wizard = 0f;


        }
        public void Fireball()
        {
            if (Mana > 0)
            {
                Console.WriteLine($"{Name_Wizard} casts a Spell and unleashes a {Fireball}!");
            }
            else
            {
                Console.WriteLine($"{Name_Wizard} is out of {Mana}!");
            }
        }
        public void Regenerate_Mana()
        {
            Console.WriteLine($"{Name_Wizard} has stepped out of the Battle to regain his {Mana}");
            Mana = 3;
        }
    }
    public class Assasin
    {
        public string Name_Assasin;
        public string Skill_Assasin;
        public int Energy;
        public float Experience_Assasin;
        public float Gold_Assasin;

        public Assasin(string name_Assasin, string skill_Assasin)
        {
            Name_Assasin = name_Assasin;
            Skill_Assasin = skill_Assasin;
            Energy = 3;
            Experience_Assasin = 0f;
            Gold_Assasin = 0f;  
        }
        public void Backstab()
        {
            if (Energy > 0)
            {
                Console.WriteLine($"{Name_Assasin} dashes behind the enemy and performs a {Backstab}!");
            }
            else
            {
                Console.WriteLine($"{Name_Assasin} is out of {Energy}!");
            }
            
        }
        public void Regenerate_Energy()
        {
            Console.WriteLine($"{Name_Assasin} dashes away from the fight and hides in the shadows to regain {Energy}!");
            Energy = 3;
        }

    }

    public class Paladin
    {
        public string Name_Paladin;
        public string Skill_Paladin;
        public int Mana_Paladin;
        public float Experience_Paladin;
        public float Gold_Paladin;

        public Paladin(string name_Paladin, string skill_Paladin)
        {
            Name_Paladin = name_Paladin;
            Skill_Paladin = skill_Paladin;
            Mana_Paladin = 5;
            Experience_Paladin = 0f;
            Gold_Paladin = 0f;
        }
        public void Heal()
        {
            if (Mana_Paladin > 0)
            {
                Console.WriteLine($"{Name_Paladin} is channeling the energy of the light to {Heal} his teammates!");
            }
            else
            {
                Console.WriteLine($"{Name_Paladin} is out of {Mana_Paladin}");
            }
        }
        public void Regenerate_Mana_Paladin()
        {
            Console.WriteLine($"{Name_Paladin} steps away from the fight and prays to regain {Mana_Paladin}!");
            Mana_Paladin = 5;
        }
    }
}
    