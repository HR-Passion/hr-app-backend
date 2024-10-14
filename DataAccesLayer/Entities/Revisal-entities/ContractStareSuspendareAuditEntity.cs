using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class ContractStareSuspendareAuditEntity : ContractStareAuditEntity
    {
        public DateTime DataInceput { get; set; }
        public DateTime? DataIncetare { get; set; }
        public DateTime? DataSfarsit { get; set; }
        public string Explicatie { get; set; }
        public TemeiSuspendareEntity TemeiLegal { get; set; }
    }
}
