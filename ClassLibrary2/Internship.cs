using System;
using System.Collections.Generic;

namespace Model
{
    public class Internship
    {
        public int Id { get; set; }
        public string Firm { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsEmployeed { get; set; }
        public string Statement { get; set; }
        public byte[] StatementImage { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}