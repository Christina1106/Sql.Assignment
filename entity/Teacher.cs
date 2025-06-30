namespace SISApp.entity
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Expertise { get; set; }

        public List<Course> AssignedCourses { get; set; }

        public Teacher()
        {
            AssignedCourses = new List<Course>();
        }

        public Teacher(int teacherId, string firstName, string lastName, string email, string expertise)
        {
            TeacherId = teacherId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Expertise = expertise;
            AssignedCourses = new List<Course>();
        }
    }
}
