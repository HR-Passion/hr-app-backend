namespace InfrastructureLayer.Services.GroupService
{
    public interface IGroupService
    {
        public int GetCurrentGroup();
        public bool SetCurrentGroup(int groupId);
        public int GetCurrentUser();
        public bool SetCurrentUser(int userId);
    }
}
