using DataAccesLayer.Entities.Base;
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InfrastructureLayer.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly DataBaseContext _context;
        public AuthService(DataBaseContext context)
        {
            _context = context;
        }
        public string? Login(string username, string password)
        {
            var exists = _context.Set<User>().Where(x=>x.Username.Equals(username)).First();
            if(exists == null)
            {
                return null;//todo throw user dont exist error
            }
            else
            {
               var user = _context.Set<User>().Where(x => x.Username.Equals(username) && x.Password.Equals(password)).First();
               
                if(user == null)
                {
                    return null;//todo throw bad password or username error
                }
                //todo return a token 
                var groupId =  _context.Users
                             .Where(u => u.Id == user.Id)
                             .Select(u => u.GroupId)
                             .FirstOrDefault();
                if (groupId == null)
                {
                    return null;
                }
                else
                {
                    return GenerateToken(user, (int)groupId);
                }
            }
        }
        // TODO , have a table later that keeps the history of login and logout maybe and a timestamp
      

        private string GenerateToken(User user,int groupId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("superSecretKey@345"); // todo put it in config
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("group_id",groupId.ToString()),
                new Claim("user_id",user.Id.ToString())
            }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}
