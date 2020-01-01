using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Models.ManageViewModels
{
    public class workingexperienceViewModel
    {
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
        public List<WorkingExperience> ResumeWorkingExperiences { get; set; }
    }
}
