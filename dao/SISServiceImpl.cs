using SISApp.entity;
using SISApp.exception;
using SISApp.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SISApp.dao
{
    public class SISServiceImpl : ISISService
    {
        // Example connection
        private string connectionString = DBPropertyUtil.GetConnectionString("db.properties");

        // Student methods
        public void AddStudent(Student student)
        {
            // TODO: Implement ADO.NET INSERT for Students table
        }

        public void UpdateStudent(Student student)
        {
            // TODO: Implement ADO.NET UPDATE for Students table
        }

        public void DeleteStudent(int studentId)
        {
            // TODO: Implement ADO.NET DELETE with referential integrity
        }

        public Student GetStudentById(int studentId)
        {
            // TODO: Implement ADO.NET SELECT for a single student
            return null;
        }

        public List<Student> GetAllStudents()
        {
            // TODO: Implement ADO.NET SELECT for all students
            return new List<Student>();
        }

        // Repeat similarly for Course, Teacher, Enrollment, Payment, and Reports...

        // Course methods
        public void AddCourse(Course course) { }
        public void UpdateCourse(Course course) { }
        public void DeleteCourse(int courseId) { }
        public Course GetCourseById(int courseId) { return null; }
        public List<Course> GetAllCourses() { return new List<Course>(); }

        // Teacher methods
        public void AddTeacher(Teacher teacher) { }
        public void UpdateTeacher(Teacher teacher) { }
        public void DeleteTeacher(int teacherId) { }
        public Teacher GetTeacherById(int teacherId) { return null; }
        public List<Teacher> GetAllTeachers() { return new List<Teacher>(); }

        // Enrollment methods
        public void EnrollStudentInCourse(Student student, Course course, DateTime enrollmentDate) { }
        public void RemoveEnrollment(int enrollmentId) { }
        public List<Enrollment> GetEnrollmentsForStudent(int studentId) { return new List<Enrollment>(); }
        public List<Enrollment> GetEnrollmentsForCourse(int courseId) { return new List<Enrollment>(); }

        // Payment methods
        public void RecordPayment(Student student, decimal amount, DateTime paymentDate) { }
        public List<Payment> GetPaymentsForStudent(int studentId) { return new List<Payment>(); }

        // Report methods
        public void GenerateEnrollmentReport(Course course) { }
        public void GeneratePaymentReport(Student student) { }
    }
}
