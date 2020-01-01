using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess
{
    public interface IEducationRepository : IRepositoryBase<Educations>
    {
        Task<IEnumerable<Educations>> FindAllOfAsync();

        Task<Educations> FindByIdAsync(int id);

        Task CreateEducationAsync(Educations education);

        Task UpdateEducationAsync(Educations dbEducation, Educations education);

        Task DelelteEducationAsync(Educations education);
    }
}
