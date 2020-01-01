
namespace JobBoard.DataAccess.Abstract
{
    public interface IRepositoryWrapper
    {

        IUserRepository User { get; }

        ICompanyRepository Company { get; }

        IJobOfferRepository JobOffer { get; }

        IEducationRepository Education { get; }

        ILanguageRepository Language { get; }

        IResumeRepository Resume { get; }

        ISkillRepository Skill { get; }

        IWorkingExperienceRepository WorkingExperience { get; }

        void Save();
    }
}
