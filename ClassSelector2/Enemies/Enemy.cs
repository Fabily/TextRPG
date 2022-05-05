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
        public Dictionary<SkillNames, Skill> Skills { get; protected set; } = new Dictionary<SkillNames, Skill>();

        /// <summary>
        /// Base constructor
        /// </summary>
        public Enemy()
        {
            Mana = BaseMana;
            Health = BaseHealth;
        }

        /// <summary>
        /// Attacks the player
        /// </summary>
        /// <param name="skillName">The name of the skill the enemy used</param>
        public void Attack(SkillNames skillName)
        {
            if (!Skills.ContainsKey(skillName))
            {
                Console.WriteLine("The enemy doesn't have such spell");
                return;
            }
            Skill skill = Skills[skillName];
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