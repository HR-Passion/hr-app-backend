using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// sediu social
    /// </summary>
    public class Headquarter : BaseEntity
    {
        public int IdLevelOfEstablishment { get; set; }
        public LevelOfEstablishment LevelOfEstablishment { get; set;}
    }
}
