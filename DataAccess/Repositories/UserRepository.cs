using JobBoard.DataAccess.Abstract;
using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class JBUserRepository : RepositoryBase<JBUser>, IUserRepository
    {
        public JBUserRepository(JobBoardDbContext Repository) : base(Repository)
        {
        }

        public Task CreateUserAsync(JBUser user)
        {
            throw new NotImplementedException();
        }

        public Task DelelteUserAsync(JBUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<JBUser>> FindAllOfAsync()
        {
            return await FindAll().ToListAsync();
                
        }

        public Task<JBUser> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(JBUser dbuser, JBUser user)
        {
            throw new NotImplementedException();
        }
    }
}
