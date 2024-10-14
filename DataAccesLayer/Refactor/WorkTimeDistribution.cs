using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class WorkTimeDistribution : BaseEntity
    {
        public int IdTypeContractDetails { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
