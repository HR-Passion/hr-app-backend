using DataAccesLayer.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entities.Base.Groups.Auxiliar
{
    public class DetaliiGroupEntity : BaseEntity
    {
        public DomeniuActivitateEntity DomeniuActivitate { get; set; }
        public string Nume { get; set; }
    }
}
