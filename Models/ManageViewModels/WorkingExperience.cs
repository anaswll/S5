using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityDemo.Models.ManageViewModels
{
    public class WorkingExperience
    {
        [Key]
        [Column("WExperienceId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Your position at, is required")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Descritpion { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

       

        public WorkingExperience()
        {
        }

        public WorkingExperience(string company, string position, string description, DateTime startDate, DateTime endDate)
        {
            this.CompanyName = company;
            this.Position = position;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}