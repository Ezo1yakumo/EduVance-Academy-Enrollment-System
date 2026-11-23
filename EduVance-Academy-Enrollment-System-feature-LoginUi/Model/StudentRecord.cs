using System;

namespace EduVance.Models
{
    public sealed class StudentRecord
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
