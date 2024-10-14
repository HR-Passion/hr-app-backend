

using AplicationLayer.DTOs;

namespace InfrastructureLayer.Handlers.Roles
{
    public interface IRoleHandler
    {
        public Task<List<RoleDto>> GetRoles();
    }
}
