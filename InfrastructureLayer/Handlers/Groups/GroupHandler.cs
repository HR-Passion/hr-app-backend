
using AplicationLayer.DTOs;
using AplicationLayer.Models;
using AutoMapper;

using DataAccesLayer.Repositories;
using DataAccesLayer.Entities.Base.Groups;

namespace InfrastructureLayer.Handlers.Groups
{
    public class GroupHandler : IGroupHandler
    {
        private readonly IRepository<Group> _groupRepository;
        private readonly IMapper _mapper;

        public GroupHandler(IRepository<Group> groupRepository,IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }
        public List<Group> GetAllGroups()
        {
           var groups =  _groupRepository.getAll();
            return groups;
        }

        public Task<Group> CreateGroup(CreateGroupModel model)
        {
           var entity = _mapper.Map<Group>(model);
            _groupRepository.Create(entity);
            return Task.FromResult(entity); 
        }
    }
}
