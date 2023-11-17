namespace JHONCABRERA.Models
{
    public class Grade
    {
        public Grade()
        {
            Students = new List<Student>();
        }
        public int GradeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Student> Students { get; set; }
    }
}
