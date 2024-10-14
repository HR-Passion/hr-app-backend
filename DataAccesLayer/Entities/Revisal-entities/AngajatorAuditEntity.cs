using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class AngajatorAuditEntity : AuditEntity
    {
        public string Adresa { get; set; }
        public DateTime AuditTimestamp { get; set; }
        public ContactEntity Contact { get; set; }
        public DetaliiAngajatorAuditEntity Detalii { get; set; }
        public LocalitateEntity Localitate { get; set; }
    }
}
