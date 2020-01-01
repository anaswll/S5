using JobBoard.Entities.dbModels;

namespace JobBoard.DataAccess
{
    public static class EntityExtensions
    {
        public static void EducationMap(this Educations dbEducation, Educations education)
        {
            dbEducation.University = education.University;
            dbEducation.StartDate = education.StartDate;
            dbEducation.EndDate = education.EndDate;
            dbEducation.Degree = education.Degree;
            dbEducation.AreaField = education.AreaField;
            
        }

        public static void ResumeMap(this Resume dbResume, Resume resume)
        {

            dbResume.FirstName = resume.FirstName;
            dbResume.LastName = resume.LastName;
            dbResume.Address = resume.Address;
            dbResume.Age = resume.Age;
            dbResume.City = resume.City;
            dbResume.Country = resume.Country;
            dbResume.Experience = resume.Experience;
            dbResume.Label = resume.Label;
            dbResume.Phone = resume.Phone;
            //dbResume.Urls = resume.Urls;
            
        }

        public static void WorkingExpMap(this WorkingExperience dbWExp, WorkingExperience wExp)
        {
            dbWExp.CompanyName = wExp.CompanyName;
            dbWExp.Descritpion = wExp.Descritpion;
            dbWExp.Position = wExp.Position;
            dbWExp.StartDate = wExp.StartDate;
            dbWExp.EndDate = wExp.EndDate;
        }

        public static void JobOfferMap(this JobOffer dbJobOffer, JobOffer jobOffer)
        {
            dbJobOffer.Field = jobOffer.Field;
            dbJobOffer.StartingDate = jobOffer.StartingDate;
            dbJobOffer.PostingDate = jobOffer.PostingDate;
            dbJobOffer.About = jobOffer.About;

        }

        public static void CompanyMap( this Company dbCompany, Company company)
        {
            dbCompany.sectorField = company.sectorField;
            dbCompany.numOfEmployee = company.numOfEmployee;
            dbCompany.location = company.location;
            dbCompany.creationDate = company.creationDate;
            dbCompany.capitalStock = company.capitalStock;
            dbCompany.CompanyJobOffers = company.CompanyJobOffers;
        }
    }
}
