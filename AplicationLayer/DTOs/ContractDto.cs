
using HrAppCore.Enums;
using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Entities.Base.Employees;

namespace AplicationLayer.DTOs
{
    public class ContractDto
    {
        public string NumarContract { get; set; }
        public DateTime DataInceputContract { get; set; }
        public DateTime? DataSfarsitContract { get; set; }
        public int Salariu { get; set; }
        public TipContract TipContract { get; set; }
        public TipDurata TipDurata { get; set; }
        public TipNorma TipNorma { get; set; }
        public ContractStareEntityDto StareCurenta { get; set; }
        public CorEntityDto Cor { get; set; }
        public int EmployeeId { get; set; }

    }
}
