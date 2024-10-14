using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{
    public class ContractStareMutareEntity : ContractStareEntity
    {
        public string AngajatorCui { get; set; }
        public string AngajatorNume { get; set; }
        public DateTime DataMutare { get; set; }
        public string TemeiLegal { get; set; }
        public TipMutare TipMutare { get; set; }
    }
}