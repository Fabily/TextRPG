using Skills;

namespace Classes
{
    public class Gunslinger : BaseClass
    {
        /// <summary>
        /// Creates a new wizard
        /// </summary>
        public Gunslinger()
        {
            base.ClassName = "Gunslinger";
            base.Health = 20f;
            base.Skills.Add(new Skill(SkillNames.Headshot, 2f, 0f, 1, 0f));
            base.BaseMana = 4;
            base.Experience = 0f;
            base.Gold = 0f;
        }
    }
}