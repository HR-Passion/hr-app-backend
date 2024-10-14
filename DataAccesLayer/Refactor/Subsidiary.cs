using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// Filiala
    /// </summary>
    public class Subsidiary : BaseEntity
    {
        public int IdLevelOfEstablishment { get; set; }
        public LevelOfEstablishment LevelOfEstablishment { get; set;}
    }
}
