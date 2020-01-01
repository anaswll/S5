
using JobBoard.DataAccess.Abstract;
using JobBoard.Entities.dbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.DataAccess.Repositories
{
    public class JobOfferRepository : RepositoryBase<JobOffer>, IJobOfferRepository
    {
        

        public JobOfferRepository(JobBoardDbContext repositoryContext) 
            : base(repositoryContext) { }

        public async Task CreateOfferJobAsync(JobOffer jobOffer)
        {
            jobOffer.Id = new int();
            Create(jobOffer);
            await SaveAsync();
        }

        public async Task DeleteOfferJobAsync(JobOffer jobOffer)
        {
            Delete(jobOffer);
            await SaveAsync();
        }

        public async Task<IEnumerable<JobOffer>> FindAllAsync()
        {
            return await FindAll()
                .OrderBy(j => j.PostingDate)
                .ToListAsync();
        }

        public async Task<JobOffer> FindByIdAsync(int id)
        {
            return await FindByCondition(e => e.Id.Equals(id))
                .DefaultIfEmpty(new JobOffer())
                .SingleAsync();
        }

        public async Task UpdateOfferJobAsync(JobOffer dbJobOffer, JobOffer jobOffer)
        {
            dbJobOffer.JobOfferMap(jobOffer);
            Update(dbJobOffer);
            await SaveAsync();
        }
    }
}


