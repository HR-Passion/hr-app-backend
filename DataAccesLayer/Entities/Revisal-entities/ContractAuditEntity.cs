using HrAppCore.Enums;
using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{
    public class ContractAuditEntity : AuditEntity
    {
        public DateTime AuditTimestamp { get; set; }
        public CorEntity Cor { get; set; }
        public DateTime DataConsemnare { get; set; }
        public DateTime DataContract { get; set; }
        public DateTime DataInceputContract { get; set; }
        public DateTime? DataSfarsitContract { get; set; }
        public string DateContractVechi { get; set; }
        public string Detalii { get; set; }
        public ContractMutareDetaliiAuditEntity DetaliiMutare { get; set; }
        public ExceptieDataSfarsitEntity ExceptieDataSfarsit { get; set; }
        public string NumarContract { get; set; }
        public string NumereContractVechi { get; set; }
        public bool Radiat { get; set; }
        public int Salariu { get; set; }
        public List<SporAuditEntity> SporuriSalariu { get; set; }
        public ContractStareAuditEntity StareCurenta { get; set; }
        public TimpMuncaEntity TimpMunca { get; set; }
        public TipContract TipContract { get; set; }
        public TipDurata TipDurata { get; set; }
        public TipNorma TipNorma { get; set; }
    }
}
