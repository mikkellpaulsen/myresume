using System.Collections.Generic;

namespace Model
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string About { get; set; }

        public Experience Experience { get; set; }

        public List<Project> Projects = new List<Project>();
        public List<Job> Jobs = new List<Job>();
        public List<Internship> Internships = new List<Internship>();

        public Person()
        {
        }
    }

}
