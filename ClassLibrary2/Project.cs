
namespace Model
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsSchoolProject { get; set; }
        public bool IsIndiviualProject { get; set; }
        public int Semester { get; set; }
        public Language language { get; set; }
        public WorkTool workTool { get; set; }
        public ThirdPartLibary thirdPartLibary { get; set; }

    }
}