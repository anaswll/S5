using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Linq;

namespace JobBoard.BusinessComponents.Extensions.Helpers
{
    public static class WorkingExperienceHelpers
    {
        public static ICollection<WorkingExperience> ToWorkingExperienceDtoList(ICollection<WorkingExperience> wExperience)
        {
            return wExperience?.Select(w => ToWorkingExperienceDto(w)).ToList();
        }

        private static WorkingExperience ToWorkingExperienceDto(WorkingExperience workingExpeience)
        {
            return new WorkingExperience
            {
                CompanyName = workingExpeience.CompanyName,
                Position = workingExpeience.Position,
                Descritpion = workingExpeience.Descritpion,
                StartDate = workingExpeience.StartDate,
                EndDate = workingExpeience.EndDate,
            };
        }
    }
}
