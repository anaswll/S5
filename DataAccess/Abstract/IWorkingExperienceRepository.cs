using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess
{
    public interface IWorkingExperienceRepository : IRepositoryBase<WorkingExperience>
    {
        Task<IEnumerable<WorkingExperience>> FindAllOfAsync();

        Task<WorkingExperience> FindByIdAsync(int id);

        Task CreateWorkingExperienceAsync(WorkingExperience wExperience);

        Task UpdateWorkingExperienceAsync(WorkingExperience dbWExperience, WorkingExperience wExperience);

        Task DelelteWorkingExperienceAsync(WorkingExperience wExperience);
    }
}
