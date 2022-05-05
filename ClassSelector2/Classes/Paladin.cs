using Skills;

namespace Classes
{
    public class Paladin : BaseClass
    {
        /// <summary>
        /// Creates a new wizard
        /// </summary>
        public Paladin()
        {
            base.ClassName = "Paladin";
            base.Health = 30f;
            base.Skills.Add(new Skill(SkillNames.Heal, 0f, 3f, 1, 0f));
            base.BaseMana = 4;
            base.Experience = 0f;
            base.Gold = 0f;
        }
    }
}