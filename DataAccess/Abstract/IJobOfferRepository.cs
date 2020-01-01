
using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Abstract
{
    public interface IJobOfferRepository : IRepositoryBase<JobOffer>
    {

        Task<IEnumerable<JobOffer>> FindAllAsync();

        Task<JobOffer> FindByIdAsync(int id);

        Task CreateOfferJobAsync(JobOffer jobOffer);

        Task UpdateOfferJobAsync(JobOffer dbJobOffer, JobOffer jobOffer);

        Task DeleteOfferJobAsync(JobOffer jobOffer);

    }
}

