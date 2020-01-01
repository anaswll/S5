
using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Abstract
{
    public interface ICompanyRepository : IRepositoryBase<Company>
    {
        Task<IEnumerable<Company>> FindAllOfAsync();

        Task<Company> FindByIdAsync(string id);

        Task CreateCompanyAsync(Company company);

        Task UpdateCompanyAsync(Company dbCompany, Company company);

        Task DelelteCompanyAsync(Company company);
    }
}
