using System;
using System.Collections.Generic;
using DataAccesLayer.Entities.Base.Contracts;

namespace DataAccesLayer.Entities.Revisal_entities
{
    public class ContractStareDetasareEntity : ContractStareEntity
    {
        public string AngajatorCui { get; set; }
        public string AngajatorNume { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime? DataIncetare { get; set; }
        public DateTime DataSfarsit { get; set; }
        public NationalitateEntity Nationalitate { get; set; }
    }
}
