using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class WorkingExperienceRepository : RepositoryBase<WorkingExperience>, IWorkingExperienceRepository
    {
        public WorkingExperienceRepository(JobBoardDbContext repositoryContext)
            : base(repositoryContext) { }

        public async Task<IEnumerable<WorkingExperience>> FindAllOfAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Id)
               .ToListAsync();
        }

        public async Task<WorkingExperience> FindByIdAsync(int id)
        {
            return await FindByCondition(e => e.Id.Equals(id))
                .DefaultIfEmpty(new WorkingExperience())
                .SingleAsync();
        }

        public async Task CreateWorkingExperienceAsync(WorkingExperience WorkingExperience)
        {
            WorkingExperience.Id = new int();
            Create(WorkingExperience);
            await SaveAsync();
        }

        public async Task UpdateWorkingExperienceAsync(WorkingExperience dbWorkingExperience, WorkingExperience WorkingExperience)
        {
            dbWorkingExperience.WorkingExpMap(WorkingExperience);
            Update(dbWorkingExperience);
            await SaveAsync();
        }

        public async Task DelelteWorkingExperienceAsync(WorkingExperience WorkingExperience)
        {
            Delete(WorkingExperience);
            await SaveAsync();
        }
    }
}
