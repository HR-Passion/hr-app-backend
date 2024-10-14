using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class ContractStareIncetareAuditEntity : ContractStareAuditEntity
    {
        public DateTime DataIncetare { get; set; }
        public string Explicatie { get; set; }
        public TemeiIncetareEntity TemeiLegal { get; set; }
    }
}
