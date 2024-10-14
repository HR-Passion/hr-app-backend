namespace DataAccesLayer.Entities.Base
{
    /// <summary>
    /// entity of user , this entity reprezents the user that will login and logout , he will get roles , permitions , etc after login ... 
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// username is a field that represents a string caracteristic for eatch user , should be uniq in a group 
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// email reprezents the email for a specific user , it should be validated to be an email  and will not be required at first 
        /// TODO should be verified later 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// password should be at least 15 characters and contain a higher letter , a number and a specific character 
        /// TODO should be hased later
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// refrence to a group 
        /// </summary>
        /// 
        public bool IsEmployeed { get; set; } = false;
        public int? GroupId { get; set; }
    }
}
