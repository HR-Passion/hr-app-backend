using AplicationLayer.DTOs;

namespace AplicationLayer.Models
{
    public class CreateEmployeeUserModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployeement { get; set; }
        public int DepartmentId { get; set; }

    }
}
