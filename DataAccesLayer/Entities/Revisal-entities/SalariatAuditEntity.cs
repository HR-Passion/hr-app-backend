using DataAccesLayer.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class SalariatAuditEntity : AuditEntity
    {
        public string Adresa { get; set; }
        public ApatridEntity Apatrid { get; set; }
        public DateTime AuditTimestamp { get; set; }
        public string Cnp { get; set; }
        public string CnpVechi { get; set; }
        public DetaliiSalariatStrainAuditEntity DetaliiSalariatStrain { get; set; }
        public LocalitateEntity Localitate { get; set; }
        public NationalitateEntity Nationalitate { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public bool Radiat { get; set; }
        public NationalitateEntity TaraDomiciliu { get; set; }
        public TipActIdentitate TipActIdentitate { get; set; }
    }
}
