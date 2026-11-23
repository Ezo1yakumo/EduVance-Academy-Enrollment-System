using System;
using System.Data;
using EduVance.BusinessLogic.Repository;
using EduVance.Models;

namespace EduVance.BusinessLogic.Controller
{
    public sealed class StudentController
    {
        private readonly StudentRepository repository;

        public StudentController(string connectionString)
        {
            repository = new StudentRepository(connectionString);
        }

        public DataTable SearchStudents(string nameFilter, string idFilter)
        {
            return repository.Search((nameFilter ?? "").Trim(), (idFilter ?? "").Trim());
        }

        public int SaveStudent(StudentRecord student)
        {
            if (student == null) throw new ArgumentNullException("student");
            student.FullName = (student.FullName ?? "").Trim();
            student.Gender = (student.Gender ?? "").Trim();
            student.Address = (student.Address ?? "").Trim();
            student.ContactNumber = (student.ContactNumber ?? "").Trim();
            student.EmailAddress = (student.EmailAddress ?? "").Trim();

            if (student.FullName.Length == 0 || student.Gender.Length == 0 ||
                student.Address.Length == 0 || student.ContactNumber.Length == 0 ||
                student.EmailAddress.Length == 0)
                throw new ArgumentException("Please complete all student fields.");

            if (student.StudentID < 0)
                throw new ArgumentException("Invalid student ID.");
            if (student.DateOfBirth.Date > DateTime.Today)
                throw new ArgumentException("Date of birth cannot be in the future.");

            return repository.Save(student);
        }

        public int DeleteStudent(int studentId)
        {
            if (studentId <= 0) throw new ArgumentException("Select a student first.");
            return repository.Delete(studentId);
        }
    }
}
