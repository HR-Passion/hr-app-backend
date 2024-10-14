using InfrastructureLayer.Services.GroupService;
using DataAccesLayer.Entities.Base;
using InfrastructureLayer.Services.AuthService;
using DataAccesLayer.Repositories.UserRepository;
using DataAccesLayer.Repositories.RoleRepository;
using AplicationLayer.DTOs;
using AutoMapper;
using AplicationLayer.Models;
using DataAccesLayer.Entities.Base.Employees;
using DataAccesLayer.Repositories;


namespace InfrastructureLayer.Handlers.Users
{
    public class UserHandler : IUserHandler
    {
        private readonly IGroupService _groupService;
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IRepository<Employee> _employeeRepository;

        public UserHandler(IGroupService groupService, IUserRepository userRepository,IAuthService authService , IRoleRepository roleRepository, IMapper mapper , IRepository<Employee> employeeRepository)
        {
            _groupService = groupService;
            _userRepository = userRepository;
            _authService = authService;
            _roleRepository = roleRepository;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<List<User>> GetAllUsers()
        {
            int groupId = _groupService.GetCurrentGroup();//grupa in care caut useri 

            var users = await _userRepository.GetAllUsersByGroupId(groupId);
            if (users != null)
            {
                return users;

            }else { return null; }
        }

        public  string? LoginUser(string username, string password)
        {
            return  _authService.Login(username, password);
        }
        public async Task<DefaultInfoDto> GetDefaultUserInfo()
        {
            int groupId = _groupService.GetCurrentGroup(); //todo filter on groupid too later
            int userId = _groupService.GetCurrentUser();

            var info = await _userRepository.GetDefaultInfo(userId);
            if (info != null)
            {
                return _mapper.Map<DefaultInfoDto>(info);
            }
            else return null;


        }
        public async Task<EmployeeInfoDto> GetEmployeeUserInfo()
        {
            int groupId = _groupService.GetCurrentGroup(); //todo filter on groupid too later
            int userId = _groupService.GetCurrentUser();

           var info = await _userRepository.GetEmployeeInfo(userId);
            if (info != null)
            {
                return _mapper.Map<EmployeeInfoDto>(info);
            }
            else return null;

        }

        public async Task<bool> CreateUser(UserDto userDto)
        {
            var entity = _mapper.Map<User>(userDto);
            int groupId = _groupService.GetCurrentGroup(); 
            //int userId = _groupService.GetCurrentUser();  TODO keep somewhere that this user was created by this id 
            entity.GroupId = groupId;

            var response = await _userRepository.CreateAsync(entity);
            return response;

        }

        public async Task<bool> CreateEmployeeUser(CreateEmployeeUserModel userEmployee)
        {
            int groupId = _groupService.GetCurrentGroup();

            var userDto = new User()
            {
                GroupId = groupId,
                Email = userEmployee.Email,
                Password = userEmployee.Password,
                Username = userEmployee.Username,
                IsEmployeed = true
            };

            var userEntity = _mapper.Map<User>(userDto);
            var userResult = await _userRepository.CreateAsync(userEntity);

            var employeeDto = new Employee()
            {
                Email = userEmployee.Email,
                Phone = userEmployee.Phone,
                FirstName = userEmployee.FirstName,
                LastName = userEmployee.LastName,
                DateOfBirth = userEmployee.DateOfBirth,
                DateOfEmployeement = userEmployee.DateOfEmployeement,
                Contracts = null,
                DepartmentId = userEmployee.DepartmentId,
                CNP = userEmployee.CNP,
                UserId = userEntity.Id

            };
            var employeeEntity = _mapper.Map<Employee>(employeeDto);
            var employeeResult =  await _employeeRepository.CreateAsync(employeeEntity);

            return userResult && employeeResult;
        }
    }
}
