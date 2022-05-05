using System;
using System.Collections.Generic;
using Skills;

namespace Enemies
{
    public abstract class Enemy
    {
        /// <summary>
        /// The name of the enemy
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The current health of the enemy
        /// </summary>
        public float Health { get; protected set; }

        /// <summary>
        /// The maximum health of the enemy
        /// </summary>
        public float BaseHealth { get; protected set; }

        /// <summary>
        /// The current mana of the enemy
        /// </summary>
        public int Mana { get; protected set; }

        /// <summary>
        /// The maximum amount of mana the enemy can have
        /// </summary>
        public int BaseMana { get; protected set; }

        /// <summary>
        /// The skills the enemy has
        /// </summary>
        public List<Skill> Skills { get; protected set; } = new List<Skill>();

        //--------------------------------------------------------
        /// <summary>
        /// Base constructor
        /// </summary>
        public Enemy()
        {
            Mana = BaseMana;
            Health = BaseHealth;
        }

        //-----------------------------------------------------
        /// <summary>
        /// Resets the enemy back to it's initial state
        /// </summary>
        public void ResetStats()
        {
            Mana = BaseMana;
            Health = BaseHealth;
        }

        //---------------------------------------------------------
        /// <summary>
        /// Attacks the player with a random skill
        /// </summary>
        public void AttackUsingRandomSkill()
        {
            if (Skills.Count == 0)
            {
                Console.WriteLine($"{Name} doesn't have any skills");
                return;
            }

            Attack(Skills[ClassSelector.Program.rnd.Next(0, Skills.Count)].Name);
        }

        //--------------------------------------------------------------------------
        /// <summary>
        /// Attacks the player
        /// </summary>
        /// <param name="skillName">The name of the skill the enemy used</param>
        public void Attack(SkillNames skillName)
        {
            if (Skills.FindIndex(x => x.Name == skillName) == -1)
            {
                Console.WriteLine("The enemy doesn't have such spell");
                return;
            }
            Skill skill = Skills.Find(x => x.Name == skillName);
            if (Mana >= skill.ManaCost && Health >= skill.HealthCost)
            {
                Console.WriteLine($"Enemy used {skillName.ToString()} and caused {skill.Damage} points damage");
                Mana -= skill.ManaCost;
                Health -= skill.HealthCost;
            }
            else
            {
                Console.WriteLine("Eneny can't cast not enough mana or health");
            }
        }
    }
}