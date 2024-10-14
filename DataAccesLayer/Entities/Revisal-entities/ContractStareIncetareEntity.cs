using System;
using System.Collections.Generic;
using DataAccesLayer.Entities.Base.Contracts;

namespace DataAccesLayer.Entities.Revisal_entities
{
    public class ContractStareIncetareEntity : ContractStareEntity
    {
        public DateTime DataIncetare { get; set; }
        public string Explicatie { get; set; }
        public TemeiIncetareEntity TemeiLegal { get; set; }
    }
}
