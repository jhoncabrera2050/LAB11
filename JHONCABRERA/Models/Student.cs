namespace JHONCABRERA.Models
{
    public class Student
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int GradeID { get; set; }
        public Grade? Grade { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
        public bool Active { get; set; }
    }
}
