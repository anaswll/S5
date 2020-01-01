using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoard.Entities.dbModels
{
    [Table("education")]
    public class Educations : IEntityBase
    {
        [Key]
        [Column("EducationId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "University name is required")]
        public string University { get; set; }

        [Required(ErrorMessage = "Speciality and/or area of field is required")]
        public string AreaField { get; set; }

        [Required(ErrorMessage = "Degree is required")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        public static int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public string UserId { get; set; }

        public Educations()
        {

        }

        public Educations(string university,string areaField, string degree, DateTime startDate, DateTime endDate)
        {
            this.University = university;
            this.AreaField = areaField;
            this.Degree = degree;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        

    }
}
