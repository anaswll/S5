using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess
{
    public interface IResumeRepository : IRepositoryBase<Resume>
    {
        Task<IEnumerable<Resume>> FindAllOfAsync();

        Task<Resume> FindByIdAsync(string id);

        Task CreateResumeAsync(Resume resume);

        Task UpdateResumeAsync(Resume dbResume, Resume resume);

        Task DelelteResumeAsync(Resume resume);
    }
}
