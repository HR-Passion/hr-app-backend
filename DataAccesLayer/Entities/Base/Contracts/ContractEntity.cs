using HrAppCore.Enums;
using DataAccesLayer.Entities.Base.Employees;
using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Base.Contracts
{
    public class ContractEntity : BaseEntity
    {
        public string NumarContract { get; set; }
        public DateTime DataInceputContract { get; set; }
        public DateTime? DataSfarsitContract { get; set; }
        public int Salariu { get; set; }
        public TipContract TipContract { get; set; }
        public TipDurata TipDurata { get; set; }
        public TipNorma TipNorma { get; set; }
        public ContractStareEntity StareCurenta { get; set; }
        public CorEntity Cor { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
