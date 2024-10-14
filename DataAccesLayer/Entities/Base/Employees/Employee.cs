using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Entities.Base.Departments;

namespace DataAccesLayer.Entities.Base.Employees
{
    public class Employee : BaseEntity
    {
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployeement { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<ContractEntity> Contracts { get; set; } = new List<ContractEntity>();
    }
}
