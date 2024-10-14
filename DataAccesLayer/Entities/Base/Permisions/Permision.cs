using HrAppCore.Enums;
using DataAccesLayer.Entities;

namespace DataAccesLayer.Entities.Base.Permisions;
public class Permission : BaseEntity
{
    public PermissionType Type { get; set; }
    public string TableId { get; set; }

    // Relație many-to-many cu Role prin intermediul PermissionRole
    public List<PermissionRole> PermissionRoles { get; set; } = new List<PermissionRole>();
}
