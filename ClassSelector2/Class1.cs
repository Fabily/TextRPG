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

    }
}
    