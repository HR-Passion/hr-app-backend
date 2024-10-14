using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// persoana juridica
    /// </summary>
    public class LegalEntitie : BaseEntity
    {
        /// <summary>
        /// referinta catre societatea 
        /// </summary>
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        /// <summary>
        /// forma juridica
        /// </summary>
        public LegalEntityType LegalEntityType { get; set; }

        public LevelOfEstablishment LevelOfEstablishment { get; set; }
    }
}
