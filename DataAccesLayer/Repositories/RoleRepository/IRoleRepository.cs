
using DataAccesLayer.Entities.Base.Employees;

namespace DataAccesLayer.Repositories.RoleRepository
{
    public  interface IRoleRepository
    {
        public Task<List<Role>> GetRolesForUser(int userId);
        
    }
}
