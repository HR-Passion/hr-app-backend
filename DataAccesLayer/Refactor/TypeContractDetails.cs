using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// tip durata contract
    /// </summary>
    public class TypeContractDetails : BaseEntity
    {
        public int IdContract {  get; set; }
        /// <summary>
        /// tip contract
        /// </summary>
        public TypeContract TypeContract { get; set; }
        /// <summary>
        /// tip norma
        /// </summary>
        public TypeWorkHours TypeWorkHours { get; set; }
        /// <summary>
        /// durata tip munca
        /// </summary>
        public WorkTimeDuration WorkTimeDuration { get; set; }
        /// <summary>
        /// repartizare timp de munca 
        /// </summary>
        public WorkTimeDistribution WorkTimeDistribution { get; set; }

    }
}
