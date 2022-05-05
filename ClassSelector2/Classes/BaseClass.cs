using System;
using System.Collections.Generic;
using Skills;
using Enemies;

namespace Classes
{
    public abstract class BaseClass
    {
        /// <summary>
        /// The name of the class
        /// </summary>
        public string ClassName { get; protected set; }

        /// <summary>
        /// The current health of the player
        /// </summary>
        public float Health { get; protected set; }

        /// <summary>
        /// The maximum health of the player
        /// </summary>
        public float BaseHealth { get; protected set; }

        /// <summary>
        /// The current mana of the player
        /// </summary>
        public int Mana { get; protected set; }

        /// <summary>
        /// The maximum amount of mana the class can have
        /// </summary>
        public int BaseMana { get; protected set; }

        /// <summary>
        /// The current number of experience of the player
        /// </summary>
        public float Experience { get; protected set; }

        /// <summary>
        /// The current number of gold of the player
        /// </summary>
        public float Gold { get; protected set; }

        /// <summary>
        /// The skills the class has
        /// </summary>
        public Dictionary<SkillNames, Skill> Skills { get; protected set; } = new Dictionary<SkillNames, Skill>();

        /// <summary>
        /// Base constructor
        /// </summary>
        public BaseClass()
        {
            Mana = BaseMana;
            Health = BaseHealth;
        }

        /// <summary>
        /// Should be called when the player exits combat
        /// </summary>
        public void OutOfCombat()
        {
            Console.WriteLine($"{ClassName} has stepped out of the Battle to regain his mana");
            Mana = BaseMana;
        }

        /// <summary>
        /// Regenerate healt or mana
        /// </summary>
        /// <param name="mana">The mana to regenerate</param>
        /// <param name="health">The health to regenerate</param>
        public void Regenerate(int mana, float health)
        {
            this.Mana += mana;
            this.Health += health;
            if (Mana > BaseMana)
            {
                Mana = BaseMana;
            }

            if (Health > BaseHealth)
            {
                Health = BaseHealth;
            }
        }

        /// <summary>
        /// Casts the spell which was given at the given target
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="target"></param>
        public void CastSpell(SkillNames skillName, Enemy target)
        {
            if (!Skills.ContainsKey(skillName))
            {
                Console.WriteLine("The class doesn't have such spell");
                return;
            }
            Skill skill = Skills[skillName];
            if (Mana >= skill.ManaCost && Health >= skill.HealthCost)
            {
                Console.WriteLine($"Casted {skillName.ToString()} and caused {skill.Damage} points damage");
                Mana -= skill.ManaCost;
                Health -= skill.HealthCost;
            }
            else
            {
                Console.WriteLine("Can't cast not enough mana");
            }
        }
    }
}