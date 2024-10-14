using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class SporAuditEntity : AuditEntity
    {
        public bool? IsProcent { get; set; }
        public TipSporEntity Tip { get; set; }
        public double Valoare { get; set; }
    }
}
