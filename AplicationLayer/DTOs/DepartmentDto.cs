using HrAppCore.Enums;

namespace AplicationLayer.DTOs
{
    public class DepartmentDto
    {
        public DepartmentType Type { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
       
    }
}
