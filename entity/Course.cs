using SISAPP.assessment.entity;

namespace SISApp.entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public Teacher AssignedTeacher { get; set; }

        public List<Enrollment> Enrollments { get; set; }

        public Course()
        {
            Enrollments = new List<Enrollment>();
        }

        public Course(int courseId, string courseName, string courseCode, Teacher assignedTeacher = null)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseCode = courseCode;
            AssignedTeacher = assignedTeacher;
            Enrollments = new List<Enrollment>();
        }
    }
}
