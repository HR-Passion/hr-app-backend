using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class Employee : BaseEntity
    {
        public EmployeeDetails EmployeeDetails { get; set; }
        public EmployeeGeneralDetails EmployeeGeneralDetails { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
