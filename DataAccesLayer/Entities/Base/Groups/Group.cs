

using HrAppCore.Enums;
using DataAccesLayer.Entities.Base.Departments;
using DataAccesLayer.Entities.Base.Employees;
using DataAccesLayer.Entities.Base.Groups.Auxiliar;

namespace DataAccesLayer.Entities.Base.Groups
{
    /// <summary>
    /// reprezents the highest level of a structure , has a singular cui , and could have many firms and many point of work , but same cui 
    /// </summary>
    public class Group : BaseEntity
    {
        /// <summary>
        /// uniq identifier of a group 
        /// </summary>
        public string Cui { get; set; } = "";
        public GroupType Type { get; set; }
        public List<Department> DepartmentGroups { get; set; } = new List<Department>();
        public List<User> Users { get; set; } = new List<User>();

        public string Name { get; set; }
        public string Adresa { get; set; }
        //public List<AngajatorAuditEntity>? AuditEntries { get; set; }
        public ContactEntity Contact { get; set; }
        public DetaliiGroupEntity Detalii { get; set; }
        public LocalitateEntity Localitate { get; set; }

    }
}
