namespace DataAccesLayer.Entities.Base.Defaults
{
    /// <summary>
    /// this will be the entity for a regular user without any role in corporation
    /// </summary>
    public class Default : BaseEntity
    {
       // public string CNP { get; set; } maybe later ... ?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
