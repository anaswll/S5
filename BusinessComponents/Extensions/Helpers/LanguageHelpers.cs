using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Linq;

namespace JobBoard.BusinessComponents.Extensions.Helpers
{
    public static class LanguageHelpers
    {
        public static ICollection<Language> ToLanguageDtoList(ICollection<Language> languages)
        {
            return languages?.Select(l => ToLanguageDto(l)).ToList();
        }

        private static Language ToLanguageDto(Language language)
        {
            return new Language
            {
                LanguageTitle = language.LanguageTitle,
                Level = language.Level
            };
        }
    }
}
