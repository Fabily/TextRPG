using Skills;

namespace Enemies
{
    internal class Wolf : Enemy
    {
        /// <summary>
        /// Creates a new wolf
        /// </summary>
        public Wolf()
        {
            base.Name = "Wolf";
            base.Health = 3f;
            base.Skills.Add(new Skill(SkillNames.Bite, 1f, 0f, 1, 0f));
            base.BaseMana = 5;
        }
    }
}