
using DataAccesLayer.Entities.Base;
using DataAccesLayer.Entities.Base.Defaults;
using DataAccesLayer.Entities.Base.Employees;

namespace DataAccesLayer.Repositories.UserRepository
{
    public interface IUserRepository : IRepository<User>
    {
        public Task<List<User>> GetAllUsersByGroupId(int groupId);
        public Task<EmployeeInfo> GetEmployeeInfo(int userId);
        public Task<DefaultInfo> GetDefaultInfo(int userId);
        
        }
}
