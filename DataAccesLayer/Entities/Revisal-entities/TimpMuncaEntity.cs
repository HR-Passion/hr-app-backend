using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class TimpMuncaEntity
    {
        public double? Durata { get; set; }
        public RepartizareIntervalTimpEntity IntervalTimp { get; set; }
        public NormaTimpMuncaEntity Norma { get; set; }
        public RepartizareTimpMuncaEntity Repartizare { get; set; }
    }
}
