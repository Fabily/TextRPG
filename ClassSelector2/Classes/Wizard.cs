using Skills;

namespace Classes
{
    public class Wizard : BaseClass
    {
        /// <summary>
        /// Creates a new wizard
        /// </summary>
        public Wizard()
        {
            base.ClassName = "WIZARD";
            base.Health = 20f;
            base.Skills.Add(new Skill(SkillNames.Fireball, 2f, 0f, 1, 0f));
            base.BaseMana = 3;
            base.Experience = 0f;
            base.Gold = 0f;
        }
    }
}