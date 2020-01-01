using JobBoard.Entities.dbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobBoard.BusinessComponent.Extensions.Helpers
{
    public static class JobOfferHelpers
    {
        public static ICollection<JobOffer> ToJobOfferListDto(ICollection<JobOffer> jobOffers)
        {
            return jobOffers?.Select(j => ToJobOfferDto(j)).ToList();
        }

        private static JobOffer ToJobOfferDto(JobOffer jobOffer)
        {
            return new JobOffer
            {
                About = jobOffer.About,
                PostingDate = jobOffer.PostingDate,
                StartingDate = jobOffer.StartingDate,
                Field = jobOffer.Field
            };
        }
    }
}
