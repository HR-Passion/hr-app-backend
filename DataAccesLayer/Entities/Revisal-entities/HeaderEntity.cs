using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class HeaderEntity
    {
        public string ClientApplication { get; set; }
        public int XmlVersion { get; set; }
        public Guid? UploadId { get; set; }
        public string UploadDescription { get; set; }
        public AngajatorEntity Angajator { get; set; }
        public int? PiecesCount { get; set; }
    }
}
