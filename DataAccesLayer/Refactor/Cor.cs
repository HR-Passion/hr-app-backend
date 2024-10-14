using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class Cor : BaseEntity
    {
        public int IdContractGeneralDetails { get; set; }
        public int Name {  get; set; }
        public int Code { get; set; }
    }
}
