using System;
using System.Collections.Generic;
using DataAccesLayer.Entities.Revisal_entities;

namespace DataAccesLayer.Entities.Base.Contracts
{
    public class CorEntity : Entity
    {
        public int Cod { get; set; }
        public int Versiune { get; set; }
        public List<ContractEntity> Contracts { get; set; }
    }
}
