using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Experience
    {
        public int Id { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<WorkTool> WorkTools { get; set; }
        public IEnumerable<ThirdPartLibary> ThirdPartLibaries { get; set; }
    }
}
