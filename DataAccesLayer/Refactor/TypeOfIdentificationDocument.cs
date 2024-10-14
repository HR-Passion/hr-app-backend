using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// tip act de identitate
    /// </summary>
    public class TypeOfIdentificationDocument : BaseEntity
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
