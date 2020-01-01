using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Models.ManageViewModels
{
    public class ResumeViewModel
    {
        public string fname { get; set; }

        public string lname { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Label { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

    }
}
