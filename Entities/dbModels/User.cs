using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoard.Entities.dbModels
{
    [Table("User")]
    public class JBUser : IdentityUser
    {
        [Key]
        [Column("userId")]
        public override string Id { set; get; }

        //[Required(ErrorMessage = "Full Name is Required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public override string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        protected string Password { get; set; }

        public string Adress { set; get; }

        public Resume Resume { get; set; }
        public Company Company { get; set; }

        public JBUser()
        {
        }
    }
}
