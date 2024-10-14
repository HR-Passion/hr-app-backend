using System;
using System.Collections.Generic;
using DataAccesLayer.Entities.Base.Contracts;

namespace DataAccesLayer.Entities.Revisal_entities
{
    public class SalariatEntity : AuditableEntity
    {
        public Guid FirmId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Cnp { get; set; }
        public string Adresa { get; set; }
        public NationalitateEntity Nationalitate { get; set; }
        public List<ContractEntity> Contracte { get; set; }
        public LocalitateEntity Localitate { get; set; }
        public DetaliiSalariatStrainEntity DetaliiSalariatStrain { get; set; }
    }
}
