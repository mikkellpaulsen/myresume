using DB;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
    public class ProjectFacade : AdminMethods<Project>
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Project> getAll()
        {
            return unitOfWork.ProjectRepository.Get();
        }

        public IEnumerable<Project> GetAllProjectsFromLanguage(Language language)
        {
            return unitOfWork.ProjectRepository.Get(project => project.language == language);
        }
        public IEnumerable<Project> GetAllProjectsFromWorkTool(WorkTool workTool)
        {
            return unitOfWork.ProjectRepository.Get(project => project.workTool == workTool);
        }
        public IEnumerable<Project> GetAllProjectsFromThirdPartyLibary(ThirdPartLibary thirdPartLibary)
        {
            return unitOfWork.ProjectRepository.Get(project => project.thirdPartLibary == thirdPartLibary);
        }

        public void Create(Project project)
        {
            unitOfWork.ProjectRepository.Add(project);
        }

        public void Delete(Project project)
        {
            unitOfWork.ProjectRepository.Delete(project);
        }

        public void Update(Project project)
        {
            unitOfWork.ProjectRepository.Update(project);
        }
    }
}
