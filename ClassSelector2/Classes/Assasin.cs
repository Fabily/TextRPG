using Skills;

namespace Classes
{
    public class Assasin : BaseClass
    {
        /// <summary>
        /// Creates a new wizard
        /// </summary>
        public Assasin()
        {
            base.ClassName = "Assasin";
            base.Health = 15f;
            base.Skills.Add(new Skill(SkillNames.BackStab, 4f, 0f, 1, 0f));
            base.BaseMana = 2;
            base.Experience = 0f;
            base.Gold = 0f;
        }
    }
}