
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoard.Entities.dbModels
{
    [Table("language")]
    public class Language : IEntityBase
    {
        [Key]
        [Column("LanguageId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Language title is required")]
        public string LanguageTitle { get; set; }

        [Required(ErrorMessage = "Fluenty is required")]
        public LangLevel Level { get; set; }

        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public string UserId { get; set; }


        public Language()
        {

        }

        public Language(string language, LangLevel level)
        {
            this.LanguageTitle = language;
            this.Level = level;
        }
    }

    //Construct
   

    public enum LangLevel
    {
        Native,
        BusinnesFluent,
        Proficient
    }
}
