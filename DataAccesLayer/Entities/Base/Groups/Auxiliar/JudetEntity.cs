using DataAccesLayer.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entities.Base.Groups.Auxiliar
{
    public class JudetEntity : Entity
    {
        public string Nume { get; set; } // Numele județului
        public string CodJudet { get; set; } // Codul județului, dacă este relevant
    }
}
