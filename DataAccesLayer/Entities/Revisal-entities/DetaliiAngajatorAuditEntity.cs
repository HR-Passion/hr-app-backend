using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class DetaliiAngajatorAuditEntity : AuditEntity
    {
        public DomeniuActivitateEntity DomeniuActivitate { get; set; }
        public string Nume { get; set; }
    }
}
