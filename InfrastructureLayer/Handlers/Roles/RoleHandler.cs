using DataAccesLayer.Repositories.RoleRepository;
using InfrastructureLayer.Services.GroupService;
using AplicationLayer.DTOs;
using AutoMapper;

namespace InfrastructureLayer.Handlers.Roles
{
    public class RoleHandler : IRoleHandler
    {
        private readonly IRoleRepository _roleRepository;
        private IGroupService _groupService;
        private readonly IMapper _mapper;

        public RoleHandler(IRoleRepository roleRepository ,IGroupService groupService , IMapper mapper)
        {
            _roleRepository = roleRepository;
            _groupService = groupService;
            _mapper=mapper;
        }
        public async Task<List<RoleDto>> GetRoles()
        {
            int userId = _groupService.GetCurrentUser();

            List<Role> roles = await _roleRepository.GetRolesForUser( userId );
            return _mapper.Map<List<RoleDto>>(roles);

        }
    }
}
