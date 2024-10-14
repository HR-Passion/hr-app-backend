using AplicationLayer.DTOs;
using AutoMapper;
using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Repositories;
using InfrastructureLayer.Services.GroupService;


namespace InfrastructureLayer.Handlers.Contract
{
    public class ContractHandler : IContractHandler
    {
        private readonly IRepository<ContractEntity> _repository;
        private readonly IMapper _mapper;
        private readonly IGroupService _groupService;

        public ContractHandler(IMapper mapper,IRepository<ContractEntity> repository , IGroupService groupService)
        {
            _repository = repository; 
            _mapper = mapper;
            _groupService = groupService;
        }

        public async Task<bool> CreateContract(ContractDto contract)
        {
            var entity = _mapper.Map<ContractEntity>(contract);

            var groupId = _groupService.GetCurrentGroup();
            entity.Employee.User.GroupId = groupId;

            var result = await _repository.CreateAsync(entity);


            return result;
        }
    }
}
