using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess
{
    public interface ILanguageRepository : IRepositoryBase<Language>
    {
        Task<IEnumerable<Language>> FindAllOfAsync();

        Task<Language> FindByIdAsync(int id);

        Task CreateLanguageAsync(Language language);

        //Task UpdateLanguageAsync(Language dbLanguage, Language language);

        Task DelelteLanguageAsync(Language language);
    }
}
