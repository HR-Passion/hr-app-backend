using AplicationLayer.DTOs;

namespace InfrastructureLayer.Handlers.Permissions
{
    public interface IPermissionHandler
    {
        public Task<List<PermisionDto>> GetPermissions();
    }
}
