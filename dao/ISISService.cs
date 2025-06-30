using SISApp.entity;
using System.Collections.Generic;

namespace SISApp.dao
{
    public interface ISISService
    {
        // Student operations
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentId);
        Student GetStudentById(int studentId);
        List<Student> GetAllStudents();

        // Course operations
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int courseId);
        Course GetCourseById(int courseId);
        List<Course> GetAllCourses();

        // Teacher operations
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
        Teacher GetTeacherById(int teacherId);
        List<Teacher> GetAllTeachers();

        // Enrollment operations
        void EnrollStudentInCourse(Student student, Course course, DateTime enrollmentDate);
        void RemoveEnrollment(int enrollmentId);
        List<Enrollment> GetEnrollmentsForStudent(int studentId);
        List<Enrollment> GetEnrollmentsForCourse(int courseId);

        // Payment operations
        void RecordPayment(Student student, decimal amount, DateTime paymentDate);
        List<Payment> GetPaymentsForStudent(int studentId);

        // Reports
        void GenerateEnrollmentReport(Course course);
        void GeneratePaymentReport(Student student);
    }
}
