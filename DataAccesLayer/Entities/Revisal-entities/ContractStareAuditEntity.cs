using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class ContractStareAuditEntity : AuditEntity
    {
        public DateTime? DataIncetareDetasare { get; set; }
        public DateTime? DataIncetareSuspendare { get; set; }
        public ContractStareAuditEntity StarePrecedenta { get; set; }
    }
}
