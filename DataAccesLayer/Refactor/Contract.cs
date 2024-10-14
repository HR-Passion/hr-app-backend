using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class Contract : BaseEntity
    {
        public int IdEmployee { get; set; }
        public TypeContractDetails TypeContractDetails { get; set; }
    }
}
