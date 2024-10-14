using DataAccesLayer.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public Guid GroupId { get; set; }

    // Relație many-to-many cu Permission prin intermediul PermissionRole
    public List<PermissionRole> PermissionRoles { get; set; } = new List<PermissionRole>();
}
