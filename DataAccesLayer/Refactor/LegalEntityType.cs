using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// forma juridica
    /// </summary>
    public class LegalEntityType : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
