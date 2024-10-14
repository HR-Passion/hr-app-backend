using AplicationLayer.DTOs;
using AplicationLayer.Models;
using DataAccesLayer.Entities.Base.Groups;

namespace InfrastructureLayer.Handlers.Groups
{
    public interface  IGroupHandler 
    {
        public List<Group> GetAllGroups();
        public Task<Group> CreateGroup(CreateGroupModel model); 
    }
}
