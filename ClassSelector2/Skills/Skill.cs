namespace Skills
{
    public class Skill
    {
        /// <summary>
        /// The name of the skill
        /// </summary>
        public SkillNames Name { get; protected set; }

        /// <summary>
        /// The damage the skill can cause
        /// </summary>
        public float Damage { get; protected set; }

        /// <summary>
        /// How much the skill can heal
        /// </summary>
        public float Heal { get; protected set; }

        /// <summary>
        /// The man cost of the skill
        /// </summary>
        public int ManaCost { get; protected set; }

        /// <summary>
        /// The health cost of the skill
        /// </summary>
        public float HealthCost { get; protected set; }

        /// <summary>
        /// Create a new skill
        /// </summary>
        /// <param name="name">The name of the skill (enum)</param>
        /// <param name="damage">How much damage the skill can cause</param>
        /// <param name="heal">How much the skill can heal</param>
        /// <param name="manaCost">How much mana does the skill costs</param>
        /// <param name="healthCost">How much health does the skill costs</param>
        public Skill(SkillNames name, float damage = 0, float heal = 0, int manaCost = 0, float healthCost = 0)
        {
            this.Name = name;
            this.Damage = damage;
            this.Heal = heal;
            this.ManaCost = manaCost;
            this.HealthCost = healthCost;
        }
    }
}