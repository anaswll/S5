
using JobBoard.BusinessComponents.Extensions.Helpers;
using JobBoard.DataAccess.Abstract;
using JobBoard.Entities.dbModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.BusinessComponents.Extensions
{
    public static class ResumeExtensions
    {
        public static async Task<IList<Resume>> GetAllResumes(IRepositoryWrapper _repository)
        {
            var resumes = await _repository.Resume.FindAllOfAsync();

            return resumes.Select(r => new Resume
            {
                FirstName = r.FirstName,
                LastName = r.LastName,
                Label = r.Label,
                Age = r.Age,
                Phone = r.Phone,
                City = r.City,
                Country = r.Country,
                Experience = r.Experience,
                Address = r.Address,
                ResumeLanguages = r.ResumeLanguages != null ? LanguageHelpers.ToLanguageDtoList(r.ResumeLanguages) : null,
                ResumeEducations = r.ResumeEducations != null ? EducationHelpers.ToEducationDtoList(r.ResumeEducations) : null,
                ResumeSkills = r.ResumeSkills != null ? SkillHelpers.ToSkillDtoList(r.ResumeSkills) : null,
                ResumeWorkingExperiences = r.ResumeWorkingExperiences != null ? WorkingExperienceHelpers.ToWorkingExperienceDtoList(r.ResumeWorkingExperiences) : null
            }).ToList();
        }

        public static async Task<Resume> GetResumeById(IRepositoryWrapper _repository, string id)
        {
            var resume = await _repository.Resume.FindByIdAsync(id);

            return new Resume
            {

                FirstName = resume.FirstName,
                LastName = resume.LastName,
                Label = resume.Label,
                Age = resume.Age,
                Phone = resume.Phone,
                City = resume.City,
                Country = resume.Country,
                Experience = resume.Experience,
                Address = resume.Address,
                ResumeLanguages = resume.ResumeLanguages != null ? LanguageHelpers.ToLanguageDtoList(resume.ResumeLanguages) : null,
                ResumeEducations = resume.ResumeEducations != null ? EducationHelpers.ToEducationDtoList(resume.ResumeEducations) : null,
                ResumeSkills = resume.ResumeSkills != null ? SkillHelpers.ToSkillDtoList(resume.ResumeSkills) : null,
                ResumeWorkingExperiences = resume.ResumeWorkingExperiences != null ? WorkingExperienceHelpers.ToWorkingExperienceDtoList(resume.ResumeWorkingExperiences) : null
            };
        }

        public static async Task CreateResume(IRepositoryWrapper _repository, Resume resume)
        {
            await _repository.Resume.CreateResumeAsync(resume);

            _repository.Save();
        }


    }
}
