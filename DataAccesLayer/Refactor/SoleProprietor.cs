using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// persoanele fizice 
    /// </summary>
    public class SoleProprietor : BaseEntity
    { 
        /// <summary>
      /// referinta catre societatea 
      /// </summary>
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        /// <summary>
        /// nationalitate
        /// </summary>
        public Citizenship Citizenship { get; set; }
        public LegalEntityType legalEntityType { get; set; }
    }
}
