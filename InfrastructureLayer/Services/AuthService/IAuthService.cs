
namespace InfrastructureLayer.Services.AuthService
{

    public interface IAuthService
    {
        /// <summary>
        /// login an user in db for a group
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>TODO return a response type</returns>
        public string? Login(string username, string password);

    }
}
