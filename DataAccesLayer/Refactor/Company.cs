using DataAccesLayer.Entities;
using DataAccesLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class Company : BaseEntity
    {
        public List<User> Users { get; set; }   
        public LegalEntitie? Legal { get; set; }
        public SoleProprietor? SoleProprietor { get; set; }
    }
}
