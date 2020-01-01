using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoard.Entities.dbModels
{
    [Table("skill")]
    public class Skill : IEntityBase
    {
        [Key]
        [Column("SkillId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Skill title is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your level is required")]
        public LevelSkill Level { get; set; }

        [Required(ErrorMessage = "Years of experience is required")]
        public int YearExperience { get; set; }

        public int ResumeId { get; set; }
        public Resume Resume { get; set; }

        public Skill()
        {

        }

        public Skill(string name, LevelSkill level, int yearExperience)
        {
            this.Name = name;
            this.Level = level;
            this.YearExperience = yearExperience;

        }
    }

    public enum LevelSkill
    {
        Begginer,
        Intermmediate,
        Expert
    }
}
