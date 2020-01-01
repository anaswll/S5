using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Linq;

namespace JobBoard.BusinessComponents.Extensions.Helpers
{
    public static class EducationHelpers
    {
        public static ICollection<Educations> ToEducationDtoList(ICollection<Educations> educations)
        {
            return educations?.Select(e => ToEducationDto(e)).ToList();
        }

        private static Educations ToEducationDto(Educations education)
        {
            return new Educations
            {
                University = education.University,
                Degree = education.Degree,
                StartDate = education.StartDate,
                EndDate = education.EndDate,
                AreaField = education.AreaField
            };
        }
    }
}
