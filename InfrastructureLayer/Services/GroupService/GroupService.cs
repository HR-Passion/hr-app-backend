
namespace InfrastructureLayer.Services.GroupService
{
    public class GroupService : IGroupService
    {
        private static int _groupId;
        public static int _userId;



        public int GetCurrentGroup()
        {
            return _groupId;
        }

        public bool SetCurrentGroup(int groupId)
        {
            _groupId = groupId;
            //todo cehck if the group exists
            return true;
        }

        public int GetCurrentUser()
        {
            return _userId;
            //
        }

        public bool SetCurrentUser(int userId)
        {
            _userId = userId;
            return true;
        }
    }
}
