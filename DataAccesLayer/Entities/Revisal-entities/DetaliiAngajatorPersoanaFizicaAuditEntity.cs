using DataAccesLayer.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class DetaliiAngajatorPersoanaFizicaAuditEntity : DetaliiAngajatorAuditEntity
    {
        public ActIdentitatePF ActIdentitatePF { get; set; }
        public string Cnp { get; set; }
        public FormaJuridicaPF FormaJuridicaPF { get; set; }
        public FormaOrganizarePF FormaOrganizarePF { get; set; }
        public NationalitateEntity Nationalitate { get; set; }
    }
}
