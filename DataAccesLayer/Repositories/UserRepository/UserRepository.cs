
using DataAccesLayer;
using DataAccesLayer.Entities.Base;
using Microsoft.EntityFrameworkCore;
using DataAccesLayer.Repositories;
using DataAccesLayer.Repositories.UserRepository;
using DataAccesLayer.Entities.Base.Employees;
using DataAccesLayer.Entities.Base.Defaults;

namespace InfrastructureLayer.Repositories.UserRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DataBaseContext _context;

        public UserRepository(DataBaseContext context) : base(context) {

            _context = context;
        }

        public async Task<List<User>> GetAllUsersByGroupId(int groupId)
        {


            var users = await _context.Groups.Where(x=>x.Id.Equals(groupId)).Include(x=>x.Users).Select(x=>x.Users).ToListAsync();

            return users.First();

        }

        public async Task<EmployeeInfo> GetEmployeeInfo(int userId)
        {
            var employeeInfo = await _context.Employees
                .Where(x => x.UserId==userId)
                .ToListAsync();
          
            return employeeInfo.Select(i=>new EmployeeInfo() { CNP = i.CNP, DateOfBirth = i.DateOfBirth , DateOfEmployeement =i.DateOfEmployeement,Phone = i.Phone,Email=i.Email,FirstName=i.FirstName,LastName=i.LastName}).First();
        }
        public async Task<DefaultInfo> GetDefaultInfo(int userId)
        {
            var employeeInfo = await _context.Defaults
                .Where(x => x.UserId.Equals(userId))
                .ToListAsync();

            return employeeInfo.Select(i => new DefaultInfo() {  DateOfBirth = i.DateOfBirth, Phone = i.Phone, Email = i.Email, FirstName = i.FirstName, LastName = i.LastName }).First();
        }
        // Alte metode specifice pentru UserRepository dacă este necesar
    }
}
