using System;
using System.Collections.Generic;

namespace DataAccesLayer.Entities.Revisal_entities
{public class ContactEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Fax { get; set; }
        public string ReprezentantLegal { get; set; }
        public string Telefon { get; set; }
    }
}
