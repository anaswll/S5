
using JobBoard.DataAccess.Abstract;
using JobBoard.DataAccess.Repositories;

namespace JobBoard.DataAccess
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private JobBoardDbContext _repoContext;
        private IUserRepository _user;
        private ICompanyRepository _company;
        private IJobOfferRepository _jobOffer;
        private IEducationRepository _education;
        private ILanguageRepository _lang;
        private ISkillRepository _skill;
        private IResumeRepository _resume;
        private IWorkingExperienceRepository _wExp;

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new JBUserRepository(_repoContext);
                }

                return _user;
            }
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_company == null)
                {
                    _company = new CompanyRepository(_repoContext);
                }
                return _company;
            }
        }


        public IJobOfferRepository JobOffer
        {
            get
            {
                if (_jobOffer == null)
                {
                    _jobOffer = new JobOfferRepository(_repoContext);
                }

                return _jobOffer;

            }
        }

        public IEducationRepository Education
        {
            get
            {
                if (_education == null)
                {
                    _education = new EducationRepository(_repoContext);
                }

                return _education;
            }
        }

        public ILanguageRepository Language
        {
            get
            {
                if (_lang == null)
                {
                    _lang = new LanguageRepository(_repoContext);
                }

                return _lang;
            }
        }

        public ISkillRepository Skill
        {
            get
            {
                if (_skill == null)
                {
                    _skill = new SkillRepository(_repoContext);
                }

                return _skill;
            }
        }

        public IResumeRepository Resume
        {
            get
            {
                if (_resume == null)
                {
                    _resume = new ResumeRepository(_repoContext);
                }

                return _resume;
            }
        }

        public IWorkingExperienceRepository WorkingExperience
        {
            get
            {
                if (_wExp == null)
                {
                    _wExp = new WorkingExperienceRepository(_repoContext);
                }

                return _wExp;
            }
        }

        public RepositoryWrapper(JobBoardDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
