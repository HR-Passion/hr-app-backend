using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class AngajatorEntity : AuditableEntity
    {
        public string Adresa { get; set; }
        public List<AngajatorAuditEntity>? AuditEntries { get; set; }
        public ContactEntity Contact { get; set; }
        public DetaliiAngajatorEntity Detalii { get; set; }
        public LocalitateEntity Localitate { get; set; }
    }
}
