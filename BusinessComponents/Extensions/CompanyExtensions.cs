using JobBoard.DataAccess.Abstract;
using JobBoard.Entities.dbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.BusinessComponent.Extensions.Helpers
{
    public static class CompanyExtensions
    {
        public static object CompanyJobOffers { get; private set; }

        public static async Task<IList<Company>> GetAllCompanies(IRepositoryWrapper _repository)
        {
            var companies = await _repository.Company.FindAllOfAsync();

            return companies.Select(c => new Company
            {
                sectorField = c.sectorField,
                numOfEmployee = c.numOfEmployee,
                creationDate = c.creationDate,
                location = c.location,
                capitalStock = c.capitalStock,
                CompanyJobOffers = c.CompanyJobOffers != null ? JobOfferHelpers.ToJobOfferListDto(c.CompanyJobOffers) : null
            }).ToList();

        }

        public static async Task<Company> FindCompanyById(IRepositoryWrapper _repository, string id)
        {
            var company = await _repository.Company.FindByIdAsync(id);

            return new Company
            {
                sectorField = company.sectorField,
                numOfEmployee = company.numOfEmployee,
                creationDate = company.creationDate,
                location = company.location,
                capitalStock = company.capitalStock,
                CompanyJobOffers = company.CompanyJobOffers != null ? JobOfferHelpers.ToJobOfferListDto(company.CompanyJobOffers) : null
            };
        }

        public static async Task CreateCompany(IRepositoryWrapper _repository, Company company)
        {
            await _repository.Company.CreateCompanyAsync(company);

            _repository.Save();
        }



    }
}
