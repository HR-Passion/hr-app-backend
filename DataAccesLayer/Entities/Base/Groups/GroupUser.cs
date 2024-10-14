namespace DataAccesLayer.Entities.Base.Groups
{
    public class GroupUser : BaseEntity
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
    }
}
