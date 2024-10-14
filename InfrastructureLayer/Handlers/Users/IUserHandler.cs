using AplicationLayer.DTOs;
using AplicationLayer.Models;
using DataAccesLayer.Entities.Base;
using DataAccesLayer.Entities.Base.Defaults;
using DataAccesLayer.Entities.Base.Employees;

namespace InfrastructureLayer.Handlers.Users
{
    /// <summary>
    /// handler for user login and related tasks for user auth , etc 
    /// </summary>
    public interface IUserHandler
    {
        public string? LoginUser(string username, string password);
        public Task<List<User>> GetAllUsers();
        Task<DefaultInfoDto> GetDefaultUserInfo();
        Task<EmployeeInfoDto> GetEmployeeUserInfo();
        Task<bool> CreateUser(UserDto user);
        Task<bool> CreateEmployeeUser(CreateEmployeeUserModel user);
    }
}
