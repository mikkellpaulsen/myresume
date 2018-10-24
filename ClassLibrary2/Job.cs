using System;
using System.Collections.Generic;

namespace Model
{
    public class Job
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsEmployeed { get; set; }
        public string Firm { get; set; }
        public List<Experience> Experiences { get; set; }

    }
}