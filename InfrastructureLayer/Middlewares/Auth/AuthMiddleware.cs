using InfrastructureLayer.Services.GroupService;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

public class JwtGroupMiddleware
{
    private readonly RequestDelegate _next;
    private readonly GroupService _groupService = new GroupService();

    public JwtGroupMiddleware(RequestDelegate next )
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Verificăm dacă există un header de autorizare
        var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();

        if (!string.IsNullOrEmpty(authHeader) )
        {
            var token = authHeader;

            // Parsăm JWT-ul
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadToken(token) as JwtSecurityToken;

            if (jwtToken != null)
            {
                // Obținem "group id" din claims
                var groupId = jwtToken.Claims.FirstOrDefault(claim => claim.Type == "group_id")?.Value;
                if(groupId != null)
                {
                    _groupService.SetCurrentGroup(int.Parse(groupId));
                }
                var userId = jwtToken.Claims.FirstOrDefault(claim => claim.Type == "user_id")?.Value;
                if (userId != null)
                {
                    _groupService.SetCurrentUser(int.Parse(groupId));
                }

                //if (!string.IsNullOrEmpty(groupId))
                //{
                //    // Adăugăm "group id" în contextul Http pentru utilizare ulterioară
                //    context.Items["GroupId"] = groupId;
                //}
            }
        }

        // Continuăm execuția pipeline-ului
        await _next(context);
    }
}
