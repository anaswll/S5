using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class ResumeRepository : RepositoryBase<Resume>, IResumeRepository
    {
        public ResumeRepository(JobBoardDbContext repositoryContext)
            : base(repositoryContext) { }

        public async Task<IEnumerable<Resume>> FindAllOfAsync()
        {
            return await FindAll()
               .Include(e => e.ResumeEducations)
               .Include(e => e.ResumeLanguages)
               .Include(e => e.ResumeSkills)
               .Include(e => e.ResumeWorkingExperiences)
               .OrderBy(x => x.Id)
               .ToListAsync();
        }

        public async Task<Resume> FindByIdAsync(string id)
        {
            return await JobBoardContext
                .Resumes
                .Include(e => e.ResumeEducations)
                .Include(e => e.ResumeLanguages)
                .Include(e => e.ResumeSkills)
                .Include(e => e.ResumeWorkingExperiences)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task CreateResumeAsync(Resume Resume)
        {
            //Resume.Id = new int();
            Create(Resume);
            await SaveAsync();
        }

        public async Task UpdateResumeAsync(Resume dbResume, Resume Resume)
        {
            dbResume.ResumeMap(Resume);
            Update(dbResume);
            await SaveAsync();
        }

        public async Task DelelteResumeAsync(Resume Resume)
        {
            Delete(Resume);
            await SaveAsync();
        }
    }
}
