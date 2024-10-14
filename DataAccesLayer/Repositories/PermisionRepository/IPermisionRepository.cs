using DataAccesLayer.Entities.Base.Permisions;

namespace DataAccesLayer.Repositories.PermissionRepository
{
    public interface IPermissionRepository
    {
        public Task<List<Permission>> GetPermissionForRoleId(int userId);
    }
}
