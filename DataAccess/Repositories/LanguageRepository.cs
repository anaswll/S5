using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
        public LanguageRepository(JobBoardDbContext repositoryContext)
            : base(repositoryContext) { }

        public async Task<IEnumerable<Language>> FindAllOfAsync()
        {
            return await FindAll()
               .OrderBy(x => x.LanguageTitle)
               .ToListAsync();
        }

        public async Task<Language> FindByIdAsync(int id)
        {
            return await FindByCondition(e => e.Id.Equals(id))
                .DefaultIfEmpty(new Language())
                .SingleAsync();
        }

        public async Task CreateLanguageAsync(Language Language)
        {
            Language.Id = new int();
            Create(Language);
            await SaveAsync();
        }

        //public async Task UpdateLanguageAsync(Language dbLanguage, Language Language)
        //{
        //    dbLanguage.Map(Language);
        //    Update(dbLanguage);
        //    await SaveAsync();
        //}

        public async Task DelelteLanguageAsync(Language Language)
        {
            Delete(Language);
            await SaveAsync();
        }
    }
}
