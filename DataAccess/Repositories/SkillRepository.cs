using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class SkillRepository : RepositoryBase<Skill>, ISkillRepository
    {
        public SkillRepository(JobBoardDbContext repositoryContext)
            : base(repositoryContext) { }

        public async Task<IEnumerable<Skill>> FindAllOfAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Id)
               .ToListAsync();
        }

        public async Task<Skill> FindByIdAsync(int id)
        {
            return await FindByCondition(e => e.Id.Equals(id))
                .DefaultIfEmpty(new Skill())
                .SingleAsync();
        }

        public async Task CreateSkillAsync(Skill Skill)
        {
            Skill.Id = new int();
            Create(Skill);
            await SaveAsync();
        }

        //public async Task UpdateSkillAsync(Skill dbSkill, Skill Skill)
        //{
        //    dbSkill.Map(Skill);
        //    Update(dbSkill);
        //    await SaveAsync();
        //}

        public async Task DelelteSkillAsync(Skill Skill)
        {
            Delete(Skill);
            await SaveAsync();
        }
    }
}
