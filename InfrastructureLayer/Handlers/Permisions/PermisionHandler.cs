using DataAccesLayer.Repositories.PermissionRepository;
using DataAccesLayer.Repositories.RoleRepository;
using InfrastructureLayer.Services.GroupService;
using AplicationLayer.DTOs;
using AutoMapper;
using DataAccesLayer.Entities.Base.Permisions;

namespace InfrastructureLayer.Handlers.Permissions
{
    public class PermissionHandler : IPermissionHandler
    {
        private readonly IRoleRepository _roleRepository;
        private IGroupService _groupService;
        private readonly IPermissionRepository _permisionRepository;
        private readonly IMapper _mapper;

        public PermissionHandler(IRoleRepository roleRepository, IGroupService groupService,IPermissionRepository permisionRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _groupService = groupService;
            _permisionRepository = permisionRepository;
            _mapper = mapper;
        }
        public async Task<List<PermisionDto>> GetPermissions()
        {
            List<PermisionDto> permisions = new List<PermisionDto>();

            var userId = _groupService.GetCurrentUser();
              List<Role> roles = await _roleRepository.GetRolesForUser(userId);
                foreach (Role role in roles)
                {
                    List<Permission> rolePermissions = await _permisionRepository.GetPermissionForRoleId(role.Id);
                List<PermisionDto> rolePermissionsDtos = _mapper.Map<List<PermisionDto>>(rolePermissions);
                    permisions.AddRange(rolePermissionsDtos);

                }
            

            return permisions;

        }
    }
}

