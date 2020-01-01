using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Entities.dbModels
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [Column("entrepriseId")]
        public string Id { set; get; }

        [Required(ErrorMessage ="Sector Field is Required")]
        public string sectorField { set; get; }

        public long numOfEmployee { set; get; }

        [Required(ErrorMessage ="Date of creation is Required")]
        public DateTime creationDate { set; get; }

        [Required(ErrorMessage ="Location is Required")]
        public string location { set; get; }
    
        public double capitalStock { set; get; }

        //public IList<Company> companyBranches { set; get; }

        [ForeignKey("Id")]
        public virtual JBUser User { get; set; }

        public ICollection<JobOffer> CompanyJobOffers { set; get; }

        public Company()
        {

        }

        public Company(string sector, long numEmp, DateTime creationDate, string location, double capitalStock,List<Company> branhces)
        {
            this.sectorField = sector;
            this.numOfEmployee = numEmp;
            this.creationDate = creationDate;
            this.location = location;
            //this.companyBranches = branhces;
        }
    }

}
