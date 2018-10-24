using DB;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facades
{
    public class ExperienceFacade
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Experience> GetAll()
        {
            return unitOfWork.ExperienceRepository.Get();
        }

        public IEnumerable<Experience> GetAllExperiencesFromLanguage(Language language)
        {
            return unitOfWork.ExperienceRepository.Get(Experience => Experience.Languages == language);
        }

        public IEnumerable<Experience> GetAllExperiencesFromWorkTool(WorkTool workTool)
        {
            return unitOfWork.ExperienceRepository.Get(Experience => Experience.WorkTools == workTool);
        }

        public IEnumerable<Experience> GetAllExperiencesFromThirdPartLibary(ThirdPartLibary thirdPartLibary)
        {
            return unitOfWork.ExperienceRepository.Get(Experience => Experience.ThirdPartLibaries == thirdPartLibary);
        }

        public void CreateLanguage(Language lanuage)
        {
            unitOfWork.LanguageRepository.Add(lanuage);
        }

        public void CreateWorkTool(WorkTool workTool)
        {
            unitOfWork.WorkToolRepository.Add(workTool);
        }

        public void CreateThirdPartLibary(ThirdPartLibary thirdPartLibary)
        {
            unitOfWork.ThirdPartLibaryRepository.Add(thirdPartLibary);
        }
    }
}
