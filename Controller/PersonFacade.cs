using DB;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
   public class PersonFacade
    {

        UnitOfWork unitOfWork = new UnitOfWork();

        public void CreatePerson(Person person)
        {
            unitOfWork.PersonRepository.Add(person);
        
        }

        public Person GetPersonById(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id);
        }

        public IEnumerable<Project> GetAllProjectsFromPerson(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id)
                                              .Projects;
        }
        
        public IEnumerable<Job> GetAllJobsFromPerson(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id)
                                              .Jobs;
        }

        public IEnumerable<Internship> GetAllInternshipsFromPerson(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id)
                                              .Internships;
        }

        public Experience GetAllExperiences(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id)
                                              .Experience;
        }

        public IEnumerable<Language> GetAllLanguages(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id)
                                              .Experience
                                              .Languages;
        }

        public IEnumerable<WorkTool> GetAllWorkTools(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id)
                                              .Experience
                                              .WorkTools;
        }

        public IEnumerable<ThirdPartLibary> GetAllThirdPartLibaries(int id)
        {
            return unitOfWork.PersonRepository.GetByID(id)
                                              .Experience
                                              .ThirdPartLibaries;
        }
    }
}
