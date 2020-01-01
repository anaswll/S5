using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class EducationRepository : RepositoryBase<Educations>, IEducationRepository
    {
        public EducationRepository(JobBoardDbContext repositoryContext)
            : base(repositoryContext) { }

        public async Task<IEnumerable<Educations>> FindAllOfAsync()
        {
            return await FindAll()
               .OrderBy(x => x.StartDate)
               .ToListAsync();
        }

        public async Task<Educations> FindByIdAsync(int id)
        {
            return await FindByCondition(e => e.Id.Equals(id))
                .DefaultIfEmpty(new Educations())
                .SingleAsync();
        }

        public async Task CreateEducationAsync(Educations education)
        {
            education.Id = new int();
            Create(education);
            await SaveAsync();
        }

        public async Task UpdateEducationAsync(Educations dbEducation, Educations education)
        {
            dbEducation.EducationMap(education);
            Update(dbEducation);
            await SaveAsync();
        }

        public async Task DelelteEducationAsync(Educations education)
        {
            Delete(education);
            await SaveAsync();
        }
    }
}
