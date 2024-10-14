using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    /// <summary>
    /// detalii salariat
    /// </summary>
    public class EmployeeDetails : BaseEntity
    {
        public int EmployeeID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public bool ApartId { get; set; }
        public Citizenship Citizenship { get; set; }
        public int IdCitizenship { get; set; }
        public TypeOfIdentificationDocument TypeOfIdentificationDocument { get; set; }
        public string CNP {  get; set; }

    }
}
