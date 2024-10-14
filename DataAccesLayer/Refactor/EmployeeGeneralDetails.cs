using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Refactor
{
    public class EmployeeGeneralDetails : BaseEntity
    {
        public int EmployeeID { get; set; } 
        public string Adress {  get; set; }
        public string Judet { get; set; }
        public string Localitate { get; set; }
    }
}
