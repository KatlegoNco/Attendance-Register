using System;
using System.Collections.Generic;

namespace StudentAttendanceSystem
{
    class Program
    {
        static Dictionary<string, bool> studentAttendance = new Dictionary<string, bool>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student Attendance Management System");
            Console.WriteLine("----------------------------------------------");

            while (true)
            {
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. Mark Attendance");
                Console.WriteLine("3. View Attendance Report");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        MarkAttendance();
                        break;
                    case 3:
                        ViewAttendanceReport();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();
            if (!studentAttendance.ContainsKey(studentName))
            {
                studentAttendance.Add(studentName, false);
                Console.WriteLine($"Student '{studentName}' added successfully.");
            }
            else
            {
                Console.WriteLine($"Student '{studentName}' already exists.");
            }
        }

        static void MarkAttendance()
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();
            if (studentAttendance.ContainsKey(studentName))
            {
                studentAttendance[studentName] = true;
                Console.WriteLine($"Attendance marked for '{studentName}'.");
            }
            else
            {
                Console.WriteLine($"Student '{studentName}' not found.");
            }
        }

        static void ViewAttendanceReport()
        {
            Console.WriteLine("\nAttendance Report:");
            foreach (var student in studentAttendance)
            {
                Console.WriteLine($"{student.Key}: {(student.Value ? "Present" : "Absent")}");
            }
        }
    }
}
