namespace JHONCABRERA.Models
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }
        public int CourseID { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
    }
}
