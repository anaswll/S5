using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoard.Entities.dbModels
{
    [Table("resume")]
    public class Resume
    {
        [Key]
        [Column("ResumeId")]
        public string Id { get; set; }

        //[Required/*(ErrorMessage = "First Name is Required")*/]
        public string FirstName { get; set; }

        //[Required/*(ErrorMessage = "Last Name is Required")*/]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Label { get;  set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get;  set; }

        public string Phone { get;  set; }

        public string Address { get;  set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get;  set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get;  set; }

        //public List<string> Urls { get;  set; }

        [Required(ErrorMessage = "Experience level is required")]
        public Maturity Experience { get; set; }
        
        public string UserId { get; set; }
        //[ForeignKey("Id")]
        public JBUser User { get; set; }

        public List<Skill> ResumeSkills { get; set; }
        public ICollection<Language> ResumeLanguages { get; set; }
        public ICollection<Educations> ResumeEducations { get; set; }
        public ICollection<WorkingExperience> ResumeWorkingExperiences { get; set; }



        /*public  postOffer()
        {

        }*/

        public Resume()
        {

        }

        public Resume(string firstName, string lastName, string label, int age, string phone, string address, string city, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Label = label;
            this.Age = age;
            this.Phone = phone;
            this.Address = address;
            this.City = city;
            this.Country = country;
            //this.Urls = urls;
        }

        
    }

    public enum Maturity
    {
        Junior = 1, 
        Senior = 2, 
        Expert = 3
    } 


}
