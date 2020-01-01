using JobBoard.Entities.dbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobBoard.BusinessComponents.Extensions.Helpers
{
    public static class SkillHelpers
    {
        public static List<Skill> ToSkillDtoList(List<Skill> skills)
        {
            return skills?.Select(s => ToSkillDto(s)).ToList();
        }

        private static Skill ToSkillDto(Skill skill)
        {
            return new Skill
            {
                Name = skill.Name,
                Level = skill.Level,
                YearExperience = skill.YearExperience
            };
        }
    }
}
