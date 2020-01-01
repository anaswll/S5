using JobBoard.DataAccess.Abstract;
using JobBoard.Entities.dbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.BusinessComponents.UseCases
{
    public class offersUseCase
    {
        private IJobOfferRepository _repository;
        //private readonly IEnumerable<JobOffer> _jobOffers;
        public ICollection<JobOffer> theseAllOffers { set; get; }

        public offersUseCase(IJobOfferRepository repository, IEnumerable<JobOffer> jobs)
        {
            _repository = repository;
            //_jobOffers = jobs;
        }

        public async Task<ICollection<JobOffer>> getAllOffersAsync(string specification)
        {

            var offers = await _repository.FindAllAsync();
            foreach(var o in offers)
            {
                try
                {
                    if (o.Field == specification)
                    {
                        theseAllOffers.Append(o);
                    }

                }

                catch(Exception e)
                {
                    e.ToString();
                }
                
                theseAllOffers.OrderBy(j => j.PostingDate);
            }
            return theseAllOffers;
        }

        private  async Task<bool> PostOffer(JobOffer jobOffer)
        {

            bool status;
            try
            {
                await _repository.CreateOfferJobAsync(jobOffer);
                status = true;
            }
            catch(Exception)
            {
                status = false;
            }
            return status;            
           
        }



    }
}
