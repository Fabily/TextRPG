using Skills;

namespace Enemies
{
    public class Goblin : Enemy
    {
        /// <summary>
        /// Creates a new Goblin
        /// </summary>
        public Goblin()
        {
            base.Name = "Goblin";
            base.Health = 5f;
            base.Skills.Add(new Skill(SkillNames.Stick_Attack, 1f, 0f, 1, 0f));
            base.BaseMana = 12;
        }
    }
}