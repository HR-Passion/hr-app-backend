using DataAccesLayer.Entities;
using DataAccesLayer.Entities.Base.Permisions;

public class PermissionRole : BaseEntity
{
    public int RoleId { get; set; }
    public Role Role { get; set; }

    public int PermissionId { get; set; }
    public Permission Permission { get; set; }
}
