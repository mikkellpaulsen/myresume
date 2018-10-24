using DB;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controllers
{
    public class JobFacade : AdminMethods<Job>
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Job> GetAllJobs()
        {
            return unitOfWork.JobRepository.Get();
        }

        public IEnumerable<Job> GetFormerJobs(string currentDate)
        {
            DateTime parsedCurrentDate = DateTime.Parse(currentDate);

            return unitOfWork.JobRepository.Get(job => job.EndDate < parsedCurrentDate);
        }

        public IEnumerable<Job> GetAllActiveInternships()
        {

            return unitOfWork.JobRepository.Get(job => job.EndDate == null);
        }

        public IEnumerable<Job> GetAllJobsFromLauguage(Language language)
        {
            return unitOfWork.JobRepository.Get(job => job.Experiences == job.Experiences
                                                                                         .FindAll(x => x.Languages.Contains(language)));
        }

        public IEnumerable<Job> GetAllJobsFromWorkTool(WorkTool workTool)
        {
            return unitOfWork.JobRepository.Get(job => job.Experiences == job.Experiences
                                                                                         .FindAll(x => x.WorkTools.Contains(workTool)));
        }

        public IEnumerable<Job> GetAllJobsFromThirdPartLibaries(ThirdPartLibary thirdPartLibary)
        {
            return unitOfWork.JobRepository.Get(job => job.Experiences == job.Experiences
                                                                                         .FindAll(x => x.ThirdPartLibaries.Contains(thirdPartLibary)));
        }

        public void Create(Job job)
        {
            unitOfWork.JobRepository.Add(job);
        }

        public void Delete(Job job)
        {
            unitOfWork.JobRepository.Delete(job);
        }

        public void Update(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
