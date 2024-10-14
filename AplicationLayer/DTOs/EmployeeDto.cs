using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Entities.Base.Departments;
using DataAccesLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.DTOs
{
    public class EmployeeDto
    {
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployeement { get; set; }
        public List<ContractDto> Contracts { get; set; } 
    }
}
