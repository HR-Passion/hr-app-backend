using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class LevelOfEstablishment : BaseEntity
    {
        public int IdLegalEntitie { get; set; }
        /// <summary>
        /// tip de nivel de infiintare
        /// </summary>
        public TypeOfEstablismentLevel TypeOfEstablismentLevel { get; set; }
        public int IdTypeOfEstablismentLevel { get; set; }

    }
}
