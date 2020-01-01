
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoard.Entities.dbModels
{
    [Table("Offer")]
    public class JobOffer : IEntityBase
    {

        [Key]
        [Column("OfferId")]
        public int Id { set; get; }

        [Column("About")]
        [Required(ErrorMessage = "About is Required")]
        public string About { set; get; }

        [Column("PostingDate")]
        [Required(ErrorMessage = "PostingDate is Required")]
        public DateTime PostingDate;

        [Column("StartingDate")]
        [Required(ErrorMessage = "StartingDate is Required")]
        public DateTime StartingDate;

        [Column("Field")]
        [Required(ErrorMessage = "Field is Required")]
        public string Field;

        public JobOffer()
        {

        }

        public JobOffer(string About, DateTime PostingDate, DateTime StartingDate, string Field)
        {
            this.About = About;
            this.PostingDate = PostingDate;
            this.StartingDate = StartingDate;
            this.Field = Field;
        }

    }
}
