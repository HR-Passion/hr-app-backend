using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class ContractStareReactivareAuditEntity : ContractStareActivAuditEntity
    {
        public DateTime DataReactivare { get; set; }
        public string Explicatie { get; set; }
        public TemeiReactivareEntity TemeiLegal { get; set; }
    }
}
