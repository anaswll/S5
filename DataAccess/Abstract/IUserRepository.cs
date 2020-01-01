
using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Abstract
{
    public interface IUserRepository : IRepositoryBase<JBUser>
    {

        Task<IEnumerable<JBUser>> FindAllOfAsync();

        Task<JBUser> FindByIdAsync(string id);

        Task CreateUserAsync(JBUser user);

        Task UpdateUserAsync(JBUser dbuser, JBUser user);

        Task DelelteUserAsync(JBUser user);

    }
}
