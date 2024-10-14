using Microsoft.AspNetCore.Mvc;
using InfrastructureLayer.Handlers.Groups;
using AplicationLayer.DTOs;
using AplicationLayer.Models;

namespace PresentationLayer.Controllers.GroupController
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupHandler _groupHandler;

        public GroupController(IGroupHandler groupHandler)
        {
            _groupHandler = groupHandler;
        }
        /// <summary>
        /// admin only
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllGroups()
        {
            var result = _groupHandler.GetAllGroups();
            return Ok(result);
        }
        [HttpPost("create-group")]
        public IActionResult CreateGroup([FromBody] CreateGroupModel group)
        {
            var result = _groupHandler.CreateGroup(group);
            return Ok(result);
        }
    }
}
