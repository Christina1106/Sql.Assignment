using SISAPP.assessment.DAO;
using SISAPP.assessment.entity;
using System;

namespace SISAPP.assessment.Main
{
    class MainModule
    {
        private readonly ISISService sisService;

        public MainModule()
        {
            sisService = new SISServiceImpl();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n--- Student Information System Menu ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        UpdateStudent();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    case 0:
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }

        private void AddStudent()
        {
            try
            {
                Student student = new Student();

                Console.Write("First Name: ");
                student.FirstName = Console.ReadLine();

                Console.Write("Last Name: ");
                student.LastName = Console.ReadLine();

                Console.Write("Date of Birth (yyyy-MM-dd): ");
                student.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.Write("Email: ");
                student.Email = Console.ReadLine();

                Console.Write("Phone Number: ");
                student.PhoneNumber = Console.ReadLine();

                bool created = sisService.AddStudent(student);
                Console.WriteLine(created ? "Student added successfully!" : "Failed to add student.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding student: {ex.Message}");
            }
        }

        private void UpdateStudent()
        {
            try
            {
                Student student = new Student();

                Console.Write("Student ID: ");
                student.StudentId = int.Parse(Console.ReadLine());

                Console.Write("First Name: ");
                student.FirstName = Console.ReadLine();

                Console.Write("Last Name: ");
                student.LastName = Console.ReadLine();

                Console.Write("Date of Birth (yyyy-MM-dd): ");
                student.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.Write("Email: ");
                student.Email = Console.ReadLine();

                Console.Write("Phone Number: ");
                student.PhoneNumber = Console.ReadLine();

                bool updated = sisService.UpdateStudent(student);
                Console.WriteLine(updated ? "Student updated successfully!" : "Failed to update student.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student: {ex.Message}");
            }
        }

        private void DeleteStudent()
        {
            try
            {
                Console.Write("Student ID: ");
                int studentId = int.Parse(Console.ReadLine());

                bool deleted = sisService.DeleteStudent(studentId);
                Console.WriteLine(deleted ? "Student deleted successfully!" : "Failed to delete student.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student: {ex.Message}");
            }
        }
    }
}
﻿
