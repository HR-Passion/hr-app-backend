
using InfrastructureLayer.Handlers.Groups;
using InfrastructureLayer.Handlers.Permissions;
using InfrastructureLayer.Handlers.Roles;
using InfrastructureLayer.Handlers.Users;
using AplicationLayer.Models;
using DataAccesLayer;
using Microsoft.AspNetCore.Mvc;
using AplicationLayer.DTOs;

namespace PresentationLayer.Controllers.GroupController
{
    [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
        private readonly IUserHandler _userHandler;
        private readonly IRoleHandler _roleHandler;
        private readonly IPermissionHandler _permitionHandler;
        private readonly IGroupHandler _groupHandler;

        public UserController( DataBaseContext context , IUserHandler userHandler , IRoleHandler roleHandler , IPermissionHandler permitionHandler , IGroupHandler groupHandler)
            {
            _userHandler = userHandler;
            _roleHandler = roleHandler;
            _permitionHandler = permitionHandler;
            _groupHandler = groupHandler;
            }

            [HttpPost("login")]
            public IActionResult Login([FromBody] UserLoginModel user)
            {
                  var result = _userHandler.LoginUser(user.UserName,user.Password);
            if(result == null)
            {
                return Unauthorized();
            }
            return Ok(result);
            }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users =  await _userHandler.GetAllUsers();
            return Ok(users);
        }
        [HttpGet("user-roles")]
        public async Task<IActionResult> GetUserRoles()
        { 
        //todo get roles loged in user
        var roles = await _roleHandler.GetRoles();
            return Ok(roles);
        
        }
        [HttpGet("user-permisions")]
        public async Task<IActionResult> GetUserPermissions()
        {
            //todo get permision loged in user
            var permisitions = await _permitionHandler.GetPermissions();
            return Ok(permisitions);

        }
        [HttpGet("user-info")]
        public async Task<IActionResult> GetUserInfo()
        {
            var info = await _userHandler.GetDefaultUserInfo();
            return Ok(info);
        }
        [HttpGet("user-employeed-info")]
        public async Task<IActionResult> GetEmployeedUserInfo()
        {
            var info = await _userHandler.GetEmployeeUserInfo();
            return Ok(info);
        }
        [HttpPost("create-employee-user")]
        public async Task<IActionResult> CreateEmployeeUser([FromBody] CreateEmployeeUserModel user)
        {
            var response = await _userHandler.CreateEmployeeUser(user);
            return Ok(response);
        }
        [HttpPost("create-default-user")]
        public async Task<IActionResult> CreateDefaultUser([FromBody] UserDto user)
        {
            var response = await _userHandler.CreateUser(user);
            return Ok(response);
        }
    }
    }


