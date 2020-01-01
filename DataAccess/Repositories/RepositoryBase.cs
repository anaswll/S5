using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected JobBoardDbContext JobBoardContext { get; set; }

        public RepositoryBase(JobBoardDbContext repositoryContext)
        {
            this.JobBoardContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.JobBoardContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.JobBoardContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.JobBoardContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.JobBoardContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.JobBoardContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await this.JobBoardContext.SaveChangesAsync();
        }
    }
}
