using SISAPP.assessment.entity;

namespace SISApp.entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<Enrollment> Enrollments { get; set; }
        public List<Payment> Payments { get; set; }

        public Student()
        {
            Enrollments = new List<Enrollment>();
            Payments = new List<Payment>();
        }

        public Student(int studentId, string firstName, string lastName, DateTime dateOfBirth, string email, string phoneNumber)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = e
