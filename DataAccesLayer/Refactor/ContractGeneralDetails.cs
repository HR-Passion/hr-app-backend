using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class ContractGeneralDetails : BaseEntity
    {
        public int IdContract {  get; set; }
        public int Number {  get; set; }
        public DateTime StartingDate { get; set; }
        /// <summary>
        /// data la care se semneaza contractul
        /// </summary>
        public DateTime ContractSigningDate { get; set;}
        public string Details { get; set; }
        public Cor Function { get; set; }
    }
}
