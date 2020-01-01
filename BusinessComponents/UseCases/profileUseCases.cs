using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using JobBoard.DataAccess;
using JobBoard.Entities.dbModels;
using System.Threading.Tasks;

namespace JobBoard.BusinessComponents.UseCases
{
    public class profileUseCases
    {
        private IResumeRepository _repositoryResume;
        private IEducationRepository _repositroyEducation;
        private ISkillRepository _repostitorySkill;
        private IWorkingExperienceRepository _repositoryExp;
        private ILanguageRepository _repositoryLanguage;
        private Resume Resume { set; get; }
        private ICollection<Educations> myAllEducations { set; get; }

        public profileUseCases(IResumeRepository repositoryResume,
            IEducationRepository repositroyEducation,
            ISkillRepository repostitorySkill,
            IWorkingExperienceRepository repositoryExp,
            ILanguageRepository repositoryLanguage)
        {
            _repositoryResume = repositoryResume;
            _repositroyEducation = repositroyEducation;
            _repositoryLanguage = repositoryLanguage;
            _repostitorySkill = repostitorySkill;
            _repositoryExp = repositoryExp;
        }

        public async Task<Resume> myResume(string Id)
        {
            try
            {
                var Resume = await _repositoryResume.FindByIdAsync(Id);
            }
            catch(Exception e)
            {
                Console.WriteLine("Resume Not Found " + e.Message);
            }

            return Resume;
            
        }

        public async Task<bool> PostMyResume(Resume resume)
        {
            bool status;
            try
            {
                await _repositoryResume.CreateResumeAsync(resume);
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }

            return status;
        }

        public async Task<ICollection<Educations>> GetAllEducationAsync()
        {
            try
            {
                var education = await _repositroyEducation.FindAllOfAsync();
                foreach (var e in education)
                {
                    myAllEducations.Append(e).OrderByDescending(o => o.EndDate);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Educations Not Found " + e.Message);
            }
            return myAllEducations;
        }  

        

        
        
    }
}
