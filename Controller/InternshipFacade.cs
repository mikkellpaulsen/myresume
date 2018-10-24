using DB;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
    public class InternshipFacade : AdminMethods<Internship>
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Internship> GetAll()
        {
           return unitOfWork.InternshipRepository.Get();
        }

        public  IEnumerable<Internship> GetAllEndedInternships(string currentDate)
        {
            DateTime parsedCurrentDate = DateTime.Parse(currentDate);

            return unitOfWork.InternshipRepository.Get(internship => internship.EndDate < parsedCurrentDate);
        }

        public IEnumerable<Internship> GetAllActiveInternships()
        {

            return unitOfWork.InternshipRepository.Get(internship => internship.EndDate == null);
        }

        public void Create(Internship internship)
        {
            unitOfWork.InternshipRepository.Add(internship);
        }

        public void Delete(Internship internship)
        {
            unitOfWork.InternshipRepository.Delete(internship);
        }

        public void Update(Internship internship)
        {
            unitOfWork.InternshipRepository.Update(internship);
        }
    }
}
