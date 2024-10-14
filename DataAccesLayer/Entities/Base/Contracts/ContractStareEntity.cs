using System;
using System.Collections.Generic;
using DataAccesLayer.Entities.Revisal_entities;

namespace DataAccesLayer.Entities.Base.Contracts
{
    public class ContractStareEntity : BaseEntity
    {
        public DateTime? DataIncetareDetasare { get; set; }
        public DateTime? DataIncetareSuspendare { get; set; }


    }
}
