using System;

namespace Enemys
{
    public class Goblin
    {
       public string Name_Goblin;
       public string Skill_Goblin;
        public int HP_Gobling;

       public Goblin(string name_Goblin, string skill_Goblin)
        {
            Name_Goblin = name_Goblin;
            Skill_Goblin = skill_Goblin;
            HP_Gobling = 10;
        }
        public void Stick_Swing()
        {
            if (HP_Gobling > 0)
            {
                Console.WriteLine("The Gobling Jumps in the air and hits you with a Stick");
            }

        }
        



    }
   
    


}
