
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Repositories.RoleRepository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {

        private readonly DataBaseContext _context;

        public RoleRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Role>> GetRolesForUser(int userId)
        {
            var roleIds = _context.RoleUsers
                           .Where(x => x.UserId.Equals(userId))
                           .Select(x => x.RoleId) 
                           .ToList();

            var roles = await _context.Roles
                                      .Where(x => roleIds.Contains(x.Id))
                                      .Include(r => r.PermissionRoles) 
                                      .ThenInclude(pr => pr.Permission) 
                                      .ToListAsync();

          

            return roles;
        }

      
    }
}
