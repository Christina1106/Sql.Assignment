using SISApp.entity;
using SISApp.exception;
using SISApp.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

 namespace SISAPP.assessment.DAO
 {
     public class SISServiceImpl : ISISService
     {
         private static SqlConnection connection;

         public SISServiceImpl()
         {
             connection = DBConnUtil.GetConnection();
         }
         public bool AddStudent(Student student)
         {
             try
             {
                 connection.Open();
                 string query = @"INSERT INTO Students (first_name, last_name, date_of_birth, email, phone_number)
                      VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber)";

                 using SqlCommand cmd = new SqlCommand(query, connection);
                 cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                 cmd.Parameters.AddWithValue("@LastName", student.LastName);
                 cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                 cmd.Parameters.AddWithValue("@Email", student.Email);
                 cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);

                 int rows = cmd.ExecuteNonQuery();
                 Console.WriteLine(rows > 0 ? "Student added successfully." : "Failed to add student.");
                 return rows > 0;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Error adding student: {ex.Message}");
                 return false;
             }
             finally
             {
                 connection.Close();
             }
         }
         public bool UpdateStudent(Student student)
         {
             try
             {
                 connection.Open();
                 string query = @"UPDATE Students
                      SET first_name = @FirstName,
                          last_name = @LastName,
                          date_of_birth = @DateOfBirth,
                          email = @Email,
                          phone_number = @PhoneNumber
                      WHERE student_id = @StudentId";

                 using SqlCommand cmd = new SqlCommand(query, connection);
                 cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                 cmd.Parameters.AddWithValue("@LastName", student.LastName);
                 cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                 cmd.Parameters.AddWithValue("@Email", student.Email);
                 cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                 cmd.Parameters.AddWithValue("@StudentId", student.StudentId);

                 int rows = cmd.ExecuteNonQuery();
                 Console.WriteLine(rows > 0
                     ? $"Student ID {student.StudentId} updated successfully."
                     : $"Failed to update student with ID {student.StudentId}.");
                 return rows > 0;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Error updating student: {ex.Message}");
                 return false;
             }
             finally
             {
                 connection.Close();
             }
         }
         public bool DeleteStudent(int studentId)
         {
             try
             {
                 connection.Open();

                 // First, remove enrollments related to the student
                 string deleteEnrollments = "DELETE FROM Enrollments WHERE student_id = @StudentId";
                 using (SqlCommand cmd1 = new SqlCommand(deleteEnrollments, connection))
                 {
                     cmd1.Parameters.AddWithValue("@StudentId", studentId);
                     cmd1.ExecuteNonQuery();
                 }


                 string deletePayments = "DELETE FROM Payments WHERE student_id = @StudentId";
                 using (SqlCommand cmd2 = new SqlCommand(deletePayments, connection))
                 {
                     cmd2.Parameters.AddWithValue("@StudentId", studentId);
                     cmd2.ExecuteNonQuery();
                 }

                 // Finally, delete the student
                 string deleteStudent = "DELETE FROM Students WHERE student_id = @StudentId";
                 using SqlCommand cmd3 = new SqlCommand(deleteStudent, connection);
                 cmd3.Parameters.AddWithValue("@StudentId", studentId);

                 int rows = cmd3.ExecuteNonQuery();
                 Console.WriteLine(rows > 0
                     ? $"Student ID {studentId} deleted successfully."
                     : $"Failed to delete student with ID {studentId}.");

                 return rows > 0;
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Error deleting student: {ex.Message}");
                 return false;
             }
             finally
             {
                 connection.Close();
             }
        }
        public Student GetStudentById(int studentId)
        {
          
            return null;
        }

        public List<Student> GetAllStudents()
        {
            
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
