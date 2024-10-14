using DataAccesLayer.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class ContractMutareDetaliiAuditEntity : AuditEntity
    {
        public string AngajatorSursaCui { get; set; }
        public string AngajatorSursaDenumire { get; set; }
        public DateTime DataImport { get; set; }
        public TipMutare TipMutare { get; set; }
    }
}
