
using JobBoard.DataAccess.Abstract;
using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(JobBoardDbContext Repository) 
            : base(Repository){ }

        public async Task CreateCompanyAsync(Company company)
        {
            //company.Id = new string();
            Create(company);
            await SaveAsync();


        }

        public async Task DelelteCompanyAsync(Company company)
        {
            Delete(company);
            await SaveAsync();
        }

        public async Task<IEnumerable<Company>> FindAllOfAsync()
        {
            return await FindAll()
                .OrderBy(c => c.sectorField)
                .ToListAsync();
        }

        public async Task<Company> FindByIdAsync(string id)
        {
            return await FindByCondition(c => c.Equals(id))
                .DefaultIfEmpty(new Company())
                .SingleAsync();
        }

        public async Task UpdateCompanyAsync(Company dbCompany, Company company)
        {
            dbCompany.CompanyMap(company);
            Update(dbCompany);
            await SaveAsync();   
        }
    }
}
