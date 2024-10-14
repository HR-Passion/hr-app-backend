using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// tip nivel de infiintare
    /// </summary>
    public class TypeOfEstablismentLevel : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
