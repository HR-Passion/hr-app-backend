using HrAppCore.Enums;
namespace AplicationLayer.DTOs
{
    public class GroupDto
    {
        public string Cui { get; set; }
        public GroupType Type { get; set; }
        public List<DepartmentDto> DepartmentGroups { get; set; } 
        public List<UserDto> Users { get; set; } 
    }
}
