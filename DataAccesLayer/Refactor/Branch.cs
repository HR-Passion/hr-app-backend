using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// sucursala
    /// </summary>
    public class Branch
    {
        public int IdLevelOfEstablishment { get; set; }
        public LevelOfEstablishment LevelOfEstablishment { get; set;}
    }
}
