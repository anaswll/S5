using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess
{
    public interface ISkillRepository : IRepositoryBase<Skill>
    {
        Task<IEnumerable<Skill>> FindAllOfAsync();

        Task<Skill> FindByIdAsync(int id);

        Task CreateSkillAsync(Skill skill);

        //Task UpdateSkillAsync(Skill dbSkill, Skill skill);

        Task DelelteSkillAsync(Skill skill);
    }
}
