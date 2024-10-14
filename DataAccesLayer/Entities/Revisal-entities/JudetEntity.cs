using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entities.Revisal_entities
{
    public class JudetEntity : Entity
    {
        public string Nume { get; set; } // Numele județului
        public string CodJudet { get; set; } // Codul județului, dacă este relevant
    }

}
