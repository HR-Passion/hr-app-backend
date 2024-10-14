
namespace DataAccesLayer.Entities.Base.Defaults
{
    public class DefaultInfo : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
