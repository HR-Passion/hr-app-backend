
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using System.Data;
using DataAccesLayer.Entities.Base.Permisions;
namespace DataAccesLayer.Repositories.PermissionRepository
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository 
    {
        private readonly DataBaseContext _context;

        public PermissionRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Permission>> GetPermissionForRoleId(int roleId)
        {
            var roleIds = _context.PermissionRoles.Where(x => x.RoleId.Equals(roleId)).Select(x => x.Id);
            var permissions = await _context.Permissions
                .Where(x => roleIds.Contains(x.Id)).ToListAsync();
           
            return permissions;
        }
    }
}
