using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class DetaliiAngajatorPersoanaJuridicaAuditEntity : DetaliiAngajatorAuditEntity
    {
        public string Cui { get; set; }
        public string CuiParinte { get; set; }
        public FormaJuridicaPJEntity FormaJuridicaPJ { get; set; }
        public FormaOrganizarePJEntity FormaOrganizarePJ { get; set; }
        public FormaProprietateEntity FormaProprietate { get; set; }
        public NivelInfiintareEntity NivelInfiintare { get; set; }
        public string NumeParinte { get; set; }
    }
}
