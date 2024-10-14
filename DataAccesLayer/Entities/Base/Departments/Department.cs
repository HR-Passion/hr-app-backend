using HrAppCore.Enums;
using DataAccesLayer.Entities.Base.Employees;

namespace DataAccesLayer.Entities.Base.Departments
{
    public class Department : BaseEntity
    {
        public DepartmentType Type { get; set; }
        public string Name { get; set; } = "";
        public string Manager { get; set; }
        public List<Employee> DepartmentEmployees { get; set; }
        public int GroupId { get; set; }
        public virtual string PrintDetails()
        {
            return $"Department : {Name} , Manager : {Manager} , Employees : {DepartmentEmployees.Count()}";
        }

    }
}
