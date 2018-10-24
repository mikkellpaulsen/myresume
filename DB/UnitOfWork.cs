using Model;
using System;

namespace DB
{
    public class UnitOfWork
    {
        public UnitOfWork() { }

        private CvContext context = new CvContext();

        private GenericRepository<Experience> experienceRepository;
        private GenericRepository<Internship> intershipRepository;
        private GenericRepository<Job> jobRepository;
        private GenericRepository<Language> languageRepository;
        private GenericRepository<Person> personRepository;
        private GenericRepository<Project> projectRepository;
        private GenericRepository<ThirdPartLibary> thirdpartylibaryRepository;
        private GenericRepository<WorkTool> workToolRepository;

        //Experience
        public GenericRepository<Experience> ExperienceRepository
        {
            get
            {
                return experienceRepository ?? new GenericRepository<Experience>(context);
            }
        }
        //Internship
        public GenericRepository<Internship> InternshipRepository
        {
            get
            {
                return intershipRepository ?? new GenericRepository<Internship>(context);
            }
        }
        //Job
        public GenericRepository<Job> JobRepository
        {
            get
            {
                return jobRepository ?? new GenericRepository<Job>(context);
            }
        }
        //Language
        public GenericRepository<Language> LanguageRepository
        {
            get
            {
                return languageRepository ?? new GenericRepository<Language>(context);
            }
        }
        //Person
        public GenericRepository<Person> PersonRepository
        {
            get
            {
                return personRepository ?? new GenericRepository<Person>(context);
            }
        }
        //Project
        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                return projectRepository ?? new GenericRepository<Project>(context);
            }
        }
        //ThirdPartLibary
        public GenericRepository<ThirdPartLibary> ThirdPartLibaryRepository
        {
            get
            {
                return thirdpartylibaryRepository ?? new GenericRepository<ThirdPartLibary>(context);
            }
        }
        //WorkTool
        public GenericRepository<WorkTool> WorkToolRepository
        {
            get
            {
                return workToolRepository ?? new GenericRepository<WorkTool>(context);
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

