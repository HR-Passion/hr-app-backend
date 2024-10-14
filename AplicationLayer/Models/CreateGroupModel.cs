using DataAccesLayer.Entities.Base.Departments;
using DataAccesLayer.Entities.Base;
using HrAppCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationLayer.DTOs;

namespace AplicationLayer.Models
{
    public class CreateGroupModel
    {
        public string Cui { get; set; } 
        public GroupType Type { get; set; }
        public List<DepartmentDto> DepartmentGroups { get; set; }
        public List<UserDto> Users { get; set; } 
        public string Name { get; set; }
        public string Adresa { get; set; }
        //public List<AngajatorAuditEntity>? AuditEntries { get; set; }
        public ContactEntityDto Contact { get; set; }
        public DetaliiGroupEntityDto Detalii { get; set; }
        public LocalitateEntityDto Localitate { get; set; }
    }
}
